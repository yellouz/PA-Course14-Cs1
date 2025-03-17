namespace WindowsFormsApp1
{
    partial class Form9
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.btnChangeForeColor = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Hello World";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.Location = new System.Drawing.Point(65, 122);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(138, 51);
            this.btnChangeBackColor.TabIndex = 1;
            this.btnChangeBackColor.Text = "Change Back Color";
            this.btnChangeBackColor.UseVisualStyleBackColor = true;
            this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
            // 
            // btnChangeForeColor
            // 
            this.btnChangeForeColor.Location = new System.Drawing.Point(244, 122);
            this.btnChangeForeColor.Name = "btnChangeForeColor";
            this.btnChangeForeColor.Size = new System.Drawing.Size(136, 51);
            this.btnChangeForeColor.TabIndex = 2;
            this.btnChangeForeColor.Text = "Change Fore Color";
            this.btnChangeForeColor.UseVisualStyleBackColor = true;
            this.btnChangeForeColor.Click += new System.EventHandler(this.btnChangeForeColor_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(65, 192);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(138, 56);
            this.btnChangeFont.TabIndex = 3;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save File Dialog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.btnChangeForeColor);
            this.Controls.Add(this.btnChangeBackColor);
            this.Controls.Add(this.textBox1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChangeBackColor;
        private System.Windows.Forms.Button btnChangeForeColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}