using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestionaleEdile
{
    public class Emolumenti
    {   
        List<Emolumenti> listaEmolumenti = new List<Emolumenti> ();

        public int IdEmolumenti { get; set; }
        public bool StipendioAcconto { get; set; }
        public string Periodo { get; set; }
        public double Pagamento { get; set; }

        public static List<Emolumenti> GetAllEmolumenti()
        {
            List<Emolumenti> lEmolumenti = new List<Emolumenti>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbEdile"].ToString();
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Emolumenti ORDER BY PeriodoDiPagamento Asc";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                Emolumenti e = new Emolumenti();
            //  e.IdEmolumenti = Convert.ToInt32( reader["IdPagamento"]);
                e.StipendioAcconto = Convert.ToBoolean(reader["StipendioAcconto"]);
                e.Periodo = reader["PeriodoDiPagamento"].ToString();
                e.Pagamento = Convert.ToDouble(reader["Pagamento"]);

                lEmolumenti.Add(e);

            }
            connection.Close();

            return lEmolumenti;
        }

    }
}