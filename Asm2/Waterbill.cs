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
    public partial class Waterbill : Form
    {
        public Waterbill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin login = new UserLogin();
            login.Show();
        }

        private void btn_Family_Click(object sender, EventArgs e)
        {
            this.Hide();
            Family family = new Family();
            family.Show();
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            this.Hide();
            Public_services public_service = new Public_services();
            public_service.Show();
        }

        private void btn_Production_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product_units product_units= new Product_units();
            product_units.Show();
        }

        private void btn_business_Click(object sender, EventArgs e)
        {
            this.Hide();
            Business_services business_services = new Business_services();
            business_services.Show();
        }
    }
}
