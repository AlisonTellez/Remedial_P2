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
    public partial class RegistrarPerfilProfe : System.Web.UI.Page
    {
        LogicaNegocios ob1 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ob1 = new LogicaNegocios();
                Session["ob1"] = ob1;
                MostrarP();
                MostrarG();
                txtevidencia.Text = (string)Session["evidencia"];
                dlprofesor.SelectedValue = (string)Session["profeActualizado"];
                dlgrado.SelectedValue = (string)Session["gradoActualizado"];
                txtestado.Text = (string)Session["estadoActualizado"];
                txtevidencia.Text = (string)Session["evidenciaActualizado"];

            }
            else
            {
                ob1 = (LogicaNegocios)Session["ob1"];
            }
        }

        //btn_InsertarPerfilProfe.
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (dlprofesor.Text != "" && dlgrado.Text != "" && txtestado.Text != "" && Calendar1.SelectedDate.ToString() != "" && txtevidencia.Text != "")
            {
                PerfilProfe temp = new PerfilProfe()
                {
                    f_profe = Convert.ToInt16(dlprofesor.SelectedValue),
                    f_grado = Convert.ToInt16(dlgrado.SelectedValue),
                    estado = txtestado.Text,
                    fecha_obtencion = Calendar1.SelectedDate,
                    evidencia = txtevidencia.Text,
                };
                string mensaje = "";
                ob1.Insertar_PerfilProfe(temp, ref mensaje);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Insertado correctamente!','" + mensaje + "','success')", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Error!','Verificar que todos los campos sean llenados correctamente','error')", true);
            }
        }//btn_InsertarPerfilProfe.

        //Mostrar datos Profesor.
        public void MostrarP()
        {
            List<Profesor> listaProfesor = null;
            string mensaje = "";
            listaProfesor = ob1.MostrarDatos_Profesor(ref mensaje);

            if (listaProfesor != null)
            {
                dlprofesor.Items.Clear();

                foreach (Profesor i in listaProfesor)
                {
                    dlprofesor.Items.Add(new ListItem(i.nombre, i.id_profe.ToString()));
                }
            }
        }//Mostrar datos Profesor.

        //Mostrar datos GradoEspecialidad.
        public void MostrarG()
        {
            List<GradoEspecialidad> listaGradoE = null;
            string mensaje = "";
            listaGradoE = ob1.MostrarDatos_GradoEspecialidad(ref mensaje);

            if (listaGradoE != null)
            {
                dlgrado.Items.Clear();

                foreach (GradoEspecialidad i in listaGradoE)
                {
                    dlgrado.Items.Add(new ListItem(i.titulo, i.id_grado.ToString()));
                }
            }
        }//Mostrar datos GradoEspecialidad.

        //btn_ActualizarPerfilProfe.
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Session["profesor"] = dlprofesor.SelectedValue;
            Session["grado"] = dlgrado.SelectedValue;
            Session["estado"] = txtestado.Text;
            Session["evidencia"] = txtevidencia.Text;

            Response.Redirect("Actualizar_RegistroPerfilProfe.aspx");
        }//btn_ActualizarPerfilProfe.

        //btn_EliminarPerfilProfe.
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            ob1.Eliminar_PerfilProfe(Convert.ToInt16(dlprofesor.SelectedValue), ref mensaje);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Eliminación correcta!','Los datos han sido eliminados.','success')", true);
            
        }//btn_EliminarPerfilProfe.

        protected void btnSig_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarAsignaProfeMateriaCuatri.aspx");
        }
    }
}