using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using ClassAccesoDatos;
using ClassEntidades;

namespace ClassLogicaNegocios
{
    public class LogicaNegocios_ramaAlisonA
    {
        //Cadena de conexión.
        private AccesoDatos cadconex = new AccesoDatos(@"Data Source=LAPTOP-99LGH8E7\SQLEXPRESS; Initial Catalog=Bitacora2021LabsUTP; Integrated Security=true;");

        //Insertar_PerfilProfe.
        public Boolean Insertar_PerfilProfe(PerfilProfe nuevo_perfilprofe, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[5];
            param1[0] = new SqlParameter
            {
                ParameterName = "f_profe",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevo_perfilprofe.f_profe
            };
            param1[1] = new SqlParameter
            {
                ParameterName = "f_grado",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevo_perfilprofe.f_grado
            };
            param1[2] = new SqlParameter
            {
                ParameterName = "estado",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = nuevo_perfilprofe.estado
            };
            param1[3] = new SqlParameter
            {
                ParameterName = "fecha_obtencion",
                SqlDbType = SqlDbType.Date,
                Direction = ParameterDirection.Input,
                Value = nuevo_perfilprofe.fecha_obtencion
            };
            param1[4] = new SqlParameter
            {
                ParameterName = "evidencia",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = nuevo_perfilprofe.evidencia
            };
            string sentenciaSql = "insert into PerfilProfe values(@f_profe,@f_grado,@estado,@fecha_obtencion,@evidencia);";

            Boolean salida = false;
            salida = cadconex.ModificaBDMasSegura(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }//Fin Insertar_PerfilProfe.

        //Actualizar_PerfilProfe.
        public string Actualizar_PerfilProfe(int F_profe, int F_grado, string estado, DateTime fecha_obtencion, string evidencia, string evidenciaN, ref string msjSalida)
        {
            string sentenciaSql = "update PerfilProfe set F_Profe='" + F_profe + "' ,  F_Grado='" + F_grado + "', Estado='" + estado + "'," +
             " FechaObtencion='" + fecha_obtencion + "', Evidencia='" + evidencia + "'where evidencia='" + evidenciaN + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Actualizar_PerfilProfe.

        //Eliminar_PerfilProfe.
        public string Eliminar_PerfilProfe(string evidenciaN, ref string msjSalida)
        {
            string sentenciaSql = "delete from  PerfilProfe where Evidencia='" + evidenciaN + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Eliminar_PerfilProfe.

        //Mostrar datos de la tabla Profesor.
        public List<Profesor> MostrarDatos_Profesor(ref string msjSalida)
        {
            SqlConnection conex = null;
            string query = "select * from Profesor";

            conex = cadconex.AbrirConexion(ref msjSalida);

            SqlDataReader datos = null;
            datos = cadconex.ConsultaReader(query, conex, ref msjSalida);

            List<Profesor> listaProfe = new List<Profesor>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaProfe.Add(new Profesor
                    {
                       id_profe = (int)datos[0],
                       nombre = datos[1].ToString(),
                    }
                     );
                }
            }
            else
            {
                listaProfe = null;
            }
            conex.Close();
            conex.Dispose();

            return listaProfe;
        }//Mostrar datos de la tabla Profesor.

        //Mostrar datos de la tabla GradoEspecialidad.
        public List<GradoEspecialidad> MostrarDatos_GradoEspecialidad(ref string msjSalida)
        {
            SqlConnection conex = null;
            string query = "select * from GradoEspecialidad";

            conex = cadconex.AbrirConexion(ref msjSalida);

            SqlDataReader datos = null;
            datos = cadconex.ConsultaReader(query, conex, ref msjSalida);

            List<GradoEspecialidad> listaGradoE = new List<GradoEspecialidad>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaGradoE.Add(new GradoEspecialidad
                    {
                        id_grado = (int)datos[0],
                        institucion = datos[1].ToString(),
                    }
                     );
                }
            }
            else
            {
                listaGradoE = null;
            }
            conex.Close();
            conex.Dispose();

            return listaGradoE;
        }//Mostrar datos de la tabla GradoEspecialidad.
    }
}
