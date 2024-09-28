namespace Asm2
{
    partial class UserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Login = new Button();
            label1 = new Label();
            laber = new Label();
            laber2 = new Label();
            txt_User = new TextBox();
            txt_Password = new TextBox();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(64, 64, 64);
            btn_Login.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.Cyan;
            btn_Login.Location = new Point(284, 236);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(193, 65);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Log in";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(344, 27);
            label1.Name = "label1";
            label1.Size = new Size(156, 29);
            label1.TabIndex = 2;
            label1.Text = "Water Bill";
            // 
            // laber
            // 
            laber.AutoSize = true;
            laber.BackColor = Color.FromArgb(64, 64, 64);
            laber.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            laber.ForeColor = Color.Cyan;
            laber.Location = new Point(119, 99);
            laber.Name = "laber";
            laber.Size = new Size(121, 29);
            laber.TabIndex = 3;
            laber.Text = "Usename";
            laber.Click += laber_Click;
            // 
            // laber2
            // 
            laber2.AutoSize = true;
            laber2.BackColor = Color.FromArgb(64, 64, 64);
            laber2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            laber2.ForeColor = Color.Cyan;
            laber2.Location = new Point(92, 181);
            laber2.Name = "laber2";
            laber2.Size = new Size(148, 29);
            laber2.TabIndex = 4;
            laber2.Text = "Password";
            // 
            // txt_User
            // 
            txt_User.BackColor = Color.FromArgb(64, 64, 64);
            txt_User.ForeColor = Color.Cyan;
            txt_User.Location = new Point(246, 99);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(336, 27);
            txt_User.TabIndex = 5;
            txt_User.TextChanged += textBox1_TextChanged;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.FromArgb(64, 64, 64);
            txt_Password.ForeColor = Color.Cyan;
            txt_Password.Location = new Point(246, 183);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(336, 27);
            txt_Password.TabIndex = 6;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(64, 64, 64);
            btn_exit.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.Cyan;
            btn_exit.Location = new Point(595, 373);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(193, 65);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(txt_Password);
            Controls.Add(txt_User);
            Controls.Add(laber2);
            Controls.Add(laber);
            Controls.Add(label1);
            Controls.Add(btn_Login);
            Name = "UserLogin";
            Text = "UserLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Label label1;
        private Label laber;
        private Label laber2;
        private TextBox txt_User;
        private TextBox txt_Password;
        private Button btn_exit;
    }
}