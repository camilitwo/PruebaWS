using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumoPrueba
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReferenciaAutosWS.WebService1SoapClient ws = new ReferenciaAutosWS.WebService1SoapClient();

            DataTable dt = ws.listarAutos();
            gv_datos.DataSource = dt;
            gv_datos.DataBind();

            List<ReferenciaAutosWS.AutoDTO> auto = ws.listarAutosObjeto().ToList();

            gv_datos2.DataSource = auto;
            gv_datos2.DataBind();

        }
    }
}