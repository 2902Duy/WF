namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.lsvInfomation = new System.Windows.Forms.ListView();
            this.colHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHo = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbHo = new System.Windows.Forms.TextBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsvInfomation
            // 
            this.lsvInfomation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHo,
            this.colTen,
            this.colSDT});
            this.lsvInfomation.FullRowSelect = true;
            this.lsvInfomation.GridLines = true;
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup1";
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "listViewGroup2";
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "listViewGroup3";
            this.lsvInfomation.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.lsvInfomation.HideSelection = false;
            this.lsvInfomation.Location = new System.Drawing.Point(12, 59);
            this.lsvInfomation.Name = "lsvInfomation";
            this.lsvInfomation.Size = new System.Drawing.Size(372, 333);
            this.lsvInfomation.TabIndex = 0;
            this.lsvInfomation.UseCompatibleStateImageBehavior = false;
            this.lsvInfomation.UseWaitCursor = true;
            this.lsvInfomation.View = System.Windows.Forms.View.Details;
            this.lsvInfomation.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvInfomation_ColumnClick);
            this.lsvInfomation.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsvInfomation_ItemSelectionChanged);
            this.lsvInfomation.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lsvInfomation.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colHo
            // 
            this.colHo.Text = "Họ";
            // 
            // colTen
            // 
            this.colTen.Text = "Tên";
            this.colTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTen.Width = 100;
            // 
            // colSDT
            // 
            this.colSDT.Text = "SDT";
            this.colSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSDT.Width = 200;
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(459, 67);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(25, 16);
            this.lblHo.TabIndex = 1;
            this.lblHo.Text = "Họ";
            this.lblHo.UseWaitCursor = true;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(459, 113);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên";
            this.lblTen.UseWaitCursor = true;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(459, 153);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(35, 16);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "SDT";
            this.lblSDT.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbHo
            // 
            this.txbHo.Location = new System.Drawing.Point(527, 67);
            this.txbHo.Name = "txbHo";
            this.txbHo.Size = new System.Drawing.Size(182, 22);
            this.txbHo.TabIndex = 11;
            this.txbHo.UseWaitCursor = true;
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(527, 113);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(182, 22);
            this.txbTen.TabIndex = 12;
            this.txbTen.UseWaitCursor = true;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(527, 153);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(182, 22);
            this.txbSDT.TabIndex = 13;
            this.txbSDT.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.txbHo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHo);
            this.Controls.Add(this.lsvInfomation);
            this.Name = "Form1";
            this.Text = "Thong tin";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvInfomation;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblSDT;
        internal System.Windows.Forms.ColumnHeader colHo;
        internal System.Windows.Forms.ColumnHeader colTen;
        internal System.Windows.Forms.ColumnHeader colSDT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbHo;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbSDT;
    }
}

