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
    public partial class Actualizar_RegistroAsignaProfeCuatrimestre : System.Web.UI.Page
    {
        LogicaNegocios_ramaAlisonA ob2 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ob2 = new LogicaNegocios_ramaAlisonA();
                Session["ob2"] = ob2;
                MostrarP();
                MostrarM();
                MostrarGC();
                txtextra.Text = (string)Session["extra"];
                dlprofesor.SelectedValue = (string)Session["profe"];
                dlmateria.SelectedValue = (string)Session["materia"];
                dlgrupocuatri.SelectedValue = (string)Session["grupo"];
                txtextra.Text = (string)Session["extra"];
            }
            else
            {
                ob2 = (LogicaNegocios_ramaAlisonA)Session["ob2"];
            }
        }

        //btn_Actualizar_RegistroAsignaProfeMateriaCuatri.
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            ob2.Actualizar_AsignaProfeMateriaCuatri(Convert.ToInt16(dlprofesor.SelectedValue), Convert.ToInt16(dlmateria.SelectedValue), Convert.ToInt16(dlgrupocuatri.SelectedValue), txtextra.Text, txtextra.Text = (string)Session["extra"], ref mensaje);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Actualización correcta!','Los datos han sido actualizados.','success')", true);

            Session["profeActualizado"] = dlprofesor.SelectedValue;
            Session["materiaActualizado"] = dlmateria.SelectedValue;
            Session["grupoActualizado"] = dlgrupocuatri.SelectedValue;
            Session["extraActualizado"] = txtextra.Text;

            Response.Redirect("RegistrarAsignaProfeMateriaCuatri.aspx");

        }//btn_Actualizar_RegistroAsignaProfeMateriaCuatri.

        //Mostrar datos Profesor.
        public void MostrarP()
        {
            List<Profesor> listaProfesor = null;
            string mensaje = "";
            listaProfesor = ob2.MostrarDatos_Profesor(ref mensaje);

            if (listaProfesor != null)
            {
                dlprofesor.Items.Clear();

                foreach (Profesor i in listaProfesor)
                {
                    dlprofesor.Items.Add(new ListItem(i.nombre, i.id_profe.ToString()));
                }
            }
        }//Mostrar datos Profesor.

        //Mostrar datos Materia.
        public void MostrarM()
        {
            List<Materia> listaMateria = null;
            string mensaje = "";
            listaMateria = ob2.MostrarDatos_Materia(ref mensaje);

            if (listaMateria != null)
            {
                dlmateria.Items.Clear();

                foreach (Materia i in listaMateria)
                {
                    dlmateria.Items.Add(new ListItem(i.nombre_materia, i.id_materia.ToString()));
                }
            }
        }//Mostrar datos Materia.

        //Mostrar datos GrupoCuatri.
        public void MostrarGC()
        {
            List<GrupoCuatrimestre> listaGrupoCuatri = null;
            string mensaje = "";
            listaGrupoCuatri = ob2.MostrarDatos_GrupoCuatrimestre(ref mensaje);

            if (listaGrupoCuatri != null)
            {
                dlgrupocuatri.Items.Clear();

                foreach (GrupoCuatrimestre i in listaGrupoCuatri)
                {
                    dlgrupocuatri.Items.Add(new ListItem(i.turno, i.id_grucuat.ToString()));
                }
            }
        }//Mostrar datos Materia.
    }
}