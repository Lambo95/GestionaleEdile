using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebGrease.Activities;

namespace GestionaleEdile
{
    public partial class DettagliDipendente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( Request.QueryString["IdDipendente"]);

           Dipendente d = Dipendente.GetDipendente(id);
            lblNome.Text = $"{d.Nome} {d.Cognome}";
            lblIndirizzo.Text = d.Indirizzo;
            lblCf.Text = d.CF;
            lblConiugato.Text = d.Coniugato.ToString();
            lblFigli.Text = d.Figli.ToString();
            lblMansione.Text = d.Mansione;
            lblStip.Text = d.StipendioAcconto.ToString();
            lblDate.Text = d.Periodo;
            lblPag.Text=d.Pagamento.ToString("c2");
        }

        protected void NuovoPagamento_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["IdDipendente"]);

            Dipendente d = Dipendente.GetDipendente(id);
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DbEdile"].ToString();
                connection.Open(); ;

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "AggiungiPagamento";
                command.Connection = connection;

                command.Parameters.AddWithValue("IdDipendente", id);
                command.Parameters.AddWithValue("PeriodoDiPagamento", txtPeriodo.Text);
                command.Parameters.AddWithValue("Pagamento", txtSottotitolo.Text);

                if (ckbStipendio.Checked)
                {
                    command.Parameters.AddWithValue("StipendioAcconto", true);
                }
                else
                {
                    command.Parameters.AddWithValue("StipendioAcconto", false);
                }

                int row = command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                lblError.Visible = true; lblError.Text = "Errore nell'aggiungere il pagamento";
            }
            
        }
    }
}