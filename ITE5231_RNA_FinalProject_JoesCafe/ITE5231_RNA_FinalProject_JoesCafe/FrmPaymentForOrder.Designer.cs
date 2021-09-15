
namespace ITE5231_RNA_FinalProject_JoesCafe {
  partial class FrmPaymentForOrder {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentForOrder));
            this.txtExpirationMonthYear = new System.Windows.Forms.TextBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardHolderName = new System.Windows.Forms.TextBox();
            this.lblCardholderName = new System.Windows.Forms.Label();
            this.txtModeOfPayment = new System.Windows.Forms.TextBox();
            this.lblModeOfPayment = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAmountBeingPaid = new System.Windows.Forms.Label();
            this.lblExpirationMonthYear = new System.Windows.Forms.Label();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCvvNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDollers = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelLeftImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtExpirationMonthYear
            // 
            this.txtExpirationMonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpirationMonthYear.Location = new System.Drawing.Point(221, 335);
            this.txtExpirationMonthYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExpirationMonthYear.Name = "txtExpirationMonthYear";
            this.txtExpirationMonthYear.Size = new System.Drawing.Size(90, 24);
            this.txtExpirationMonthYear.TabIndex = 4;
            this.txtExpirationMonthYear.Tag = "Expiration Month-Year";
            this.txtExpirationMonthYear.Text = "04/2024";
            this.txtExpirationMonthYear.TextChanged += new System.EventHandler(this.txtExpirationMonthYear_TextChanged);
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(46, 301);
            this.lblCardType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(80, 18);
            this.lblCardType.TabIndex = 23;
            this.lblCardType.Text = "Card Type:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(221, 261);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(164, 24);
            this.txtCardNumber.TabIndex = 2;
            this.txtCardNumber.Tag = "Card Number";
            this.txtCardNumber.Text = "1234123412341234";
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(46, 264);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(101, 18);
            this.lblCardNumber.TabIndex = 22;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardHolderName.Location = new System.Drawing.Point(221, 224);
            this.txtCardHolderName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(211, 24);
            this.txtCardHolderName.TabIndex = 1;
            this.txtCardHolderName.Tag = "Card Holder\'s Name";
            this.txtCardHolderName.Text = "Oreoluwa Lawal";
            this.txtCardHolderName.TextChanged += new System.EventHandler(this.txtCardHolderName_TextChanged);
            // 
            // lblCardholderName
            // 
            this.lblCardholderName.AutoSize = true;
            this.lblCardholderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardholderName.Location = new System.Drawing.Point(46, 227);
            this.lblCardholderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardholderName.Name = "lblCardholderName";
            this.lblCardholderName.Size = new System.Drawing.Size(129, 18);
            this.lblCardholderName.TabIndex = 21;
            this.lblCardholderName.Text = "Cardholder Name:";
            // 
            // txtModeOfPayment
            // 
            this.txtModeOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeOfPayment.Location = new System.Drawing.Point(221, 187);
            this.txtModeOfPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModeOfPayment.Name = "txtModeOfPayment";
            this.txtModeOfPayment.ReadOnly = true;
            this.txtModeOfPayment.Size = new System.Drawing.Size(90, 24);
            this.txtModeOfPayment.TabIndex = 17;
            this.txtModeOfPayment.Tag = "Mode of Payment";
            this.txtModeOfPayment.Text = " Credit Card";
            // 
            // lblModeOfPayment
            // 
            this.lblModeOfPayment.AutoSize = true;
            this.lblModeOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeOfPayment.Location = new System.Drawing.Point(46, 190);
            this.lblModeOfPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeOfPayment.Name = "lblModeOfPayment";
            this.lblModeOfPayment.Size = new System.Drawing.Size(129, 18);
            this.lblModeOfPayment.TabIndex = 16;
            this.lblModeOfPayment.Text = "Mode of Payment:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(2, 88);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(478, 43);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Joe’s Café - Order Payment";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmountBeingPaid
            // 
            this.lblAmountBeingPaid.AutoSize = true;
            this.lblAmountBeingPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountBeingPaid.Location = new System.Drawing.Point(49, 153);
            this.lblAmountBeingPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountBeingPaid.Name = "lblAmountBeingPaid";
            this.lblAmountBeingPaid.Size = new System.Drawing.Size(137, 18);
            this.lblAmountBeingPaid.TabIndex = 25;
            this.lblAmountBeingPaid.Text = "Amount Being Paid:";
            // 
            // lblExpirationMonthYear
            // 
            this.lblExpirationMonthYear.AutoSize = true;
            this.lblExpirationMonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationMonthYear.Location = new System.Drawing.Point(46, 338);
            this.lblExpirationMonthYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpirationMonthYear.Name = "lblExpirationMonthYear";
            this.lblExpirationMonthYear.Size = new System.Drawing.Size(165, 18);
            this.lblExpirationMonthYear.TabIndex = 26;
            this.lblExpirationMonthYear.Text = "Expiration Month / Year:";
            // 
            // cmbCardType
            // 
            this.cmbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCardType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.ItemHeight = 16;
            this.cmbCardType.Location = new System.Drawing.Point(221, 298);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(147, 24);
            this.cmbCardType.TabIndex = 3;
            this.cmbCardType.Tag = "Card Type";
            this.cmbCardType.SelectedIndexChanged += new System.EventHandler(this.cmbCardType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "CVV Number:";
            // 
            // txtCvvNumber
            // 
            this.txtCvvNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvvNumber.Location = new System.Drawing.Point(221, 372);
            this.txtCvvNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCvvNumber.Name = "txtCvvNumber";
            this.txtCvvNumber.PasswordChar = '*';
            this.txtCvvNumber.Size = new System.Drawing.Size(56, 24);
            this.txtCvvNumber.TabIndex = 5;
            this.txtCvvNumber.Tag = "CVV Number";
            this.txtCvvNumber.Text = "123";
            this.txtCvvNumber.TextChanged += new System.EventHandler(this.txtCvvNumber_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(335, 411);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 32);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Tag = "Payment Submit";
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.EnabledChanged += new System.EventHandler(this.btnSubmit_EnabledChanged);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(46, 411);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDollers
            // 
            this.lblDollers.AutoSize = true;
            this.lblDollers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollers.Location = new System.Drawing.Point(221, 153);
            this.lblDollers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDollers.Name = "lblDollers";
            this.lblDollers.Size = new System.Drawing.Size(32, 18);
            this.lblDollers.TabIndex = 32;
            this.lblDollers.Text = "$$$";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(49, 453);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(384, 54);
            this.lblMessage.TabIndex = 33;
            this.lblMessage.Text = "Message";
            // 
            // panelLeftImage
            // 
            this.panelLeftImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeftImage.BackgroundImage")));
            this.panelLeftImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeftImage.Location = new System.Drawing.Point(1, 1);
            this.panelLeftImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeftImage.Name = "panelLeftImage";
            this.panelLeftImage.Size = new System.Drawing.Size(478, 82);
            this.panelLeftImage.TabIndex = 34;
            // 
            // FrmPaymentForOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(477, 514);
            this.Controls.Add(this.panelLeftImage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblDollers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCvvNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCardType);
            this.Controls.Add(this.lblExpirationMonthYear);
            this.Controls.Add(this.lblAmountBeingPaid);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtExpirationMonthYear);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtCardHolderName);
            this.Controls.Add(this.lblCardholderName);
            this.Controls.Add(this.txtModeOfPayment);
            this.Controls.Add(this.lblModeOfPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPaymentForOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaymentForOrder";
            this.Load += new System.EventHandler(this.frmPaymentForOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtExpirationMonthYear;
    private System.Windows.Forms.Label lblCardType;
    private System.Windows.Forms.TextBox txtCardNumber;
    private System.Windows.Forms.Label lblCardNumber;
    private System.Windows.Forms.TextBox txtCardHolderName;
    private System.Windows.Forms.Label lblCardholderName;
    private System.Windows.Forms.TextBox txtModeOfPayment;
    private System.Windows.Forms.Label lblModeOfPayment;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblAmountBeingPaid;
    private System.Windows.Forms.Label lblExpirationMonthYear;
    private System.Windows.Forms.ComboBox cmbCardType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtCvvNumber;
    private System.Windows.Forms.Button btnSubmit;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lblDollers;
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.Panel panelLeftImage;
  }
}