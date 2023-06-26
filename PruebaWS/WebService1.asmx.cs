using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using datos;
using mis_clases;

namespace PruebaWS
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataTable listarAutos() {
            return DatosDAO.listarAutos();
        }


        [WebMethod]
        public List<AutoDTO> listarAutosObjeto()
        {
            DataTable dt =  DatosDAO.listarAutos();

            List<AutoDTO> listaAutos = new List<AutoDTO>();
            AutoDTO auto = null;
            foreach (DataRow row in dt.Rows)
            {
                auto = new AutoDTO();
                {
                    auto.Marca = row["MARCA"].ToString();
                    auto.IdPropietario = row["ID_PROPIETARIO"].ToString();
                    auto.Patente = row["PATENTE"].ToString();
                    // Map other properties accordingly
                };

                listaAutos.Add(auto);
            }

            return listaAutos;
        }

    }
}
