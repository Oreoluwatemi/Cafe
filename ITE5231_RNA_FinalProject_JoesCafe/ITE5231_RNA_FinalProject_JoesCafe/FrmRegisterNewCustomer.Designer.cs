
namespace ITE5231_RNA_FinalProject_JoesCafe {
  partial class FrmRegisterNewCustomer {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisterNewCustomer));
      this.lblTitle = new System.Windows.Forms.Label();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblUsername = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.lblEmail = new System.Windows.Forms.Label();
      this.txtMobile = new System.Windows.Forms.TextBox();
      this.lblMobile = new System.Windows.Forms.Label();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.lblLastName = new System.Windows.Forms.Label();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.lblFirstName = new System.Windows.Forms.Label();
      this.txtConfirmPassword = new System.Windows.Forms.TextBox();
      this.lblConfirmPassword = new System.Windows.Forms.Label();
      this.lblNewUserRegistration = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnRegister = new System.Windows.Forms.Button();
      this.lblMessage = new System.Windows.Forms.Label();
      this.panelLeftImage = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(111, 113);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(333, 32);
      this.lblTitle.TabIndex = 9;
      this.lblTitle.Text = "Welcome to Joe’s Café ";
      // 
      // txtUsername
      // 
      this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUsername.Location = new System.Drawing.Point(211, 66);
      this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(217, 28);
      this.txtUsername.TabIndex = 2;
      this.txtUsername.Tag = "Username";
      this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(211, 304);
      this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(217, 28);
      this.txtPassword.TabIndex = 7;
      this.txtPassword.Tag = "Password";
      this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
      // 
      // lblUsername
      // 
      this.lblUsername.AutoSize = true;
      this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUsername.Location = new System.Drawing.Point(36, 68);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(102, 24);
      this.lblUsername.TabIndex = 1;
      this.lblUsername.Text = "Username:";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPassword.Location = new System.Drawing.Point(36, 305);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(97, 24);
      this.lblPassword.TabIndex = 3;
      this.lblPassword.Text = "Password:";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FloralWhite;
      this.panel1.Controls.Add(this.txtEmail);
      this.panel1.Controls.Add(this.lblEmail);
      this.panel1.Controls.Add(this.txtMobile);
      this.panel1.Controls.Add(this.lblMobile);
      this.panel1.Controls.Add(this.txtLastName);
      this.panel1.Controls.Add(this.lblLastName);
      this.panel1.Controls.Add(this.txtFirstName);
      this.panel1.Controls.Add(this.lblFirstName);
      this.panel1.Controls.Add(this.txtConfirmPassword);
      this.panel1.Controls.Add(this.lblConfirmPassword);
      this.panel1.Controls.Add(this.lblNewUserRegistration);
      this.panel1.Controls.Add(this.btnCancel);
      this.panel1.Controls.Add(this.btnRegister);
      this.panel1.Controls.Add(this.txtUsername);
      this.panel1.Controls.Add(this.txtPassword);
      this.panel1.Controls.Add(this.lblUsername);
      this.panel1.Controls.Add(this.lblPassword);
      this.panel1.Location = new System.Drawing.Point(47, 160);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(469, 452);
      this.panel1.TabIndex = 10;
      // 
      // txtEmail
      // 
      this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEmail.Location = new System.Drawing.Point(211, 209);
      this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(217, 28);
      this.txtEmail.TabIndex = 5;
      this.txtEmail.Tag = "Email Address";
      this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEmail.Location = new System.Drawing.Point(36, 210);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(62, 24);
      this.lblEmail.TabIndex = 17;
      this.lblEmail.Text = "Email:";
      // 
      // txtMobile
      // 
      this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMobile.Location = new System.Drawing.Point(211, 256);
      this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtMobile.Name = "txtMobile";
      this.txtMobile.Size = new System.Drawing.Size(217, 28);
      this.txtMobile.TabIndex = 6;
      this.txtMobile.Tag = "Mobile Number";
      this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
      // 
      // lblMobile
      // 
      this.lblMobile.AutoSize = true;
      this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMobile.Location = new System.Drawing.Point(36, 257);
      this.lblMobile.Name = "lblMobile";
      this.lblMobile.Size = new System.Drawing.Size(146, 24);
      this.lblMobile.TabIndex = 15;
      this.lblMobile.Text = "Mobile Number:";
      // 
      // txtLastName
      // 
      this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLastName.Location = new System.Drawing.Point(211, 162);
      this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(217, 28);
      this.txtLastName.TabIndex = 4;
      this.txtLastName.Tag = "Last Name";
      this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
      // 
      // lblLastName
      // 
      this.lblLastName.AutoSize = true;
      this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLastName.Location = new System.Drawing.Point(36, 164);
      this.lblLastName.Name = "lblLastName";
      this.lblLastName.Size = new System.Drawing.Size(104, 24);
      this.lblLastName.TabIndex = 13;
      this.lblLastName.Text = "Last Name:";
      // 
      // txtFirstName
      // 
      this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFirstName.Location = new System.Drawing.Point(211, 114);
      this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(217, 28);
      this.txtFirstName.TabIndex = 3;
      this.txtFirstName.Tag = "First Name";
      this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
      // 
      // lblFirstName
      // 
      this.lblFirstName.AutoSize = true;
      this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFirstName.Location = new System.Drawing.Point(36, 116);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.Size = new System.Drawing.Size(106, 24);
      this.lblFirstName.TabIndex = 11;
      this.lblFirstName.Text = "First Name:";
      // 
      // txtConfirmPassword
      // 
      this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtConfirmPassword.Location = new System.Drawing.Point(211, 350);
      this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtConfirmPassword.Name = "txtConfirmPassword";
      this.txtConfirmPassword.PasswordChar = '*';
      this.txtConfirmPassword.Size = new System.Drawing.Size(217, 28);
      this.txtConfirmPassword.TabIndex = 8;
      this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
      // 
      // lblConfirmPassword
      // 
      this.lblConfirmPassword.AutoSize = true;
      this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblConfirmPassword.Location = new System.Drawing.Point(36, 353);
      this.lblConfirmPassword.Name = "lblConfirmPassword";
      this.lblConfirmPassword.Size = new System.Drawing.Size(152, 20);
      this.lblConfirmPassword.TabIndex = 9;
      this.lblConfirmPassword.Text = "Confirm Password:";
      // 
      // lblNewUserRegistration
      // 
      this.lblNewUserRegistration.AutoSize = true;
      this.lblNewUserRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNewUserRegistration.ForeColor = System.Drawing.Color.DarkOrchid;
      this.lblNewUserRegistration.Location = new System.Drawing.Point(99, 10);
      this.lblNewUserRegistration.Name = "lblNewUserRegistration";
      this.lblNewUserRegistration.Size = new System.Drawing.Size(276, 29);
      this.lblNewUserRegistration.TabIndex = 8;
      this.lblNewUserRegistration.Text = "New User Registration";
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.GreenYellow;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.Location = new System.Drawing.Point(36, 400);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(80, 34);
      this.btnCancel.TabIndex = 10;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnRegister
      // 
      this.btnRegister.BackColor = System.Drawing.Color.GreenYellow;
      this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRegister.Location = new System.Drawing.Point(331, 400);
      this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(97, 36);
      this.btnRegister.TabIndex = 9;
      this.btnRegister.Text = "Register";
      this.btnRegister.UseVisualStyleBackColor = false;
      this.btnRegister.EnabledChanged += new System.EventHandler(this.btnRegister_EnabledChanged);
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
      // 
      // lblMessage
      // 
      this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMessage.ForeColor = System.Drawing.Color.Crimson;
      this.lblMessage.Location = new System.Drawing.Point(43, 626);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(475, 49);
      this.lblMessage.TabIndex = 12;
      this.lblMessage.Text = "Message";
      // 
      // panelLeftImage
      // 
      this.panelLeftImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeftImage.BackgroundImage")));
      this.panelLeftImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.panelLeftImage.Location = new System.Drawing.Point(0, 1);
      this.panelLeftImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panelLeftImage.Name = "panelLeftImage";
      this.panelLeftImage.Size = new System.Drawing.Size(574, 101);
      this.panelLeftImage.TabIndex = 13;
      // 
      // FrmRegisterNewCustomer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SeaShell;
      this.ClientSize = new System.Drawing.Size(575, 682);
      this.Controls.Add(this.panelLeftImage);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lblMessage);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MinimizeBox = false;
      this.Name = "FrmRegisterNewCustomer";
      this.Text = "Register New Customer";
      this.Load += new System.EventHandler(this.frmRegisterNewCustomer_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblNewUserRegistration;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.TextBox txtConfirmPassword;
    private System.Windows.Forms.Label lblConfirmPassword;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.Label lblFirstName;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.TextBox txtMobile;
    private System.Windows.Forms.Label lblMobile;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Panel panelLeftImage;
  }
}