using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Cashier_Click(object sender, EventArgs e)
        {
            //CashierForm cashierFrm = new CashierForm();
            CashierForm cashierFrm = CashierForm.GetInstance(this);

            cashierFrm.Show();
            this.Hide();
        }

        private void btn_Warehouse_Click(object sender, EventArgs e)
        {
            WarehouseFrom warehouseFrm = WarehouseFrom.GetInstance(this);

            warehouseFrm.Show();
            this.Hide();
        }
    }
}
