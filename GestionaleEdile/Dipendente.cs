using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionaleEdile
{
    public class Dipendente
    {
        public static List<Dipendente> listaDipendenti = new List<Dipendente>();
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set;}
        public string Indirizzo { get; set; }
        public string CF { get; set;}
        public bool Coniugato { get; set;}
        public int Figli { get; set; }
        public string Mansione { get; set;}
        public bool StipendioAcconto { get;  set; }
        public string Periodo { get;  set; }
        public double Pagamento { get;  set; }

        public static List<Dipendente> GetAllDipendente()
        {
            List<Dipendente> lDipendente = new List<Dipendente>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbEdile"].ToString();
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Dipendenti";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                Dipendente d = new Dipendente();
                d.ID = Convert.ToInt32(reader["IdDipendente"]);
                d.Nome = reader["Nome"].ToString();
                d.Cognome = reader["Cognome"].ToString();
                d.Indirizzo = reader["Indirizzo"].ToString();
                d.CF = reader["CodiceFiscale"].ToString();
                d.Coniugato = Convert.ToBoolean(reader["Coniugato"]);
                d.Figli = Convert.ToInt32(reader["NumeroDiFigli"]);
                d.Mansione = reader["Mansione"].ToString();

                lDipendente.Add(d);

            }
            connection.Close();

            return lDipendente;
        }
        
        public static Dipendente GetDipendente(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbEdile"].ToString();
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "SelezionaDipendente";
            command.Connection = connection;

            command.Parameters.AddWithValue("ID", id);

            SqlDataReader reader= command.ExecuteReader();

            Dipendente d = new Dipendente();
            while (reader.Read())
            {
                d.Nome = reader["Nome"].ToString();
                d.Cognome = reader["Cognome"].ToString();
                d.Indirizzo = reader["Indirizzo"].ToString();
                d.CF = reader["CodiceFiscale"].ToString();
                d.Coniugato = Convert.ToBoolean(reader["Coniugato"]);
                d.Figli = Convert.ToInt32(reader["NumeroDiFigli"]);
                d.Mansione = reader["Mansione"].ToString();
                d.StipendioAcconto = Convert.ToBoolean(reader["StipendioAcconto"]);
                d.Periodo = reader["PeriodoDiPagamento"].ToString();
                d.Pagamento = Convert.ToDouble(reader["Pagamento"]);
            }
            connection.Close();
            return d;

        }

        
    }

}