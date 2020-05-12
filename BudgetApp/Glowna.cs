using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    public class Glowna
    {
        #region Wlasciwosci
        public static SQLiteConnection _Polaczenie;
        public static SQLiteConnection Polaczenie
        {
            get
            {
                if(!File.Exists(Path.Combine(Application.StartupPath, "expenses.db")))
                {
                    _Polaczenie = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "expenses.db")));
                    _Polaczenie.Open();

                    zapytanieSQL = string.Format("create table if not exists wydatki(id integer primary key autoincrement, " +
                     "TytulWydatku varchar(50), KwotaWydatku int)");

                    Komenda = new SQLiteCommand(zapytanieSQL, Polaczenie);
                    Komenda.ExecuteNonQuery();

                    zapytanieSQL = string.Format("create table if not exists przychody(id integer primary key autoincrement, " +
                        "TytulPrzychodu varchar(50), KwotaPrzychodu int, DataPrzychodu datetime)");
                    Komenda.CommandText = zapytanieSQL;
                    Komenda.ExecuteNonQuery();

                    zapytanieSQL = string.Format("create table if not exists wydatkiStale(id integer primary key autoincrement, " +
                        "TytulWydatkuStalego varchar(50), KwotaWydatkuStalego int, DataWydatkuStalego datetime)");
                    Komenda.CommandText = zapytanieSQL;
                    Komenda.ExecuteNonQuery();

                    _Polaczenie.Close();

                } else
                    if(_Polaczenie == null)
                    _Polaczenie = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "expenses.db")));

                return _Polaczenie;
            }
        }

        public static SQLiteCommand Komenda;
        public static SQLiteDataReader Czytnik;
        public static string zapytanieSQL = "";
        #endregion Wlasciwosci

    }
}
