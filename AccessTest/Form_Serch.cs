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
    public partial class Form_Serch : Form
    {
        public Form_Serch()
        {
            InitializeComponent();
        }

        private void btnDisp_Click(object sender, EventArgs e)
        {
            //DBクラスインスタンス
            var db = new DB();
            //グリッドにデータを表示
            dgvTestDB.DataSource = db.SelectData();
        }
    }
}
