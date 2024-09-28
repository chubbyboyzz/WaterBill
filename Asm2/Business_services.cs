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
    public partial class Business_services : Form
    {
        public Business_services()
        {
            InitializeComponent();
        }

        private void txt_thismorth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //must be mumbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // check Special characters
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_lastmorth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //must be mumbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // check Special characters
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes is empty
            if (string.IsNullOrEmpty(txt_thismorth.Text) || string.IsNullOrEmpty(txt_lastmorth.Text))
            {
                MessageBox.Show("Please fill in all the required information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }
            //pick infor from textbox
            string thismorth = txt_thismorth.Text;
            float Thismorth = float.Parse(thismorth);
            string lastmorth = txt_lastmorth.Text;
            float Lastmorth = float.Parse(lastmorth);
            float WaterUsed = Thismorth - Lastmorth;
            float wateruse = WaterUsed * 22068;
            float cast = wateruse + (wateruse * 10) / 100;
            // Check result
            if (cast >= 0)
            {
                // output
                txt_result.Text = Convert.ToString(cast);
                string Cast = Convert.ToString(cast);
                string Used = Convert.ToString(WaterUsed);
                // listbase
                ListViewItem item = new ListViewItem();
                item.Text = lastmorth;
                item.SubItems.Add(thismorth);
                item.SubItems.Add(Used);
                item.SubItems.Add(Cast);
                txt_database.Items.Add(item);
            }
            else
            {
                // error
                MessageBox.Show("Result must be positive.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waterbill waterbill = new Waterbill();
            waterbill.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dataToSend = txt_result.Text;
            Pay formB = new Pay(dataToSend);
            formB.Show();
        }

        private void Business_services_Load(object sender, EventArgs e)
        {
            txt_database.View = View.Details;
            txt_database.GridLines = true;
            txt_database.FullRowSelect = true;
            txt_database.Columns.Add("Last water used", 100);
            txt_database.Columns.Add("this water used", 100);
            txt_database.Columns.Add("Water used", 100);
            txt_database.Columns.Add("Cost", 100);
        }
    }
}
