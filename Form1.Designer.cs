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
            tabControlPrincipal.SuspendLayout();
            tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
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
            tabProductos.Location = new Point(4, 24);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(3);
            tabProductos.Size = new Size(944, 501);
            tabProductos.TabIndex = 1;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
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
    }
}
