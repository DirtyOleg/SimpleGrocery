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
    public partial class WarehouseFrom : Form
    {
        public static WarehouseFrom warehouseFrm = null;
        public MainForm mainFrm = null;

        private WarehouseFrom(MainForm mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
        }

        public static WarehouseFrom GetInstance(MainForm mainFrm)
        {
            if (warehouseFrm == null)
            {
                warehouseFrm = new WarehouseFrom(mainFrm);
            }

            return warehouseFrm;
        }
    }
}
