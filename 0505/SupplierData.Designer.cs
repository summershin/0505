
namespace 期中專題
{
    partial class SupplierData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mu_gpBx_C = new System.Windows.Forms.GroupBox();
            this.Mu_lbl2_SupplierName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Mu_gpBx_URD = new System.Windows.Forms.GroupBox();
            this.dataGV_SupplierData = new System.Windows.Forms.DataGridView();
            this.tabCtrl_Supplier = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Mo_gpBx_RUD = new System.Windows.Forms.GroupBox();
            this.Mo_gpBx_C = new System.Windows.Forms.GroupBox();
            this.lbl1_Supplier = new System.Windows.Forms.Label();
            this.Mu_gpBx_C.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_SupplierData)).BeginInit();
            this.tabCtrl_Supplier.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mu_gpBx_C
            // 
            this.Mu_gpBx_C.Controls.Add(this.Mu_lbl2_SupplierName);
            this.Mu_gpBx_C.Controls.Add(this.textBox1);
            this.Mu_gpBx_C.Location = new System.Drawing.Point(6, 6);
            this.Mu_gpBx_C.Name = "Mu_gpBx_C";
            this.Mu_gpBx_C.Size = new System.Drawing.Size(479, 116);
            this.Mu_gpBx_C.TabIndex = 0;
            this.Mu_gpBx_C.TabStop = false;
            this.Mu_gpBx_C.Text = "新增";
            // 
            // Mu_lbl2_SupplierName
            // 
            this.Mu_lbl2_SupplierName.AutoSize = true;
            this.Mu_lbl2_SupplierName.Location = new System.Drawing.Point(6, 24);
            this.Mu_lbl2_SupplierName.Name = "Mu_lbl2_SupplierName";
            this.Mu_lbl2_SupplierName.Size = new System.Drawing.Size(65, 12);
            this.Mu_lbl2_SupplierName.TabIndex = 1;
            this.Mu_lbl2_SupplierName.Text = "供應商名稱";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // Mu_gpBx_URD
            // 
            this.Mu_gpBx_URD.Location = new System.Drawing.Point(6, 128);
            this.Mu_gpBx_URD.Name = "Mu_gpBx_URD";
            this.Mu_gpBx_URD.Size = new System.Drawing.Size(802, 116);
            this.Mu_gpBx_URD.TabIndex = 1;
            this.Mu_gpBx_URD.TabStop = false;
            this.Mu_gpBx_URD.Text = "查詢 修改 刪除";
            // 
            // dataGV_SupplierData
            // 
            this.dataGV_SupplierData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_SupplierData.Location = new System.Drawing.Point(12, 359);
            this.dataGV_SupplierData.Name = "dataGV_SupplierData";
            this.dataGV_SupplierData.RowTemplate.Height = 24;
            this.dataGV_SupplierData.Size = new System.Drawing.Size(822, 149);
            this.dataGV_SupplierData.TabIndex = 2;
            // 
            // tabCtrl_Supplier
            // 
            this.tabCtrl_Supplier.Controls.Add(this.tabPage1);
            this.tabCtrl_Supplier.Controls.Add(this.tabPage2);
            this.tabCtrl_Supplier.Location = new System.Drawing.Point(12, 53);
            this.tabCtrl_Supplier.Name = "tabCtrl_Supplier";
            this.tabCtrl_Supplier.SelectedIndex = 0;
            this.tabCtrl_Supplier.Size = new System.Drawing.Size(822, 300);
            this.tabCtrl_Supplier.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.Mu_gpBx_C);
            this.tabPage1.Controls.Add(this.Mu_gpBx_URD);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "景點";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.Mo_gpBx_RUD);
            this.tabPage2.Controls.Add(this.Mo_gpBx_C);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "電影院";
            // 
            // Mo_gpBx_RUD
            // 
            this.Mo_gpBx_RUD.Location = new System.Drawing.Point(6, 128);
            this.Mo_gpBx_RUD.Name = "Mo_gpBx_RUD";
            this.Mo_gpBx_RUD.Size = new System.Drawing.Size(479, 116);
            this.Mo_gpBx_RUD.TabIndex = 1;
            this.Mo_gpBx_RUD.TabStop = false;
            this.Mo_gpBx_RUD.Text = "查詢 修改 刪除";
            // 
            // Mo_gpBx_C
            // 
            this.Mo_gpBx_C.Location = new System.Drawing.Point(6, 6);
            this.Mo_gpBx_C.Name = "Mo_gpBx_C";
            this.Mo_gpBx_C.Size = new System.Drawing.Size(479, 116);
            this.Mo_gpBx_C.TabIndex = 1;
            this.Mo_gpBx_C.TabStop = false;
            this.Mo_gpBx_C.Text = "新增";
            // 
            // lbl1_Supplier
            // 
            this.lbl1_Supplier.AutoSize = true;
            this.lbl1_Supplier.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl1_Supplier.Location = new System.Drawing.Point(7, 9);
            this.lbl1_Supplier.Name = "lbl1_Supplier";
            this.lbl1_Supplier.Size = new System.Drawing.Size(158, 29);
            this.lbl1_Supplier.TabIndex = 4;
            this.lbl1_Supplier.Text = "供應商管理";
            // 
            // SupplierData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 520);
            this.Controls.Add(this.lbl1_Supplier);
            this.Controls.Add(this.tabCtrl_Supplier);
            this.Controls.Add(this.dataGV_SupplierData);
            this.Name = "SupplierData";
            this.Text = "SupplierData";
            this.Mu_gpBx_C.ResumeLayout(false);
            this.Mu_gpBx_C.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_SupplierData)).EndInit();
            this.tabCtrl_Supplier.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Mu_gpBx_C;
        private System.Windows.Forms.GroupBox Mu_gpBx_URD;
        private System.Windows.Forms.DataGridView dataGV_SupplierData;
        private System.Windows.Forms.TabControl tabCtrl_Supplier;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox Mo_gpBx_RUD;
        private System.Windows.Forms.GroupBox Mo_gpBx_C;
        private System.Windows.Forms.Label lbl1_Supplier;
        private System.Windows.Forms.Label Mu_lbl2_SupplierName;
        private System.Windows.Forms.TextBox textBox1;
    }
}