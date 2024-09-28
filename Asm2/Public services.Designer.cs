namespace Asm2
{
    partial class Public_services
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
            laber = new Label();
            txt_thismorth = new TextBox();
            btn_pay = new Button();
            label2 = new Label();
            ka = new Label();
            txt_lastmorth = new TextBox();
            btn_cast = new Button();
            label4 = new Label();
            txt_result = new Label();
            btn_back = new Button();
            txtdatabase = new ListView();
            SuspendLayout();
            // 
            // laber
            // 
            laber.AutoSize = true;
            laber.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            laber.ForeColor = Color.FromArgb(64, 64, 64);
            laber.Location = new Point(254, 23);
            laber.Margin = new Padding(2, 0, 2, 0);
            laber.Name = "laber";
            laber.Size = new Size(243, 35);
            laber.TabIndex = 0;
            laber.Text = "pulic services";
            // 
            // txt_thismorth
            // 
            txt_thismorth.BackColor = Color.FromArgb(64, 64, 64);
            txt_thismorth.ForeColor = Color.FromArgb(255, 128, 128);
            txt_thismorth.Location = new Point(526, 102);
            txt_thismorth.Margin = new Padding(2, 3, 2, 3);
            txt_thismorth.Name = "txt_thismorth";
            txt_thismorth.Size = new Size(180, 36);
            txt_thismorth.TabIndex = 1;
            txt_thismorth.KeyPress += txt_thismorth_KeyPress;
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.FromArgb(64, 64, 64);
            btn_pay.ForeColor = Color.FromArgb(255, 128, 128);
            btn_pay.Location = new Point(302, 324);
            btn_pay.Margin = new Padding(2, 3, 2, 3);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(128, 52);
            btn_pay.TabIndex = 2;
            btn_pay.Text = "Pay";
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += btn_pay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(87, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(432, 23);
            label2.TabIndex = 3;
            label2.Text = "Number of countries consuming this month";
            // 
            // ka
            // 
            ka.AutoSize = true;
            ka.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ka.ForeColor = Color.FromArgb(64, 64, 64);
            ka.Location = new Point(87, 155);
            ka.Margin = new Padding(2, 0, 2, 0);
            ka.Name = "ka";
            ka.Size = new Size(433, 23);
            ka.TabIndex = 4;
            ka.Text = "Number of countries consuming last month";
            // 
            // txt_lastmorth
            // 
            txt_lastmorth.BackColor = Color.FromArgb(64, 64, 64);
            txt_lastmorth.ForeColor = Color.FromArgb(255, 128, 128);
            txt_lastmorth.Location = new Point(526, 155);
            txt_lastmorth.Margin = new Padding(2, 3, 2, 3);
            txt_lastmorth.Name = "txt_lastmorth";
            txt_lastmorth.Size = new Size(180, 36);
            txt_lastmorth.TabIndex = 5;
            txt_lastmorth.KeyPress += textBox2_KeyPress;
            // 
            // btn_cast
            // 
            btn_cast.BackColor = Color.FromArgb(64, 64, 64);
            btn_cast.ForeColor = Color.FromArgb(255, 128, 128);
            btn_cast.Location = new Point(526, 238);
            btn_cast.Margin = new Padding(2, 3, 2, 3);
            btn_cast.Name = "btn_cast";
            btn_cast.Size = new Size(162, 48);
            btn_cast.TabIndex = 6;
            btn_cast.Text = "calculate";
            btn_cast.UseVisualStyleBackColor = false;
            btn_cast.Click += btn_cast_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(171, 238);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 29);
            label4.TabIndex = 7;
            label4.Text = "Cost";
            // 
            // txt_result
            // 
            txt_result.AutoSize = true;
            txt_result.ForeColor = Color.FromArgb(64, 64, 64);
            txt_result.Location = new Point(331, 238);
            txt_result.Margin = new Padding(2, 0, 2, 0);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(28, 29);
            txt_result.TabIndex = 8;
            txt_result.Text = "0";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(64, 64, 64);
            btn_back.ForeColor = Color.FromArgb(255, 128, 128);
            btn_back.Location = new Point(647, 400);
            btn_back.Margin = new Padding(2, 3, 2, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(112, 40);
            btn_back.TabIndex = 9;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txtdatabase
            // 
            txtdatabase.Font = new Font("Calibri", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtdatabase.Location = new Point(11, 462);
            txtdatabase.Margin = new Padding(2, 3, 2, 3);
            txtdatabase.Name = "txtdatabase";
            txtdatabase.Size = new Size(749, 281);
            txtdatabase.TabIndex = 10;
            txtdatabase.UseCompatibleStateImageBehavior = false;
            // 
            // Public_services
            // 
            AutoScaleDimensions = new SizeF(16F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(773, 756);
            Controls.Add(txtdatabase);
            Controls.Add(btn_back);
            Controls.Add(txt_result);
            Controls.Add(label4);
            Controls.Add(btn_cast);
            Controls.Add(txt_lastmorth);
            Controls.Add(ka);
            Controls.Add(label2);
            Controls.Add(btn_pay);
            Controls.Add(txt_thismorth);
            Controls.Add(laber);
            Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(7, 3, 7, 3);
            Name = "Public_services";
            Text = "Public_services";
            Load += Public_services_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label laber;
        private TextBox txt_thismorth;
        private Button btn_pay;
        private Label label2;
        private Label ka;
        private TextBox txt_lastmorth;
        private Button btn_cast;
        private Label label4;
        private Label txt_result;
        private Button btn_back;
        private ListView txtdatabase;
    }
}