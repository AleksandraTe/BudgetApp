using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace BudgetApp
{
    public partial class DodajControl : UserControl
    {
        List<Wydatek> ListaWydatkow = null;



        SQLiteConnection polaczenie = new SQLiteConnection(string.Format("Data Source ={0}", Path.Combine(Application.StartupPath, "expenses.db")));
        SQLiteCommand komenda;
        string zapytanieSQL;
      

        public DodajControl()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void DodajControl_Load(object sender, EventArgs e)
        {
            InicjalizacjaDanych();
            polaczenie.Open();
           
            if (polaczenie.State == ConnectionState.Open)
            {
                zapytanieSQL = string.Format("create table if not exists wydatki(id integer primary key autoincrement, " +
                    "TytulWydatku varchar(50), KwotaWydatku int)");

                komenda = new SQLiteCommand(zapytanieSQL, polaczenie);
                komenda.ExecuteNonQuery();

                zapytanieSQL = string.Format("create table if not exists przychody(id integer primary key autoincrement, " +
                    "TytulPrzychodu varchar(50), KwotaPrzychodu int, DataPrzychodu datetime)");
                komenda.CommandText = zapytanieSQL;
                komenda.ExecuteNonQuery();

                zapytanieSQL = string.Format("create table if not exists wydatkiStale(id integer primary key autoincrement, " +
                    "TytulWydatkuStalego varchar(50), KwotaWydatkuStalego int, DataWydatkuStalego datetime)");
                komenda.CommandText = zapytanieSQL;
                komenda.ExecuteNonQuery();

                MessageBox.Show("Tabele utworzona", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            polaczenie.Close();
        }

        private void btn_Income_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_Expense_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtExpenseAmount.Text))
            {
                if(Wydatki.DodajWydatek(txtExpenseTitle.Text, Convert.ToInt32(txtExpenseAmount.Text) ))

                {
                    InicjalizacjaDanych();

                }
            }
            else
                MessageBox.Show("Kwota musi być wprowadzona", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listaWydatkow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void InicjalizacjaDanych()
        {
            ListaWydatkow = Wydatki.ListaWydatkow;

            int licznik = 1;

            foreach(Wydatek w in ListaWydatkow)
            {
                listaWydatkow.Items.Add( string.Format("{0}. {1} . {2} ", licznik, w.TytulWydatku, w.KwotaWydatku));
            }
        }

        private void btn_FixedExpense_Click(object sender, EventArgs e)
        {

        }
    }
}
