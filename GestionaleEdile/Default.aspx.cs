using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionaleEdile
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Dipendente.GetAllDipendente();
            GridView1.DataBind();
        }
    }
}