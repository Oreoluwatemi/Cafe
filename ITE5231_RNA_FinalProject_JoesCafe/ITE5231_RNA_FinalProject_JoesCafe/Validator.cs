using System;
using System.Drawing;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class Validator {
    private static Control lblMessage = null;

    public static void setErrorMessageControl(Control control) {
      lblMessage = control;
    }

    public static bool ShouldNotBePresent(Control control) {
      if (control.GetType().ToString() == "System.Windows.Forms.TextBox") {
        TextBox textBox = (TextBox)control;
        if (textBox.Text != "") {
          lblMessage.Text = "Error: Must NOT enter '" + textBox.Tag + "'";
          lblMessage.ForeColor = Color.Red;

          textBox.Focus();
          return false;
        }
      }
      return true;
    }

    public static bool IsPresent(Control control) {
      if (control.GetType().ToString() == "System.Windows.Forms.TextBox") {
        TextBox textBox = (TextBox)control;
        if (textBox.Text == "") {
          lblMessage.Text = "Error: Must enter '" + textBox.Tag + "'";
          lblMessage.ForeColor = Color.Red;

          textBox.Focus();
          return false;
        }
      } else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox") {
        ComboBox comboBox = (ComboBox)control;
        if (comboBox.SelectedIndex == -1) {
          lblMessage.Text = "Error: Must enter '" + comboBox.Tag + "'";
          lblMessage.ForeColor = Color.Red;

          comboBox.Focus();
          return false;
        }
      }
      return true;
    }

    public static bool IsMinimumLength(Control control, int minimumLength) {
      if (control.GetType().ToString() == "System.Windows.Forms.TextBox") {
        TextBox textBox = (TextBox)control;
        if (textBox.Text.Length < minimumLength) {
          lblMessage.Text = $"Error: Must enter at least {minimumLength} characters in '{textBox.Tag}'";
          lblMessage.ForeColor = Color.Red;

          textBox.Focus();
          return false;
        }
      }

      return true;
    }

    public static bool IsValidCardNumber(Control control) {
      if (control.GetType().ToString() == "System.Windows.Forms.TextBox") {
        TextBox textBox = (TextBox)control;
        BigInteger parsedValue;
        if ((textBox.Text.Length != 16) || !BigInteger.TryParse(textBox.Text, out parsedValue)) {
          lblMessage.Text = $"Error: Must enter exactly 16 digits for '{textBox.Tag}'";
          lblMessage.ForeColor = Color.Red;

          textBox.Focus();
          return false;
        }
      }

      return true;
    }

    public static bool IsExactLength(Control control, int exactLength) {
      if (control.GetType().ToString() == "System.Windows.Forms.TextBox") {
        TextBox textBox = (TextBox)control;
        if (textBox.Text.Length != exactLength) {
          lblMessage.Text = $"Error: Must enter exactly {exactLength} characters in '{textBox.Tag}'";
          lblMessage.ForeColor = Color.Red;

          textBox.Focus();
          return false;
        }
      }

      return true;
    }

    public static bool IsValidMobile(Control control) {
      if (control.GetType().ToString() == "System.Windows.Forms.TextBox") {
        TextBox textBox = (TextBox)control;
        string mobile = textBox.Text;
        string[] mobileParts = mobile.Split('-');
        if ((mobileParts.Length != 3) || (mobileParts[0].Length != 3) || (mobileParts[1].Length != 3)
          || (mobileParts[2].Length != 4)) {
          lblMessage.Text = $"Error: Must enter '{textBox.Tag}' in the form 'NNN-NNN-NNNN'";
          lblMessage.ForeColor = Color.Red;

          textBox.Focus();
          return false;
        }
      }

      return true;
    }

    public static bool IsValidEmail(Control control) {
      if (control.GetType().ToString() == "System.Windows.Forms.TextBox") {
        TextBox textBox = (TextBox)control;
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(textBox.Text);
        if (!match.Success) {
          lblMessage.Text = $"Error: '{textBox.Tag}' is not a valid Email";
          lblMessage.ForeColor = Color.Red;

          textBox.Focus();
          return false;
        }
      }

      return true;
    }

    public static bool IsValidCreditCardExpiryDateMMYYYY(Control control) {
      if (control.GetType().ToString() == "System.Windows.Forms.TextBox") {
        TextBox textBox = (TextBox)control;
        string expiryDate = textBox.Text;
        string[] expiryDateParts = expiryDate.Split('/');
        if ((expiryDate.Length != 7) || (expiryDateParts[0].Length != 2) || (expiryDateParts[1].Length != 4)) {
          lblMessage.Text = $"Error: Must enter '{textBox.Tag}' in the form 'MM/YYYY'";
          lblMessage.ForeColor = Color.Red;

          textBox.Focus();
          return false;
        } else {
          try {
            int temp = Convert.ToInt32(expiryDateParts[0]);
            int temp1 = Convert.ToInt32(expiryDateParts[1]);
          } catch (Exception) {
            lblMessage.Text = $"Error: Must enter '{textBox.Tag}' in the form 'MM/YYYY'";
            lblMessage.ForeColor = Color.Red;

            textBox.Focus();
            return false;
          }
        }
      }

      return true;
    }

    public static bool IsDecimal(TextBox textBox) {
      try {
        Convert.ToDecimal(textBox.Text);
        return true;
      } catch (FormatException) {
        lblMessage.Text = "Error: '" + textBox.Tag + "' must be a decimal number";
        lblMessage.ForeColor = Color.Red;

        textBox.Focus();
        return false;
      }
    }

    public static bool IsInt32(TextBox textBox) {
      try {
        Convert.ToInt32(textBox.Text);
        return true;
      } catch (FormatException) {
        lblMessage.Text = "Error: '" + textBox.Tag + "' must be an integer";
        lblMessage.ForeColor = Color.Red;

        textBox.Focus();
        return false;
      }
    }

    public static bool IsWithinRange(TextBox textBox, decimal min, decimal max) {
      decimal number = Convert.ToDecimal(textBox.Text);
      if (number < min || number > max) {
        lblMessage.Text = "'" + textBox.Tag + ", must be between " + min + " and " + max;
        lblMessage.ForeColor = Color.Red;

        textBox.Focus();
        return false;
      }
      return true;
    }
  }
}
