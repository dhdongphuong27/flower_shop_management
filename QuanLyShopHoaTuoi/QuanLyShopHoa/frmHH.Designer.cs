namespace QuanLyShopHoa
{
    partial class frmHH
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
            this.textview1 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXuatxu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSLHH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateHH = new System.Windows.Forms.Button();
            this.btnAddHH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textview1
            // 
            this.textview1.AutoSize = true;
            this.textview1.Location = new System.Drawing.Point(105, 43);
            this.textview1.Name = "textview1";
            this.textview1.Size = new System.Drawing.Size(31, 17);
            this.textview1.TabIndex = 0;
            this.textview1.Text = "Mã:";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(142, 43);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(232, 22);
            this.txtMaHH.TabIndex = 1;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(142, 82);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(232, 22);
            this.txtTenHH.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên:";
            // 
            // txtXuatxu
            // 
            this.txtXuatxu.Location = new System.Drawing.Point(142, 120);
            this.txtXuatxu.Name = "txtXuatxu";
            this.txtXuatxu.Size = new System.Drawing.Size(232, 22);
            this.txtXuatxu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xuất xứ:";
            // 
            // txtSLHH
            // 
            this.txtSLHH.Location = new System.Drawing.Point(142, 198);
            this.txtSLHH.Name = "txtSLHH";
            this.txtSLHH.Size = new System.Drawing.Size(232, 22);
            this.txtSLHH.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(142, 158);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(232, 22);
            this.txtGiaban.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá thành:";
            // 
            // btnUpdateHH
            // 
            this.btnUpdateHH.AutoSize = true;
            this.btnUpdateHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHH.Location = new System.Drawing.Point(65, 250);
            this.btnUpdateHH.Name = "btnUpdateHH";
            this.btnUpdateHH.Size = new System.Drawing.Size(152, 27);
            this.btnUpdateHH.TabIndex = 10;
            this.btnUpdateHH.Text = "Cập nhật thông tin";
            this.btnUpdateHH.UseVisualStyleBackColor = true;
            this.btnUpdateHH.Click += new System.EventHandler(this.btnUpdateHH_Click);
            // 
            // btnAddHH
            // 
            this.btnAddHH.AutoSize = true;
            this.btnAddHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHH.Location = new System.Drawing.Point(243, 250);
            this.btnAddHH.Name = "btnAddHH";
            this.btnAddHH.Size = new System.Drawing.Size(131, 27);
            this.btnAddHH.TabIndex = 11;
            this.btnAddHH.Text = "Thêm hàng hóa";
            this.btnAddHH.UseVisualStyleBackColor = true;
            this.btnAddHH.Click += new System.EventHandler(this.btnAddHH_Click);
            // 
            // frmHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 308);
            this.Controls.Add(this.btnAddHH);
            this.Controls.Add(this.btnUpdateHH);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSLHH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXuatxu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.textview1);
            this.Name = "frmHH";
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.frmHH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textview1;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXuatxu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSLHH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateHH;
        private System.Windows.Forms.Button btnAddHH;
    }
}