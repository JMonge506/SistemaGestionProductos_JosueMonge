using SistemaGestionProductos_JosueMonge.Logica;
using SistemaGestionProductos_JosueMonge.Modelos;
using System;
using System.Windows.Forms;

namespace SistemaGestionProductos_JosueMonge
{
    public partial class Form1 : Form
    {
        private CategoriaLogica categoriaLogica = new CategoriaLogica();
        private ProductoLogica productoLogica = new ProductoLogica();

        // Almacenar el ID de la categoría seleccionada
        private int idCategoriaSeleccionada = 0;

        // Almacenar el ID del producto seleccionado
        private int idProductoSeleccionado = 0;

        public Form1()
        {
            InitializeComponent();

            CargarCategorias();
            CargarProductos();
        }

        // ==========================================
        // FUNCIONES DE CATEGORÍAS
        // ==========================================

        // Cargar las categorías registradas
        private void CargarCategorias()
        {
            try
            {
                var categorias = categoriaLogica.Listar();

                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = categorias;

                dgvCategorias.Columns["IdCategoria"].HeaderText = "ID";
                dgvCategorias.Columns["Nombre"].HeaderText = "Nombre";
                dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";

                // Cargar categorías en el ComboBox de productos
                cmbCategoria.DataSource = null;
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
        }

        // Registrar una categoría
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria
                {
                    Nombre = txtNombreCategoria.Text.Trim(),
                    Descripcion = txtDescripcionCategoria.Text.Trim()
                };

                categoriaLogica.Agregar(categoria);

                MessageBox.Show("Categoría registrada correctamente.");

                CargarCategorias();
                LimpiarCamposCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar");
            }
        }

        // Seleccionar una categoría de la tabla
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Categoria categoria = dgvCategorias.Rows[e.RowIndex].DataBoundItem as Categoria;

                if (categoria != null)
                {
                    idCategoriaSeleccionada = categoria.IdCategoria;

                    txtNombreCategoria.Text = categoria.Nombre;
                    txtDescripcionCategoria.Text = categoria.Descripcion;
                }
            }
        }

        // Limpiar los campos de categoría
        private void LimpiarCamposCategoria()
        {
            idCategoriaSeleccionada = 0;
            txtNombreCategoria.Clear();
            txtDescripcionCategoria.Clear();
            dgvCategorias.ClearSelection();
        }

        // Actualizar una categoría
        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria
                {
                    IdCategoria = idCategoriaSeleccionada,
                    Nombre = txtNombreCategoria.Text.Trim(),
                    Descripcion = txtDescripcionCategoria.Text.Trim()
                };

                categoriaLogica.Actualizar(categoria);

                MessageBox.Show("Categoría actualizada correctamente.");

                CargarCategorias();
                LimpiarCamposCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al actualizar");
            }
        }

        // Eliminar una categoría seleccionada
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCategoriaSeleccionada <= 0)
                {
                    MessageBox.Show("Seleccione una categoría para eliminar.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta categoría?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    categoriaLogica.Eliminar(idCategoriaSeleccionada);

                    MessageBox.Show("Categoría eliminada correctamente.");

                    CargarCategorias();
                    LimpiarCamposCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar la categoría. Puede que tenga productos asociados.\n\n" + ex.Message,
                    "Error al eliminar"
                );
            }
        }

        // Botón limpiar categorías
        private void btnLimpiarCategoria_Click(object sender, EventArgs e)
        {
            LimpiarCamposCategoria();
        }

        // ==========================================
        // FUNCIONES DE PRODUCTOS
        // ==========================================

        // Cargar los productos registrados
        private void CargarProductos()
        {
            try
            {
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productoLogica.Listar();

                // Cambiar encabezados de las columnas
                dgvProductos.Columns["IdProducto"].HeaderText = "ID";
                dgvProductos.Columns["Nombre"].HeaderText = "Producto";
                dgvProductos.Columns["Precio"].HeaderText = "Precio";
                dgvProductos.Columns["Stock"].HeaderText = "Stock";
                dgvProductos.Columns["FechaRegistro"].HeaderText = "Fecha de registro";
                dgvProductos.Columns["NombreCategoria"].HeaderText = "Categoría";
                dgvProductos.Columns["ValorInventario"].HeaderText = "Valor del inventario";

                // Ocultar el ID de la categoría
                dgvProductos.Columns["IdCategoria"].Visible = false;

                // Formato de precio e inventario
                dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dgvProductos.Columns["ValorInventario"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        // Evento de texto de categoría
        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {
        }

        // Evento de etiqueta de precio 
        private void lblPrecio_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el nombre no esté vacío
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
                {
                    MessageBox.Show("Ingrese el nombre del producto.");
                    return;
                }

                // Validar que el precio sea numérico
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    return;
                }

                // Validar que el stock sea un número entero
                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("Ingrese una cantidad de stock válida.");
                    return;
                }

                // Validar que se haya seleccionado una categoría
                if (cmbCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una categoría.");
                    return;
                }

                // Crear el objeto producto
                Producto producto = new Producto
                {
                    Nombre = txtNombreProducto.Text.Trim(),
                    Precio = precio,
                    Stock = stock,
                    IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue)
                };

                // Registrar el producto
                productoLogica.Agregar(producto);

                MessageBox.Show("Producto registrado correctamente.");

                // Actualizar la tabla y limpiar los campos
                CargarProductos();
                LimpiarCamposProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar producto");
            }
        }
        // Limpiar los campos de productos
        private void LimpiarCamposProducto()
        {
            idProductoSeleccionado = 0;

            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

            cmbCategoria.SelectedIndex = -1;

            txtBuscarProducto.Clear();

            dgvProductos.ClearSelection();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un producto
                if (idProductoSeleccionado <= 0)
                {
                    MessageBox.Show("Seleccione un producto de la tabla para actualizar.");
                    return;
                }

                // Validar el nombre
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
                {
                    MessageBox.Show("Ingrese el nombre del producto.");
                    return;
                }

                // Validar el precio
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    return;
                }

                // Validar el stock
                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("Ingrese una cantidad de stock válida.");
                    return;
                }

                // Validar la categoría
                if (cmbCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una categoría.");
                    return;
                }

                // Crear el objeto con los datos actualizados
                Producto producto = new Producto
                {
                    IdProducto = idProductoSeleccionado,
                    Nombre = txtNombreProducto.Text.Trim(),
                    Precio = precio,
                    Stock = stock,
                    IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue)
                };

                // Actualizar el producto
                productoLogica.Actualizar(producto);

                MessageBox.Show("Producto actualizado correctamente.");

                // Recargar la tabla y limpiar los campos
                CargarProductos();
                LimpiarCamposProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al actualizar producto");
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener el producto seleccionado
                Producto producto = dgvProductos.Rows[e.RowIndex].DataBoundItem as Producto;

                if (producto != null)
                {
                    // Guardar el ID del producto
                    idProductoSeleccionado = producto.IdProducto;

                    // Mostrar los datos en los campos
                    txtNombreProducto.Text = producto.Nombre;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtStock.Text = producto.Stock.ToString();

                    // Seleccionar la categoría correspondiente
                    cmbCategoria.SelectedValue = producto.IdCategoria;
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un producto
                if (idProductoSeleccionado <= 0)
                {
                    MessageBox.Show("Seleccione un producto de la tabla para eliminar.");
                    return;
                }

                // Solicitar confirmación
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    productoLogica.Eliminar(idProductoSeleccionado);

                    MessageBox.Show("Producto eliminado correctamente.");

                    CargarProductos();
                    LimpiarCamposProducto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar producto");
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscar productos por nombre
                dgvProductos.DataSource = productoLogica.Buscar(txtBuscarProducto.Text);

                // Configurar los encabezados
                dgvProductos.Columns["IdProducto"].HeaderText = "ID";
                dgvProductos.Columns["Nombre"].HeaderText = "Producto";
                dgvProductos.Columns["Precio"].HeaderText = "Precio";
                dgvProductos.Columns["Stock"].HeaderText = "Stock";
                dgvProductos.Columns["FechaRegistro"].HeaderText = "Fecha de registro";
                dgvProductos.Columns["NombreCategoria"].HeaderText = "Categoría";
                dgvProductos.Columns["ValorInventario"].HeaderText = "Valor del inventario";

                // Ocultar el ID de la categoría
                dgvProductos.Columns["IdCategoria"].Visible = false;

                // Formato de precios
                dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dgvProductos.Columns["ValorInventario"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar productos");
            }
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCamposProducto();
            CargarProductos();
        }
    }
}