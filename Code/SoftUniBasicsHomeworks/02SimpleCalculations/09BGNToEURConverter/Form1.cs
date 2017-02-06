using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09BGNToEURConverter
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void input_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertCurrency();
        }

        private void Converter_Load(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void input_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void ConvertCurrency()
        {
            var amountBGN = this.input.Value;
            var amountEUR = amountBGN * 1.95583m;

            this.output.Text =
              amountBGN + " BGN = " +
              Math.Round(amountEUR, 2) + " EUR";
        }
    }
}
