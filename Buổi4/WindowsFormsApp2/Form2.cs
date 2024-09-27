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
    public partial class Form2 : Form
    {
        Form1 form1= new Form1();
        public Form2(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
        }
        
        public void settxt(string MSNV,string NV,string LUONGCB)
        {
            textBox1.Text = MSNV;
            textBox2.Text = NV;
            textBox3.Text = LUONGCB;

        }
        
        private void button1_Click(object sender, EventArgs e)

        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
