using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessTest
{
    public partial class Form_SelectEntry : Form
    {
        public Form_SelectEntry()
        {
            InitializeComponent();
        }

        private void btnADR_Click(object sender, EventArgs e)
        {
            var frmEntAd = new Form_EntryADR();
            frmEntAd.ShowDialog();
        }
    }
}
