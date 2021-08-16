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
    public partial class Mostrar_PerfilProfesor : System.Web.UI.Page
    {
        LogicaNegocios ob1 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ob1 = new LogicaNegocios();
                Session["ob1"] = ob1;
                Mostrar();
            }
            else
            {
                ob1 = (LogicaNegocios)Session["ob1"];
            }
        }

        //btnmostprofesor_(Mostrar_PerfilProfesor).
        protected void btnmostprofesor_Click(object sender, EventArgs e)
        {
            string msj = "";
            GridView1.DataSource = ob1.MostrarPerfilProfe(dlselecprofesor.SelectedValue, ref msj);
            GridView1.DataBind();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "msj1", "Alerta('¡Datos mostrados correctamente!','Los datos han sido mostrados.','success')", true);
        }//btnmostprofesor_(Mostrar_PerfilProfesor).

        //Mostrar datos Profesor.
        public void Mostrar()
        {
            List<Profesor> listaProfesor = null;
            string mensaje = "";
            listaProfesor = ob1.MostrarDatos_Profesor(ref mensaje);

            if (listaProfesor != null)
            {
                dlselecprofesor.Items.Clear();

                foreach (Profesor i in listaProfesor)
                {
                    dlselecprofesor.Items.Add(new ListItem(i.nombre));
                }
            }
        }//Mostrar datos Profesor.

        protected void btnSig_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mostrar_ProfeCuatrimestre.aspx");
        }
    }
}