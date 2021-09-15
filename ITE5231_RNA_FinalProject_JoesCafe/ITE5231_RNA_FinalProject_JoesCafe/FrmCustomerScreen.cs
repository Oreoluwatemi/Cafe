using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  public partial class FrmCustomerScreen : Form {
    List<Product> products = null; // List of beverages to Order

    // Following things we need for all the beverage Orders that will be displayed
    const int noOfRecordsToDisplayOnOrderScreen = 3;
    internal Dictionary<int, List<Item>>[] productsSelectedForOrder = new Dictionary<int, List<Item>>[noOfRecordsToDisplayOnOrderScreen];
    AddonCollection[] addonForProducts = new AddonCollection[noOfRecordsToDisplayOnOrderScreen];
    Dictionary<int, double>[] addonPricesForAllProducts = new Dictionary<int, double>[noOfRecordsToDisplayOnOrderScreen];
    BeveragePanelPrototype[] beveragePanels = new BeveragePanelPrototype[noOfRecordsToDisplayOnOrderScreen];
    DataGridView[] dataGridViewItemOrders = new DataGridView[noOfRecordsToDisplayOnOrderScreen];

    BeveragePanelPrototype beveragePanel1, beveragePanel2, beveragePanel3, beveragePanel4, beveragePanel5;
    // Above is the named (variable) access for the array of beveragePanels, which makes the code more readable
    // Why do we need them? In the event handler code we do not get the index and hence we have to access each array element
    // like beveragePanels[0] or beveragePanels[1], etc. We would like to be able to access them as beveragePanel1 or beveragePanel2
    // This increases readbility and verification through code-walkhrough

    FrmPaymentForOrder paymentForm = new FrmPaymentForOrder();
    public static double grandTotalOrderAmount = 0.00;

    GrandTotalObserver grandTotalObserver = new GrandTotalObserver();

    public FrmCustomerScreen() {
      InitializeComponent();
    }

    private void clearAllFields() {
      // Uncheck all the Beverages that can be ordered
      for (int i = 0; i < beveragePanels.Length; i++) {
        beveragePanels[i].chkOrder.Checked = false;
      }
    }

    private void FrmCustomerScreen_Load(object sender, EventArgs e) {
      lblMessage.Text = "";
      CenterToScreen();

      AbstractBeverageDisplayRecordFactory displayRecordFactory = BeverageDisplayRecordFactory.GetInstance();

      for (int i = 0; i < noOfRecordsToDisplayOnOrderScreen; i++) {
        beveragePanels[i] = displayRecordFactory.GetBeverageDisplayRecord(); // Get the BeverageDisplayRecord from Factory Method
        switch (i) {
            case 0:
                dataGridViewItemOrders[i] = dataGridViewItem1Order;
                break;
            case 1:
                dataGridViewItemOrders[i] = dataGridViewItem2Order;
                break;
            case 2:
                dataGridViewItemOrders[i] = dataGridViewItem3Order;
                break;

        }
        BeveragePanelPrototype beveragePanel = beveragePanels[i];

        beveragePanel.Register(grandTotalObserver); // beveragePanel is a Subject and grandTotalObserver is an Observer

        panelItemsAvailable.Controls.Add(beveragePanel.panelBeverage);

        // Now add the hanlder for each
        beveragePanel.btnDelete.Click += new System.EventHandler(btnDelete_Click);
        beveragePanel.cmbNo.SelectedIndexChanged += new System.EventHandler(cmbNo_SelectedIndexChanged);
        beveragePanel.btnAdd.Click += new System.EventHandler(btnAdd_Click);
        beveragePanel.chkOrder.CheckedChanged += new System.EventHandler(chkOrder_CheckedChanged);
        beveragePanel.cmbAddon.SelectedIndexChanged += new System.EventHandler(cmbAddon_SelectedIndexChanged);

        switch (i) {
          // Set up prototype's location on the screen and the names of the controls within
          case 0:
            beveragePanel1 = beveragePanel; // Setup named access
            beveragePanel.panelBeverage.Location = new Point(13, 41);
            beveragePanel.btnDelete.Name = "btnDelete1";
            beveragePanel.cmbNo.Name = "cmbNo1";
            beveragePanel.btnAdd.Name = "btnAdd1";
            beveragePanel.chkOrder.Name = "chkOrder1";
            beveragePanel.cmbAddon.Name = "cmbAddon1";
            break;
          case 1:
            beveragePanel2 = beveragePanel; // Setup named access
            beveragePanel.panelBeverage.Location = new Point(13, 175);
            beveragePanel.btnDelete.Name = "btnDelete2";
            beveragePanel.cmbNo.Name = "cmbNo2";
            beveragePanel.btnAdd.Name = "btnAdd2";
            beveragePanel.chkOrder.Name = "chkOrder2";
            beveragePanel.cmbAddon.Name = "cmbAddon2";
            break;
          case 2:
            beveragePanel3 = beveragePanel; // Setup named access
            beveragePanel.panelBeverage.Location = new Point(13, 308);
            beveragePanel.btnDelete.Name = "btnDelete3";
            beveragePanel.cmbNo.Name = "cmbNo3";
            beveragePanel.btnAdd.Name = "btnAdd3";
            beveragePanel.chkOrder.Name = "chkOrder3";
            beveragePanel.cmbAddon.Name = "cmbAddon3";
            break;
          case 3:
            beveragePanel4 = beveragePanel; // Setup named access
            beveragePanel.panelBeverage.Location = new Point(13, 441);
            beveragePanel.btnDelete.Name = "btnDelete4";
            beveragePanel.cmbNo.Name = "cmbNo4";
            beveragePanel.btnAdd.Name = "btnAdd4";
            beveragePanel.chkOrder.Name = "chkOrder4";
            beveragePanel.cmbAddon.Name = "cmbAddon4";
            break;
          case 4:
            beveragePanel5 = beveragePanel; // Setup named access
            beveragePanel.panelBeverage.Location = new Point(13, 574);
            beveragePanel.btnDelete.Name = "btnDelete5";
            beveragePanel.cmbNo.Name = "cmbNo5";
            beveragePanel.btnAdd.Name = "btnAdd5";
            beveragePanel.chkOrder.Name = "chkOrder5";
            beveragePanel.cmbAddon.Name = "cmbAddon5";
            break;
        }
      }

      products = ProductDB.GetAllProducts(); // Get all the Beverages from the Database

      // Now display the actual Beverage details as read from the database
      for (int i = 0; i < products.Count && i < noOfRecordsToDisplayOnOrderScreen; i++) { // Display only first 5, since we do not have room for more on page
        // TODO: Provide pagination
        BeveragePanelPrototype beveragePanel = beveragePanels[i];
        Product product = products[i];

        beveragePanel.panelImage.BackgroundImage = product.ProductImage;
        beveragePanel.lblName.Text = product.Name;
        beveragePanel.lblDescription.Text = product.Description;
        beveragePanel.lblPrice.Text = "$ " + product.Price.ToString("N2");
        for (int j = 1; j <= 10; j++)
          beveragePanel.cmbNo.Items.Add(j);

        AddonCollection addonsCollection = ProductDB.GetAllAddonsForProduct(product);
        addonForProducts[i] = addonsCollection;
        Dictionary<int, double> addonPricesForThisProduct = new Dictionary<int, double>();
        for (int j = 0; j < addonsCollection.Count; j++) {
          Addon addon = addonsCollection[j];
          beveragePanel.cmbAddon.Items.Add(addon.Name);
          addonPricesForThisProduct[j] = addon.Price;
        }
        addonPricesForAllProducts[i] = addonPricesForThisProduct;

        for (int j = 1; j <= 3; j++) {
          beveragePanel.cmbAddonNo.Items.Add(j);
        }
      }

      // One cycle of chkOrder.Checked to true and then to false, takes care of states of all sub-controls properly
      for (int i = 0; i < beveragePanels.Length; i++) {
        beveragePanels[i].chkOrder.Checked = true;
      }
      for (int i = 0; i < beveragePanels.Length; i++) {
        beveragePanels[i].chkOrder.Checked = false;
      }
    } // End of 'FrmCustomerScreen_Load'


    // Here on, down below, starts the code of all the event handlers for different controls of the Display Record
    // There are so many controls, that this code seems large, but its a very repetitive code easy to understand
    private void chkOrder_CheckedChanged(object sender, EventArgs e) {
      CheckBox checkbox = sender as CheckBox;
      int i = checkbox.Name[checkbox.Name.Length - 1] - '1';
      BeveragePanelPrototype beveragePanel = beveragePanels[i];
      DataGridView dataGridViewItemOrder = dataGridViewItemOrders[i];

      if (beveragePanel.chkOrder.Checked) {
        if (checkbox != null) checkbox.BackColor = Color.Blue;

        beveragePanel.cmbNo.Enabled = true;
        if (beveragePanel.cmbNo.Items.Count > 0) {
          beveragePanel.cmbNo.SelectedIndex = 0;
        }

        beveragePanel.cmbAddon.Enabled = true;
        beveragePanel.cmbAddonNo.Enabled = true;
        beveragePanel.btnAdd.Enabled = true;
        beveragePanel.btnDelete.Enabled = true;

        Dictionary<int, List<Item>> thisSelectedForOrder = new Dictionary<int, List<Item>>();
        List<Item> itemsOrdered = new List<Item>();
        Item orderedItem = new Item();
        orderedItem.ProductId = products[i].Id;
        orderedItem.Type = "Main";
        orderedItem.Name = products[i].Name;
        orderedItem.Qty = 1;
        orderedItem.UnitPrice = products[i].Price;
        itemsOrdered.Add(orderedItem);
        thisSelectedForOrder[i] = itemsOrdered;
        productsSelectedForOrder[i] = thisSelectedForOrder;
        dataGridViewItemOrder.DataSource = itemsOrdered.ToArray();
        beveragePanel.Notify();
      } else {
        if (checkbox != null) checkbox.BackColor = Color.Brown;

        beveragePanel.cmbNo.Enabled = false;
        beveragePanel.cmbNo.SelectedIndex = -1;

        beveragePanel.cmbAddon.Enabled = false;
        beveragePanel.cmbAddon.SelectedIndex = -1;
        beveragePanel.cmbAddonNo.Enabled = false;
        beveragePanel.cmbAddonNo.SelectedIndex = -1;
        beveragePanel.btnAdd.Enabled = false;
        beveragePanel.btnDelete.Enabled = false;

        Dictionary<int, List<Item>> thisSelectedForOrder = productsSelectedForOrder[i];
        List<Item> itemsOrdered = thisSelectedForOrder[i];
        itemsOrdered.Clear();
        thisSelectedForOrder[i] = itemsOrdered;
        dataGridViewItemOrder.DataSource = itemsOrdered.ToArray();
        beveragePanel.Notify();
      }
    }

    private void cmbAddon_SelectedIndexChanged(object sender, EventArgs e) {
      ComboBox cmbAddon = sender as ComboBox;
      int i = cmbAddon.Name[cmbAddon.Name.Length - 1] - '1';
      BeveragePanelPrototype beveragePanel = beveragePanels[i];

      if (beveragePanel.cmbAddon.SelectedIndex != -1) {
        beveragePanel.cmbAddonNo.SelectedIndex = 0;
        beveragePanel.lblPriceAddon.Text = "$ " + addonPricesForAllProducts[i][beveragePanel.cmbAddon.SelectedIndex].ToString("N2");
      }
    }

    private void cmbNo_SelectedIndexChanged(object sender, EventArgs e) {
      ComboBox cmbNo = sender as ComboBox;
      int i = cmbNo.Name[cmbNo.Name.Length - 1] - '1';
      DataGridView dataGridViewItemOrder = dataGridViewItemOrders[i];
      BeveragePanelPrototype beveragePanel = beveragePanels[i];

      if (beveragePanel.cmbNo.SelectedIndex != -1) {
        Dictionary<int, List<Item>> thisSelectedForOrder = productsSelectedForOrder[i];
        if (thisSelectedForOrder != null) {
          List<Item> itemsOrdered = thisSelectedForOrder[i];
          if (itemsOrdered.Count > 0) {
            itemsOrdered[0].Qty = Convert.ToInt32(beveragePanel.cmbNo.SelectedItem);
            thisSelectedForOrder[i] = itemsOrdered;
            dataGridViewItemOrder.DataSource = itemsOrdered.ToArray();
            beveragePanel.Notify();
          }
        }
      }
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      Button btnAdd = sender as Button;
      int i = btnAdd.Name[btnAdd.Name.Length - 1] - '1';

      BeveragePanelPrototype beveragePanel = beveragePanels[i];
      DataGridView dataGridViewItemOrder = dataGridViewItemOrders[i];

      if (beveragePanel.cmbNo.SelectedIndex != -1) {
        Dictionary<int, List<Item>> thisSelectedForOrder = productsSelectedForOrder[i];
        if (thisSelectedForOrder != null) {
          List<Item> itemsOrdered = thisSelectedForOrder[i];
          bool foundAndUpdated = false;
          for (int j = 0; j < itemsOrdered.Count; j++) {
            if (itemsOrdered[j].Name.Equals(beveragePanel.cmbAddon.SelectedItem)) {
              itemsOrdered[j].Qty = Convert.ToInt32(beveragePanel.cmbAddonNo.SelectedItem);
              thisSelectedForOrder[i] = itemsOrdered;
              dataGridViewItemOrder.DataSource = itemsOrdered.ToArray();
              beveragePanel.Notify();
              foundAndUpdated = true;
              break;
            }
          }
          if (!foundAndUpdated) {
            if (beveragePanel.cmbAddon.SelectedIndex != -1) {
              Item orderedItem = new Item();
              orderedItem.ProductId = products[i].Id;
              orderedItem.AddonId = addonForProducts[i][beveragePanel.cmbAddon.SelectedIndex].Id;
              orderedItem.Type = "Addon";
              orderedItem.Name = addonForProducts[i][beveragePanel.cmbAddon.SelectedIndex].Name;
              orderedItem.Qty = Convert.ToInt32(beveragePanel.cmbAddonNo.SelectedItem);
              orderedItem.UnitPrice = addonForProducts[i][beveragePanel.cmbAddon.SelectedIndex].Price;
              itemsOrdered.Add(orderedItem);
              dataGridViewItemOrder.DataSource = itemsOrdered.ToArray();
              beveragePanel.Notify();
            }
          }
        }
      }
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      Button btnDelete = sender as Button;
      int i = btnDelete.Name[btnDelete.Name.Length - 1] - '1';

      BeveragePanelPrototype beveragePanel = beveragePanels[i];
      DataGridView dataGridViewItemOrder = dataGridViewItemOrders[i];

      if (beveragePanel.cmbAddon.SelectedIndex != -1) {
        Dictionary<int, List<Item>> thisSelectedForOrder = productsSelectedForOrder[i];
        if (thisSelectedForOrder != null) {
          List<Item> itemsOrdered = thisSelectedForOrder[i];
          for (int j = 0; j < itemsOrdered.Count; j++) {
            if (itemsOrdered[j].Name.Equals(beveragePanel.cmbAddon.SelectedItem)) {
              itemsOrdered.RemoveAt(j);
              thisSelectedForOrder[i] = itemsOrdered;
              dataGridViewItemOrder.DataSource = itemsOrdered.ToArray();
              beveragePanel.Notify();
              break;
            }
          }
        }
      }
    }

    private List<Item> getAllOrderedItems() {
      List<Item> items = new List<Item>();
      for (int i = 0; i < productsSelectedForOrder.Length; i++) {
        Dictionary<int, List<Item>> products = productsSelectedForOrder[i];
        if (products != null) {
          foreach (KeyValuePair<int, List<Item>> entry in products) {
            List<Item> orderList = entry.Value;
            for (int j = 0; j < orderList.Count; j++) {
              items.Add(orderList[j]);
            }
          }
        }
      }

      return items;
    }

    private void btnConfirmOrder_Click(object sender, EventArgs e) {
      Hide();
      paymentForm.ShowDialog();
      if (paymentForm.paymentDone) {
        Order order = new Order();
        order.UserId = FrmJoesCafeMain.LoggedInUserId;
        order.OrderAmount = Convert.ToDouble(lblActualGrandTotalAmount.Text);
        order.OrderDate = DateTime.Now;
        List<Item> items = getAllOrderedItems();
        OrderDB.setErrorMessageControl(lblMessage);
        int orderId = OrderDB.AddOrder(order, items);
        if (orderId != 0) {
          lblMessage.Text = "Your order has been successfully placed!";
          lblMessage.ForeColor = Color.Green;
        }

        clearAllFields();
      }
      Show();
    }

    private void btnConfirmOrder_EnabledChanged(object sender, EventArgs e) {
      if (btnConfirmOrder.Enabled) {
        btnConfirmOrder.BackColor = Color.MediumSeaGreen;
      } else {
        btnConfirmOrder.BackColor = Color.LightGray;
      }
    }

    // Below are DataGridView specific event handlers - to stage these DataGridViews in more appealing way
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

    private void dataGridViewItem1Order_DataSourceChanged(object sender, EventArgs e) {
      setupGridControlOnDataSourceChanged(dataGridViewItem1Order);
    }

    private void dataGridViewItem1Order_SelectionChanged(object sender, EventArgs e) {
      dataGridViewItem1Order.ClearSelection();
    }

    private void dataGridViewItem2Order_DataSourceChanged(object sender, EventArgs e) {
      setupGridControlOnDataSourceChanged(dataGridViewItem2Order);
    }

    private void dataGridViewItem2Order_SelectionChanged(object sender, EventArgs e) {
      dataGridViewItem2Order.ClearSelection();

    }

    private void dataGridViewItem3Order_DataSourceChanged(object sender, EventArgs e) {
      setupGridControlOnDataSourceChanged(dataGridViewItem3Order);
    }

    private void dataGridViewItem3Order_SelectionChanged(object sender, EventArgs e) {
      dataGridViewItem3Order.ClearSelection();
    }

    private void dataGridViewItem4Order_DataSourceChanged(object sender, EventArgs e) {
      // setupGridControlOnDataSourceChanged(dataGridViewItem4Order);
    }

    private void dataGridViewItem4Order_SelectionChanged(object sender, EventArgs e) {
      // dataGridViewItem4Order.ClearSelection();
    }

    private void dataGridViewItem5Order_DataSourceChanged(object sender, EventArgs e) {
      // setupGridControlOnDataSourceChanged(dataGridViewItem5Order);
    }

    private void dataGridViewItem5Order_SelectionChanged(object sender, EventArgs e) {
      // dataGridViewItem5Order.ClearSelection();
    }

    private void dataGridViewItem1Order_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 5 || e.ColumnIndex == 6) {
        e.CellStyle.Format = "N2";
      }
    }

        private void panelItemsAvailable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewItem2Order_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 5 || e.ColumnIndex == 6) {
        e.CellStyle.Format = "N2";
      }
    }

    private void dataGridViewItem3Order_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 5 || e.ColumnIndex == 6) {
        e.CellStyle.Format = "N2";
      }
    }

    private void dataGridViewItem4Order_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 5 || e.ColumnIndex == 6) {
        e.CellStyle.Format = "N2";
      }
    }

    private void dataGridViewItem5Order_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
      if (e.ColumnIndex == 5 || e.ColumnIndex == 6) {
        e.CellStyle.Format = "N2";
      }
    }
  }
}
