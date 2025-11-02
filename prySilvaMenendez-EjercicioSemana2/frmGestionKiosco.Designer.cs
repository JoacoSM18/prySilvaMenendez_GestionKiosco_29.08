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
            btnModificar = new RadioButton();
            lblCodigo = new Label();
            lblProducto = new Label();
            btnAgregar = new RadioButton();
            btnEliminar = new RadioButton();
            lbBienvenida = new Label();
            lblAccion = new Label();
            btnAceptar = new Button();
            lblAgregado = new Label();
            txtNuevoNombre = new TextBox();
            lblAgregado2 = new Label();
            mskCodigo = new MaskedTextBox();
            mskNuevoCodigo = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 10F);
            txtNombre.Location = new Point(405, 354);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 30);
            txtNombre.TabIndex = 11;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.Font = new Font("Microsoft Sans Serif", 9F);
            btnModificar.Location = new Point(227, 199);
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
            lblCodigo.Location = new Point(86, 279);
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
            lblProducto.Location = new Point(86, 359);
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
            btnAgregar.Location = new Point(27, 163);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(204, 26);
            btnAgregar.TabIndex = 13;
            btnAgregar.TabStop = true;
            btnAgregar.Text = "Agregar Un Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.CheckedChanged += btnAgregar_CheckedChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9F);
            btnEliminar.Location = new Point(433, 163);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(204, 26);
            btnEliminar.TabIndex = 14;
            btnEliminar.TabStop = true;
            btnEliminar.Text = "Eliminar Un Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.CheckedChanged += btnEliminar_CheckedChanged;
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
            lblAgregado.Location = new Point(86, 442);
            lblAgregado.Margin = new Padding(4, 0, 4, 0);
            lblAgregado.Name = "lblAgregado";
            lblAgregado.Size = new Size(227, 50);
            lblAgregado.TabIndex = 16;
            lblAgregado.Text = "Ingrese el Nuevo Codigo\r\n\r\n";
            lblAgregado.Visible = false;
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Font = new Font("Microsoft Sans Serif", 10F);
            txtNuevoNombre.Location = new Point(405, 513);
            txtNuevoNombre.Margin = new Padding(4, 5, 4, 5);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(155, 30);
            txtNuevoNombre.TabIndex = 17;
            txtNuevoNombre.Visible = false;
            // 
            // lblAgregado2
            // 
            lblAgregado2.AutoSize = true;
            lblAgregado2.Font = new Font("Microsoft Sans Serif", 10F);
            lblAgregado2.Location = new Point(86, 518);
            lblAgregado2.Margin = new Padding(4, 0, 4, 0);
            lblAgregado2.Name = "lblAgregado2";
            lblAgregado2.Size = new Size(233, 25);
            lblAgregado2.TabIndex = 18;
            lblAgregado2.Text = "Ingrese el Nuevo Nombre";
            lblAgregado2.Visible = false;
            // 
            // mskCodigo
            // 
            mskCodigo.Location = new Point(405, 273);
            mskCodigo.Mask = "99999";
            mskCodigo.Name = "mskCodigo";
            mskCodigo.Size = new Size(155, 31);
            mskCodigo.TabIndex = 19;
            mskCodigo.TextAlign = HorizontalAlignment.Center;
            mskCodigo.ValidatingType = typeof(int);
            mskCodigo.Click += mskCodigo_Click;
            // 
            // mskNuevoCodigo
            // 
            mskNuevoCodigo.Location = new Point(405, 428);
            mskNuevoCodigo.Mask = "99999";
            mskNuevoCodigo.Name = "mskNuevoCodigo";
            mskNuevoCodigo.Size = new Size(155, 31);
            mskNuevoCodigo.TabIndex = 20;
            mskNuevoCodigo.TextAlign = HorizontalAlignment.Center;
            mskNuevoCodigo.ValidatingType = typeof(int);
            mskNuevoCodigo.Click += mskNuevoCodigo_Click;
            // 
            // frmGestionKiosco
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(650, 629);
            Controls.Add(mskNuevoCodigo);
            Controls.Add(mskCodigo);
            Controls.Add(lblAgregado2);
            Controls.Add(txtNuevoNombre);
            Controls.Add(lblAgregado);
            Controls.Add(btnAceptar);
            Controls.Add(lblAccion);
            Controls.Add(lbBienvenida);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblProducto);
            Controls.Add(lblCodigo);
            Controls.Add(btnModificar);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmGestionKiosco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Gestion de Inventario \"Kiosco 10\"";
            Load += frmGestionKiosco_Load;
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
        private TextBox txtNuevoNombre;
        private Label lblAgregado2;
        private MaskedTextBox mskCodigo;
        private MaskedTextBox mskNuevoCodigo;
    }
}
