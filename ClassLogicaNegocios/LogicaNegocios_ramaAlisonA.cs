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
        private AccesoDatos obAcc = new AccesoDatos(@"Data Source=LAPTOP-99LGH8E7\SQLEXPRESS; Initial Catalog=Bitacora2021LabsUTP; Integrated Security=true;");

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
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }//Fin Insertar_PerfilProfe.
    }
}
