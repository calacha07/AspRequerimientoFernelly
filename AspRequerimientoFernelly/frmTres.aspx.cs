using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AspRequerimientoFernelly
{
    public partial class frmTres : System.Web.UI.Page
    {

        Dato dato = new Dato();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) {
           
            lstCategoria.DataSource = dato.consulta();
            lstCategoria.DataValueField = "CodCat";
            lstCategoria.DataTextField = "NomCat";
            lstCategoria.DataBind();


            GridProducto.DataSource = dato.consultaInner(Convert.ToInt32(lstCategoria.SelectedValue)).Tables[0].DefaultView;
            GridProducto.DataBind();

            }
        }

        protected void btnCargarTodo_Click(object sender, EventArgs e)
        {

          

        
        }

        protected void lstCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridProducto.DataSource = dato.consultaInner(Convert.ToInt32(lstCategoria.SelectedValue)).Tables[0].DefaultView;
            GridProducto.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}