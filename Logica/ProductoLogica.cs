using SistemaGestionProductos_JosueMonge.Datos;
using SistemaGestionProductos_JosueMonge.Modelos;
using System;
using System.Collections.Generic;

namespace SistemaGestionProductos_JosueMonge.Logica
{
    public class ProductoLogica
    {
        private ProductoDatos datos = new ProductoDatos();

        // Consultar todos los productos
        public List<Producto> Listar()
        {
            return datos.Listar();
        }

        // Registrar un producto
        public void Agregar(Producto producto)
        {
            Validar(producto);

            producto.FechaRegistro = DateTime.Now;

            datos.Agregar(producto);
        }

        // Modificar un producto
        public void Actualizar(Producto producto)
        {
            if (producto.IdProducto <= 0)
            {
                throw new Exception("Seleccione un producto válido.");
            }

            Validar(producto);

            datos.Actualizar(producto);
        }

        // Eliminar un producto
        public void Eliminar(int idProducto)
        {
            if (idProducto <= 0)
            {
                throw new Exception("Seleccione un producto válido.");
            }

            datos.Eliminar(idProducto);
        }

        // Buscar productos por nombre
        public List<Producto> Buscar(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return datos.Listar();
            }

            return datos.Buscar(nombre.Trim());
        }

        // Validar los datos del producto
        private void Validar(Producto producto)
        {
            if (producto == null)
            {
                throw new Exception("El producto no es válido.");
            }

            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new Exception("El nombre del producto es obligatorio.");
            }

            if (producto.Nombre.Length > 100)
            {
                throw new Exception("El nombre no puede superar los 100 caracteres.");
            }

            if (producto.Precio <= 0)
            {
                throw new Exception("El precio debe ser mayor que cero.");
            }

            if (producto.Stock < 0)
            {
                throw new Exception("El stock no puede ser negativo.");
            }

            if (producto.IdCategoria <= 0)
            {
                throw new Exception("Debe seleccionar una categoría.");
            }
        }
    }
}