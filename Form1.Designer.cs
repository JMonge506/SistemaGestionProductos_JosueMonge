namespace SistemaGestionProductos_JosueMonge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlPrincipal = new TabControl();
            tabCategorias = new TabPage();
            btnLimpiarCategoria = new Button();
            btnEliminarCategoria = new Button();
            btnActualizarCategoria = new Button();
            btnAgregarCategoria = new Button();
            txtDescripcionCategoria = new TextBox();
            lblDescripcionCategoria = new Label();
            txtNombreCategoria = new TextBox();
            lblNombreCategoria = new Label();
            dgvCategorias = new DataGridView();
            tabProductos = new TabPage();
            dgvProductos = new DataGridView();
            txtBuscarProducto = new TextBox();
            lblBuscarProducto = new Label();
            cmbCategoria = new ComboBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombreProducto = new TextBox();
            lblCategoria = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            lblNombreProducto = new Label();
            btnLimpiarProducto = new Button();
            btnBuscarProducto = new Button();
            btnEliminarProducto = new Button();
            btnActualizarProducto = new Button();
            btnAgregarProducto = new Button();
            tabControlPrincipal.SuspendLayout();
            tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabCategorias);
            tabControlPrincipal.Controls.Add(tabProductos);
            tabControlPrincipal.Location = new Point(20, 20);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(952, 529);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabCategorias
            // 
            tabCategorias.Controls.Add(btnLimpiarCategoria);
            tabCategorias.Controls.Add(btnEliminarCategoria);
            tabCategorias.Controls.Add(btnActualizarCategoria);
            tabCategorias.Controls.Add(btnAgregarCategoria);
            tabCategorias.Controls.Add(txtDescripcionCategoria);
            tabCategorias.Controls.Add(lblDescripcionCategoria);
            tabCategorias.Controls.Add(txtNombreCategoria);
            tabCategorias.Controls.Add(lblNombreCategoria);
            tabCategorias.Controls.Add(dgvCategorias);
            tabCategorias.Location = new Point(4, 24);
            tabCategorias.Name = "tabCategorias";
            tabCategorias.Padding = new Padding(3);
            tabCategorias.Size = new Size(944, 501);
            tabCategorias.TabIndex = 0;
            tabCategorias.Text = "Categorías";
            tabCategorias.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCategoria
            // 
            btnLimpiarCategoria.Location = new Point(38, 356);
            btnLimpiarCategoria.Name = "btnLimpiarCategoria";
            btnLimpiarCategoria.Size = new Size(75, 23);
            btnLimpiarCategoria.TabIndex = 18;
            btnLimpiarCategoria.Text = "Limpiar";
            btnLimpiarCategoria.UseVisualStyleBackColor = true;
            btnLimpiarCategoria.Click += btnLimpiarCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Location = new Point(281, 356);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(75, 23);
            btnEliminarCategoria.TabIndex = 17;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // btnActualizarCategoria
            // 
            btnActualizarCategoria.Location = new Point(200, 356);
            btnActualizarCategoria.Name = "btnActualizarCategoria";
            btnActualizarCategoria.Size = new Size(75, 23);
            btnActualizarCategoria.TabIndex = 16;
            btnActualizarCategoria.Text = "Actualizar";
            btnActualizarCategoria.UseVisualStyleBackColor = true;
            btnActualizarCategoria.Click += btnActualizarCategoria_Click;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(119, 356);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(75, 23);
            btnAgregarCategoria.TabIndex = 15;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // txtDescripcionCategoria
            // 
            txtDescripcionCategoria.Location = new Point(99, 65);
            txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            txtDescripcionCategoria.Size = new Size(100, 23);
            txtDescripcionCategoria.TabIndex = 14;
            // 
            // lblDescripcionCategoria
            // 
            lblDescripcionCategoria.AutoSize = true;
            lblDescripcionCategoria.Location = new Point(14, 68);
            lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            lblDescripcionCategoria.Size = new Size(72, 15);
            lblDescripcionCategoria.TabIndex = 13;
            lblDescripcionCategoria.Text = "Descripción:";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(99, 31);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(100, 23);
            txtNombreCategoria.TabIndex = 12;
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(14, 34);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(54, 15);
            lblNombreCategoria.TabIndex = 11;
            lblNombreCategoria.Text = "Nombre:";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(557, 34);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(240, 150);
            dgvCategorias.TabIndex = 10;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(dgvProductos);
            tabProductos.Controls.Add(txtBuscarProducto);
            tabProductos.Controls.Add(lblBuscarProducto);
            tabProductos.Controls.Add(cmbCategoria);
            tabProductos.Controls.Add(txtStock);
            tabProductos.Controls.Add(txtPrecio);
            tabProductos.Controls.Add(txtNombreProducto);
            tabProductos.Controls.Add(lblCategoria);
            tabProductos.Controls.Add(lblStock);
            tabProductos.Controls.Add(lblPrecio);
            tabProductos.Controls.Add(lblNombreProducto);
            tabProductos.Controls.Add(btnLimpiarProducto);
            tabProductos.Controls.Add(btnBuscarProducto);
            tabProductos.Controls.Add(btnEliminarProducto);
            tabProductos.Controls.Add(btnActualizarProducto);
            tabProductos.Controls.Add(btnAgregarProducto);
            tabProductos.Location = new Point(4, 24);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(3);
            tabProductos.Size = new Size(944, 501);
            tabProductos.TabIndex = 1;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(28, 154);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(846, 341);
            dgvProductos.TabIndex = 15;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(439, 31);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(100, 23);
            txtBuscarProducto.TabIndex = 14;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(336, 34);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(97, 15);
            lblBuscarProducto.TabIndex = 13;
            lblBuscarProducto.Text = "Buscar producto:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(94, 115);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 12;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(102, 86);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 11;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(102, 57);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 10;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(102, 28);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(27, 118);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoría:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(27, 89);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(28, 61);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(27, 31);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(54, 15);
            lblNombreProducto.TabIndex = 5;
            lblNombreProducto.Text = "Nombre:";
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Location = new Point(556, 85);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(75, 23);
            btnLimpiarProducto.TabIndex = 4;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            btnLimpiarProducto.Click += btnLimpiarProducto_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(556, 31);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(75, 23);
            btnBuscarProducto.TabIndex = 3;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(475, 85);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(75, 23);
            btnEliminarProducto.TabIndex = 2;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnActualizarProducto
            // 
            btnActualizarProducto.Location = new Point(394, 85);
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.Size = new Size(75, 23);
            btnActualizarProducto.TabIndex = 1;
            btnActualizarProducto.Text = "Actualizar";
            btnActualizarProducto.UseVisualStyleBackColor = true;
            btnActualizarProducto.Click += btnActualizarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(313, 85);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(75, 23);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tabControlPrincipal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Productos";
            tabControlPrincipal.ResumeLayout(false);
            tabCategorias.ResumeLayout(false);
            tabCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tabProductos.ResumeLayout(false);
            tabProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabCategorias;
        private TabPage tabProductos;
        private Button btnLimpiarCategoria;
        private Button btnEliminarCategoria;
        private Button btnActualizarCategoria;
        private Button btnAgregarCategoria;
        private TextBox txtDescripcionCategoria;
        private Label lblDescripcionCategoria;
        private TextBox txtNombreCategoria;
        private Label lblNombreCategoria;
        private DataGridView dgvCategorias;
        private Button btnBuscarProducto;
        private Button btnEliminarProducto;
        private Button btnActualizarProducto;
        private Button btnAgregarProducto;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombreProducto;
        private Label lblCategoria;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblNombreProducto;
        private Button btnLimpiarProducto;
        private ComboBox cmbCategoria;
        private DataGridView dgvProductos;
        private TextBox txtBuscarProducto;
        private Label lblBuscarProducto;
    }
}
