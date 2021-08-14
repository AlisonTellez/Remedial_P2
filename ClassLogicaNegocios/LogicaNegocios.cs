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
        private AccesoDatos obAcc = new AccesoDatos(@"Data Source=LAPTOP-99LGH8E7\SQLEXPRESS; Initial Catalog=Bitacora2021LabsUTP; Integrated Security=true;");

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
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

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
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }//Fin Insertar_GradoEspecialidad.

    }
}
