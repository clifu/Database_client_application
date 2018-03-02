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
    
    public partial class Form1 : Form
    {

        private DataSet wybor_danych;
        private DataView wyswietlenie_danych;
        private OracleCommand control_manager_dialog;
        private OracleCommandBuilder comand_builder;
        private OracleDataAdapter data_adapter;
        Form_Prezes prezes;
        Form_Pracownik oknoPracownika;
        Form_ksiegowa ksiegowa;
    

        public Form1()
        {
            InitializeComponent();
            textBox_haslo.PasswordChar='*';
            label_login.ForeColor = System.Drawing.Color.Green;
            label_login.Font = new Font("Arial", 10);
            label_haslo.ForeColor = System.Drawing.Color.Green;
            label_haslo.Font = new Font("Arial", 10);
        }


    
        private OracleConnection nowe_polaczenie = new OracleConnection();


        private void button_polacz_Click(object sender, EventArgs e)
        {
            string TypKonta="";
            string idPracownika="";
            try
            {
                nowe_polaczenie.Close();
                nowe_polaczenie.ConnectionString = "User Id=" + "dwasilew" + ";Password=" + "dwasilew" + ";Data Source =(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=ora3.elka.pw.edu.pl)(PORT=1521))" + "(CONNECT_DATA=(SID=ora3inf)));";
                nowe_polaczenie.Open();

                

                control_manager_dialog = new OracleCommand("SELECT * FROM KONTO WHERE login = '" + textBox_login.Text + "' AND haslo='" + textBox_haslo.Text + "'", nowe_polaczenie);
                data_adapter = new OracleDataAdapter(control_manager_dialog);
                comand_builder = new OracleCommandBuilder(data_adapter);

                wybor_danych = new DataSet();
                data_adapter.Fill(wybor_danych);

                DataTable table = wybor_danych.Tables[0];
                if (table.Rows.Count > 0)
                {
                   TypKonta = table.Rows[0].ItemArray[4].ToString();
                }

                if (table.Rows.Count == 1)
                {
                    if (TypKonta=="1")
                    {
                       
                        this.Hide();
                        prezes = new Form_Prezes(ref nowe_polaczenie);
                        prezes.Show();
                    }
                    else if(TypKonta=="2")
                    {
                        control_manager_dialog = new OracleCommand("Select p.id_pracownika from KONTO p JOIN PRACOWNICY k ON p.ID_PRACOWNIKA=k.ID_PRACOWNIKA WHERE p.login='"+textBox_login.Text+"' and p.haslo='"+textBox_haslo.Text+"'", nowe_polaczenie);
                        data_adapter = new OracleDataAdapter(control_manager_dialog);
                        comand_builder = new OracleCommandBuilder(data_adapter);

                        wybor_danych = new DataSet();
                        data_adapter.Fill(wybor_danych);
                        table = wybor_danych.Tables[0];
                        idPracownika = table.Rows[0].ItemArray[0].ToString();

                        this.Hide();
                        oknoPracownika = new Form_Pracownik(idPracownika,nowe_polaczenie);
                        oknoPracownika.Show();
                        
                    }
                    else if (TypKonta == "3")
                    {
                        this.Hide();
                        ksiegowa = new Form_ksiegowa(ref nowe_polaczenie);
                        ksiegowa.Show();

                    }



                } else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło");
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            textBox_haslo.Clear();
            textBox_login.Clear();
        }

        private void label_haslo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
