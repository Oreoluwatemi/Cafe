
namespace ITE5231_RNA_FinalProject_JoesCafe {
  partial class FrmChefScreen {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChefScreen));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOrderQueue = new System.Windows.Forms.Label();
            this.dataGridViewOrder1 = new System.Windows.Forms.DataGridView();
            this.panelImage1 = new System.Windows.Forms.Panel();
            this.panelSelectedForOrder = new System.Windows.Forms.Panel();
            this.panelImage5 = new System.Windows.Forms.Panel();
            this.dataGridViewOrder5 = new System.Windows.Forms.DataGridView();
            this.panelImage4 = new System.Windows.Forms.Panel();
            this.panelImage3 = new System.Windows.Forms.Panel();
            this.dataGridViewOrder4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrder3 = new System.Windows.Forms.DataGridView();
            this.panelImage2 = new System.Windows.Forms.Panel();
            this.dataGridViewOrder2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRecipe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder1)).BeginInit();
            this.panelSelectedForOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTitle.Location = new System.Drawing.Point(12, 101);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1268, 36);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Joe’s Café";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 100);
            this.panel1.TabIndex = 22;
            // 
            // lblOrderQueue
            // 
            this.lblOrderQueue.AutoSize = true;
            this.lblOrderQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderQueue.Location = new System.Drawing.Point(10, 9);
            this.lblOrderQueue.Name = "lblOrderQueue";
            this.lblOrderQueue.Size = new System.Drawing.Size(105, 18);
            this.lblOrderQueue.TabIndex = 2;
            this.lblOrderQueue.Text = "Order Queue";
            // 
            // dataGridViewOrder1
            // 
            this.dataGridViewOrder1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewOrder1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder1.Location = new System.Drawing.Point(148, 45);
            this.dataGridViewOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder1.Name = "dataGridViewOrder1";
            this.dataGridViewOrder1.ReadOnly = true;
            this.dataGridViewOrder1.RowHeadersVisible = false;
            this.dataGridViewOrder1.RowHeadersWidth = 51;
            this.dataGridViewOrder1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder1.Size = new System.Drawing.Size(448, 122);
            this.dataGridViewOrder1.TabIndex = 10;
            this.dataGridViewOrder1.DataSourceChanged += new System.EventHandler(this.dataGridViewOrder1_DataSourceChanged);
            this.dataGridViewOrder1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewOrder1_CellFormatting);
            this.dataGridViewOrder1.SelectionChanged += new System.EventHandler(this.dataGridViewOrder1_SelectionChanged);
            // 
            // panelImage1
            // 
            this.panelImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage1.Location = new System.Drawing.Point(11, 45);
            this.panelImage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImage1.Name = "panelImage1";
            this.panelImage1.Size = new System.Drawing.Size(130, 122);
            this.panelImage1.TabIndex = 28;
            // 
            // panelSelectedForOrder
            // 
            this.panelSelectedForOrder.BackColor = System.Drawing.Color.Snow;
            this.panelSelectedForOrder.Controls.Add(this.panelImage5);
            this.panelSelectedForOrder.Controls.Add(this.dataGridViewOrder5);
            this.panelSelectedForOrder.Controls.Add(this.panelImage4);
            this.panelSelectedForOrder.Controls.Add(this.panelImage3);
            this.panelSelectedForOrder.Controls.Add(this.dataGridViewOrder4);
            this.panelSelectedForOrder.Controls.Add(this.dataGridViewOrder3);
            this.panelSelectedForOrder.Controls.Add(this.panelImage2);
            this.panelSelectedForOrder.Controls.Add(this.lblOrderQueue);
            this.panelSelectedForOrder.Controls.Add(this.dataGridViewOrder2);
            this.panelSelectedForOrder.Controls.Add(this.panelImage1);
            this.panelSelectedForOrder.Controls.Add(this.dataGridViewOrder1);
            this.panelSelectedForOrder.Location = new System.Drawing.Point(13, 148);
            this.panelSelectedForOrder.Margin = new System.Windows.Forms.Padding(4);
            this.panelSelectedForOrder.Name = "panelSelectedForOrder";
            this.panelSelectedForOrder.Size = new System.Drawing.Size(610, 500);
            this.panelSelectedForOrder.TabIndex = 29;
            // 
            // panelImage5
            // 
            this.panelImage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage5.Location = new System.Drawing.Point(12, 557);
            this.panelImage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImage5.Name = "panelImage5";
            this.panelImage5.Size = new System.Drawing.Size(130, 122);
            this.panelImage5.TabIndex = 34;
            // 
            // dataGridViewOrder5
            // 
            this.dataGridViewOrder5.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewOrder5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder5.Location = new System.Drawing.Point(149, 557);
            this.dataGridViewOrder5.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder5.Name = "dataGridViewOrder5";
            this.dataGridViewOrder5.ReadOnly = true;
            this.dataGridViewOrder5.RowHeadersVisible = false;
            this.dataGridViewOrder5.RowHeadersWidth = 51;
            this.dataGridViewOrder5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder5.Size = new System.Drawing.Size(448, 122);
            this.dataGridViewOrder5.TabIndex = 33;
            this.dataGridViewOrder5.DataSourceChanged += new System.EventHandler(this.dataGridViewOrder5_DataSourceChanged);
            this.dataGridViewOrder5.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewOrder5_CellFormatting);
            this.dataGridViewOrder5.SelectionChanged += new System.EventHandler(this.dataGridViewOrder5_SelectionChanged);
            // 
            // panelImage4
            // 
            this.panelImage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage4.Location = new System.Drawing.Point(11, 429);
            this.panelImage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImage4.Name = "panelImage4";
            this.panelImage4.Size = new System.Drawing.Size(130, 122);
            this.panelImage4.TabIndex = 32;
            // 
            // panelImage3
            // 
            this.panelImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage3.Location = new System.Drawing.Point(11, 301);
            this.panelImage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImage3.Name = "panelImage3";
            this.panelImage3.Size = new System.Drawing.Size(130, 122);
            this.panelImage3.TabIndex = 32;
            // 
            // dataGridViewOrder4
            // 
            this.dataGridViewOrder4.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewOrder4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder4.Location = new System.Drawing.Point(148, 429);
            this.dataGridViewOrder4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder4.Name = "dataGridViewOrder4";
            this.dataGridViewOrder4.ReadOnly = true;
            this.dataGridViewOrder4.RowHeadersVisible = false;
            this.dataGridViewOrder4.RowHeadersWidth = 51;
            this.dataGridViewOrder4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder4.Size = new System.Drawing.Size(448, 122);
            this.dataGridViewOrder4.TabIndex = 31;
            this.dataGridViewOrder4.DataSourceChanged += new System.EventHandler(this.dataGridViewOrder4_DataSourceChanged);
            this.dataGridViewOrder4.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewOrder4_CellFormatting);
            this.dataGridViewOrder4.SelectionChanged += new System.EventHandler(this.dataGridViewOrder4_SelectionChanged);
            // 
            // dataGridViewOrder3
            // 
            this.dataGridViewOrder3.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewOrder3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder3.Location = new System.Drawing.Point(148, 301);
            this.dataGridViewOrder3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder3.Name = "dataGridViewOrder3";
            this.dataGridViewOrder3.ReadOnly = true;
            this.dataGridViewOrder3.RowHeadersVisible = false;
            this.dataGridViewOrder3.RowHeadersWidth = 51;
            this.dataGridViewOrder3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder3.Size = new System.Drawing.Size(448, 122);
            this.dataGridViewOrder3.TabIndex = 31;
            this.dataGridViewOrder3.DataSourceChanged += new System.EventHandler(this.dataGridViewOrder3_DataSourceChanged);
            this.dataGridViewOrder3.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewOrder3_CellFormatting);
            this.dataGridViewOrder3.SelectionChanged += new System.EventHandler(this.dataGridViewOrder3_SelectionChanged);
            // 
            // panelImage2
            // 
            this.panelImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage2.Location = new System.Drawing.Point(11, 175);
            this.panelImage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImage2.Name = "panelImage2";
            this.panelImage2.Size = new System.Drawing.Size(130, 122);
            this.panelImage2.TabIndex = 30;
            // 
            // dataGridViewOrder2
            // 
            this.dataGridViewOrder2.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewOrder2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder2.Location = new System.Drawing.Point(148, 175);
            this.dataGridViewOrder2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder2.Name = "dataGridViewOrder2";
            this.dataGridViewOrder2.ReadOnly = true;
            this.dataGridViewOrder2.RowHeadersVisible = false;
            this.dataGridViewOrder2.RowHeadersWidth = 51;
            this.dataGridViewOrder2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder2.Size = new System.Drawing.Size(448, 122);
            this.dataGridViewOrder2.TabIndex = 29;
            this.dataGridViewOrder2.DataSourceChanged += new System.EventHandler(this.dataGridViewOrder2_DataSourceChanged);
            this.dataGridViewOrder2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewOrder2_CellFormatting);
            this.dataGridViewOrder2.SelectionChanged += new System.EventHandler(this.dataGridViewOrder2_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblRecipe);
            this.panel2.Location = new System.Drawing.Point(631, 148);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 500);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.Location = new System.Drawing.Point(10, 9);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(115, 18);
            this.lblRecipe.TabIndex = 2;
            this.lblRecipe.Text = "Coffee Recipe";
            // 
            // FrmChefScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSelectedForOrder);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmChefScreen";
            this.Text = "Chef\'s Display";
            this.Load += new System.EventHandler(this.FrmChefScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder1)).EndInit();
            this.panelSelectedForOrder.ResumeLayout(false);
            this.panelSelectedForOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblOrderQueue;
    private System.Windows.Forms.DataGridView dataGridViewOrder1;
    private System.Windows.Forms.Panel panelImage1;
    private System.Windows.Forms.Panel panelSelectedForOrder;
    private System.Windows.Forms.Panel panelImage5;
    private System.Windows.Forms.DataGridView dataGridViewOrder5;
    private System.Windows.Forms.Panel panelImage4;
    private System.Windows.Forms.Panel panelImage3;
    private System.Windows.Forms.DataGridView dataGridViewOrder4;
    private System.Windows.Forms.DataGridView dataGridViewOrder3;
    private System.Windows.Forms.Panel panelImage2;
    private System.Windows.Forms.DataGridView dataGridViewOrder2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label lblRecipe;
  }
}