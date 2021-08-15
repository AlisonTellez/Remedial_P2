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
    public partial class Actualizar_RegistroProfesor : System.Web.UI.Page
    {
        LogicaNegocios ob1 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ob1 = new LogicaNegocios();
                Session["ob1"] = ob1;
                Mostrar();
                txtregisempleado.Text = (string)Session["registro"];
                txtnombre.Text = (string)Session["nombre"];
                txtapp.Text = (string)Session["App"];
                txtapm.Text = (string)Session["Apm"];
                txtcategoria.Text = (string)Session["categoria"];
                txtcorreo.Text = (string)Session["correo"];
                txtcelular.Text = (string)Session["celular"];
            }
            else
            {
                ob1 = (LogicaNegocios)Session["ob1"];
            }
        }

        //btn_Actualizar_RegistroProfesor.
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            ob1.Actualizar_Profesor(Convert.ToInt16(txtregisempleado.Text), txtnombre.Text, txtapp.Text, txtapm.Text, dlgenero.SelectedValue,
                txtcategoria.Text, txtcorreo.Text, txtcelular.Text, Convert.ToInt16(dlestadocivil.SelectedValue), txtnombre.Text = (string)Session["nombre"] , ref mensaje);

            Response.Redirect("RegistrarProfe.aspx");
        }//btn_Actualizar_RegistroProfesor.

        //Mostrar datos EstadoCivil.
        public void Mostrar()
        {
            List<EstadoCivil> listaEstadoCivil = null;
            string mensaje = "";
            listaEstadoCivil = ob1.MostrarDatos_EstadoCivil(ref mensaje);

            if (listaEstadoCivil != null)
            {
                dlestadocivil.Items.Clear();

                foreach (EstadoCivil i in listaEstadoCivil)
                {
                    dlestadocivil.Items.Add(new ListItem(i.estado, i.id_edo.ToString()));
                }
            }
        }//Mostrar datos EstadoCivil.
    }
}