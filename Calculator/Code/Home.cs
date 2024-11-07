using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            double numberOne;
            double numberTwo;
            double result;

            string operation = ops.Text;

            bool testNumberone = double.TryParse(num1.Text, out numberOne);
            bool testNumberTwo=double.TryParse(num2.Text, out numberTwo);

            if(testNumberone && testNumberTwo)
            { 
                switch(operation)
                {
                    case "+":
                        result = numberOne + numberTwo;
                        Lblresult.Text=result.ToString();
                        break;
                    case "-":
                        result = numberOne - numberTwo;
                        Lblresult.Text = result.ToString();
                        break;
                    case "*":
                        result = numberOne * numberTwo;
                        Lblresult.Text = result.ToString();
                        break; 
                    case "/":
                        result = numberOne / numberTwo;
                        Lblresult.Text = result.ToString();
                        break;
                    default:
                        MessageBox.Show("خطأ في الادخال,هذه العملية غير موجودة"," ",MessageBoxButtons.OK);
                        break;
                }
            }
            else
            {
                MessageBox.Show("خطأ في الأرقام المدخلة");
            }


        }

        private void Lblresult_Click(object sender, EventArgs e)
        {

        }
    }
}
