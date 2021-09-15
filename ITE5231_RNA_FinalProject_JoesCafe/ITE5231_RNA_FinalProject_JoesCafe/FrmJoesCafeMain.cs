using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  public partial class FrmJoesCafeMain : Form {

    public static int LoggedInUserId;

    public FrmJoesCafeMain() {
      InitializeComponent();
    }

    private void frmJoesCafeMain_Load(object sender, EventArgs e) {
      lblMessage.Text = "";
      // btnLogin.Enabled = false;
      btnLogin.Enabled = true; // For Professor's convenience
      CenterToScreen();
    }

    private void btnLogin_Click(object sender, EventArgs e) {
      UserWithLogin user = UserDB.verifyLogin(txtUsername.Text, txtPassword.Text);
      if (user != null) {
        Hide();
        LoggedInUserId = user.Id;
        if (user.Role.Equals("Customer")) {
          Global.GetInstance().CustomerScreen.ShowDialog();
        } else if (user.Role.Equals("Chef")) {
          Global.GetInstance().ChefScreen.ShowDialog();
        }
        Application.Exit();
      } else {
        lblMessage.Text = "Error: Invalid Username or Password";
        lblMessage.ForeColor = Color.Red;
      }
    }

    private void enableDisableLoginButton() {
      if (txtUsername.Text.Equals("") || txtPassword.Text.Equals("")) {
        btnLogin.Enabled = false;
      } else {
        btnLogin.Enabled = true;
      }
    }

    private void txtUsername_KeyUp(object sender, KeyEventArgs e) {
      enableDisableLoginButton();
    }

    private void btnLogin_EnabledChanged(object sender, EventArgs e) {
      if (btnLogin.Enabled) {
        btnLogin.BackColor = Color.GreenYellow;
      } else {
        btnLogin.BackColor = Color.LightGray;
      }
    }

    private void txtPassword_KeyUp(object sender, KeyEventArgs e) {
      enableDisableLoginButton();
    }

    private void btnExit_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void btnRegisterNew_Click(object sender, EventArgs e) {
      Hide();
      Global.GetInstance().RegisterNewCustomerForm.ShowDialog();
      Show();
    }
  }
}
