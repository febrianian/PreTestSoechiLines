using PreTestSoechiLines.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PreTestSoechiLines.FormMaster
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void txtuom_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ProductContext())
            {
                var query = context.UOM.Where(i => i.Satuan.Contains(txtuom.Text));
                
                if (txtuom.Text == "")
                {
                    txtrates.Text = "0";
                    return;
                }
                else
                {
                    if (query.Count() > 0)
                    {
                        double getRates = query.FirstOrDefault().Rate;
                        txtrates.Text = getRates.ToString();
                    }
                    else
                    {
                        txtrates.Text = "0";
                    }
                        
                }              
            }
        }
        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            char decimalSeparatorChar = Convert.ToChar(Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator);
            if (ch == decimalSeparatorChar && txtqty.Text.IndexOf(decimalSeparatorChar) != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != decimalSeparatorChar)
            {
                e.Handled = true;
            }
        }
        private void Transaction_Load(object sender, EventArgs e)
        {
            
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if(txtqty.Text == "")
            {
                txtqtykecil.Text = "0";
                return;
            }
            else
            {
                //count qty kecil
                double result = 0;
                var rates = Convert.ToDouble(txtrates.Text);
                var qty = Convert.ToDouble(txtqty.Text);
                result = rates * qty;

                txtqtykecil.Text = result.ToString();
            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            var discountString = txtdiscount.Text;
            var plusString = txtdiscount.Text.Contains("+");
            var percentageString = txtdiscount.Text.Contains("%");
            double discountAmount = 0;
            var unitPrices = Convert.ToDouble(txtunitprice.Text);
            var qty = Convert.ToDouble(txtqty.Text);
            double total = 0;
            if (discountString.Length > 0)
            {
                txtdiscountamt.Text = txtdiscount.Text;

                if (percentageString == true)
                {
                    //if any (%) symbol and without (+) cymbol
                    var number = discountString.Substring(0, 2); //get 2 digits front string                                        
                    discountString = number;
                    discountAmount = (unitPrices * qty) * Convert.ToDouble(discountString) / 100;
                    total = (unitPrices * qty) - discountAmount;
                    txtdiscountamt.Text = discountAmount.ToString("#,###.00");                    
                }
                else if (plusString == true)
                {
                    string trimStringPlus = txtdiscount.Text.Replace("+", "");
                    discountAmount = Convert.ToDouble(trimStringPlus);
                    total = (unitPrices * qty) - discountAmount;
                    txtdiscountamt.Text = discountAmount.ToString("#,###.00");
                }

                txttotal.Text = total.ToString("#,###.00");
            }
            else
            {
                txtdiscountamt.Text = "0";
                txttotal.Text = "0";
            }
        }

        //private void txtqty_TextChanged(object sender, EventArgs e)
        //{
        //    txtqty.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(txtqty.Text));
        //}
    }
}
