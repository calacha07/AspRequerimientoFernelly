using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;
using System.Data;
namespace AspRequerimientoFernelly
{
    public partial class frmCuatro : System.Web.UI.Page
    {

        Dato dato = new Dato();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                btnCargarTodo.Enabled = false;
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            object jsonObj = JsonConvert.SerializeObject(dato.consulta());
            string newjson = jsonObj.ToString();
            File.WriteAllText(@"C:\Users\usuario\source\repos\AspRequerimientoFernelly\AspRequerimientoFernelly\jsonCategoria.json", newjson);

            object jsonObj1 = JsonConvert.SerializeObject(dato.consultaPro());
            string newjson1 = jsonObj.ToString();
            File.WriteAllText(@"C:\Users\usuario\source\repos\AspRequerimientoFernelly\AspRequerimientoFernelly\jsonProducto.json", newjson1);
            btnCargarTodo.Enabled = true;







        }

        protected void btnCargarTodo_Click(object sender, EventArgs e)
        {
            string dato = File.ReadAllText(Server.MapPath("jsonCategoria.json"));

            DataSet tabla = (DataSet)JsonConvert.DeserializeObject(dato, typeof(DataSet));
            lstCategoria.DataSource = tabla;
            lstCategoria.DataValueField = "CodCat";
            lstCategoria.DataTextField = "NomCat";
            lstCategoria.DataBind();



            string dato1 = File.ReadAllText(Server.MapPath("jsonProducto.json"));

            DataSet tabla1 = (DataSet)JsonConvert.DeserializeObject(dato, typeof(DataSet));
            GridProducto.DataSource= tabla1;
       
           GridProducto.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}