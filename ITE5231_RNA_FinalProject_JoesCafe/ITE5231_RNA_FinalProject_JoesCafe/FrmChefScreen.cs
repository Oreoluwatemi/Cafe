using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  public partial class FrmChefScreen : Form {
    SortedDictionary<Order, Tuple<OrderItem, List<OrderItemAddon>>> ordersPendingTobeServed = null;
    Queue<Tuple<Order, Tuple<OrderItem, List<OrderItemAddon>>>> undeliveredOrderQueue = 
      new Queue<Tuple<Order, Tuple<OrderItem, List<OrderItemAddon>>>>();

    public FrmChefScreen() {
      InitializeComponent();
    }

    private void FrmChefScreen_Load(object sender, EventArgs e) {
      CenterToScreen();
      dataGridViewOrder1.Hide();
      dataGridViewOrder2.Hide();
      dataGridViewOrder3.Hide();
      dataGridViewOrder4.Hide();
      dataGridViewOrder5.Hide();

      ordersPendingTobeServed = OrderDB.GetOrdersWithOrderItemsAndAddons();
      foreach (KeyValuePair<Order, Tuple<OrderItem, List<OrderItemAddon>>> entry in ordersPendingTobeServed) {
        Order order = entry.Key;
        Tuple<OrderItem, List<OrderItemAddon>> orderItemWithAddons = entry.Value;
        Tuple<Order, Tuple<OrderItem, List<OrderItemAddon>>> queueEntry = 
          new Tuple<Order, Tuple<OrderItem, List<OrderItemAddon>>>(order, orderItemWithAddons);

        undeliveredOrderQueue.Enqueue(queueEntry);
      }

      int j = 0;
      foreach (Tuple<Order, Tuple<OrderItem, List<OrderItemAddon>>> queueEntry in undeliveredOrderQueue) {
        if (j == 3) break; // We only display top 5 entries to the chef, so that he can prepare them.

        (Order order, Tuple <OrderItem, List <OrderItemAddon>> orderItemAndAddonTuple) = queueEntry;
        OrderItem orderItem = orderItemAndAddonTuple.Item1;
        Product product = ProductDB.GetProduct(orderItem.ProductId);
        List<OrderItemAddon> listAddons = orderItemAndAddonTuple.Item2;

        List<Item> items = new List<Item>();
        Bitmap productImage = product.ProductImage;
        Item item = new Item();
        item.ProductId = product.Id;
        item.Name = product.Name;
        item.Type = "Main";
        item.Qty = orderItem.Qty;
        item.UnitPrice = orderItem.UnitPrice;
        items.Add(item);

        for (int i = 0; i < listAddons.Count; i++) {
          OrderItemAddon orderItemAddon = listAddons[i];
          Addon addon = ProductDB.GetAddon(orderItemAddon.AddonId);
          item = new Item();
          item.ProductId = orderItemAddon.ProductId;
          item.Name = addon.Name;
          item.Type = "Addon";
          item.Qty = orderItemAddon.Qty;
          item.UnitPrice = orderItemAddon.UnitPrice;

          items.Add(item);
        }

        switch (j) {
          case 0:
            panelImage1.BackgroundImage = productImage;
            dataGridViewOrder1.Show();
            dataGridViewOrder1.DataSource = items.ToArray();
            break;
          case 1:
            panelImage2.BackgroundImage = productImage;
            dataGridViewOrder2.Show();
            dataGridViewOrder2.DataSource = items.ToArray();
            break;
          case 2:
            panelImage3.BackgroundImage = productImage;
            dataGridViewOrder3.Show();
            dataGridViewOrder3.DataSource = items.ToArray();
            break;
          /*case 3:
            panelImage4.BackgroundImage = productImage;
            dataGridViewOrder4.Show();
            dataGridViewOrder4.DataSource = items.ToArray();
            break;
          case 4:
            panelImage5.BackgroundImage = productImage;
            dataGridViewOrder5.Show();
            dataGridViewOrder5.DataSource = items.ToArray();
            break;*/
        }

        j++;
      }
    }

    private void dataGridViewOrder1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 4 || e.ColumnIndex == 5) {
        e.CellStyle.Format = "N2";
      }
    }

    private void setupGridControlOnDataSourceChanged(DataGridView dataGridViewItemOrder) {
      dataGridViewItemOrder.Columns[0].Width = 10; // Does not matter, this column will be hidden
      dataGridViewItemOrder.Columns[1].Width = 10; // Does not matter, this column will be hidden
      dataGridViewItemOrder.Columns[2].Width = 60;
      dataGridViewItemOrder.Columns[3].Width = 170;
      dataGridViewItemOrder.Columns[4].Width = 58;
      dataGridViewItemOrder.Columns[5].Width = 78;
      dataGridViewItemOrder.Columns[6].Width = 79;

      dataGridViewItemOrder.Columns["ProductId"].Visible = false;
      dataGridViewItemOrder.Columns["AddonId"].Visible = false;
      dataGridViewItemOrder.Columns["Type"].HeaderText = "Type";
      dataGridViewItemOrder.Columns["Name"].HeaderText = "Name";
      dataGridViewItemOrder.Columns["Qty"].HeaderText = "Qty";
      dataGridViewItemOrder.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dataGridViewItemOrder.Columns["Qty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
      dataGridViewItemOrder.Columns["UnitPrice"].HeaderText = "Price";
      dataGridViewItemOrder.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dataGridViewItemOrder.Columns["UnitPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
      dataGridViewItemOrder.Columns["TotalPrice"].HeaderText = "Total";
      dataGridViewItemOrder.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dataGridViewItemOrder.Columns["TotalPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

      dataGridViewItemOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.LavenderBlush;
      dataGridViewItemOrder.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewItemOrder.Font, FontStyle.Bold);
      dataGridViewItemOrder.EnableHeadersVisualStyles = false;
    }

    private void dataGridViewOrder1_DataSourceChanged(object sender, EventArgs e) {
      setupGridControlOnDataSourceChanged(dataGridViewOrder1);
    }

    private void dataGridViewOrder1_SelectionChanged(object sender, EventArgs e) {
      dataGridViewOrder1.ClearSelection();
    }

    private void dataGridViewOrder2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 5 || e.ColumnIndex == 6) {
        e.CellStyle.Format = "N2";
      }
    }

    private void dataGridViewOrder2_DataSourceChanged(object sender, EventArgs e) {
      setupGridControlOnDataSourceChanged(dataGridViewOrder2);
    }

    private void dataGridViewOrder2_SelectionChanged(object sender, EventArgs e) {
      dataGridViewOrder2.ClearSelection();
    }

    private void dataGridViewOrder3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 5 || e.ColumnIndex == 5) {
        e.CellStyle.Format = "N2";
      }
    }

    private void dataGridViewOrder3_DataSourceChanged(object sender, EventArgs e) {
      setupGridControlOnDataSourceChanged(dataGridViewOrder3);
    }

    private void dataGridViewOrder3_SelectionChanged(object sender, EventArgs e) {
      dataGridViewOrder3.ClearSelection();
    }

    private void dataGridViewOrder4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 5 || e.ColumnIndex == 6) {
        e.CellStyle.Format = "N2";
      }
    }

    private void dataGridViewOrder4_DataSourceChanged(object sender, EventArgs e) {
      setupGridControlOnDataSourceChanged(dataGridViewOrder4);
    }

    private void dataGridViewOrder4_SelectionChanged(object sender, EventArgs e) {
      dataGridViewOrder4.ClearSelection();
    }

    private void dataGridViewOrder5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 5 || e.ColumnIndex == 6) {
        e.CellStyle.Format = "N2";
      }
    }

    private void dataGridViewOrder5_DataSourceChanged(object sender, EventArgs e) {
      setupGridControlOnDataSourceChanged(dataGridViewOrder5);
    }

    private void dataGridViewOrder5_SelectionChanged(object sender, EventArgs e) {
      dataGridViewOrder4.ClearSelection();
    }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
