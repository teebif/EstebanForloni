using DocumentFormat.OpenXml.Office2010.Excel;
using Proyecto1.Clases;
using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Controladores
{
    public class UsuarioController
    {
        public static string cadenaConexion = "Data Source=DESKTOP-HPHJBO6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Usuario> ObtenerUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Usuario", conn);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    for (var i; i <= reader.Rows.Count; i++)
                    {
                        reader.Read();

                        Usuario usuario = new Usuario();

                        usuario.Id = reader.GetInt32(0);
                        usuario.Nombre = reader.GetString(1);
                        usuario.Apellido = reader.GetString(2);
                        usuario.NombreUsuario = reader.GetString(3);
                        usuario.Contraseña = reader.GetString(4);
                        usuario.Mail = reader.GetString(5);

                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }

        public static Usuario ObtenerUsuario(long id)
        {
            Usuario usuario = new Usuario();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {

                SqlCommand command = new SqlCommand("SELECT * FROM Usuario WHERE Id=@id", conn);

                var parameter = new SqlParameter();
                parameter.ParameterName = "Id";
                parameter.SqlDbType = SqlDbType.BigInt;
                parameter.Value = id;

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    usuario.Id = reader.GetInt32(0);
                    usuario.Nombre = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.NombreUsuario = reader.GetString(3);
                    usuario.Contraseña = reader.GetString(4);
                    usuario.Mail = reader.GetString(5);

                }

            }
            return usuario;
        }
    }

    internal class UsuarioController
    {

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Usuario", conn);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    for (var i; i <= reader.Rows.Count; i++)
                    {
                        reader.Read();

                        Usuario usuario = new Usuario();

                        usuario.Id = reader.GetInt32(0);
                        usuario.Nombre = reader.GetString(1);
                        usuario.Apellido = reader.GetString(2);
                        usuario.NombreUsuario = reader.GetString(3);
                        usuario.Contraseña = reader.GetString(4);
                        usuario.Mail = reader.GetString(5);

                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }

        public static Usuario ObtenerUsuario(long id)
        {
            Usuario usuario = new Usuario();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {

                SqlCommand command = new SqlCommand("SELECT * FROM Usuario WHERE Id=@id", conn);

                var parameter = new SqlParameter();
                parameter.ParameterName = "Id";
                parameter.SqlDbType = SqlDbType.BigInt;
                parameter.Value = Id;

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    usuario.Id = reader.GetInt32(0);
                    usuario.Nombre = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.NombreUsuario = reader.GetString(3);
                    usuario.Contraseña = reader.GetString(4);
                    usuario.Mail = reader.GetString(5);

                }

            }
            return usuario;
        }
    }

    public class ProductoVendidoController
    {


        public static List<ProductoVendido> obtenerProductosVendidos(long idUsuario)
        {
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT IdProducto FROM Venta INNER JOIN ProductoVendido ON Venta.Id = ProductoVendido.IdVenta WHERE IdUsuario = {idUsuario}", conn);

                var parameter = new SqlParameter();
                parameter.ParameterName = "IdUsuario";
                parameter.SqlDbType = SqlDbType.BigInt;
                parameter.Value = IdUsuario;

                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();

                        producto.Id = reader.GetInt64(0);
                        producto.Descripciones = reader.GetString(1);
                        producto.Costo = reader.GetDecimal(2);
                        producto.PrecioVenta = reader.GetDecimal(3);
                        producto.Stock = reader.GetInt32(4);
                        producto.IdUsuario = reader.GetInt64(5);

                        productos.Add(producto);
                    }
                }
            }
            return productosVendidos;
        }
    }

    internal class ProductoController
    {

        public static Producto obtenerProducto(string Descripciones)
        {
            Producto producto = new Producto();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Producto WHERE Descripciones=@Descripciones", conn);

                var parameter = new SqlParameter();
                parameter.ParameterName = "Descripciones";
                parameter.SqlDbType = SqlDbType.String;
                parameter.Value = Descripciones;

                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    producto.Id = reader.GetInt64(0);
                    producto.Descripciones = reader.GetString(1);
                    producto.Costo = reader.GetDecimal(2);
                    producto.PrecioVenta = reader.GetDecimal(3);
                    producto.Stock = reader.GetInt32(4);
                    producto.IdUsuario = reader.GetInt64(5);

                }
            }
            return producto;
        }

        public static List<Producto> obtenerProductos(long id)
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Producto WHERE IdUsuario=@id", conn);

                var parameter = new SqlParameter();
                parameter.ParameterName = "Id";
                parameter.SqlDbType = SqlDbType.BigInt;
                parameter.Value = Id;

                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();

                        producto.Id = reader.GetInt64(0);
                        producto.Descripciones = reader.GetString(1);
                        producto.Costo = reader.GetDecimal(2);
                        producto.PrecioVenta = reader.GetDecimal(3);
                        producto.Stock = reader.GetInt32(4);
                        producto.IdUsuario = reader.GetInt64(5);

                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
    }

    internal class LoginController
    {
        public static string LogIn(string usuarioNombre, string usuarioPass)
        {
            Usuario usuario = new Usuario();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {

                SqlCommand command = new SqlCommand("SELECT * FROM Usuario where NombreUsuario=@usuarioNombre and Contraseña=@usuarioPass", conn);

                var parameterUser = new SqlParameter();
                parameterUser.ParameterName = "nombreUsuario";
                parameterUser.SqlDbType = SqlDbType.VarChar;
                parameterUser.Value = usuarioNombre;

                var parameterPass = new SqlParameter();
                parameterPass.ParameterName = "Contraseña";
                parameterPass.SqlDbType = SqlDbType.VarChar;
                parameterPass.Value = usuarioPass;

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Usuario usuario = new Usuario();

                    reader.Read();

                    usuario.Nombre = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.NombreUsuario = reader.GetString(3);
                    usuario.Mail = reader.GetString(5);
                    Console.WriteLine("Usuario encontrado");
                    return usuario;

                }
                else
                {
                    Console.WriteLine("Usuario no encontrado");
                    return null;
                }
            }
        }
    }


}