using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WBD_2
{
    public partial class Form_dodaj : Form
    {
        private OracleConnection polaczenie;
        private DataSet wybor_danych;
        private DataView wyswietlenie_danych;
        private OracleCommand control_manager_dialog;
        private OracleCommandBuilder comand_builder;
        private OracleDataAdapter data_adapter;

        List<string> lista_text_box = new List<string>();
        List<string> lista_label = new List<string>();
        List<string> lista_combobox = new List<string>();
        string nazwa_tabeli = "";

        public Form_dodaj(string tmp, OracleConnection connection)
        {
            InitializeComponent();
            polaczenie = new OracleConnection();
            polaczenie = connection;
            nazwa_tabeli = tmp;
            

        control_manager_dialog = new OracleCommand("SELECT * FROM "+tmp, polaczenie);
        data_adapter = new OracleDataAdapter(control_manager_dialog);
        comand_builder = new OracleCommandBuilder(data_adapter);

        wybor_danych = new DataSet();
        data_adapter.Fill(wybor_danych);
            int a = 0;
            int b = 15;
            int c = 130;
            for(int i=0; i<wybor_danych.Tables[0].Columns.Count; i++)
            {
                if(i==8)
                {
                    a -= 240;
                    b += 300;
                    c += 300;
                }
                a += 30;
               

                Label nowy_label = new Label();
                nowy_label.Location = new Point(b, 30 + a);
                nowy_label.Text = wybor_danych.Tables[0].Columns[i].ToString();

                lista_label.Add(wybor_danych.Tables[0].Columns[i].ToString());
                groupBox1.Controls.Add(nowy_label);

                if (nowy_label.Text == "FUNKCJA")
                {
                    ComboBox nowy_combobox = new ComboBox();
                    nowy_combobox.Location = new Point(c, 25 + a);
                    nowy_combobox.Name = "wbd" + i.ToString();

                    nowy_combobox.Items.Add("");
                    nowy_combobox.Items.Add("prezes");
                    nowy_combobox.Items.Add("wiceprezes");
                    nowy_combobox.Items.Add("ksiegowa");
                    nowy_combobox.Items.Add("czlonek zarzadu");
                    nowy_combobox.Items.Add("pomocnik");

                    lista_combobox.Add(nowy_combobox.Name);
                    groupBox1.Controls.Add(nowy_combobox);

                    TextBox nowy_textBox = new TextBox();
                    nowy_textBox.Location = new Point(c, 25 + a);
                    nowy_textBox.Name = "wbd" + i.ToString();

                    lista_text_box.Add(nowy_textBox.Name);
                }
                else if (nowy_label.Text == "PLEC")
                {
                    ComboBox nowy_combobox = new ComboBox();
                    nowy_combobox.Location = new Point(c, 25 + a);
                    nowy_combobox.Name = "wbd" + i.ToString();

                    nowy_combobox.Items.Add("");
                    nowy_combobox.Items.Add("M");
                    nowy_combobox.Items.Add("K");


                    lista_combobox.Add(nowy_combobox.Name);
                    groupBox1.Controls.Add(nowy_combobox);

                    TextBox nowy_textBox = new TextBox();
                    nowy_textBox.Location = new Point(c, 25 + a);
                    nowy_textBox.Name = "wbd" + i.ToString();

                    lista_text_box.Add(nowy_textBox.Name);
                }
                else if (nowy_label.Text == "TYP" && tmp == "POJAZDY")
                {
                    ComboBox nowy_combobox = new ComboBox();
                    nowy_combobox.Location = new Point(c, 25 + a);
                    nowy_combobox.Name = "combobox" + i.ToString();

                    nowy_combobox.Items.Add("");
                    nowy_combobox.Items.Add("ciagnik");
                    nowy_combobox.Items.Add("koparka");


                    lista_combobox.Add(nowy_combobox.Name);
                    groupBox1.Controls.Add(nowy_combobox);

                    TextBox nowy_textBox = new TextBox();
                    nowy_textBox.Location = new Point(c, 25 + a);
                    nowy_textBox.Name = "wbd" + i.ToString();

                    lista_text_box.Add(nowy_textBox.Name);
                }
                else {

                    TextBox nowy_textBox = new TextBox();
                    nowy_textBox.Location = new Point(c, 25 + a);
                    nowy_textBox.Name = "wbd" + i.ToString();

                    lista_text_box.Add(nowy_textBox.Name);
                    groupBox1.Controls.Add(nowy_textBox);
                }

            }



    }

       

     

       

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            int pomocnicza = 0;
            try {
                string tmp_tabela="",tmp_pola="";

                for(int i=0; i<lista_label.Count;i++)
                {
                    if (i == lista_label.Count - 1)
                        tmp_tabela = tmp_tabela + lista_label[i].ToString();
                    else
                        tmp_tabela = tmp_tabela + lista_label[i].ToString() + ",";

                }
                for(int i = 0; i < lista_text_box.Count; i++)
                {
                    if (lista_label[i] != "FUNKCJA" && lista_label[i] != "PLEC" && lista_label[i] != "TYP")
                    {
                        TextBox tmp_textbox = this.Controls.Find(lista_text_box[i], true).First() as TextBox;
                       

                        if (i == lista_text_box.Count - 1)
                            tmp_pola = tmp_pola + "'" + tmp_textbox.Text;
                        else
                            tmp_pola = tmp_pola + "'" + tmp_textbox.Text + "',";
                        tmp_textbox.Clear();
                    }
                    else
                    {
                        ComboBox tmp_combobox = this.Controls.Find(lista_combobox[pomocnicza], true).First() as ComboBox;

                        if (i == lista_text_box.Count - 1)
                            tmp_pola = tmp_pola + "'" + tmp_combobox.Text;
                        else
                            tmp_pola = tmp_pola + "'" + tmp_combobox.Text + "',";
                        tmp_combobox.SelectedIndex = 0;
                        pomocnicza++;
                    }
                }
                control_manager_dialog.CommandText = @"INSERT INTO " + nazwa_tabeli + " VALUES (" + tmp_pola + "')";
                control_manager_dialog.ExecuteNonQuery();
                MessageBox.Show("Wprowadzono dane do bazy");

            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

           

            


        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            lista_combobox.Clear();
            lista_label.Clear();
            lista_text_box.Clear();
        }
    }
}
