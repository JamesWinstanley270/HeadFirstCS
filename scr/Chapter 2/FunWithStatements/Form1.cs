using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (label1.BackColor == Color.Blue)
                {
                    label1.BackColor = Color.LightCoral;
                    label1.ForeColor = Color.Black;
                }
                else
                {
                    label1.BackColor = Color.Blue;
                    label1.ForeColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("The box is not checked");
            }
        }
    }
}
