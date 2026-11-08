using SistemaGestionProductos_JosueMonge.Logica;
using SistemaGestionProductos_JosueMonge.Modelos;
using System;
using System.Windows.Forms;

namespace SistemaGestionProductos_JosueMonge
{
    public partial class Form1 : Form
    {
        private CategoriaLogica categoriaLogica = new CategoriaLogica();

        // Almacenar el ID de la categoría seleccionada
        private int idCategoriaSeleccionada = 0;

        public Form1()
        {
            InitializeComponent();

            CargarCategorias();
        }

        // Cargar las categorías registradas
        private void CargarCategorias()
        {
            try
            {
                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = categoriaLogica.Listar();

                dgvCategorias.Columns["IdCategoria"].HeaderText = "ID";
                dgvCategorias.Columns["Nombre"].HeaderText = "Nombre";
                dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";
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

        // Limpiar los campos
        private void LimpiarCamposCategoria()
        {
            idCategoriaSeleccionada = 0;
            txtNombreCategoria.Clear();
            txtDescripcionCategoria.Clear();
            dgvCategorias.ClearSelection();
        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }

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
        // Limpiar los campos de categoría
        private void btnLimpiarCategoria_Click(object sender, EventArgs e)
        {
            LimpiarCamposCategoria();
        }
    }
}