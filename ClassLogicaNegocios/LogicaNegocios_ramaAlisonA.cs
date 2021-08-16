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

        //Insertar_AsignaProfeMateriaCuatri.
        public Boolean Insertar_AsignaProfeMateriaCuatri(AsignaProfeMateriaCuatrimestre nuevo_apmc, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[4];
            param1[0] = new SqlParameter
            {
                ParameterName = "f_profe",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevo_apmc.f_profe
            };
            param1[1] = new SqlParameter
            {
                ParameterName = "f_materia",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevo_apmc.f_materia
            };
            param1[2] = new SqlParameter
            {
                ParameterName = "f_grupocuatri",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevo_apmc.f_grupocuatri
            };
            param1[3] = new SqlParameter
            {
                ParameterName = "extra",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = nuevo_apmc.extra
            };
            string sentenciaSql = "insert into AsignaProfeMateriaCuatri values(@f_profe,@f_materia,@f_grupocuatri,@extra);";

            Boolean salida = false;
            salida = cadconex.ModificaBDMasSegura(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }//Fin Insertar_AsignaProfeMateriaCuatri.

        //Actualizar_AsignaProfeMateriaCuatri.
        public string Actualizar_AsignaProfeMateriaCuatri(int F_profe, int F_materia, int F_grupocuatri, string extra, string extraN, ref string msjSalida)
        {
            string sentenciaSql = "update AsignaProfeMateriaCuatri set F_Profe='" + F_profe + "' , F_materia='" + F_materia + "', F_grupocuatri='" + F_grupocuatri + "', Extra='" + extra + "'where extra='" + extraN + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Actualizar_AsignaProfeMateriaCuatri.

        //Eliminar_AsignaProfeMateriaCuatri.
        public string Eliminar_AsignaProfeMateriaCuatri(string extraN, ref string msjSalida)
        {
            string sentenciaSql = "delete from AsignaProfeMateriaCuatri where Extra='" + extraN + "'";

            SqlDataReader salida = null;
            salida = cadconex.ConsultaReader(sentenciaSql, cadconex.AbrirConexion(ref msjSalida), ref msjSalida);

            return salida.ToString();
        }//Fin Eliminar_AsignaProfeMateriaCuatri.

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

        //Mostrar datos de la tabla Materia.
        public List<Materia> MostrarDatos_Materia(ref string msjSalida)
        {
            SqlConnection conex = null;
            string query = "select * from Materia";

            conex = cadconex.AbrirConexion(ref msjSalida);

            SqlDataReader datos = null;
            datos = cadconex.ConsultaReader(query, conex, ref msjSalida);

            List<Materia> listaMateria = new List<Materia>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaMateria.Add(new Materia
                    {
                        id_materia = (short)datos[0],
                        nombre_materia = datos[1].ToString(),
                    }
                     );
                }
            }
            else
            {
                listaMateria = null;
            }
            conex.Close();
            conex.Dispose();

            return listaMateria;
        }//Mostrar datos de la tabla Materia.

        //Mostrar datos de la tabla GrupoCuatrimestre.
        public List<GrupoCuatrimestre> MostrarDatos_GrupoCuatrimestre(ref string msjSalida)
        {
            SqlConnection conex = null;
            string query = "select * from GrupoCuatrimestre";

            conex = cadconex.AbrirConexion(ref msjSalida);

            SqlDataReader datos = null;
            datos = cadconex.ConsultaReader(query, conex, ref msjSalida);

            List<GrupoCuatrimestre> listaGrupoCuatrimestre = new List<GrupoCuatrimestre>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaGrupoCuatrimestre.Add(new GrupoCuatrimestre
                    {
                        id_grucuat = (int)datos[0],
                        turno = datos[4].ToString(),
                    }
                     );
                }
            }
            else
            {
                listaGrupoCuatrimestre = null;
            }
            conex.Close();
            conex.Dispose();

            return listaGrupoCuatrimestre;
        }//Mostrar datos de la tabla GrupoCuatrimestre.
    }
}
