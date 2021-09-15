
namespace ITE5231_RNA_FinalProject_JoesCafe {
  partial class FrmTest {
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
      this.chkOrder = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // chkOrder
      // 
      this.chkOrder.BackColor = System.Drawing.Color.Brown;
      this.chkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkOrder.ForeColor = System.Drawing.Color.White;
      this.chkOrder.Location = new System.Drawing.Point(542, 72);
      this.chkOrder.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
      this.chkOrder.Name = "chkOrder";
      this.chkOrder.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.chkOrder.Size = new System.Drawing.Size(99, 32);
      this.chkOrder.TabIndex = 0;
      this.chkOrder.Text = "Order";
      this.chkOrder.UseVisualStyleBackColor = false;
      this.chkOrder.CheckedChanged += new System.EventHandler(this.chkOrder_CheckedChanged);
      // 
      // FrmTest
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(1163, 570);
      this.Controls.Add(this.chkOrder);
      this.Name = "FrmTest";
      this.Text = "FrmTest";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.CheckBox chkOrder;
  }
}