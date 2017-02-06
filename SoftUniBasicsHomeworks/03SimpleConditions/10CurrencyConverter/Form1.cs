using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericCurrencyValue_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            decimal value = this.numericCurrencyValue.Value;
            decimal factor = 1;

            string currency = this.comboBoxCurrency.SelectedItem.ToString();

            if (currency == "EUR")
            {
                factor = 1.95583m;
            }
            else if (currency == "USD")
            {
                factor = 1.80810m;
            }
            else if (currency == "GBP")
            {
                factor = 2.440001m;
            }

            decimal result = value / factor;
            string resultAsString = string.Format("{0:f2}", result);
            this.labelResult.Text = resultAsString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxCurrency.SelectedIndex = 0;
        }
    }
}
