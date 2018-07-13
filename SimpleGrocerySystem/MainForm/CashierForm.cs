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
    public partial class CashierForm : Form
    {
        private static CashierForm cashierFrm = null;
        private MainForm mainFrm = null;

        private CashierForm(MainForm mainFrm)
        {
            InitializeComponent();

            this.mainFrm = mainFrm;
        }

        public static CashierForm GetInstance(MainForm mainFrm)
        {
            if (cashierFrm == null)
            {
                cashierFrm = new CashierForm(mainFrm);
            }

            return cashierFrm;
        }
    }
}
