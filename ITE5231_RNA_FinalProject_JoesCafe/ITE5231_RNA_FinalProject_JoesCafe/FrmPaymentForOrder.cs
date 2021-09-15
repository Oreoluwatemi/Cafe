using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  public partial class FrmPaymentForOrder : Form {
    int minimumLengthOfAllFields = 5;
    int cvvNumberLength = 3;
    public bool paymentDone = false;

    public FrmPaymentForOrder() {
      InitializeComponent();
    }

    private void clearAllFields() {
      txtCardHolderName.Text = "";
      txtCardNumber.Text = "";
      cmbCardType.SelectedIndex = -1;
      txtExpirationMonthYear.Text = "";
      txtCvvNumber.Text = "";
    }

    private void enableDisableSubmitButton() {
      if ((lblAmountBeingPaid.Text == "") || txtCardHolderName.Text.Equals("") || txtCardNumber.Text.Equals("") || cmbCardType.SelectedIndex == -1
        || txtExpirationMonthYear.Text.Equals("") || txtCvvNumber.Text.Equals("")) {
        btnSubmit.Enabled = false;
      } else {
        btnSubmit.Enabled = true;
      }
    }

    private bool isAllValid() {
      if (!Validator.IsMinimumLength(txtCardHolderName, minimumLengthOfAllFields)) return false;
      if (!Validator.IsValidCardNumber(txtCardNumber)) return false;
      if (!Validator.IsPresent(cmbCardType)) return false;
      if (!Validator.IsValidCreditCardExpiryDateMMYYYY(txtExpirationMonthYear)) return false;
      if (!Validator.IsExactLength(txtCvvNumber, cvvNumberLength)) return false;

      return true;
    }

    private void frmPaymentForOrder_Load(object sender, EventArgs e) {
      btnCancel.Text = "Cancel";
      paymentDone = false;
      txtCardHolderName.Enabled = true;
      txtCardNumber.Enabled = true;
      cmbCardType.SelectedIndex = -1;
      txtExpirationMonthYear.Enabled = true;
      txtCvvNumber.Enabled = true;

      cmbCardType.Items.Clear();
      cmbCardType.Items.Add("Visa");
      cmbCardType.Items.Add("Master Card");
      cmbCardType.Items.Add("American Express");

      cmbCardType.Text = "Visa";

      lblMessage.Text = "";
      CenterToScreen();
      lblDollers.Text = "$ " + FrmCustomerScreen.grandTotalOrderAmount.ToString("N2");
      Validator.setErrorMessageControl(lblMessage);
      // btnSubmit.Enabled = false;
      btnSubmit.Enabled = true; // For Professor's convenience
    }

    private void btnSubmit_Click(object sender, EventArgs e) {
      if (isAllValid()) {
        // Enter the logic of making the credit card payment
        // In the Project we do not actually do the credit card payment

        lblMessage.Text = "Credit Card Payment Successfully Done!";
        lblMessage.ForeColor = Color.Green;
        btnCancel.Text = "Done";
        clearAllFields();

        paymentDone = true;
        txtCardHolderName.Enabled = false;
        txtCardNumber.Enabled = false;
        cmbCardType.SelectedIndex = -1;
        txtExpirationMonthYear.Enabled = false;
        txtCvvNumber.Enabled = false;
      }
    }

    private void txtCardHolderName_TextChanged(object sender, EventArgs e) {
      enableDisableSubmitButton();
    }

    private void txtCardNumber_TextChanged(object sender, EventArgs e) {
      enableDisableSubmitButton();
    }

    private void cmbCardType_SelectedIndexChanged(object sender, EventArgs e) {
      enableDisableSubmitButton();
    }

    private void txtExpirationMonthYear_TextChanged(object sender, EventArgs e) {
      enableDisableSubmitButton();
    }

    private void txtCvvNumber_TextChanged(object sender, EventArgs e) {
      enableDisableSubmitButton();
    }

    private void btnSubmit_EnabledChanged(object sender, EventArgs e) {
      if (btnSubmit.Enabled) {
        btnSubmit.BackColor = Color.GreenYellow;
      } else {
        btnSubmit.BackColor = Color.LightGray;
      }
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      Close();
    }
  }
}
