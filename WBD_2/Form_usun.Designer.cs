namespace WBD_2
{
    partial class Form_usun
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
            this.button_usun = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID_usun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_usun
            // 
            this.button_usun.Location = new System.Drawing.Point(191, 142);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(75, 23);
            this.button_usun.TabIndex = 0;
            this.button_usun.Text = "Usun";
            this.button_usun.UseVisualStyleBackColor = true;
            this.button_usun.Click += new System.EventHandler(this.button_usun_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.Location = new System.Drawing.Point(345, 142);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(75, 23);
            this.button_anuluj.TabIndex = 1;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(151, 75);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(96, 17);
            this.label_ID.TabIndex = 2;
            this.label_ID.Text = "ID pracownika";
            // 
            // textBox_ID_usun
            // 
            this.textBox_ID_usun.Location = new System.Drawing.Point(354, 75);
            this.textBox_ID_usun.Name = "textBox_ID_usun";
            this.textBox_ID_usun.Size = new System.Drawing.Size(120, 22);
            this.textBox_ID_usun.TabIndex = 3;
            // 
            // Form_usun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 191);
            this.Controls.Add(this.textBox_ID_usun);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_usun);
            this.Name = "Form_usun";
            this.Text = "Form_usun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID_usun;
    }
}