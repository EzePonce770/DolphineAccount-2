using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dominio;

namespace negocio
{
    public class TipoNegocio
    {

        public List<Tipo> listar()
        {
            List<Tipo> lista = new List<Tipo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("Select Numero, Descripcion From Tipo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tipo aux = new Tipo();
                    aux.Id = (int)datos.Lector["Numero"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
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

    }
}

