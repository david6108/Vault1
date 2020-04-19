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
        private void Form1_Load(object sender, EventArgs e)
        {
                 
            
            this.Text = "Push the Button";
            this.BackColor = Color.Brown;
            this.Size = new Size(350, 350);
            this.Location = new Point(300, 300);
            this.MaximizeBox = false;
            label1.Text = "This is my first Lable";
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string var;
            var = textBox1.Text;
            MessageBox.Show(var);
            this.BackColor = Color.BurlyWood ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Multiline = true;

        }
        void TextBox1KeyDown(object sender, KeyEventArgs e)
  //      private void textBox1_key_down(object sender ,KeyEventArgs e)
        {
 //           if (e.KeyCode == Keys.Enter)
                if (e.KeyCode == Keys.Return)
                {

                MessageBox.Show("<ENTER>");


            }





        }
    }
}
