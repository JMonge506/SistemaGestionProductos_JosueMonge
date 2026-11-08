using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.SqlClient;
using SistemaGestionProductos_JosueMonge.Modelos;
using System.Collections.Generic;

namespace SistemaGestionProductos_JosueMonge.Datos
{
    public class CategoriaDatos
    {
        private Conexion conexion = new Conexion();

        // Consultar todas las categorías
        public List<Categoria> Listar()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta = "SELECT IdCategoria, Nombre, Descripcion FROM Categorias";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria
                        {
                            IdCategoria = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2)
                        };

                        categorias.Add(categoria);
                    }
                }
            }

            return categorias;
        }

        // Registrar una categoría
        public void Agregar(Categoria categoria)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta = "INSERT INTO Categorias (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Modificar una categoría
        public void Actualizar(Categoria categoria)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta = "UPDATE Categorias SET Nombre = @Nombre, Descripcion = @Descripcion WHERE IdCategoria = @IdCategoria";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                    cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar una categoría
        public void Eliminar(int idCategoria)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta = "DELETE FROM Categorias WHERE IdCategoria = @IdCategoria";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}