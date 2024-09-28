namespace Asm2
{
    partial class Product_units
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
            btn_cast = new Button();
            txt_thismorth = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txt_lastmorth = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            txt_result = new Label();
            btn_back = new Button();
            txtdatabase = new ListView();
            SuspendLayout();
            // 
            // btn_cast
            // 
            btn_cast.BackColor = Color.FromArgb(64, 64, 64);
            btn_cast.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cast.ForeColor = Color.FromArgb(255, 128, 255);
            btn_cast.Location = new Point(534, 218);
            btn_cast.Name = "btn_cast";
            btn_cast.Size = new Size(179, 55);
            btn_cast.TabIndex = 0;
            btn_cast.Text = "calculate";
            btn_cast.UseVisualStyleBackColor = false;
            btn_cast.Click += btn_cast_Click;
            // 
            // txt_thismorth
            // 
            txt_thismorth.BackColor = Color.FromArgb(64, 64, 64);
            txt_thismorth.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_thismorth.ForeColor = Color.FromArgb(255, 192, 255);
            txt_thismorth.Location = new Point(534, 93);
            txt_thismorth.Name = "txt_thismorth";
            txt_thismorth.Size = new Size(141, 26);
            txt_thismorth.TabIndex = 1;
            txt_thismorth.KeyPress += txt_thismorth_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 23);
            label1.Name = "label1";
            label1.Size = new Size(248, 35);
            label1.TabIndex = 2;
            label1.Text = "Product units";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 97);
            label3.Name = "label3";
            label3.Size = new Size(432, 23);
            label3.TabIndex = 4;
            label3.Text = "Number of countries consuming this month";
            // 
            // txt_lastmorth
            // 
            txt_lastmorth.BackColor = Color.FromArgb(64, 64, 64);
            txt_lastmorth.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_lastmorth.ForeColor = Color.FromArgb(255, 192, 255);
            txt_lastmorth.Location = new Point(534, 150);
            txt_lastmorth.Name = "txt_lastmorth";
            txt_lastmorth.Size = new Size(141, 26);
            txt_lastmorth.TabIndex = 6;
            txt_lastmorth.KeyPress += txt_lastmorth_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 150);
            label2.Name = "label2";
            label2.Size = new Size(433, 23);
            label2.TabIndex = 7;
            label2.Text = "Number of countries consuming last month";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 128, 255);
            button1.Location = new Point(306, 301);
            button1.Name = "button1";
            button1.Size = new Size(179, 55);
            button1.TabIndex = 8;
            button1.Text = "pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(160, 230);
            label4.Name = "label4";
            label4.Size = new Size(70, 29);
            label4.TabIndex = 9;
            label4.Text = "cost";
            // 
            // txt_result
            // 
            txt_result.AutoSize = true;
            txt_result.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_result.Location = new Point(291, 230);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(27, 29);
            txt_result.TabIndex = 10;
            txt_result.Text = "0";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(64, 64, 64);
            btn_back.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.FromArgb(255, 128, 255);
            btn_back.Location = new Point(657, 398);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(131, 40);
            btn_back.TabIndex = 11;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txtdatabase
            // 
            txtdatabase.Location = new Point(12, 459);
            txtdatabase.Name = "txtdatabase";
            txtdatabase.Size = new Size(776, 271);
            txtdatabase.TabIndex = 12;
            txtdatabase.UseCompatibleStateImageBehavior = false;
            // 
            // Product_units
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(800, 742);
            Controls.Add(txtdatabase);
            Controls.Add(btn_back);
            Controls.Add(txt_result);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txt_lastmorth);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txt_thismorth);
            Controls.Add(btn_cast);
            Name = "Product_units";
            Text = "Product_units";
            Load += Product_units_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cast;
        private TextBox txt_thismorth;
        private Label label1;
        private Label label3;
        private TextBox txt_lastmorth;
        private Label label2;
        private Button button1;
        private Label label4;
        private Label txt_result;
        private Button btn_back;
        private ListView txtdatabase;
    }
}