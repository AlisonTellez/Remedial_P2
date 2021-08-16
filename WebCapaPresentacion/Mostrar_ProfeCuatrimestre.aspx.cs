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
    public partial class Mostrar_ProfeCuatrimestre : System.Web.UI.Page
    {
        LogicaNegocios ob1 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ob1 = new LogicaNegocios();
                Session["ob1"] = ob1;
                MostrarP();
                MostrarCuatri();
            }
            else
            {
                ob1 = (LogicaNegocios)Session["ob1"];
            }
        }        

        //btnmostprofcuatri_(Mostrar_ProfeCuatrimestre).
        protected void btnmostprofcuatri_Click(object sender, EventArgs e)
        {
            string msj = "";
            GridView1.DataSource = ob1.MostrarBitacora(dlselecprofesor.SelectedValue,dlseleccuatrimestre.SelectedValue, ref msj);
            GridView1.DataBind();
        }//btnmostprofcuatri_(Mostrar_ProfeCuatrimestre).

        //Mostrar datos Profesor.
        public void MostrarP()
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

        //Mostrar datos Cuatrimestre.
        public void MostrarCuatri()
        {
            List<Cuatrimestre> listaCuatrimestre = null;
            string mensaje = "";
            listaCuatrimestre = ob1.MostrarDatos_Cuatrimestre(ref mensaje);

            if (listaCuatrimestre != null)
            {
                dlseleccuatrimestre.Items.Clear();

                foreach (Cuatrimestre i in listaCuatrimestre)
                {
                    dlseleccuatrimestre.Items.Add(new ListItem(i.periodo));
                }
            }
        }//Mostrar datos Cuatrimestre.
    }
}