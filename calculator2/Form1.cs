using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{

    public partial class Form1 : Form
    {
        string operating;
        Double value1=0;
        Double value2 =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      /*  private void one_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            output.Text = output.Text + b.Text;
         //   output.Text = output.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "0";
        }*/

        private void clear_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

       /* private void add_Click(object sender, EventArgs e)
        {
           // Button b = (Button)sender;
            int y=0,x=0;
            string a;
            // a = output.Text.Toint;
            x = int.Parse(output.Text);
            output.Text = output.Text + "+";
            a = output.Text;
           // y = int.Parse(output.Text, out );
           

        }*/

        private void num_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            output.Text = output.Text + b.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            
                //string operating;
                //value1 = int.Parse(output.Text);
                value1 = Convert.ToDouble(output.Text);
                Button o = (Button)sender;
                operating = o.Text;
                output.Text = output.Text + operating;
                output.Clear();
                // value2= int.Parse(output.Text);
            
            }

        private void result_Click(object sender, EventArgs e)
        {
            //value2 = int.Parse(output.Text);
            value2 = Convert.ToDouble(output.Text);
            switch (operating)
            {
                case "+":
                    output.Text = (value1 + value2).ToString();
                    break;
                case "-":
                    output.Text = (value1 - value2).ToString();
                    break;
                case "*":
                    output.Text = (value1 * value2).ToString();
                    break;
                case "/":
                    output.Text = (value1 / value2).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
