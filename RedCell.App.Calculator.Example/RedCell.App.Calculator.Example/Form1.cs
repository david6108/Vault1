using System;
using System.Windows.Forms;

namespace RedCell.App.Calculator.Example
{
    public partial class Form1 : Form
    {
        private double accumulator = 0;
        private char lastOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Operator_Pressed(object sender, EventArgs e)
        {
            // An operator was pressed; perform the last operation and store the new operator.
            char operation = (sender as Button).Text[0];
            if (operation == 'C')
            {
                accumulator = 0;
            }
           

            else
            {
                double currentValue = double.Parse(Display.Text);
                switch (lastOperation)
                {
                    case '+': accumulator += currentValue; break;
                    case '-': accumulator -= currentValue; break;
                    case '×': accumulator *= currentValue; break;
                    case '÷': accumulator /= currentValue; break;
                    default: accumulator = currentValue; break;
                }
            }

            lastOperation = operation;
            Display.Text = operation == '=' ? accumulator.ToString() : "0";
 //           Display.Text = accumulator.ToString() ;
        }

        private void Number_Pressed(object sender, EventArgs e)
        {
            // Add it to the display.
            string number = (sender as Button).Text;
            switch (number)
            {
                case "K": Display.Text += "000"; break;
                case "M": Display.Text += "000000"; break;

                default:
                    if (lastOperation == '=') Display.Text = "0";
                    Display.Text = Display.Text == "0" ? number : Display.Text + number;
                    break;

            }

            //if (number == "K")
            //{
            //    Display.Text += "000";
            //}
            //  else
            //{
            //    if (lastOperation == '=') Display.Text = "0";
            //    Display.Text = Display.Text == "0" ? number : Display.Text + number;
            //}
        }

    }
}
