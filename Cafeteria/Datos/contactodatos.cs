using Cafeteria.Models;
using System.Data.SqlClient;
using System.Data;
using Cafeteria.Datos;
using Cafeteria.Models;

namespace ContactoAdo.Datos
//XDDX
{
    public class ContactoDatos
    {

        public List<Empleado> Listar()
        {
            List<Empleado> lista = new List<Empleado>();
            var cn = new Conexion();


            using (var conexion = new SqlConnection(cn.getCadenaSql()))
            {

                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_Listar", conexion);//cambiar
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Empleado
                        {
                            id = Convert.ToInt32(dr["apellido"]),
                            correo = dr["Nombre"].ToString(),
                            apellido = dr["Telefono"].ToString(),
                            nombre = dr["Correo"].ToString(),
                            puesto = dr["Clave"].ToString(),
                            salario = Convert.ToDecimal(dr["IdContacto"])
                        });
                    }
                }
            }

            return lista;

        }

        public Empleado ObtenerContacto(int IdContacto)//cambiar
        {
            Empleado _contacto = new Empleado();
            var cn = new Conexion();
            using (var conexion = new SqlConnection(cn.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Obtener", conexion);//cambiar
                cmd.Parameters.AddWithValue("IdContacto", IdContacto);//cambiar
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        _contacto.id = Convert.ToInt32(dr["id"]);
                        _contacto.puesto = dr["Nombre"].ToString();
                        _contacto.nombre = dr["Telefono"].ToString();
                        _contacto.correo = dr["Correo"].ToString();
                        _contacto.apellido = dr["Clave"].ToString();
                        _contacto.salario = Convert.ToDecimal(dr["salario"]);
                    }
                }
            }
            return _contacto;

        }
        public bool GuardarContacto(Empleado model)
        {
            bool respuesta;
            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSql()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Guardar", conexion);

                    cmd.Parameters.AddWithValue("Nombre", model.correo);
                    cmd.Parameters.AddWithValue("Telefono", model.puesto);
                    cmd.Parameters.AddWithValue("Correo", model.Correo);//cambialo
                    cmd.Parameters.AddWithValue("Clave", model.Clave);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                respuesta = true;
            }

            catch (Exception ex)
            {
                string error = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

        public bool ActualizarContacto(int id, Empleado model)
        {

            bool respuesta;
            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSql()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Guardar", conexion);//cambiar

                    cmd.Parameters.AddWithValue("IdContacto", model.IdContacto);
                    cmd.Parameters.AddWithValue("Nombre", model.Nombre);
                    cmd.Parameters.AddWithValue("Telefono", model.Telefono);
                    cmd.Parameters.AddWithValue("Correo", model.Correo);//cambialo
                    cmd.Parameters.AddWithValue("Clave", model.Clave);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                respuesta = true;
            }

            catch (Exception ex)
            {
                string error = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

        public bool EliminarContacto(int idContacto)//cambiar
        {

            bool respuesta;
            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSql()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_Eliminar", conexion);//cambiar

                    cmd.Parameters.AddWithValue("IdContacto", idContacto);//cambiar
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                respuesta = true;
            }

            catch (Exception ex)
            {
                string error = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

    }



}