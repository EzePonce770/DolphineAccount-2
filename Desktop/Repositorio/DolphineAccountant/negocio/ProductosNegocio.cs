using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dominio;


namespace negocio
{
     public class ProductosNegocio
    {
        public List<producto> listar()
        {
            List<producto> lista = new List<producto>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=Negocio; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Nombre, Descripcion, Marca, Precio, Stock from MERCAD";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    producto aux = new producto();
                    aux.Nombre = lector.GetString(0);
                    aux.Descripcion = lector.GetString(1);
                    aux.Marca = lector.GetString(2);
                    aux.Precio = lector.GetDouble(3);
                    aux.Stock = lector.GetInt32(4);


                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void agregar(producto nuevo)
        {
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into MERCAD (Nombre, Descripcion, Marca, Precio, Stock) values ('" + nuevo.Nombre + "','" +nuevo.Descripcion + "',' " +nuevo.Marca+ " ',"+nuevo.Precio+ ","+nuevo.Stock+")");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }

        }

        public void modificar(producto modificar) { }


    }
}

