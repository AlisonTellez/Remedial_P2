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
    public partial class Actualizar_RegistroPerfilProfe : System.Web.UI.Page
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
                txtestado.Text = (string)Session["estado"];
                txtevidencia.Text = (string)Session["evidencia"];
            }
            else
            {
                ob1 = (LogicaNegocios)Session["ob1"];
            }
        }

        //btn_Actualizar_RegistroPerfilProfe.
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            ob1.Actualizar_PerfilProfe(Convert.ToInt16(dlprofesor.SelectedValue), Convert.ToInt16(dlgrado.SelectedValue), txtestado.Text, Calendar1.SelectedDate.ToShortDateString() , txtevidencia.Text, txtevidencia.Text = (string)Session["evidencia"], ref mensaje);

            Response.Redirect("RegistrarPerfilProfe.aspx");
        }//btn_Actualizar_RegistroPerfilProfe.

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
    }
}