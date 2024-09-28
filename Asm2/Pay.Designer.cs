namespace Asm2
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_back = new Button();
            bnt_exit = new Button();
            txt_result = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 4.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 163);
            label2.Name = "label2";
            label2.Size = new Size(0, 10);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 4.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(357, 163);
            label3.Name = "label3";
            label3.Size = new Size(0, 10);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 4.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(468, 163);
            label4.Name = "label4";
            label4.Size = new Size(0, 10);
            label4.TabIndex = 3;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(64, 64, 64);
            btn_back.ForeColor = Color.FromArgb(128, 255, 255);
            btn_back.Location = new Point(533, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 4;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click_1;
            // 
            // bnt_exit
            // 
            bnt_exit.BackColor = Color.FromArgb(64, 64, 64);
            bnt_exit.ForeColor = Color.FromArgb(128, 255, 255);
            bnt_exit.Location = new Point(641, 12);
            bnt_exit.Name = "bnt_exit";
            bnt_exit.Size = new Size(94, 29);
            bnt_exit.TabIndex = 5;
            bnt_exit.Text = "exit";
            bnt_exit.UseVisualStyleBackColor = false;
            bnt_exit.Click += bnt_exit_Click;
            // 
            // txt_result
            // 
            txt_result.AutoSize = true;
            txt_result.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_result.Location = new Point(412, 178);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(15, 18);
            txt_result.TabIndex = 6;
            txt_result.Text = "0";
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(11F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(747, 498);
            Controls.Add(txt_result);
            Controls.Add(bnt_exit);
            Controls.Add(btn_back);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Pay";
            Text = "Pay";
            Load += Pay_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_back;
        private Button bnt_exit;
        private Label txt_result;
    }
}