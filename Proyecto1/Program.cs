using Proyecto1.Modelos;
using System.Data.SqlClient;
namespace Proyecto1
{ 
            internal class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Hello, World!");

                    List<Usuarios> usuarios = new List<Usuarios>();
                    Usuario usuario = new Usuario();

                    usuarios = UsuarioController.obtenerUsuarios();
                    Console.WriteLine(usuarios[1].Nombre);
                    usuario = UsuarioController.obtenerUsuario(1);
                    Console.WriteLine(usuario.Nombre);


                    List<Producto> productos = new List<Producto>();

                    productos = ProductoController.obtenerProductos(1);
                    Console.WriteLine(productos[1].Descripciones);

                    List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
                    productosVendidos = ProductoVendidoController.obtenerProductosVendidos(1);
                }
            }
}