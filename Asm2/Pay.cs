using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm2
{
    public partial class Pay : Form
    {
        public Pay(string data)
        {
            InitializeComponent();
            txt_result.Text = data;
        }

        private void Pay_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waterbill waterbill = new Waterbill();
            waterbill.Show();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Waterbill waterbill = new Waterbill();
            waterbill.Show();
        }

        private void bnt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pay_Load_1(object sender, EventArgs e)
        {

        }
    }
}
