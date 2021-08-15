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
        } // Fin Insertar_Profesor.

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
    }
}
