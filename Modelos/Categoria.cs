using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionProductos_JosueMonge.Modelos
{
    public class Categoria
    {
        public int IdCategoria { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;
    }
}