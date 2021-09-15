
namespace ITE5231_RNA_FinalProject_JoesCafe {
  partial class FrmCustomerScreen {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblItemsToOrder = new System.Windows.Forms.Label();
            this.panelItemsAvailable = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSelectedForOrder = new System.Windows.Forms.Panel();
            this.dataGridViewItem3Order = new System.Windows.Forms.DataGridView();
            this.dataGridViewItem2Order = new System.Windows.Forms.DataGridView();
            this.dataGridViewItem1Order = new System.Windows.Forms.DataGridView();
            this.lblOrderedItems = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.lblGrandTotalOrderAmount = new System.Windows.Forms.Label();
            this.lblActualGrandTotalAmount = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelItemsAvailable.SuspendLayout();
            this.panelSelectedForOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem3Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem2Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem1Order)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblItemsToOrder
            // 
            this.lblItemsToOrder.AutoSize = true;
            this.lblItemsToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsToOrder.Location = new System.Drawing.Point(9, 9);
            this.lblItemsToOrder.Name = "lblItemsToOrder";
            this.lblItemsToOrder.Size = new System.Drawing.Size(216, 18);
            this.lblItemsToOrder.TabIndex = 2;
            this.lblItemsToOrder.Text = "Items Available for Ordering";
            // 
            // panelItemsAvailable
            // 
            this.panelItemsAvailable.BackColor = System.Drawing.Color.FloralWhite;
            this.panelItemsAvailable.Controls.Add(this.lblMessage);
            this.panelItemsAvailable.Controls.Add(this.lblItemsToOrder);
            this.panelItemsAvailable.Controls.Add(this.btnConfirmOrder);
            this.panelItemsAvailable.Location = new System.Drawing.Point(12, 156);
            this.panelItemsAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelItemsAvailable.Name = "panelItemsAvailable";
            this.panelItemsAvailable.Size = new System.Drawing.Size(789, 522);
            this.panelItemsAvailable.TabIndex = 3;
            this.panelItemsAvailable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelItemsAvailable_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTitle.Location = new System.Drawing.Point(12, 105);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1268, 49);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Joe’s Café";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSelectedForOrder
            // 
            this.panelSelectedForOrder.BackColor = System.Drawing.Color.Snow;
            this.panelSelectedForOrder.Controls.Add(this.lblActualGrandTotalAmount);
            this.panelSelectedForOrder.Controls.Add(this.dataGridViewItem3Order);
            this.panelSelectedForOrder.Controls.Add(this.lblGrandTotalOrderAmount);
            this.panelSelectedForOrder.Controls.Add(this.dataGridViewItem2Order);
            this.panelSelectedForOrder.Controls.Add(this.dataGridViewItem1Order);
            this.panelSelectedForOrder.Controls.Add(this.lblOrderedItems);
            this.panelSelectedForOrder.Location = new System.Drawing.Point(807, 158);
            this.panelSelectedForOrder.Margin = new System.Windows.Forms.Padding(4);
            this.panelSelectedForOrder.Name = "panelSelectedForOrder";
            this.panelSelectedForOrder.Size = new System.Drawing.Size(476, 520);
            this.panelSelectedForOrder.TabIndex = 9;
            // 
            // dataGridViewItem3Order
            // 
            this.dataGridViewItem3Order.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewItem3Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem3Order.Location = new System.Drawing.Point(13, 304);
            this.dataGridViewItem3Order.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewItem3Order.Name = "dataGridViewItem3Order";
            this.dataGridViewItem3Order.ReadOnly = true;
            this.dataGridViewItem3Order.RowHeadersVisible = false;
            this.dataGridViewItem3Order.RowHeadersWidth = 51;
            this.dataGridViewItem3Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItem3Order.Size = new System.Drawing.Size(448, 122);
            this.dataGridViewItem3Order.TabIndex = 11;
            this.dataGridViewItem3Order.DataSourceChanged += new System.EventHandler(this.dataGridViewItem3Order_DataSourceChanged);
            this.dataGridViewItem3Order.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewItem3Order_CellFormatting);
            this.dataGridViewItem3Order.SelectionChanged += new System.EventHandler(this.dataGridViewItem3Order_SelectionChanged);
            // 
            // dataGridViewItem2Order
            // 
            this.dataGridViewItem2Order.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewItem2Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem2Order.Location = new System.Drawing.Point(13, 171);
            this.dataGridViewItem2Order.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewItem2Order.Name = "dataGridViewItem2Order";
            this.dataGridViewItem2Order.ReadOnly = true;
            this.dataGridViewItem2Order.RowHeadersVisible = false;
            this.dataGridViewItem2Order.RowHeadersWidth = 51;
            this.dataGridViewItem2Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItem2Order.Size = new System.Drawing.Size(448, 122);
            this.dataGridViewItem2Order.TabIndex = 10;
            this.dataGridViewItem2Order.DataSourceChanged += new System.EventHandler(this.dataGridViewItem2Order_DataSourceChanged);
            this.dataGridViewItem2Order.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewItem2Order_CellFormatting);
            this.dataGridViewItem2Order.SelectionChanged += new System.EventHandler(this.dataGridViewItem2Order_SelectionChanged);
            // 
            // dataGridViewItem1Order
            // 
            this.dataGridViewItem1Order.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewItem1Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem1Order.Location = new System.Drawing.Point(13, 37);
            this.dataGridViewItem1Order.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewItem1Order.Name = "dataGridViewItem1Order";
            this.dataGridViewItem1Order.ReadOnly = true;
            this.dataGridViewItem1Order.RowHeadersVisible = false;
            this.dataGridViewItem1Order.RowHeadersWidth = 51;
            this.dataGridViewItem1Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItem1Order.Size = new System.Drawing.Size(448, 122);
            this.dataGridViewItem1Order.TabIndex = 9;
            this.dataGridViewItem1Order.DataSourceChanged += new System.EventHandler(this.dataGridViewItem1Order_DataSourceChanged);
            this.dataGridViewItem1Order.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewItem1Order_CellFormatting);
            this.dataGridViewItem1Order.SelectionChanged += new System.EventHandler(this.dataGridViewItem1Order_SelectionChanged);
            // 
            // lblOrderedItems
            // 
            this.lblOrderedItems.AutoSize = true;
            this.lblOrderedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedItems.Location = new System.Drawing.Point(9, 7);
            this.lblOrderedItems.Name = "lblOrderedItems";
            this.lblOrderedItems.Size = new System.Drawing.Size(198, 18);
            this.lblOrderedItems.TabIndex = 8;
            this.lblOrderedItems.Text = "Items Selected For Order";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmOrder.Location = new System.Drawing.Point(613, 467);
            this.btnConfirmOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(173, 36);
            this.btnConfirmOrder.TabIndex = 15;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.EnabledChanged += new System.EventHandler(this.btnConfirmOrder_EnabledChanged);
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // lblGrandTotalOrderAmount
            // 
            this.lblGrandTotalOrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalOrderAmount.ForeColor = System.Drawing.Color.Sienna;
            this.lblGrandTotalOrderAmount.Location = new System.Drawing.Point(113, 479);
            this.lblGrandTotalOrderAmount.Name = "lblGrandTotalOrderAmount";
            this.lblGrandTotalOrderAmount.Size = new System.Drawing.Size(218, 25);
            this.lblGrandTotalOrderAmount.TabIndex = 20;
            this.lblGrandTotalOrderAmount.Text = "Grand Total Order Amount:";
            // 
            // lblActualGrandTotalAmount
            // 
            this.lblActualGrandTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualGrandTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblActualGrandTotalAmount.Location = new System.Drawing.Point(341, 475);
            this.lblActualGrandTotalAmount.Name = "lblActualGrandTotalAmount";
            this.lblActualGrandTotalAmount.Size = new System.Drawing.Size(120, 25);
            this.lblActualGrandTotalAmount.TabIndex = 21;
            this.lblActualGrandTotalAmount.Text = "Amount";
            this.lblActualGrandTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(15, 460);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(592, 62);
            this.lblMessage.TabIndex = 20;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCustomerScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1295, 745);
            this.Controls.Add(this.panelSelectedForOrder);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelItemsAvailable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCustomerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Main Hall of Cafe";
            this.Load += new System.EventHandler(this.FrmCustomerScreen_Load);
            this.panelItemsAvailable.ResumeLayout(false);
            this.panelItemsAvailable.PerformLayout();
            this.panelSelectedForOrder.ResumeLayout(false);
            this.panelSelectedForOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem3Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem2Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem1Order)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblItemsToOrder;
    private System.Windows.Forms.Panel panelItemsAvailable;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panelSelectedForOrder;
    private System.Windows.Forms.Label lblOrderedItems;
    private System.Windows.Forms.DataGridView dataGridViewItem1Order;
    private System.Windows.Forms.DataGridView dataGridViewItem2Order;
    private System.Windows.Forms.DataGridView dataGridViewItem3Order;
    internal System.Windows.Forms.Button btnConfirmOrder; // Ved - Changed to internal
    private System.Windows.Forms.Label lblGrandTotalOrderAmount;
    internal System.Windows.Forms.Label lblActualGrandTotalAmount; // Ved - Changed to internal
    private System.Windows.Forms.Label lblMessage;
  }
}