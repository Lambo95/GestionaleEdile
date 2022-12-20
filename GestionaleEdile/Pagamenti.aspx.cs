using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionaleEdile
{
    public partial class Pagamenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Emolumenti.GetAllEmolumenti();
            GridView1.DataBind();
        }
    }
}