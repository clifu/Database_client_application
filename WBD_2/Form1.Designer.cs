namespace WBD_2
{
    partial class Form1
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.button_polacz = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_haslo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(82, 50);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 22);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Location = new System.Drawing.Point(298, 53);
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.Size = new System.Drawing.Size(105, 22);
            this.textBox_haslo.TabIndex = 1;
            // 
            // button_polacz
            // 
            this.button_polacz.Location = new System.Drawing.Point(168, 105);
            this.button_polacz.Name = "button_polacz";
            this.button_polacz.Size = new System.Drawing.Size(96, 29);
            this.button_polacz.TabIndex = 2;
            this.button_polacz.Text = "Polacz";
            this.button_polacz.UseVisualStyleBackColor = true;
            this.button_polacz.Click += new System.EventHandler(this.button_polacz_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(28, 53);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(38, 17);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "login";
            // 
            // label_haslo
            // 
            this.label_haslo.AutoSize = true;
            this.label_haslo.Location = new System.Drawing.Point(232, 53);
            this.label_haslo.Name = "label_haslo";
            this.label_haslo.Size = new System.Drawing.Size(42, 17);
            this.label_haslo.TabIndex = 4;
            this.label_haslo.Text = "haslo";
            this.label_haslo.Click += new System.EventHandler(this.label_haslo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 178);
            this.Controls.Add(this.label_haslo);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_polacz);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.textBox_login);
            this.Name = "Form1";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.button_polacz_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_haslo;
        private System.Windows.Forms.Button button_polacz;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_haslo;
    }
}

