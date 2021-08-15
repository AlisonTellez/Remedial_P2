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
    public partial class RegistrarProfe : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtregisempleado.Text != "" && txtnombre.Text != "" && txtapp.Text != "" && txtapm.Text != "" && dlgenero.Text != ""
                && txtcategoria.Text != "" && txtcorreo.Text != "" && txtcelular.Text != "" && dlestadocivil.Text != "")
            {
                Profesor temp = new Profesor()
                {
                    registro_empleado = Convert.ToInt16(txtregisempleado.Text),
                    nombre = txtnombre.Text,
                    ap_pat = txtapp.Text,
                    ap_mat = txtapm.Text,
                    genero = dlgenero.SelectedValue,
                    categoria = txtcategoria.Text,
                    correo = txtcorreo.Text,
                    celular = txtcelular.Text,
                    f_edocivil = Convert.ToInt16(dlestadocivil.SelectedValue)
                };

                string mensaje = "";
                ob1.Insertar_Profesor(temp, ref mensaje);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensaje2", "msbox('¡Error!','Inserte todos los datos','error')", true);
            }

        }

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
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            Session["registro"] = txtregisempleado.Text;
            Session["nombre"] = txtnombre.Text;
            Session["App"] = txtapp.Text;
            Session["Apm"] = txtapm.Text;
            Session["categoria"] = txtcategoria.Text;
            Session["correo"] = txtcorreo.Text;
            Session["celular"] = txtcelular.Text;

            Response.Redirect("Actualizar_RegistroProfesor.aspx");

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            ob1.Eliminar_Profesor(txtnombre.Text, ref mensaje);
            txtregisempleado.Text = "";
            txtnombre.Text = "";
            txtapp.Text = "";
            txtapm.Text = "";
            dlgenero.Text = "";
            txtcategoria.Text = "";
            txtcorreo.Text = "";
            txtcelular.Text = "";
        }
    }
}