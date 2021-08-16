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
    public partial class AsignaProfeMateriaCuatri : System.Web.UI.Page
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
                dlprofesor.SelectedValue = (string)Session["profeActualizado"];
                dlmateria.SelectedValue = (string)Session["materiaActualizado"];
                dlgrupocuatri.SelectedValue = (string)Session["grupoActualizado"];
                txtextra.Text = (string)Session["extraActualizado"];
            }
            else
            {
                ob2 = (LogicaNegocios_ramaAlisonA)Session["ob2"];
            }
        }

        //btn_InsertarAsignaProfeMateriaCuatri.
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (dlprofesor.Text != "" && dlmateria.Text != "" && dlgrupocuatri.Text != "" && txtextra.Text != "")
            {
                AsignaProfeMateriaCuatrimestre temp = new AsignaProfeMateriaCuatrimestre()
                {
                    f_profe = Convert.ToInt16(dlprofesor.SelectedValue),
                    f_materia = Convert.ToInt16(dlmateria.SelectedValue),
                    f_grupocuatri = Convert.ToInt16(dlgrupocuatri.SelectedValue),
                    extra = txtextra.Text
                };
                string mensaje = "";
                ob2.Insertar_AsignaProfeMateriaCuatri(temp, ref mensaje);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Insertado correctamente!','" + mensaje + "','success')", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Error!','Verificar que todos los campos sean llenados correctamente','error')", true);
            }
        }//btn_InsertarAsignaProfeMateriaCuatri.

        //btn_ActualizarAsignaProfeMateriaCuatri.
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Session["profe"] = dlprofesor.SelectedValue;
            Session["materia"] = dlmateria.SelectedValue;
            Session["grupo"] = dlgrupocuatri.SelectedValue;
            Session["extra"] = txtextra.Text;

            Response.Redirect("Actualizar_RegistroAsignaProfeCuatrimestre.aspx");

        }//btn_ActualizarAsignaProfeMateriaCuatri.

        //btn_EliminarAsignaProfeMateriaCuatri.
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            ob2.Eliminar_AsignaProfeMateriaCuatri(txtextra.Text, ref mensaje);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Eliminación correcta!','Los datos han sido eliminados.','success')", true);
        }//btn_EliminarAsignaProfeMateriaCuatri.

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

        protected void btnSig_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mostrar_PerfilProfesor.aspx");
        }
    }
}