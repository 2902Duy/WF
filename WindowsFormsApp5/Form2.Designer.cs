namespace WindowsFormsApp5
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.grbgioitinh = new System.Windows.Forms.GroupBox();
            this.rbtnam = new System.Windows.Forms.RadioButton();
            this.rbtnu = new System.Windows.Forms.RadioButton();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btncapnhap = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbgioitinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "mssv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "tên sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "điểm tb";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(151, 90);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(191, 20);
            this.txtmssv.TabIndex = 5;
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(151, 139);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(191, 20);
            this.txttensv.TabIndex = 6;
            // 
            // grbgioitinh
            // 
            this.grbgioitinh.Controls.Add(this.rbtnu);
            this.grbgioitinh.Controls.Add(this.rbtnam);
            this.grbgioitinh.Location = new System.Drawing.Point(151, 165);
            this.grbgioitinh.Name = "grbgioitinh";
            this.grbgioitinh.Size = new System.Drawing.Size(156, 42);
            this.grbgioitinh.TabIndex = 7;
            this.grbgioitinh.TabStop = false;
            // 
            // rbtnam
            // 
            this.rbtnam.AutoSize = true;
            this.rbtnam.Location = new System.Drawing.Point(16, 20);
            this.rbtnam.Name = "rbtnam";
            this.rbtnam.Size = new System.Drawing.Size(47, 17);
            this.rbtnam.TabIndex = 0;
            this.rbtnam.TabStop = true;
            this.rbtnam.Text = "Nam";
            this.rbtnam.UseVisualStyleBackColor = true;
            // 
            // rbtnu
            // 
            this.rbtnu.AutoSize = true;
            this.rbtnu.Location = new System.Drawing.Point(83, 20);
            this.rbtnu.Name = "rbtnu";
            this.rbtnu.Size = new System.Drawing.Size(39, 17);
            this.rbtnu.TabIndex = 1;
            this.rbtnu.TabStop = true;
            this.rbtnu.Text = "Nữ";
            this.rbtnu.UseVisualStyleBackColor = true;
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Items.AddRange(new object[] {
            "CNTT",
            "NNA",
            "QTKD"});
            this.cmbkhoa.Location = new System.Drawing.Point(151, 240);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(191, 21);
            this.cmbkhoa.TabIndex = 8;
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(151, 300);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(191, 20);
            this.txtdiem.TabIndex = 9;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(83, 379);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(188, 379);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(75, 23);
            this.btncapnhap.TabIndex = 11;
            this.btncapnhap.Text = "Cập nhập";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(293, 379);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 483);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.cmbkhoa);
            this.Controls.Add(this.grbgioitinh);
            this.Controls.Add(this.txttensv);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbgioitinh.ResumeLayout(false);
            this.grbgioitinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.GroupBox grbgioitinh;
        private System.Windows.Forms.RadioButton rbtnu;
        private System.Windows.Forms.RadioButton rbtnam;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btncapnhap;
        private System.Windows.Forms.Button btnthoat;
    }
}