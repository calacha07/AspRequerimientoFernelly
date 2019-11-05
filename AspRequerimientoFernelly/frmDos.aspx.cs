using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspRequerimientoFernelly
{
    public partial class frmDos : System.Web.UI.Page
    {

        Dato dato = new Dato();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCargarTodo_Click(object sender, EventArgs e)
        {

            lstCategoria.DataSource = dato.consulta();
            lstCategoria.DataValueField = "CodCat";
            lstCategoria.DataTextField = "NomCat";
            lstCategoria.DataBind();

            GridProducto.DataSource = dato.consultaPro().Tables[0].DefaultView;
            GridProducto.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("Index.aspx");
        }
    }
}