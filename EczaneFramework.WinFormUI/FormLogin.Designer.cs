namespace EczaneFramework.WinFormUI
{
    partial class FormLogin
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
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(47, 136);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(172, 20);
            this.textBox_UserName.TabIndex = 0;
            this.textBox_UserName.Text = "husrevyildiz@gmail.com";
            this.textBox_UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(47, 162);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(172, 20);
            this.textBox_Password.TabIndex = 0;
            this.textBox_Password.Text = "123123";
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Giris Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button1;
    }
}