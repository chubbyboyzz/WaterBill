using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Asm2
{
    public partial class Family : Form
    {
        public Family()
        {
            InitializeComponent();
            
        }

        private void Family_Load(object sender, EventArgs e)
        {
            txtdatabase.View = View.Details;
            txtdatabase.GridLines = true;
            txtdatabase.FullRowSelect = true;

            txtdatabase.Columns.Add("Member", 150);
            txtdatabase.Columns.Add("Last water used", 100);
            txtdatabase.Columns.Add("this water used", 100);
            txtdatabase.Columns.Add("Water used", 100);
            txtdatabase.Columns.Add("Cost", 100);

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
                string dataToSend = txt_result.Text;
                Pay formB = new Pay(dataToSend);
                formB.Show();

        }

        private void txt_member_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_member_KeyPress(object sender, KeyPressEventArgs e)
        {
            // entrance test is numerical
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_thismorth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // The entrance test is numerical
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // allow input "."
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_lastmorth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  The entrance test is numerical
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // allow input "."
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes is empty
            if (string.IsNullOrEmpty(txt_thismorth.Text) ||
                string.IsNullOrEmpty(txt_lastmorth.Text) ||
                string.IsNullOrEmpty(txt_member.Text))
            {
                MessageBox.Show("Please fill in all the required information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            // Proceed with the calculation
            // Pick information from textboxes
            float Thismorth, Lastmorth, Member;

            // Parse input values
            if (!float.TryParse(txt_thismorth.Text, out Thismorth) ||!float.TryParse(txt_lastmorth.Text, out Lastmorth) ||
!float.TryParse(txt_member.Text, out Member))
            {
                MessageBox.Show("Invalid input format. Please enter numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            // Calculate water usage
            float wateruse = Thismorth - Lastmorth;

            // Check if the number of members is greater than 0
            if (Member <= 0)
            {
                MessageBox.Show("Member must be greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            // Calculate average water usage per member
            float averageUsage = wateruse / Member;

            double totalAmount;
            if (averageUsage < 10 && averageUsage > 0)
            {
                totalAmount = wateruse * 5973;
            }
            else if (averageUsage < 20 && averageUsage >= 10)
            {
                totalAmount = wateruse * 7052;
            }
            else if (averageUsage < 30 && averageUsage >= 20)
            {
                totalAmount = wateruse * 8699;
            }
            else
            {
                totalAmount = wateruse * 15.929;
            }
   
            // Apply surcharge
            double result = totalAmount + (10 * totalAmount) / 100;

            // Output result
            txt_result.Text = Convert.ToString(result);
            string equal = Convert.ToString(result);
            string WaterUsed = Convert.ToString(wateruse);

            // Add information to list view
            ListViewItem item = new ListViewItem();
            item.Text = txt_member.Text;
            item.SubItems.Add(txt_lastmorth.Text);
            item.SubItems.Add(txt_thismorth.Text);
            item.SubItems.Add(WaterUsed);
            item.SubItems.Add(equal);

            txtdatabase.Items.Add(item);


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waterbill waterbill = new Waterbill();
            waterbill.Show();
        }

        private void txt_result_Click(object sender, EventArgs e)
        {
 
        }
    }
}
