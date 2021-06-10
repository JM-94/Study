using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415.UI
{
    public partial class AddCust: MaterialForm
    {
        public AddCust()
        {
            InitializeComponent();
        }

        private void Man_ValueChanged(object sender, bool value)
        {

        }

        private void Woman_ValueChanged(object sender, bool value)
        {

        }

        private void addCarCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
