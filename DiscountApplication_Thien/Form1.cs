using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscountApplication2; //added to access NamespaceExampleClass

namespace DiscountApplication_Thien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string inputPrice = txtInputPrice.Text;
            string discount = txtDiscount.Text;

            //below without class
            //string finalPrice = "";
            //finalPrice = inputPrice - (inputPrice * discount);

            //below for normal class
            //DiscountCalculator calculator = new DiscountCalculator();
            //string finalPrice = calculator.calculate(inputPrice);

            //below for static class
            string finalPrice = DiscountCalculator.calculate(inputPrice, discount);

            MessageBox.Show(finalPrice);

            //NamespaceExample
            //MessageBox.Show(NamespaceExampleClass.x);

            //To access class of different namespace,
            //we need to add "using" namespace

            //To access namespace of different project,
            //we need to add Reference
        }
    }
}
