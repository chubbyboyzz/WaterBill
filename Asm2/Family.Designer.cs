namespace Asm2
{
    partial class Family
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
            label1 = new Label();
            label2 = new Label();
            txt_member = new TextBox();
            btn_pay = new Button();
            label3 = new Label();
            txt_thismorth = new TextBox();
            txt_lastmorth = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_result = new Label();
            btn_calculate = new Button();
            btn_back = new Button();
            txtdatabase = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 18);
            label1.Name = "label1";
            label1.Size = new Size(355, 35);
            label1.TabIndex = 0;
            label1.Text = "Household customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 86);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 1;
            label2.Text = "Family members";
            // 
            // txt_member
            // 
            txt_member.BackColor = Color.FromArgb(64, 64, 64);
            txt_member.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_member.ForeColor = Color.Lime;
            txt_member.Location = new Point(238, 86);
            txt_member.Name = "txt_member";
            txt_member.Size = new Size(171, 26);
            txt_member.TabIndex = 2;
            txt_member.TextChanged += txt_member_TextChanged;
            txt_member.KeyPress += txt_member_KeyPress;
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.FromArgb(64, 64, 64);
            btn_pay.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_pay.ForeColor = Color.FromArgb(128, 255, 128);
            btn_pay.Location = new Point(291, 346);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(118, 42);
            btn_pay.TabIndex = 3;
            btn_pay.Text = "Pay";
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += btn_pay_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 140);
            label3.Name = "label3";
            label3.Size = new Size(432, 23);
            label3.TabIndex = 4;
            label3.Text = "Number of countries consuming this month";
            // 
            // txt_thismorth
            // 
            txt_thismorth.BackColor = Color.FromArgb(64, 64, 64);
            txt_thismorth.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_thismorth.ForeColor = Color.Lime;
            txt_thismorth.Location = new Point(503, 140);
            txt_thismorth.Name = "txt_thismorth";
            txt_thismorth.Size = new Size(171, 26);
            txt_thismorth.TabIndex = 5;
            txt_thismorth.KeyPress += txt_thismorth_KeyPress;
            // 
            // txt_lastmorth
            // 
            txt_lastmorth.BackColor = Color.FromArgb(64, 64, 64);
            txt_lastmorth.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_lastmorth.ForeColor = Color.Lime;
            txt_lastmorth.Location = new Point(503, 190);
            txt_lastmorth.Name = "txt_lastmorth";
            txt_lastmorth.Size = new Size(171, 26);
            txt_lastmorth.TabIndex = 6;
            txt_lastmorth.KeyPress += txt_lastmorth_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 190);
            label4.Name = "label4";
            label4.Size = new Size(426, 23);
            label4.TabIndex = 7;
            label4.Text = "Number of countries consumed last month";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(163, 262);
            label5.Name = "label5";
            label5.Size = new Size(83, 29);
            label5.TabIndex = 8;
            label5.Text = "Cost:";
            // 
            // txt_result
            // 
            txt_result.AutoSize = true;
            txt_result.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_result.Location = new Point(279, 264);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(24, 28);
            txt_result.TabIndex = 9;
            txt_result.Text = "0";
            txt_result.Click += txt_result_Click;
            // 
            // btn_calculate
            // 
            btn_calculate.BackColor = Color.FromArgb(64, 64, 64);
            btn_calculate.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_calculate.ForeColor = Color.FromArgb(128, 255, 128);
            btn_calculate.Location = new Point(503, 251);
            btn_calculate.Name = "btn_calculate";
            btn_calculate.Size = new Size(171, 51);
            btn_calculate.TabIndex = 10;
            btn_calculate.Text = "Calculate";
            btn_calculate.UseVisualStyleBackColor = false;
            btn_calculate.Click += btn_calculate_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(64, 64, 64);
            btn_back.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.FromArgb(128, 255, 128);
            btn_back.Location = new Point(607, 399);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(118, 42);
            btn_back.TabIndex = 11;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txtdatabase
            // 
            txtdatabase.BackColor = Color.FromArgb(128, 255, 128);
            txtdatabase.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtdatabase.Location = new Point(12, 502);
            txtdatabase.Name = "txtdatabase";
            txtdatabase.Size = new Size(713, 238);
            txtdatabase.TabIndex = 12;
            txtdatabase.UseCompatibleStateImageBehavior = false;
            // 
            // Family
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(737, 752);
            Controls.Add(txtdatabase);
            Controls.Add(btn_back);
            Controls.Add(btn_calculate);
            Controls.Add(txt_result);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_lastmorth);
            Controls.Add(txt_thismorth);
            Controls.Add(label3);
            Controls.Add(btn_pay);
            Controls.Add(txt_member);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Family";
            Text = "Family";
            Load += Family_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_member;
        private Button btn_pay;
        private Label label3;
        private TextBox txt_thismorth;
        private TextBox txt_lastmorth;
        private Label label4;
        private Label label5;
        private Label txt_result;
        private Button btn_calculate;
        private Button btn_back;
        private ListView txtdatabase;
    }
}