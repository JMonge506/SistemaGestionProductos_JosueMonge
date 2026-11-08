using System;
using System.Collections.Generic;
using System.Text;

using SistemaGestionProductos_JosueMonge.Datos;
using SistemaGestionProductos_JosueMonge.Modelos;
using System;
using System.Collections.Generic;

namespace SistemaGestionProductos_JosueMonge.Logica
{
    public class CategoriaLogica
    {
        private CategoriaDatos datos = new CategoriaDatos();

        // Consultar categorías
        public List<Categoria> Listar()
        {
            return datos.Listar();
        }

        // Registrar una categoría
        public void Agregar(Categoria categoria)
        {
            Validar(categoria);
            datos.Agregar(categoria);
        }

        // Modificar una categoría
        public void Actualizar(Categoria categoria)
        {
            if (categoria.IdCategoria <= 0)
            {
                throw new Exception("Seleccione una categoría válida.");
            }

            Validar(categoria);
            datos.Actualizar(categoria);
        }

        // Eliminar una categoría
        public void Eliminar(int idCategoria)
        {
            if (idCategoria <= 0)
            {
                throw new Exception("Seleccione una categoría válida.");
            }

            datos.Eliminar(idCategoria);
        }

        // Validar los datos de la categoría
        private void Validar(Categoria categoria)
        {
            if (categoria == null)
            {
                throw new Exception("La categoría no es válida.");
            }

            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                throw new Exception("El nombre de la categoría es obligatorio.");
            }

            if (categoria.Nombre.Length > 100)
            {
                throw new Exception("El nombre no puede superar los 100 caracteres.");
            }

            if (categoria.Descripcion != null && categoria.Descripcion.Length > 250)
            {
                throw new Exception("La descripción no puede superar los 250 caracteres.");
            }
        }
    }
}