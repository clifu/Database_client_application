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
    public partial class Form_Pracownik : Form
    {
        private OracleConnection polaczenie;
        private DataSet wybor_danych;
        private DataView wyswietlenie_danych;
        private OracleCommand control_manager_dialog;
        private OracleCommandBuilder comand_builder;
        private OracleDataAdapter data_adapter;
        private DataTable table;
        private string identyfikator;

        public Form_Pracownik(string identyfikator, OracleConnection connection)
        {
            InitializeComponent();
            polaczenie = new OracleConnection();
            polaczenie = connection;
            this.identyfikator = identyfikator;

            control_manager_dialog = new OracleCommand("Select * FROM PRACOWNICY where ID_PRACOWNIKA='" + identyfikator + "'", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_danych = new DataSet();
            data_adapter.Fill(wybor_danych);
          
            labelID1.Text = wybor_danych.Tables[0].Rows[0].ItemArray[0].ToString();
            labelImie1.Text = wybor_danych.Tables[0].Rows[0].ItemArray[1].ToString();
            labelNazwisko1.Text = wybor_danych.Tables[0].Rows[0].ItemArray[2].ToString();
            labelData1.Text = wybor_danych.Tables[0].Rows[0].ItemArray[4].ToString();
            labelFunkcja1.Text = wybor_danych.Tables[0].Rows[0].ItemArray[11].ToString();
            labelMiejscowos1.Text = wybor_danych.Tables[0].Rows[0].ItemArray[5].ToString();
            labelUlica1.Text = wybor_danych.Tables[0].Rows[0].ItemArray[6].ToString();
            labelNrDomu1.Text = wybor_danych.Tables[0].Rows[0].ItemArray[7].ToString();
            labelNrMieszkania1.Text = wybor_danych.Tables[0].Rows[0].ItemArray[8].ToString();





        }

        private void Form_Pracownik_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control_manager_dialog = new OracleCommand("Select DATA, KWOTA FROM WYNAGRODZENIA where ID_PRACOWNIKA='" + identyfikator + "' ORDER BY DATA DESC", polaczenie);
            data_adapter = new OracleDataAdapter(control_manager_dialog);
            comand_builder = new OracleCommandBuilder(data_adapter);

            wybor_danych = new DataSet();
            data_adapter.Fill(wybor_danych);
            dataGridView1.DataSource = wybor_danych.Tables[0];
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polaczenie.Close();
            this.Close();
            Form logowanie = new Form1();
            logowanie.Show();
        }

    
    }
}
