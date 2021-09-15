using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class BeveragePanelPrototype : ICostSubject, ICloneable {
    List<IGrandTotalObserver> allObservers = new List<IGrandTotalObserver>();

    public Panel panelBeverage = new Panel(); // Parent control of all the next 12 controls

    public Panel panelImage = new Panel();
    public Label lblName = new Label();
    public Label lblDescription = new Label();
    public Label lblPrice = new Label();
    public Label lblAddon = new Label();
    public ComboBox cmbAddon = new ComboBox();
    public Label lblPriceAddon = new Label();
    public ComboBox cmbAddonNo = new ComboBox();
    public Button btnAdd = new Button();
    public Button btnDelete = new Button();
    public CheckBox chkOrder = new CheckBox();
    public ComboBox cmbNo = new ComboBox();

    private double changeInMainCost { get; set; }
    private double _mainItemCost = 0.00;
    public double MainItemCost {
      get { return _mainItemCost; }
      set {
        changeInMainCost = value - _mainItemCost;
        _mainItemCost = value; 
      }
    }

    public BeveragePanelPrototype() {
      panelBeverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      panelBeverage.Controls.Add(btnDelete);
      panelBeverage.Controls.Add(lblPriceAddon);
      panelBeverage.Controls.Add(cmbNo);
      panelBeverage.Controls.Add(cmbAddonNo);
      panelBeverage.Controls.Add(lblPrice);
      panelBeverage.Controls.Add(btnAdd);
      panelBeverage.Controls.Add(chkOrder);
      panelBeverage.Controls.Add(cmbAddon);
      panelBeverage.Controls.Add(lblAddon);
      panelBeverage.Controls.Add(lblName);
      panelBeverage.Controls.Add(lblDescription);
      panelBeverage.Controls.Add(panelImage);
      panelBeverage.Location = new System.Drawing.Point(13, 37);
      panelBeverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      panelBeverage.Name = "panel5";
      panelBeverage.Size = new System.Drawing.Size(765, 121);
      panelBeverage.TabIndex = 6;
      // 
      btnDelete.BackColor = System.Drawing.Color.Pink;
      btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      btnDelete.Location = new System.Drawing.Point(687, 86);
      btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      btnDelete.Name = "btnDelete";
      btnDelete.Size = new System.Drawing.Size(73, 26);
      btnDelete.TabIndex = 20;
      btnDelete.Text = "Delete";
      btnDelete.UseVisualStyleBackColor = false;
      // btnDelete.Click += new System.EventHandler(btnDelete3_Click);
      // The above handler will be dynamically setup

      lblPriceAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      lblPriceAddon.ForeColor = System.Drawing.Color.DarkOliveGreen;
      lblPriceAddon.Location = new System.Drawing.Point(397, 89);
      lblPriceAddon.Name = "lblPriceAddon";
      lblPriceAddon.Size = new System.Drawing.Size(85, 25);
      lblPriceAddon.TabIndex = 23;
      lblPriceAddon.Text = "Price";
      // 
      cmbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      cmbNo.FormattingEnabled = true;
      cmbNo.Location = new System.Drawing.Point(687, 2);
      cmbNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      cmbNo.Name = "cmbNo";
      cmbNo.Size = new System.Drawing.Size(72, 28);
      cmbNo.TabIndex = 11;
      // cmbNo.SelectedIndexChanged += new System.EventHandler(cmbNo3_SelectedIndexChanged);
      // The above handler will be dynamically setup

      cmbAddonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      cmbAddonNo.FormattingEnabled = true;
      cmbAddonNo.Location = new System.Drawing.Point(517, 87);
      cmbAddonNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      cmbAddonNo.Name = "cmbAddonNo";
      cmbAddonNo.Size = new System.Drawing.Size(61, 26);
      cmbAddonNo.TabIndex = 22;
      // 
      lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      lblPrice.ForeColor = System.Drawing.Color.Black;
      lblPrice.Location = new System.Drawing.Point(475, 5);
      lblPrice.Name = "lblPrice";
      lblPrice.Size = new System.Drawing.Size(93, 25);
      lblPrice.TabIndex = 5;
      lblPrice.Text = "Price";
      // 
      btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
      btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      btnAdd.Location = new System.Drawing.Point(603, 86);
      btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new System.Drawing.Size(57, 26);
      btnAdd.TabIndex = 21;
      btnAdd.Text = "Add";
      btnAdd.UseVisualStyleBackColor = false;
      // btnAdd.Click += new System.EventHandler(btnAdd3_Click);
      // The above handler will be dynamically setup

      chkOrder.AutoSize = true;
      chkOrder.BackColor = System.Drawing.Color.Brown;
      chkOrder.ForeColor = System.Drawing.Color.White;
      chkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      chkOrder.Location = new System.Drawing.Point(600, 2);
      chkOrder.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      chkOrder.Padding = new System.Windows.Forms.Padding(5, 2, 3, 2);
      chkOrder.Name = "chkOrder";
      chkOrder.Size = new System.Drawing.Size(99, 29);
      chkOrder.TabIndex = 10;
      chkOrder.Text = "Order";
      chkOrder.UseVisualStyleBackColor = false;
      // chkOrder.CheckedChanged += new System.EventHandler(chkOrder3_CheckedChanged);
      // The above handler will be dynamically setup

      cmbAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      cmbAddon.FormattingEnabled = true;
      cmbAddon.Location = new System.Drawing.Point(227, 89);
      cmbAddon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      cmbAddon.Name = "cmbAddon";
      cmbAddon.Size = new System.Drawing.Size(157, 26);
      cmbAddon.TabIndex = 20;
      // cmbAddon.SelectedIndexChanged += new System.EventHandler(cmbAddon3_SelectedIndexChanged);
      // The above handler will be dynamically setup

      lblAddon.AutoSize = true;
      lblAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      lblAddon.Location = new System.Drawing.Point(132, 92);
      lblAddon.Name = "lblAddon";
      lblAddon.Size = new System.Drawing.Size(76, 20);
      lblAddon.TabIndex = 19;
      lblAddon.Text = "Add-ons:";
      // 
      lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      lblName.ForeColor = System.Drawing.Color.Black;
      lblName.Location = new System.Drawing.Point(132, 5);
      lblName.Name = "lblName";
      lblName.Size = new System.Drawing.Size(283, 25);
      lblName.TabIndex = 4;
      lblName.Text = "Name";
      // 
      lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      lblDescription.ForeColor = System.Drawing.Color.DimGray;
      lblDescription.Location = new System.Drawing.Point(136, 36);
      lblDescription.Name = "lblDescription";
      lblDescription.Size = new System.Drawing.Size(499, 78);
      lblDescription.TabIndex = 4;
      lblDescription.Text = "Description";
      // 
      panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      panelImage.Location = new System.Drawing.Point(3, 2);
      panelImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      panelImage.Name = "panelImage";
      panelImage.Size = new System.Drawing.Size(123, 114);
      panelImage.TabIndex = 0;

      panelImage.BackColor = Color.FloralWhite;
      panelBeverage.BackColor = Color.FloralWhite;
    }

    public Object Clone() {
      BeveragePanelPrototype instance = Activator.CreateInstance<BeveragePanelPrototype>();
      return instance;
    }

    // Implementing the ICostSubject Interface, with following three methods
    public void Notify() {
      foreach (IGrandTotalObserver observer in allObservers) {
        observer.Update();
      }
    }

    public void Register(IGrandTotalObserver observer) {
      allObservers.Add(observer);
    }

    public void Remove(IGrandTotalObserver observer) {
      allObservers.Remove(observer);
    }
  }
}
