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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }
        private void btnEntry_Click(object sender, EventArgs e)
        {
            var frmSelEnt = new Form_SelectEntry();
            frmSelEnt.ShowDialog();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            var frmSerch = new Form_Serch();
            frmSerch.ShowDialog();
        }
    }
}
