namespace WBD_2
{
    partial class Form_Prezes
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
            this.comboBox_atrybuty = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxWybor = new System.Windows.Forms.ComboBox();
            this.button_szukaj = new System.Windows.Forms.Button();
            this.label_fraza = new System.Windows.Forms.Label();
            this.textBox_fraza = new System.Windows.Forms.TextBox();
            this.label_atrybut = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_pokaz_dane = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.combobox_atrybutGora = new System.Windows.Forms.ComboBox();
            this.label_Polecenia = new System.Windows.Forms.Label();
            this.comboBoxPolecenia = new System.Windows.Forms.ComboBox();
            this.button_zapytania = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.buttonEdycja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_atrybuty
            // 
            this.comboBox_atrybuty.FormattingEnabled = true;
            this.comboBox_atrybuty.Location = new System.Drawing.Point(192, 36);
            this.comboBox_atrybuty.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_atrybuty.Name = "comboBox_atrybuty";
            this.comboBox_atrybuty.Size = new System.Drawing.Size(92, 21);
            this.comboBox_atrybuty.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxWybor);
            this.groupBox1.Controls.Add(this.button_szukaj);
            this.groupBox1.Controls.Add(this.label_fraza);
            this.groupBox1.Controls.Add(this.textBox_fraza);
            this.groupBox1.Controls.Add(this.label_atrybut);
            this.groupBox1.Controls.Add(this.comboBox_atrybuty);
            this.groupBox1.Location = new System.Drawing.Point(28, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(595, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szukaj";
            // 
            // comboBoxWybor
            // 
            this.comboBoxWybor.FormattingEnabled = true;
            this.comboBoxWybor.Location = new System.Drawing.Point(22, 34);
            this.comboBoxWybor.Name = "comboBoxWybor";
            this.comboBoxWybor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWybor.TabIndex = 5;
            this.comboBoxWybor.SelectedIndexChanged += new System.EventHandler(this.comboBoxWybor_SelectedIndexChanged);
            // 
            // button_szukaj
            // 
            this.button_szukaj.Location = new System.Drawing.Point(535, 35);
            this.button_szukaj.Margin = new System.Windows.Forms.Padding(2);
            this.button_szukaj.Name = "button_szukaj";
            this.button_szukaj.Size = new System.Drawing.Size(56, 19);
            this.button_szukaj.TabIndex = 4;
            this.button_szukaj.Text = "Szukaj";
            this.button_szukaj.UseVisualStyleBackColor = true;
            this.button_szukaj.Click += new System.EventHandler(this.button_szukaj_Click_1);
            // 
            // label_fraza
            // 
            this.label_fraza.AutoSize = true;
            this.label_fraza.Location = new System.Drawing.Point(298, 39);
            this.label_fraza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_fraza.Name = "label_fraza";
            this.label_fraza.Size = new System.Drawing.Size(75, 13);
            this.label_fraza.TabIndex = 3;
            this.label_fraza.Text = "Szukana fraza";
            // 
            // textBox_fraza
            // 
            this.textBox_fraza.Location = new System.Drawing.Point(377, 34);
            this.textBox_fraza.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fraza.Name = "textBox_fraza";
            this.textBox_fraza.Size = new System.Drawing.Size(128, 20);
            this.textBox_fraza.TabIndex = 2;
            // 
            // label_atrybut
            // 
            this.label_atrybut.AutoSize = true;
            this.label_atrybut.Location = new System.Drawing.Point(148, 39);
            this.label_atrybut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_atrybut.Name = "label_atrybut";
            this.label_atrybut.Size = new System.Drawing.Size(40, 13);
            this.label_atrybut.TabIndex = 1;
            this.label_atrybut.Text = "Atrybut";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 122);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_pokaz_dane
            // 
            this.button_pokaz_dane.Location = new System.Drawing.Point(220, 37);
            this.button_pokaz_dane.Margin = new System.Windows.Forms.Padding(2);
            this.button_pokaz_dane.Name = "button_pokaz_dane";
            this.button_pokaz_dane.Size = new System.Drawing.Size(92, 26);
            this.button_pokaz_dane.TabIndex = 3;
            this.button_pokaz_dane.Text = "Pokaz";
            this.button_pokaz_dane.UseVisualStyleBackColor = true;
            this.button_pokaz_dane.Click += new System.EventHandler(this.button_pokaz_dane_Click);
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(423, 38);
            this.button_dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(110, 25);
            this.button_dodaj.TabIndex = 4;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // combobox_atrybutGora
            // 
            this.combobox_atrybutGora.FormattingEnabled = true;
            this.combobox_atrybutGora.Location = new System.Drawing.Point(50, 42);
            this.combobox_atrybutGora.Name = "combobox_atrybutGora";
            this.combobox_atrybutGora.Size = new System.Drawing.Size(121, 21);
            this.combobox_atrybutGora.TabIndex = 6;
            this.combobox_atrybutGora.SelectedIndexChanged += new System.EventHandler(this.combobox_atrybutGora_SelectedIndexChanged);
            // 
            // label_Polecenia
            // 
            this.label_Polecenia.AutoSize = true;
            this.label_Polecenia.Location = new System.Drawing.Point(290, 356);
            this.label_Polecenia.Name = "label_Polecenia";
            this.label_Polecenia.Size = new System.Drawing.Size(54, 13);
            this.label_Polecenia.TabIndex = 7;
            this.label_Polecenia.Text = "Polecenia";
            // 
            // comboBoxPolecenia
            // 
            this.comboBoxPolecenia.FormattingEnabled = true;
            this.comboBoxPolecenia.Location = new System.Drawing.Point(350, 353);
            this.comboBoxPolecenia.Name = "comboBoxPolecenia";
            this.comboBoxPolecenia.Size = new System.Drawing.Size(172, 21);
            this.comboBoxPolecenia.TabIndex = 8;
            this.comboBoxPolecenia.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button_zapytania
            // 
            this.button_zapytania.Location = new System.Drawing.Point(544, 351);
            this.button_zapytania.Name = "button_zapytania";
            this.button_zapytania.Size = new System.Drawing.Size(75, 23);
            this.button_zapytania.TabIndex = 9;
            this.button_zapytania.Text = "Wykonaj";
            this.button_zapytania.UseVisualStyleBackColor = true;
            this.button_zapytania.Click += new System.EventHandler(this.button_zapytania_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Opcje";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // button_zapisz
            // 
            this.button_zapisz.Location = new System.Drawing.Point(544, 37);
            this.button_zapisz.Margin = new System.Windows.Forms.Padding(2);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(100, 26);
            this.button_zapisz.TabIndex = 11;
            this.button_zapisz.Text = "Zapisz zmiany";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // buttonEdycja
            // 
            this.buttonEdycja.Location = new System.Drawing.Point(329, 37);
            this.buttonEdycja.Name = "buttonEdycja";
            this.buttonEdycja.Size = new System.Drawing.Size(75, 23);
            this.buttonEdycja.TabIndex = 12;
            this.buttonEdycja.Text = "Edycja";
            this.buttonEdycja.UseVisualStyleBackColor = true;
            this.buttonEdycja.Click += new System.EventHandler(this.buttonEdycja_Click);
            // 
            // Form_Prezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 440);
            this.Controls.Add(this.buttonEdycja);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.button_zapytania);
            this.Controls.Add(this.comboBoxPolecenia);
            this.Controls.Add(this.label_Polecenia);
            this.Controls.Add(this.combobox_atrybutGora);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.button_pokaz_dane);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Prezes";
            this.Text = "Aplikacja_spoldzielni";
            this.Activated += new System.EventHandler(this.button_usun_Click);
            this.Load += new System.EventHandler(this.Form_Prezes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Prezes_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox comboBox_atrybuty;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Label label_fraza;
        protected System.Windows.Forms.TextBox textBox_fraza;
        protected System.Windows.Forms.Label label_atrybut;
        protected System.Windows.Forms.Button button_szukaj;
        protected System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button button_pokaz_dane;
        protected System.Windows.Forms.Button button_dodaj;
        protected System.Windows.Forms.ComboBox comboBoxWybor;
       protected System.Windows.Forms.ComboBox combobox_atrybutGora;
       protected System.Windows.Forms.Label label_Polecenia;
        protected System.Windows.Forms.ComboBox comboBoxPolecenia;
        protected System.Windows.Forms.Button button_zapytania;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        protected System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        protected System.Windows.Forms.Button button_zapisz;
        protected System.Windows.Forms.Button buttonEdycja;
    }
}