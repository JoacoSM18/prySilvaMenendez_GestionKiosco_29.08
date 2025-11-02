namespace prySilvaMenendez_EjercicioSemana2
{
    partial class frmGestionKiosco:Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionKiosco));
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            btnModificar = new RadioButton();
            lblCodigo = new Label();
            lblProducto = new Label();
            btnAgregar = new RadioButton();
            btnEliminar = new RadioButton();
            lbBienvenida = new Label();
            lblAccion = new Label();
            btnAceptar = new Button();
            lblAgregado = new Label();
            txtAgregado = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 10F);
            txtNombre.Location = new Point(410, 394);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 30);
            txtNombre.TabIndex = 11;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Microsoft Sans Serif", 10F);
            txtCodigo.Location = new Point(410, 302);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(145, 30);
            txtCodigo.TabIndex = 10;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.Font = new Font("Microsoft Sans Serif", 9F);
            btnModificar.Location = new Point(229, 217);
            btnModificar.Margin = new Padding(4, 5, 4, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(212, 26);
            btnModificar.TabIndex = 12;
            btnModificar.TabStop = true;
            btnModificar.Text = "Modificar Un Producto";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.CheckedChanged += btnModificar_CheckedChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 10F);
            lblCodigo.Location = new Point(86, 307);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(279, 25);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Ingrese el Codigo del Producto";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Microsoft Sans Serif", 10F);
            lblProducto.Location = new Point(86, 399);
            lblProducto.Margin = new Padding(4, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(285, 25);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Ingrese el Nombre del Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9F);
            btnAgregar.Location = new Point(31, 173);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(204, 26);
            btnAgregar.TabIndex = 13;
            btnAgregar.TabStop = true;
            btnAgregar.Text = "Agregar Un Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9F);
            btnEliminar.Location = new Point(433, 173);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(204, 26);
            btnEliminar.TabIndex = 14;
            btnEliminar.TabStop = true;
            btnEliminar.Text = "Eliminar Un Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lbBienvenida
            // 
            lbBienvenida.AutoSize = true;
            lbBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline);
            lbBienvenida.Location = new Point(70, 22);
            lbBienvenida.Margin = new Padding(4, 0, 4, 0);
            lbBienvenida.Name = "lbBienvenida";
            lbBienvenida.Size = new Size(505, 54);
            lbBienvenida.TabIndex = 7;
            lbBienvenida.Text = "BIENVENIDO AL SISTEMA";
            // 
            // lblAccion
            // 
            lblAccion.AutoSize = true;
            lblAccion.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAccion.Location = new Point(173, 92);
            lblAccion.Margin = new Padding(4, 0, 4, 0);
            lblAccion.Name = "lblAccion";
            lblAccion.Size = new Size(302, 45);
            lblAccion.TabIndex = 8;
            lblAccion.Text = "¿Que Desea Hacer?";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9F);
            btnAceptar.Location = new Point(458, 579);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(141, 36);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "&ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblAgregado
            // 
            lblAgregado.AutoSize = true;
            lblAgregado.Font = new Font("Microsoft Sans Serif", 10F);
            lblAgregado.Location = new Point(86, 490);
            lblAgregado.Margin = new Padding(4, 0, 4, 0);
            lblAgregado.Name = "lblAgregado";
            lblAgregado.Size = new Size(295, 25);
            lblAgregado.TabIndex = 16;
            lblAgregado.Text = "Ingrese Lo Que Quiere Modificar";
            lblAgregado.Visible = false;
            // 
            // txtAgregado
            // 
            txtAgregado.Font = new Font("Microsoft Sans Serif", 10F);
            txtAgregado.Location = new Point(410, 484);
            txtAgregado.Margin = new Padding(4, 5, 4, 5);
            txtAgregado.Name = "txtAgregado";
            txtAgregado.Size = new Size(145, 30);
            txtAgregado.TabIndex = 17;
            txtAgregado.Visible = false;
            // 
            // frmGestionKiosco
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(650, 629);
            Controls.Add(txtAgregado);
            Controls.Add(lblAgregado);
            Controls.Add(btnAceptar);
            Controls.Add(lblAccion);
            Controls.Add(lbBienvenida);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblProducto);
            Controls.Add(lblCodigo);
            Controls.Add(btnModificar);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmGestionKiosco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Gestion de Inventario \"Kiosco 10\"";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCodigo;
        private RadioButton btnModificar;
        private Label lblCodigo;
        private Label lblProducto;
        private RadioButton btnAgregar;
        private RadioButton btnEliminar;
        private Label lbBienvenida;
        private Label lblAccion;
        private Button btnAceptar;
        private Label lblAgregado;
        private TextBox txtAgregado;
    }
}
