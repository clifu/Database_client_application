namespace WBD_2
{
    partial class Form_Pracownik
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelID = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelID1 = new System.Windows.Forms.Label();
            this.labelImie1 = new System.Windows.Forms.Label();
            this.labelNazwisko1 = new System.Windows.Forms.Label();
            this.labelData1 = new System.Windows.Forms.Label();
            this.labelMiejscowosc = new System.Windows.Forms.Label();
            this.labelUlica = new System.Windows.Forms.Label();
            this.labelNumer = new System.Windows.Forms.Label();
            this.labelNrMieszkania = new System.Windows.Forms.Label();
            this.labelMiejscowos1 = new System.Windows.Forms.Label();
            this.labelUlica1 = new System.Windows.Forms.Label();
            this.labelNrDomu1 = new System.Windows.Forms.Label();
            this.labelNrMieszkania1 = new System.Windows.Forms.Label();
            this.labelFunkcja = new System.Windows.Forms.Label();
            this.labelFunkcja1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 248);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(479, 119);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pokaz historie wynagrodzen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(62, 28);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(62, 58);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(26, 13);
            this.labelImie.TabIndex = 4;
            this.labelImie.Text = "Imie";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(62, 90);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(53, 13);
            this.labelNazwisko.TabIndex = 5;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(65, 125);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(79, 13);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "Data urodzenia";
            // 
            // labelID1
            // 
            this.labelID1.AutoSize = true;
            this.labelID1.Location = new System.Drawing.Point(138, 28);
            this.labelID1.Name = "labelID1";
            this.labelID1.Size = new System.Drawing.Size(35, 13);
            this.labelID1.TabIndex = 7;
            this.labelID1.Text = "label5";
            // 
            // labelImie1
            // 
            this.labelImie1.AutoSize = true;
            this.labelImie1.Location = new System.Drawing.Point(141, 57);
            this.labelImie1.Name = "labelImie1";
            this.labelImie1.Size = new System.Drawing.Size(35, 13);
            this.labelImie1.TabIndex = 8;
            this.labelImie1.Text = "label6";
            // 
            // labelNazwisko1
            // 
            this.labelNazwisko1.AutoSize = true;
            this.labelNazwisko1.Location = new System.Drawing.Point(141, 90);
            this.labelNazwisko1.Name = "labelNazwisko1";
            this.labelNazwisko1.Size = new System.Drawing.Size(35, 13);
            this.labelNazwisko1.TabIndex = 9;
            this.labelNazwisko1.Text = "label7";
            // 
            // labelData1
            // 
            this.labelData1.AutoSize = true;
            this.labelData1.Location = new System.Drawing.Point(141, 124);
            this.labelData1.Name = "labelData1";
            this.labelData1.Size = new System.Drawing.Size(35, 13);
            this.labelData1.TabIndex = 10;
            this.labelData1.Text = "label8";
            // 
            // labelMiejscowosc
            // 
            this.labelMiejscowosc.AutoSize = true;
            this.labelMiejscowosc.Location = new System.Drawing.Point(278, 27);
            this.labelMiejscowosc.Name = "labelMiejscowosc";
            this.labelMiejscowosc.Size = new System.Drawing.Size(68, 13);
            this.labelMiejscowosc.TabIndex = 11;
            this.labelMiejscowosc.Text = "Miejscowosc";
            // 
            // labelUlica
            // 
            this.labelUlica.AutoSize = true;
            this.labelUlica.Location = new System.Drawing.Point(278, 57);
            this.labelUlica.Name = "labelUlica";
            this.labelUlica.Size = new System.Drawing.Size(31, 13);
            this.labelUlica.TabIndex = 12;
            this.labelUlica.Text = "Ulica";
            // 
            // labelNumer
            // 
            this.labelNumer.AutoSize = true;
            this.labelNumer.Location = new System.Drawing.Point(278, 90);
            this.labelNumer.Name = "labelNumer";
            this.labelNumer.Size = new System.Drawing.Size(47, 13);
            this.labelNumer.TabIndex = 13;
            this.labelNumer.Text = "Nr domu";
            // 
            // labelNrMieszkania
            // 
            this.labelNrMieszkania.AutoSize = true;
            this.labelNrMieszkania.Location = new System.Drawing.Point(281, 123);
            this.labelNrMieszkania.Name = "labelNrMieszkania";
            this.labelNrMieszkania.Size = new System.Drawing.Size(73, 13);
            this.labelNrMieszkania.TabIndex = 14;
            this.labelNrMieszkania.Text = "Nr mieszkania";
            // 
            // labelMiejscowos1
            // 
            this.labelMiejscowos1.AutoSize = true;
            this.labelMiejscowos1.Location = new System.Drawing.Point(396, 28);
            this.labelMiejscowos1.Name = "labelMiejscowos1";
            this.labelMiejscowos1.Size = new System.Drawing.Size(41, 13);
            this.labelMiejscowos1.TabIndex = 15;
            this.labelMiejscowos1.Text = "label13";
            // 
            // labelUlica1
            // 
            this.labelUlica1.AutoSize = true;
            this.labelUlica1.Location = new System.Drawing.Point(399, 56);
            this.labelUlica1.Name = "labelUlica1";
            this.labelUlica1.Size = new System.Drawing.Size(41, 13);
            this.labelUlica1.TabIndex = 16;
            this.labelUlica1.Text = "label14";
            // 
            // labelNrDomu1
            // 
            this.labelNrDomu1.AutoSize = true;
            this.labelNrDomu1.Location = new System.Drawing.Point(399, 90);
            this.labelNrDomu1.Name = "labelNrDomu1";
            this.labelNrDomu1.Size = new System.Drawing.Size(41, 13);
            this.labelNrDomu1.TabIndex = 17;
            this.labelNrDomu1.Text = "label15";
            // 
            // labelNrMieszkania1
            // 
            this.labelNrMieszkania1.AutoSize = true;
            this.labelNrMieszkania1.Location = new System.Drawing.Point(399, 123);
            this.labelNrMieszkania1.Name = "labelNrMieszkania1";
            this.labelNrMieszkania1.Size = new System.Drawing.Size(26, 13);
            this.labelNrMieszkania1.TabIndex = 18;
            this.labelNrMieszkania1.Text = "Imie";
            // 
            // labelFunkcja
            // 
            this.labelFunkcja.AutoSize = true;
            this.labelFunkcja.Location = new System.Drawing.Point(65, 158);
            this.labelFunkcja.Name = "labelFunkcja";
            this.labelFunkcja.Size = new System.Drawing.Size(45, 13);
            this.labelFunkcja.TabIndex = 19;
            this.labelFunkcja.Text = "Funkcja";
            // 
            // labelFunkcja1
            // 
            this.labelFunkcja1.AutoSize = true;
            this.labelFunkcja1.Location = new System.Drawing.Point(141, 157);
            this.labelFunkcja1.Name = "labelFunkcja1";
            this.labelFunkcja1.Size = new System.Drawing.Size(35, 13);
            this.labelFunkcja1.TabIndex = 20;
            this.labelFunkcja1.Text = "label1";
            // 
            // Form_Pracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 378);
            this.Controls.Add(this.labelFunkcja1);
            this.Controls.Add(this.labelFunkcja);
            this.Controls.Add(this.labelNrMieszkania1);
            this.Controls.Add(this.labelNrDomu1);
            this.Controls.Add(this.labelUlica1);
            this.Controls.Add(this.labelMiejscowos1);
            this.Controls.Add(this.labelNrMieszkania);
            this.Controls.Add(this.labelNumer);
            this.Controls.Add(this.labelUlica);
            this.Controls.Add(this.labelMiejscowosc);
            this.Controls.Add(this.labelData1);
            this.Controls.Add(this.labelNazwisko1);
            this.Controls.Add(this.labelImie1);
            this.Controls.Add(this.labelID1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Pracownik";
            this.Text = "Form_Pracownik";
            this.Load += new System.EventHandler(this.Form_Pracownik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelID1;
        private System.Windows.Forms.Label labelImie1;
        private System.Windows.Forms.Label labelNazwisko1;
        private System.Windows.Forms.Label labelData1;
        private System.Windows.Forms.Label labelMiejscowosc;
        private System.Windows.Forms.Label labelUlica;
        private System.Windows.Forms.Label labelNumer;
        private System.Windows.Forms.Label labelNrMieszkania;
        private System.Windows.Forms.Label labelMiejscowos1;
        private System.Windows.Forms.Label labelUlica1;
        private System.Windows.Forms.Label labelNrDomu1;
        private System.Windows.Forms.Label labelNrMieszkania1;
        private System.Windows.Forms.Label labelFunkcja;
        private System.Windows.Forms.Label labelFunkcja1;
    }
}