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
    public partial class Form_ksiegowa :Form
    {
        OracleConnection polaczenie;
        private DataSet wybor_danych, wybor_pracownicy, wybor_mieszkania, wybor_czynsz, wybor_wynagrodzenia;
        private DataView wyswietlanie_danych;
        private OracleCommand control_manager_dialog;
        private OracleCommandBuilder comand_builder;
        private OracleDataAdapter data_adapter;
        bool Delete = true;
        bool Edycja = true;

        public Form_ksiegowa( ref OracleConnection connection)//:base(ref connection)
        {

            //comboBoxWybor.Items.Clear();
            //combobox_atrybutGora.Items.Clear();
           
       
            polaczenie = new OracleConnection();
            polaczenie = connection;
            KeyPreview = true;

            InitializeComponent();


            comboBoxWybor.Items.Add("");
            comboBoxWybor.Items.Add("PRACOWNICY");
            comboBoxWybor.Items.Add("MIESZKANIA");
            comboBoxWybor.Items.Add("WYNAGRODZENIA");
            comboBoxWybor.Items.Add("CZYNSZE");

            combobox_atrybutGora.Items.Add("");
            combobox_atrybutGora.Items.Add("PRACOWNICY");
            combobox_atrybutGora.Items.Add("MIESZKANIA");
            combobox_atrybutGora.Items.Add("WYNAGRODZENIA");
            combobox_atrybutGora.Items.Add("CZYNSZE");

            comboBoxPolecenia.Items.Add("");
            comboBoxPolecenia.Items.Add("DLUZNICY");
            comboBoxPolecenia.Items.Add("ZADLUZONE MIESZKANIA");
            comboBoxPolecenia.Items.Add("PUSTOSTANY");
            comboBoxPolecenia.Items.Add("MAX PENSJA");
            comboBoxPolecenia.Items.Add("MAX PENSJA NA STANOWISKU");

            control_manager_dialog = new OracleCommand("SELECT * FROM PRACOWNICY ORDER BY ID_PRACOWNIKA ASC", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_pracownicy = new DataSet();
            data_adapter.Fill(wybor_pracownicy);

            control_manager_dialog = new OracleCommand("SELECT * FROM MIESZKANIA ORDER BY ID_MIESZKANIA ASC ", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_mieszkania = new DataSet();
            data_adapter.Fill(wybor_mieszkania);

            control_manager_dialog = new OracleCommand("SELECT * FROM CZYNSZE ORDER BY ID_CZYNSZU ASC", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_czynsz = new DataSet();
            data_adapter.Fill(wybor_czynsz);
            control_manager_dialog = new OracleCommand("SELECT * FROM WYNAGRODZENIA ORDER BY ID_WYNAGRODZENIE", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_wynagrodzenia = new DataSet();
            data_adapter.Fill(wybor_wynagrodzenia);

        }

        private void Form_ksiegowa_Load(object sender, EventArgs e)
        {

        }
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string tabela = "";

            if (combobox_atrybutGora.Text == "PRACOWNICY")
            {

                tabela = "PRACOWNICY";
                MessageBox.Show("Nie masz uprawnień");


            }
            else if (combobox_atrybutGora.Text == "MIESZKANIA")
            {

                tabela = "MIESZKANIA";
                MessageBox.Show("Nie masz uprawnień");
            }

            else if (combobox_atrybutGora.Text == "CZYNSZE")
            {

                tabela = "CZYNSZE";
                Form dodaj = new Form_dodaj(tabela, polaczenie);
                dodaj.Show();

            }
            else if (combobox_atrybutGora.Text == "WYNAGRODZENIA")
            {

                tabela = "WYNAGRODZENIA";
                Form dodaj = new Form_dodaj(tabela, polaczenie);
                dodaj.Show();

            }


        }

        private void button_pokaz_dane_Click(object sender, EventArgs e)

        {
            dataGridView1.ReadOnly = true;
            refresh();
            if (combobox_atrybutGora.Text == "PRACOWNICY")
            {

                dataGridView1.DataSource = wybor_pracownicy.Tables[0].DefaultView;
                Delete = false;
                Edycja = false;


            }
            else if (combobox_atrybutGora.Text == "MIESZKANIA")
            {

                dataGridView1.DataSource = wybor_mieszkania.Tables[0];
                Delete = false;
                Edycja = false;

            }
            else if (combobox_atrybutGora.Text == "WYNAGRODZENIA")
            {

                dataGridView1.DataSource = wybor_wynagrodzenia.Tables[0];
                Delete = true;
                Edycja = true;

            }
            else if (combobox_atrybutGora.Text == "CZYNSZE")
            {

                dataGridView1.DataSource = wybor_czynsz.Tables[0];
                Delete = true;
                Edycja = true;

            }






        }

        private void button_usun_Click(object sender, EventArgs e)
        {

        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polaczenie.Close();
            this.Close();
            Form logowanie = new Form1();
            logowanie.Show();

        }

        private void button_szukaj_Click_1(object sender, EventArgs e)
        {
            if (comboBoxWybor.Text == "PRACOWNICY")
            {
                try
                {
                    if(comboBox_atrybuty.Text=="ID_PRACOWNIKA")
                    wyswietlanie_danych = new DataView(wybor_pracownicy.Tables[0], comboBox_atrybuty.Text + "='" + textBox_fraza.Text + "' ", comboBox_atrybuty.Text + " Desc", DataViewRowState.CurrentRows);
                    else
                    wyswietlanie_danych = new DataView(wybor_pracownicy.Tables[0], comboBox_atrybuty.Text + " LIKE '%" + textBox_fraza.Text + "%' ", comboBox_atrybuty.Text + " Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = wyswietlanie_danych;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wprowadziles zle dane");
                }
            }
            else if (comboBoxWybor.Text == "MIESZKANIA")
            {
                try
                {
                    wyswietlanie_danych = new DataView(wybor_mieszkania.Tables[0], comboBox_atrybuty.Text + "= '" + textBox_fraza.Text + "' ", comboBox_atrybuty.Text + " Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = wyswietlanie_danych;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wprowadziles zle dane");
                }
            }
            else if (comboBoxWybor.Text == "WYNAGRODZENIA")
            {
                try
                {
                    wyswietlanie_danych = new DataView(wybor_wynagrodzenia.Tables[0], comboBox_atrybuty.Text + "= '" + textBox_fraza.Text + "' ", comboBox_atrybuty.Text + " Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = wyswietlanie_danych;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wprowadziles zle dane");
                }
            }
            else if (comboBoxWybor.Text == "CZYNSZE")
            {
                try
                {
                    wyswietlanie_danych = new DataView(wybor_czynsz.Tables[0], comboBox_atrybuty.Text + "= '" + textBox_fraza.Text + "' ", comboBox_atrybuty.Text + " Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = wyswietlanie_danych;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wprowadziles zle dane");
                }
            }
            comboBoxWybor.SelectedIndex = 0;
            comboBox_atrybuty.SelectedIndex = 0;
            textBox_fraza.Clear();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Prezes_Load(object sender, EventArgs e)
        {

        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            data_adapter.Update(wybor_czynsz.Tables[0]);
            data_adapter.Update(wybor_wynagrodzenia.Tables[0]);
        }

        private void Form_Prezes_KeyDown(object sender, KeyEventArgs e)
        {


            e.Handled = true;
            if (e.KeyCode == Keys.Delete)
            {

                if (Delete)
                {
                    DialogResult result = MessageBox.Show("Czy na pewno usunąć ?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {  
                           
                           
                                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                                    dataGridView1.Rows.RemoveAt(row.Index);
                                data_adapter.Update(wybor_czynsz.Tables[0]);           
                        
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Brak uprawnień");
                    }
                }
                else
                {

                }
            }
        }

        private void buttonEdycja_Click(object sender, EventArgs e)
        {
            if (Edycja)
            {
                dataGridView1.ReadOnly = false;

            }
            else
            {
                MessageBox.Show("Nie masz uprawnień");
            }
             


        }

        private void combobox_atrybutGora_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_zapytania_Click(object sender, EventArgs e)
        {
            if (comboBoxPolecenia.Text == "ZADLUZONE MIESZKANIA")
            {
                control_manager_dialog = new OracleCommand("select m.id_mieszkania, m.KWOTA, w.imie,w.nazwisko from mieszkania c JOIN czynsze m ON m.id_mieszkania=c.id_mieszkania JOIN KUPNA k ON k.ID_MIESZKANIA=c.ID_MIESZKANIA JOIN wlasciciele w ON w.ID_WLASCICIELA=k.ID_WLASCICIELA WHERE m.CZY_OPLACONY='N'", polaczenie);
                data_adapter = new OracleDataAdapter(control_manager_dialog);
                comand_builder = new OracleCommandBuilder(data_adapter);

                wybor_danych = new DataSet();
                data_adapter.Fill(wybor_danych);
                dataGridView1.DataSource = wybor_danych.Tables[0];
            }
            else if (comboBoxPolecenia.Text == "PUSTOSTANY")
            {
                control_manager_dialog = new OracleCommand("Select* from MIESZKANIA where id_mieszkania=(select n.ID_MIESZKANIA from MIESZKANIA n MINUS select m.ID_MIESZKANIA from KUPNA k join MIESZKANIA m on k.ID_MIESZKANIA=m.ID_MIESZKANIA where k.CZY_AKTUALNE='Y')", polaczenie);
                data_adapter = new OracleDataAdapter(control_manager_dialog);
                comand_builder = new OracleCommandBuilder(data_adapter);

                wybor_danych = new DataSet();
                data_adapter.Fill(wybor_danych);
                dataGridView1.DataSource = wybor_danych.Tables[0];
            }
            else if (comboBoxPolecenia.Text == "DLUZNICY")
            {
                control_manager_dialog = new OracleCommand("select k.id_wlasciciela, SUM(c.KWOTA) from KUPNA k JOIN MIESZKANIA m  ON k.ID_MIESZKANIA=m.ID_MIESZKANIA JOIN CZYNSZE c ON m.id_mieszkania=c.id_mieszkania  where c.CZY_OPLACONY='N' and k.CZY_AKTUALNE='Y'  GROUP BY k.ID_WLASCICIELA ", polaczenie);
                data_adapter = new OracleDataAdapter(control_manager_dialog);
                comand_builder = new OracleCommandBuilder(data_adapter);

                wybor_danych = new DataSet();
                data_adapter.Fill(wybor_danych);
                dataGridView1.DataSource = wybor_danych.Tables[0];
            }
            else if (comboBoxPolecenia.Text == "MAX PENSJA")
            {
                control_manager_dialog = new OracleCommand("Select distinct w.kwota, p.id_pracownika, p.imie, p.nazwisko FROM  PRACOWNICY p JOIN WYNAGRODZENIA w ON p.id_pracownika=w.ID_PRACOWNIKA where w.kwota=(select max(kwota)from wynagrodzenia)", polaczenie);
                data_adapter = new OracleDataAdapter(control_manager_dialog);
                comand_builder = new OracleCommandBuilder(data_adapter);

                wybor_danych = new DataSet();
                data_adapter.Fill(wybor_danych);
                dataGridView1.DataSource = wybor_danych.Tables[0];
            }
            else if (comboBoxPolecenia.Text == "MAX PENSJA NA STANOWISKU")
            {
                control_manager_dialog = new OracleCommand("Select distinct p.funkcja, MAX(w.KWOTA) FROM  PRACOWNICY p JOIN WYNAGRODZENIA w ON p.id_pracownika=w.ID_PRACOWNIKA GROUP BY p.FUNKCJA ORDER BY p.funkcja DESC", polaczenie);
                data_adapter = new OracleDataAdapter(control_manager_dialog);
                comand_builder = new OracleCommandBuilder(data_adapter);

                wybor_danych = new DataSet();
                data_adapter.Fill(wybor_danych);
                dataGridView1.DataSource = wybor_danych.Tables[0];
            }
        }



        private void button_szukaj_Click(object sender, EventArgs e)
        {


        }
        public void refresh()
        {
            control_manager_dialog = new OracleCommand("SELECT * FROM PRACOWNICY ORDER BY ID_PRACOWNIKA ASC", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_pracownicy = new DataSet();
            data_adapter.Fill(wybor_pracownicy);

            control_manager_dialog = new OracleCommand("SELECT * FROM MIESZKANIA ORDER BY ID_MIESZKANIA ASC", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_mieszkania = new DataSet();
            data_adapter.Fill(wybor_mieszkania);

            control_manager_dialog = new OracleCommand("SELECT * FROM CZYNSZE ORDER BY ID_CZYNSZU ASC", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_czynsz = new DataSet();
            data_adapter.Fill(wybor_czynsz);
            control_manager_dialog = new OracleCommand("SELECT * FROM WYNAGRODZENIA ORDER BY ID_WYNAGRODZENIE ASC", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_wynagrodzenia = new DataSet();
            data_adapter.Fill(wybor_wynagrodzenia);
        }

        private void comboBoxWybor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_atrybuty.Items.Clear();
            comboBox_atrybuty.Items.Add("");
            if (comboBoxWybor.Text == "PRACOWNICY")
            {
                for (int i = 0; i < wybor_pracownicy.Tables[0].Columns.Count; i++)
                {
                    comboBox_atrybuty.Items.Add(wybor_pracownicy.Tables[0].Columns[i].ToString());
                }
            }
            else if (comboBoxWybor.Text == "MIESZKANIA")
            {
                for (int i = 0; i < wybor_mieszkania.Tables[0].Columns.Count; i++)
                {
                    comboBox_atrybuty.Items.Add(wybor_mieszkania.Tables[0].Columns[i].ToString());
                }
            }
            else if (comboBoxWybor.Text == "WYNAGRODZENIA")
            {
                for (int i = 0; i < wybor_wynagrodzenia.Tables[0].Columns.Count; i++)
                {
                    comboBox_atrybuty.Items.Add(wybor_wynagrodzenia.Tables[0].Columns[i].ToString());
                }
            }
            else if (comboBoxWybor.Text == "CZYNSZE")
            {
                for (int i = 0; i < wybor_czynsz.Tables[0].Columns.Count; i++)
                {
                    comboBox_atrybuty.Items.Add(wybor_czynsz.Tables[0].Columns[i].ToString());
                }
            }


        }
    }
}
