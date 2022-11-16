using PreTestSoechiLines.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreTestSoechiLines.FormMaster
{
    public partial class MasterUOM : Form
    {
        public MasterUOM()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtsatuan.Text = "";
            txtrates.Text = "0";
        }
        
        private void SimpanUOM()
        {
            using (var context = new ProductContext())
            {
                
                //do insert new
                UOM uom = new UOM()
                {
                    Satuan = txtsatuan.Text,
                    Rate = Convert.ToInt32(txtrates.Text),
                    Status = "A",
                    //DateCreated = DateTime.Now,
                    DateCreated = DateTime.Now
                };

                context.UOM.Add(uom);
                context.SaveChanges();
                //lblresult.Text = "Success";
                MessageBox.Show("Simpan Berhasil satuan " + txtsatuan.Text + " UOM ditambahkan", "Information");
                Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SimpanUOM();
        }

        private void MasterUOM_Load(object sender, EventArgs e)
        {

        }
    }
}
