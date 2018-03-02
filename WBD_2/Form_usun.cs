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
    public partial class Form_usun : Form
    {
        public Form_usun()
        {
            InitializeComponent();
        }
        private OracleCommand control_manager_dialog;

        private void button_usun_Click(object sender, EventArgs e)
        {
            control_manager_dialog.CommandText= @"DELETE FROM"+ "Pracownicy"+"WHERE "+"ID_PRACOWNIKA = "+ textBox_ID_usun;
            //control_manager_dialog = new OracleCommand("DELETE FROM"+ "Pracownicy"+"WHERE "+"ID_PRACOWNIKA = "+ textBox_ID_usun, Form1.nowe_polaczenie);
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
