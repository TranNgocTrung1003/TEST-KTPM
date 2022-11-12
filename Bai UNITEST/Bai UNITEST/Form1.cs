using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_UNITEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcong_Click(object sender, EventArgs e)
        {
            int a, b, Ketqua;
            a = int.Parse(txtso1.Text);
            b = int.Parse(txtso2.Text);
            TinhToan c = new TinhToan(a,b);
            Ketqua = c.Execute("+");
            lbKQ.Text = Ketqua.ToString();
        }
    }
}
