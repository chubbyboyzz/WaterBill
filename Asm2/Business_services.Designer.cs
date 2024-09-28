namespace Asm2
{
    partial class Business_services
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
            txt_thismorth = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txt_lastmorth = new TextBox();
            button2 = new Button();
            label4 = new Label();
            txt_result = new Label();
            btn_back = new Button();
            txt_database = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 19);
            label1.Name = "label1";
            label1.Size = new Size(291, 35);
            label1.TabIndex = 0;
            label1.Text = "Business services";
            // 
            // txt_thismorth
            // 
            txt_thismorth.BackColor = Color.FromArgb(64, 64, 64);
            txt_thismorth.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_thismorth.ForeColor = Color.FromArgb(255, 128, 0);
            txt_thismorth.Location = new Point(502, 92);
            txt_thismorth.Name = "txt_thismorth";
            txt_thismorth.Size = new Size(125, 26);
            txt_thismorth.TabIndex = 1;
            txt_thismorth.KeyPress += txt_thismorth_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(502, 222);
            button1.Name = "button1";
            button1.Size = new Size(161, 53);
            button1.TabIndex = 2;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 92);
            label2.Name = "label2";
            label2.Size = new Size(404, 21);
            label2.TabIndex = 3;
            label2.Text = "Number of countries consuming this month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 145);
            label3.Name = "label3";
            label3.Size = new Size(404, 21);
            label3.TabIndex = 4;
            label3.Text = "Number of countries consuming last month";
            // 
            // txt_lastmorth
            // 
            txt_lastmorth.BackColor = Color.FromArgb(64, 64, 64);
            txt_lastmorth.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_lastmorth.ForeColor = Color.FromArgb(255, 128, 0);
            txt_lastmorth.Location = new Point(502, 145);
            txt_lastmorth.Name = "txt_lastmorth";
            txt_lastmorth.Size = new Size(125, 26);
            txt_lastmorth.TabIndex = 5;
            txt_lastmorth.KeyPress += txt_lastmorth_KeyPress;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(278, 307);
            button2.Name = "button2";
            button2.Size = new Size(125, 61);
            button2.TabIndex = 6;
            button2.Text = "pay";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(148, 234);
            label4.Name = "label4";
            label4.Size = new Size(70, 29);
            label4.TabIndex = 7;
            label4.Text = "cost";
            // 
            // txt_result
            // 
            txt_result.AutoSize = true;
            txt_result.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_result.Location = new Point(269, 234);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(27, 29);
            txt_result.TabIndex = 8;
            txt_result.Text = "0";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(64, 64, 64);
            btn_back.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.FromArgb(255, 128, 0);
            btn_back.Location = new Point(662, 397);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(126, 41);
            btn_back.TabIndex = 9;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txt_database
            // 
            txt_database.Location = new Point(12, 484);
            txt_database.Name = "txt_database";
            txt_database.Size = new Size(776, 242);
            txt_database.TabIndex = 10;
            txt_database.UseCompatibleStateImageBehavior = false;
            // 
            // Business_services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 738);
            Controls.Add(txt_database);
            Controls.Add(btn_back);
            Controls.Add(txt_result);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(txt_lastmorth);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txt_thismorth);
            Controls.Add(label1);
            Name = "Business_services";
            Text = "Business_services";
            Load += Business_services_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_thismorth;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txt_lastmorth;
        private Button button2;
        private Label label4;
        private Label txt_result;
        private Button btn_back;
        private ListView txt_database;
    }
}