using DocumentFormat.OpenXml.Office2010.Excel;
using Proyecto1.Clases;
using Proyecto1.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto1
{ 
            internal class Program
            {
                static void Main(string[] args)
                {

                    List<Usuario> usuarios = new List<Usuarios>();
                    Usuario usuario = new Usuario();

                    usuarios = Controllers.UsuarioController.obtenerUsuarios();
                    Console.WriteLine(usuarios[1].Nombre);
                    usuario = Controllers.UsuarioController.obtenerUsuario(1);
                    Console.WriteLine(usuario.Nombre);


                    List<Producto> productos = new List<Producto>();

                    productos = Controllers.obtenerProductos(1);
                    Console.WriteLine(productos[1].Descripciones);

                    List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
                    productosVendidos = Controllers.obtenerProductosVendidos(1);
                }
            }
}

