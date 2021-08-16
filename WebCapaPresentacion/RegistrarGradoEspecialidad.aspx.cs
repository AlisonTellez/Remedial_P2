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
    public partial class RegistrarGradoEspecialidad : System.Web.UI.Page
    {
        LogicaNegocios ob1 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ob1 = new LogicaNegocios();
                Session["ob1"] = ob1;
                txttitulo.Text = (string)Session["tituloActualizado"];
                txtinstitucion.Text = (string)Session["institucionActualizado"];
                txtpais.Text = (string)Session["paisActualizado"];
                txtextra.Text = (string)Session["extraActualizado"];
            }
            else
            {
                ob1 = (LogicaNegocios)Session["ob1"];
            }
        }

        //btn_InsertarGradoEspecialidad.
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txttitulo.Text != "" && txtinstitucion.Text != "" && txtpais.Text != "" && txtextra.Text != "")
            {
                GradoEspecialidad temp = new GradoEspecialidad()
                {
                    titulo = txttitulo.Text,
                    institucion = txtinstitucion.Text,
                    pais = txtpais.Text,
                    extra = txtextra.Text,
                };
                string mensaje = "";
                ob1.Insertar_GradoEspecialidad(temp, ref mensaje);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Insertado correctamente!','" + mensaje + "','success')", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Error!','Verificar que todos los campos sean llenados correctamente','error')", true);
            }
        }//btn_InsertarGradoEspecialidad.

        //btn_ActualizarGradoEspecialidad.
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Session["titulo"] = txttitulo.Text;
            Session["institucion"] = txtinstitucion.Text;
            Session["pais"] = txtpais.Text;
            Session["extra"] = txtextra.Text;

            Response.Redirect("Actualizar_RegistroGradoEspecialidad.aspx");
        }//btn_ActualizarGradoEspecialidad.

        //btn_EliminarGradoEspecialidad.
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            ob1.Eliminar_GradoEspecialidad(txtextra.Text, ref mensaje);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Eliminación correcta!','Los datos han sido eliminados.','success')", true);
           
        }//btn_EliminarGradoEspecialidad.

        protected void btnSig_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarPerfilProfe.aspx");
        }
    }
}