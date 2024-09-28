namespace Asm2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_usename = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_Password = new TextBox();
            btn_login = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(382, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 35);
            label1.TabIndex = 0;
            label1.Text = "Water Bill ";
            // 
            // txt_usename
            // 
            txt_usename.BackColor = Color.FromArgb(64, 64, 64);
            txt_usename.ForeColor = Color.FromArgb(128, 255, 255);
            txt_usename.Location = new Point(282, 151);
            txt_usename.Name = "txt_usename";
            txt_usename.Size = new Size(347, 29);
            txt_usename.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(159, 149);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 3;
            label2.Text = "Usename";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(159, 218);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.FromArgb(64, 64, 64);
            txt_Password.ForeColor = Color.FromArgb(128, 255, 255);
            txt_Password.Location = new Point(282, 217);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(347, 29);
            txt_Password.TabIndex = 5;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(64, 64, 64);
            btn_login.Font = new Font("Calibri", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.Cyan;
            btn_login.Location = new Point(272, 278);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(133, 74);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Calibri", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cyan;
            button2.Location = new Point(749, 465);
            button2.Name = "button2";
            button2.Size = new Size(133, 74);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(903, 551);
            Controls.Add(button2);
            Controls.Add(btn_login);
            Controls.Add(txt_Password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_usename);
            Controls.Add(label1);
            Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_usename;
        private Label label2;
        private Label label3;
        private TextBox txt_Password;
        private Button btn_login;
        private Button button2;
    }
}
