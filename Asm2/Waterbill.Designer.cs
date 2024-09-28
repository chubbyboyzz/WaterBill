namespace Asm2
{
    partial class Waterbill
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
            btn_logout = new Button();
            label1 = new Label();
            btn_Family = new Button();
            btn_services = new Button();
            btn_Production = new Button();
            btn_business = new Button();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(64, 64, 64);
            btn_logout.Font = new Font("Broadway", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.Cyan;
            btn_logout.Location = new Point(648, 402);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(140, 36);
            btn_logout.TabIndex = 0;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 27);
            label1.Name = "label1";
            label1.Size = new Size(264, 29);
            label1.TabIndex = 1;
            label1.Text = "Choose your option";
            // 
            // btn_Family
            // 
            btn_Family.BackColor = Color.SpringGreen;
            btn_Family.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Family.Location = new Point(181, 79);
            btn_Family.Name = "btn_Family";
            btn_Family.Size = new Size(408, 63);
            btn_Family.TabIndex = 2;
            btn_Family.Text = "Household customer";
            btn_Family.UseVisualStyleBackColor = false;
            btn_Family.Click += btn_Family_Click;
            // 
            // btn_services
            // 
            btn_services.BackColor = Color.SpringGreen;
            btn_services.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_services.Location = new Point(181, 148);
            btn_services.Name = "btn_services";
            btn_services.Size = new Size(408, 63);
            btn_services.TabIndex = 3;
            btn_services.Text = "Public services";
            btn_services.UseVisualStyleBackColor = false;
            btn_services.Click += btn_services_Click;
            // 
            // btn_Production
            // 
            btn_Production.BackColor = Color.SpringGreen;
            btn_Production.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Production.Location = new Point(181, 217);
            btn_Production.Name = "btn_Production";
            btn_Production.Size = new Size(408, 63);
            btn_Production.TabIndex = 4;
            btn_Production.Text = "Production units";
            btn_Production.UseVisualStyleBackColor = false;
            btn_Production.Click += btn_Production_Click;
            // 
            // btn_business
            // 
            btn_business.BackColor = Color.SpringGreen;
            btn_business.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_business.Location = new Point(181, 286);
            btn_business.Name = "btn_business";
            btn_business.Size = new Size(408, 63);
            btn_business.TabIndex = 5;
            btn_business.Text = "Business services";
            btn_business.UseVisualStyleBackColor = false;
            btn_business.Click += btn_business_Click;
            // 
            // Waterbill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_business);
            Controls.Add(btn_Production);
            Controls.Add(btn_services);
            Controls.Add(btn_Family);
            Controls.Add(label1);
            Controls.Add(btn_logout);
            Name = "Waterbill";
            Text = "Waterbill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_logout;
        private Label label1;
        private Button btn_Family;
        private Button btn_services;
        private Button btn_Production;
        private Button btn_business;
    }
}