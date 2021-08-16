using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassEntidades;
using ClassLogicaNegocios;

namespace WebCapaPresentacion
{
    public partial class Actualizar_RegistroGradoEspecialidad : System.Web.UI.Page
    {
        LogicaNegocios ob1 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ob1 = new LogicaNegocios();
                Session["ob1"] = ob1;
                txttitulo.Text = Session["titulo"].ToString();
                txtinstitucion.Text = Session["institucion"].ToString();
                txtpais.Text = Session["pais"].ToString();
                txtextra.Text = Session["extra"].ToString();
            }
            else
            {
                ob1 = (LogicaNegocios)Session["ob1"];
            }
        }

        //btn_Actualizar_RegistroGradoEspecialidad.
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            ob1.Actualizar_GradoEspecialidad(txttitulo.Text, txtinstitucion.Text, txtpais.Text, txtextra.Text, txtextra.Text = (string)Session["extra"], ref mensaje);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Actualización correcta!','Los datos han sido actualizados.','success')", true);
            Response.Redirect("RegistrarGradoEspecialidad.aspx");
        }//btn_Actualizar_RegistroGradoEspecialidad.
    }
}