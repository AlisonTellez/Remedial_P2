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
    public class LogicaNegocios
    {
        //Cadena de conexión.
        private AccesoDatos cadconex = new AccesoDatos(@"Data Source=LAPTOP-99LGH8E7\SQLEXPRESS; Initial Catalog=Bitacora2021LabsUTP; Integrated Security=true;");

        //Insertar_Profesor.
        public Boolean Insertar_Profesor(Profesor nuevo_profesor, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[9];
            param1[0] = new SqlParameter
            {
                ParameterName = "registro_empleado",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevo_profesor.registro_empleado
            };
            param1[1] = new SqlParameter
            {
                ParameterName = "nombre",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = nuevo_profesor.nombre
            };
            param1[2] = new SqlParameter
            {
                ParameterName = "ap_pat",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Direction = ParameterDirection.Input,
                Value = nuevo_profesor.ap_pat
            };
            param1[3] = new SqlParameter
            {
                ParameterName = "ap_mat",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Direction = ParameterDirection.Input,
                Value = nuevo_profesor.ap_mat
            };
            param1[4] = new SqlParameter
            {
                ParameterName = "genero",
                SqlDbType = SqlDbType.VarChar,
                Size = 10,
                Direction = ParameterDirection.Input,
                Value = nuevo_profesor.genero
            };
            param1[5] = new SqlParameter
            {
                ParameterName = "categoria",
                SqlDbType = SqlDbType.VarChar,
                Size = 5,
                Direction = ParameterDirection.Input,
                Value = nuevo_profesor.categoria
            };
            param1[6] = new SqlParameter
            {
                ParameterName = "correo",
                SqlDbType = SqlDbType.VarChar,
                Size = 200,
                Direction = ParameterDirection.Input,
                Value = nuevo_profesor.correo
            };
            param1[7] = new SqlParameter
            {
                ParameterName = "celular",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevo_profesor.celular
            };
            param1[8] = new SqlParameter
            {
                ParameterName = "f_edocivil",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevo_profesor.f_edocivil
            };
            string sentenciaSql = "insert into Profesor values(@registro_empleado,@nombre,@ap_pat,@ap_mat,@genero,@categoria,@correo,@celular,@f_edocivil);";

            Boolean salida = false;
            salida = cadconex.ModificaBDMasSegura(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }//Fin Insertar_Profesor.

        //Insertar_GradoEspecialidad.
        public Boolean Insertar_GradoEspecialidad(GradoEspecialidad nuevo_gradoespecialidad, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[4];
            param1[0] = new SqlParameter
            {
                ParameterName = "titulo",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = nuevo_gradoespecialidad.titulo
            };
            param1[1] = new SqlParameter
            {
                ParameterName = "institucion",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Direction = ParameterDirection.Input,
                Value = nuevo_gradoespecialidad.institucion
            };
            param1[2] = new SqlParameter
            {
                ParameterName = "pais",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = nuevo_gradoespecialidad.pais
            };
            param1[3] = new SqlParameter
            {
                ParameterName = "extra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = nuevo_gradoespecialidad.extra
            };
            string sentenciaSql = "insert into GradoEspecialidad values(@titulo,@institucion,@pais,@extra);";

            Boolean salida = false;
            salida = cadconex.ModificaBDMasSegura(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }//Fin Insertar_GradoEspecialidad.

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


        //Eliminar_Profesor.
        public string Eliminar_Profesor(string nombre, ref string msjSalida)
        {
            string sentenciaSql = "delete from  Profesor where Nombre='" + nombre + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Eliminar_Profesor.

        //Eliminar_GradoEspecialidad.
        public string Eliminar_GradoEspecialidad(string extraN, ref string msjSalida)
        {
            string sentenciaSql = "delete from  GradoEspecialidad where Extra='" + extraN + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Eliminar_GradoEspecialidad.

        //Eliminar_PerfilProfe.
        public string Eliminar_PerfilProfe(int profeIDN, ref string msjSalida)
        {
            string sentenciaSql = "delete from  PerfilProfe where F_Profe='" + profeIDN + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Eliminar_PerfilProfe.

        //Actualizar_Profesor.
        public string Actualizar_Profesor(int registroN, string nombreN, string apN, string apmN, string generoN, string categoriaN,
            string correoN, string celularN, int F_edoCivilN, string Nombre, ref string msjSalida)
        {
            string sentenciaSql = "update Profesor set RegistroEmpleado='" + registroN + "' ,  Nombre='" + nombreN + "', Ap_pat='" + apN + "'," +
             " Ap_Mat='" + apmN + "', Genero='" + generoN + "', Categoria='" + categoriaN + "', Correo='" + correoN + "', Celular='" + celularN + "', " +
             "F_EdoCivil='" + F_edoCivilN + "'where nombre='" + Nombre + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Actualizar_Profesor.

        //Actualizar_GradoEspecialidad.
        public string Actualizar_GradoEspecialidad(string titulo, string institucion, string pais, string extra, string extraN, ref string msjSalida)
        {
            string sentenciaSql = "update GradoEspecialidad set Titulo='" + titulo + "' ,  Institucion='" + institucion + "', Pais='" + pais + "'," +
             " Extra='" + extra + "'where Extra='" + extraN + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Actualizar_GradoEspecialidad.

        //Actualizar_PerfilProfe.
        public string Actualizar_PerfilProfe(int F_profe, int F_grado, string estado, string fecha_obtencion, string evidencia, string evidenciaN, ref string msjSalida)
        {
            string sentenciaSql = "update PerfilProfe set F_Profe='" + F_profe + "' ,  F_Grado='" + F_grado + "', Estado='" + estado + "',FechaObtencion='" + fecha_obtencion + "', Evidencia='" + evidencia + "'where Evidencia='" + evidenciaN + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Actualizar_PerfilProfe.

        //Mostrar datos de la tabla EstadoCivil.
        public List<EstadoCivil> MostrarDatos_EstadoCivil(ref string msjSalida)
        {
            SqlConnection conex = null;
            string query = "select * from EstadoCivil";

            conex = cadconex.AbrirConexion(ref msjSalida);

            SqlDataReader datos = null;
            datos = cadconex.ConsultaReader(query, conex, ref msjSalida);

            List<EstadoCivil> listaEstadoC = new List<EstadoCivil>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaEstadoC.Add(new EstadoCivil
                    {
                        id_edo = (byte)datos[0],
                        estado = datos[1].ToString(),
                        extra = datos[2].ToString()
                    }
                     );
                }
            }
            else
            {
                listaEstadoC = null;
            }
            conex.Close();
            conex.Dispose();

            return listaEstadoC;
        }//Mostrar datos de la tabla EstadoCivil.

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
                        id_profe = (short)datos[0],
                        nombre = datos[2].ToString(),                     
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
                        id_grado = (short)datos[0],
                        titulo = datos[1].ToString(),
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
