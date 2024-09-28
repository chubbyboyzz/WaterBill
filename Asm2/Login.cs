namespace Asm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_usename.Text.Trim();
            string password = txt_Password.Text.Trim();
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password ))
            {
                MessageBox.Show("Username and Password is not emty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (username.Equals("hhieu") && password.Equals("123456"))
            {
                
            }
            else
            {
                MessageBox.Show("Erorr", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
