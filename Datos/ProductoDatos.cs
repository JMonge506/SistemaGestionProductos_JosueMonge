using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.SqlClient;
using SistemaGestionProductos_JosueMonge.Modelos;
using System.Collections.Generic;

namespace SistemaGestionProductos_JosueMonge.Datos
{
    public class ProductoDatos
    {
        private Conexion conexion = new Conexion();

        // Consultar todos los productos
        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta = @"
                    SELECT P.IdProducto, P.Nombre, P.Precio, P.Stock,
                           P.FechaRegistro, P.IdCategoria, C.Nombre AS NombreCategoria
                    FROM Productos P
                    INNER JOIN Categorias C ON P.IdCategoria = C.IdCategoria";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto
                        {
                            IdProducto = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Precio = reader.GetDecimal(2),
                            Stock = reader.GetInt32(3),
                            FechaRegistro = reader.GetDateTime(4),
                            IdCategoria = reader.GetInt32(5),
                            NombreCategoria = reader.GetString(6)
                        };

                        productos.Add(producto);
                    }
                }
            }

            return productos;
        }

        // Registrar un producto
        public void Agregar(Producto producto)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta = @"
                    INSERT INTO Productos
                    (Nombre, Precio, Stock, FechaRegistro, IdCategoria)
                    VALUES
                    (@Nombre, @Precio, @Stock, @FechaRegistro, @IdCategoria)";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@FechaRegistro", producto.FechaRegistro);
                    cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Modificar un producto
        public void Actualizar(Producto producto)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta = @"
                    UPDATE Productos
                    SET Nombre = @Nombre,
                        Precio = @Precio,
                        Stock = @Stock,
                        IdCategoria = @IdCategoria
                    WHERE IdProducto = @IdProducto";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar un producto
        public void Eliminar(int idProducto)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Buscar productos por nombre
        public List<Producto> Buscar(string nombre)
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta = @"
                    SELECT P.IdProducto, P.Nombre, P.Precio, P.Stock,
                           P.FechaRegistro, P.IdCategoria, C.Nombre AS NombreCategoria
                    FROM Productos P
                    INNER JOIN Categorias C ON P.IdCategoria = C.IdCategoria
                    WHERE P.Nombre LIKE @Nombre";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                IdProducto = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Precio = reader.GetDecimal(2),
                                Stock = reader.GetInt32(3),
                                FechaRegistro = reader.GetDateTime(4),
                                IdCategoria = reader.GetInt32(5),
                                NombreCategoria = reader.GetString(6)
                            };

                            productos.Add(producto);
                        }
                    }
                }
            }

            return productos;
        }
    }
}