﻿using DocumentFormat.OpenXml.Office2010.Excel;
using Proyecto1.Clases;
using Proyecto1.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto1
{
    internal class VentaController
    {
        public static string cadenaConexion = "Data Source=DESKTOP-HPHJBO6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Venta> obtenerVentas(long id)
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Venta WHERE IdUsuario=@idUsuario", conn);

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

                        ventas.Add(producto);
                    }
                }
            }
            return ventas;
        }
    }
}

