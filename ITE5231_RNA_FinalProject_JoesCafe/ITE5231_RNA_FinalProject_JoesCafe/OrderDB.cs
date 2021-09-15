using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class OrderDB {
    private static Control lblMessage = null;

    public static void setErrorMessageControl(Control control) {
      lblMessage = control;
    }

    public static int AddOrder(Order order, List<Item> items) {
      SqlConnection connection = Connection.GetConnection();
      SqlTransaction sqlTransaction = null;
      string insertUsersStatement =
          "INSERT DBO.Orders (user_id, order_date, order_amount) VALUES (@UserId, @OrderDate, @OrderAmount)";

      try {
        connection.Open();
        sqlTransaction = connection.BeginTransaction();

        SqlCommand insertOrderCommand = new SqlCommand(insertUsersStatement, connection, sqlTransaction);
        insertOrderCommand.Parameters.AddWithValue("@UserId", order.UserId);
        insertOrderCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate);
        insertOrderCommand.Parameters.AddWithValue("@OrderAmount", order.OrderAmount);
        insertOrderCommand.ExecuteNonQuery();

        string selectStatement = "SELECT IDENT_CURRENT('DBO.Orders') FROM DBO.Orders";
        SqlCommand selectCommand = new SqlCommand(selectStatement, connection, sqlTransaction);
        int orderID = Convert.ToInt32(selectCommand.ExecuteScalar());


        for (int i = 0; i < items.Count; i++) {
          Item item = items[i];
          string insertOrderItemStatement;
          if (item.Type.Equals("Main")) {
            // Insert into OrderItems table
            insertOrderItemStatement = $"INSERT INTO DBO.OrderItems (order_id, product_id, unit_price, qty) VALUES " +
                $"({orderID}, {item.ProductId}, {item.UnitPrice}, {item.Qty})";
            SqlCommand insertOrderItemCommand = new SqlCommand(insertOrderItemStatement, connection, sqlTransaction);
            insertOrderItemCommand.ExecuteNonQuery();
          } else {
            // Else Insert into OrderItemAddons table
            insertOrderItemStatement = $"INSERT INTO DBO.OrderItemAddons (order_id, product_id, addon_id, unit_price, qty) VALUES " +
              $"({orderID}, {item.ProductId}, {item.AddonId}, {item.UnitPrice}, {item.Qty})";
            SqlCommand insertOrderItemCommand = new SqlCommand(insertOrderItemStatement, connection, sqlTransaction);
            insertOrderItemCommand.ExecuteNonQuery();
          }

        }

        sqlTransaction.Commit();

        return orderID;
      } catch (SqlException ex) {
        lblMessage.Text = $"Error: Exception in 'AddOrder': {ex.Message}";
        lblMessage.ForeColor = Color.Red;

        sqlTransaction.Rollback();
        return 0;
      } finally {
        connection.Close();
      }
    }

    public static List<Order> GetNextOrders() {
      List<Order> orders = new List<Order>();

      SqlConnection connection = Connection.GetConnection();
      string selectStatement = $"SELECT id, user_id, order_date, order_amount FROM DBO.Orders WHERE delivery_date is NULL" +
        $" ORDER BY id asc";
      SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

      try {
        connection.Open();

        SqlDataReader orderReader = selectCommand.ExecuteReader();
        while (orderReader.Read()) {
          Order order = new Order();
          order.Id = (int)orderReader["id"];
          order.UserId = (int)orderReader["user_id"];
          order.OrderDate = (DateTime)orderReader["order_date"];
          order.OrderAmount = Convert.ToDouble((decimal)orderReader["order_amount"]);

          orders.Add(order);
        }
      } catch (SqlException ex) {
        lblMessage.Text = $"Error: Exception in 'GetNextOrders': {ex.Message}";
        lblMessage.ForeColor = Color.Red;
      } finally {
        connection.Close();
      }

      return orders;
    }

    public static SortedDictionary<Order, Tuple<OrderItem, List<OrderItemAddon>>> GetOrdersWithOrderItemsAndAddons() {
      SortedDictionary<Order, Tuple<OrderItem, List<OrderItemAddon>>> oderItemsAndAddonsByOrder = 
        new SortedDictionary<Order, Tuple<OrderItem, List<OrderItemAddon>>>();
      List<Order> orders = GetNextOrders();

      SqlConnection connectionOrderItems = Connection.GetConnection();
      SqlConnection connectionOrderItemAddons = Connection.GetConnection();

      for (int i = 0; i < orders.Count; i++) {
        Order order = orders[i];
        try {
          connectionOrderItems.Open();
          string selectStatement = $"SELECT order_id, product_id, unit_price, qty FROM DBO.OrderItems " +
            $"WHERE order_id = {order.Id}";
          SqlCommand selectOrderItemStatement = new SqlCommand(selectStatement, connectionOrderItems);
          SqlDataReader orderItemReader = selectOrderItemStatement.ExecuteReader();

          while (orderItemReader.Read()) {
            OrderItem orderItem = new OrderItem();
            orderItem.OrderId = (int)orderItemReader["order_id"];
            orderItem.ProductId = (int)orderItemReader["product_id"];
            orderItem.UnitPrice = Convert.ToDouble((decimal)orderItemReader["unit_price"]);
            orderItem.Qty = (int)orderItemReader["qty"];

            connectionOrderItemAddons.Open();
            List<OrderItemAddon> allOrderItemAddons = new List<OrderItemAddon>();
            string selectOrderItemAddonStatement = $"SELECT order_id, product_id, addon_id, unit_price, qty " +
              $"FROM DBO.OrderItemAddons WHERE order_id = {order.Id} AND product_id = {orderItem.ProductId}";
            SqlCommand selectOrderItemAddonCommand = new SqlCommand(selectOrderItemAddonStatement, 
              connectionOrderItemAddons);
            SqlDataReader orderItemAddonReader = selectOrderItemAddonCommand.ExecuteReader();

            while (orderItemAddonReader.Read()) {
              OrderItemAddon orderItemAddon = new OrderItemAddon();
              orderItemAddon.OrderId = (int)orderItemAddonReader["order_id"];
              orderItemAddon.ProductId = (int)orderItemAddonReader["product_id"];
              orderItemAddon.AddonId = (int)orderItemAddonReader["addon_id"];
              orderItemAddon.UnitPrice = Convert.ToDouble((decimal)orderItemAddonReader["unit_price"]);
              orderItemAddon.Qty = (int)orderItemAddonReader["qty"];
              allOrderItemAddons.Add(orderItemAddon);
            }

            oderItemsAndAddonsByOrder[order] = new Tuple<OrderItem, List<OrderItemAddon>>(orderItem, allOrderItemAddons);
            connectionOrderItemAddons.Close();
          }
        } catch (SqlException ex) {
          lblMessage.Text = $"Error: Exception in 'GetNextOrdersWithOrderItemsAndAddons': {ex.Message}";
          lblMessage.ForeColor = Color.Red;
        } finally {
          connectionOrderItems.Close();
          connectionOrderItemAddons.Close();
        }
      }

      return oderItemsAndAddonsByOrder;
    }
  }
}
