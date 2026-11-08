using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.SqlClient;

namespace SistemaGestionProductos_JosueMonge.Datos
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Server=DESKTOP-0IDDMC9\SQLEXPRESS;Database=SistemaGestionProductos;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}