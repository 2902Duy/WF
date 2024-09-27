using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }
        public static NV setDgv(NV nv )
        {
            return nv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (Form2 form2 = new Form2(this))
            {

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Add(form2.textBox1.Text, form2.textBox2.Text, form2.textBox3.Text);
                }
            }
            this.Validate();
            this.dataGridView1.EndEdit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                
                Form2 form2 = new Form2(this);
                form2.textBox1.Text = row.Cells[0].Value.ToString();
                form2.textBox2.Text = row.Cells[1].Value.ToString();
                form2.textBox3.Text = row.Cells[2].Value.ToString();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    row.Cells[0].Value = form2.textBox1.Text;
                    row.Cells[1].Value = form2.textBox2.Text;
                    row.Cells[2].Value = form2.textBox3.Text;
                }
            }    
                    

                
                this.Validate();
                this.dataGridView1.EndEdit();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
