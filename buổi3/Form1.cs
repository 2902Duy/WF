using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvInfomation.FullRowSelect = true;
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = lsvInfomation.Items.Count - 1; i >= 0; i--)
            {
                if (lsvInfomation.Items[i].Selected)
                {
                    lsvInfomation.Items[i].Remove();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem l1 = new ListViewItem(txbHo.Text);
            l1.SubItems.Add(Text = txbTen.Text);
            l1.SubItems.Add(Text = txbSDT.Text);
            lsvInfomation.Items.Add(l1);
        }

        private void lsvInfomation_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void lsvInfomation_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int index = e.ItemIndex;
            ListViewItem l1 = lsvInfomation.Items [index];
            txbHo.Text = l1.SubItems[0].Text;
            txbTen.Text = l1.SubItems[1].Text;
            txbSDT.Text = l1.SubItems[2].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lsvInfomation.SelectedItems.Count>0)
            {
                lsvInfomation.SelectedItems[0].SubItems[0].Text=txbHo.Text;
                lsvInfomation.SelectedItems[0].SubItems[1].Text = txbTen.Text;
                lsvInfomation.SelectedItems[0].SubItems[2].Text = txbSDT.Text;
            }
        }
    }
}
