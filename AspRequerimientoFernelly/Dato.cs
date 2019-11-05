using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AspRequerimientoFernelly
{
    public class Dato
    {



        public DataSet consulta()
        {


            try
            {


                SqlConnection conex = new SqlConnection(Properties.Settings.Default.cadena);
                conex.Open();

                SqlCommand comando = new SqlCommand("ConsultaCat", conex);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                da.Fill(ds, "Categoria");



                conex.Close();
                comando.Dispose();

                return ds;




            }
            catch
            {
                throw;

            }

        }



        public DataSet consultaPro()
        {


            try
            {


                SqlConnection conex = new SqlConnection(Properties.Settings.Default.cadena);
                conex.Open();

                SqlCommand comando = new SqlCommand("ConsultaPro", conex);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                da.Fill(ds, "Producto");



                conex.Close();
                comando.Dispose();

                return ds;




            }
            catch
            {
                throw;

            }

        }





        public DataSet consultaInner(int codigo)
        {


            try
            {


                SqlConnection conex = new SqlConnection(Properties.Settings.Default.cadena);
                conex.Open();

                SqlCommand comando = new SqlCommand("ConsultaInner", conex);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cod", SqlDbType.Int).Value = codigo;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                da.Fill(ds, "Producto");



                conex.Close();
                comando.Dispose();

                return ds;




            }
            catch
            {
                throw;

            }

        }
    }
}