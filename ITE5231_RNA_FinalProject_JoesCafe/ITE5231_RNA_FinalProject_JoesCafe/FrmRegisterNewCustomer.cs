using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  public partial class FrmRegisterNewCustomer : Form {
    int minimumLengthOfAllFields = 3;

    public FrmRegisterNewCustomer() {
      InitializeComponent();
    }

    private void enableDisableRegisterButton() {
      if (txtUsername.Text.Equals("") || txtFirstName.Text.Equals("") || txtLastName.Text.Equals("")
        || txtEmail.Text.Equals("") || txtMobile.Text.Equals("") || txtPassword.Text.Equals("") 
        || txtConfirmPassword.Text.Equals("")) {
        btnRegister.Enabled = false;
      } else {
        btnRegister.Enabled = true;
      }
    }

    private void txtUsername_TextChanged(object sender, EventArgs e) {
      enableDisableRegisterButton();
    }

    private void btnRegister_EnabledChanged(object sender, EventArgs e) {
      if (btnRegister.Enabled) {
        btnRegister.BackColor = Color.GreenYellow;
      } else {
        btnRegister.BackColor = Color.LightGray;
      }
    }

    private void txtFirstName_TextChanged(object sender, EventArgs e) {
      enableDisableRegisterButton();
    }

    private void txtLastName_TextChanged(object sender, EventArgs e) {
      enableDisableRegisterButton();
    }

    private void txtMobile_TextChanged(object sender, EventArgs e) {
      enableDisableRegisterButton();
    }

    private void txtPassword_TextChanged(object sender, EventArgs e) {
      enableDisableRegisterButton();
    }

    private void txtConfirmPassword_TextChanged(object sender, EventArgs e) {
      enableDisableRegisterButton();
    }

    private void frmRegisterNewCustomer_Load(object sender, EventArgs e) {
      lblMessage.Text = "";
      btnRegister.Enabled = false;
      CenterToScreen();
      Validator.setErrorMessageControl(lblMessage);
    }

    private UserWithLogin createUserInstance() {
      UserWithLogin userWithLogin = new UserWithLogin();
      userWithLogin.Username = txtUsername.Text;
      userWithLogin.FirstName = txtFirstName.Text;
      userWithLogin.LastName = txtLastName.Text;
      userWithLogin.Email = txtEmail.Text;
      userWithLogin.Mobile = txtMobile.Text;
      userWithLogin.Role = "Customer";
      userWithLogin.Password = txtPassword.Text;

      return userWithLogin;
    }

    private bool isAllValid() {
      if (!Validator.IsMinimumLength(txtUsername, minimumLengthOfAllFields)) return false;
      if (!Validator.IsMinimumLength(txtFirstName, minimumLengthOfAllFields)) return false;
      if (!Validator.IsMinimumLength(txtLastName, minimumLengthOfAllFields)) return false;
      if (!Validator.IsValidEmail(txtEmail)) return false;
      if (!Validator.IsValidMobile(txtMobile)) return false;
      if (!Validator.IsMinimumLength(txtPassword, minimumLengthOfAllFields)) return false;

      return true;
    }

    private void btnRegister_Click(object sender, EventArgs e) {
      if (txtPassword.Text.Equals(txtConfirmPassword.Text)) {
        bool usernameExists = UserDB.UsernameExists(txtUsername.Text);
        if (usernameExists) {
          lblMessage.Text = $"Error: Username '{txtUsername.Text}' already exists, please choose a different username";
          lblMessage.ForeColor = Color.Red;
        } else {
          if (isAllValid()) {
            UserWithLogin userWithLogin = createUserInstance();
            int userID = UserDB.AddCustomerUser(userWithLogin);
            if (userID == 0) {
              lblMessage.Text = "Error: Problem encountered while registering new user";
              lblMessage.ForeColor = Color.Red;
            } else {
              lblMessage.Text = "Registered new Successfully!";
              lblMessage.ForeColor = Color.Green;
              btnCancel.Text = "Done";
            }
          }
        }
      } else {
        lblMessage.Text = "Error: 'Password' and 'Confirm Password' do not match";
        lblMessage.ForeColor = Color.Red;
      }
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      Close();
    }

    private void txtEmail_TextChanged(object sender, EventArgs e) {
      enableDisableRegisterButton();
    }
  }
}
