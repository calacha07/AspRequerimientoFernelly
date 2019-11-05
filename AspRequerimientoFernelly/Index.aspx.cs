using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AspRequerimientoFernelly
{

    
    public partial class Index : System.Web.UI.Page
    {

        Dato dato = new Dato();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCargarTodo_Click(object sender, EventArgs e)
        {



            //ds1.ReadXml(Server.MapPath("categoria.xml"));
            // ds2.ReadXml(Server.MapPath("Producto.xml"));

            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            ds1 = dato.consulta();
            ds1.WriteXml(@"C:\Users\usuario\source\repos\AspRequerimientoFernelly\AspRequerimientoFernelly\categoria.xml");

            ds1.ReadXml(Server.MapPath("categoria.xml"));

            lstCategoria.DataSource = ds1;
            lstCategoria.DataValueField = "CodCat";
            lstCategoria.DataTextField = "NomCat";
            lstCategoria.DataBind();



            ds2 = dato.consultaPro();
            ds1.WriteXml(@"C:\Users\usuario\source\repos\AspRequerimientoFernelly\AspRequerimientoFernelly\Producto.xml");

            ds1.ReadXml(Server.MapPath("Producto.xml"));
            GridProducto.DataSource = ds2;
           GridProducto.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmDos.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmTres.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCuatro.aspx");
        }
    }
}