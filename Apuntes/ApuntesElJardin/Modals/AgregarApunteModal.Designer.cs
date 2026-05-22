namespace ApuntesElJardin.Modals
{
    partial class AgregarApunteModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            lblEmpleado = new Label();
            lblMonto = new Label();
            label3 = new Label();
            txtMonto = new TextBox();
            txtDetalle = new TextBox();
            btnAceptar = new Button();
            lblCantidad = new Label();
            btnLimpiar = new Button();
            lblCadaUno = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.ForeColor = SystemColors.MenuText;
            txtNombre.Location = new Point(44, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(508, 34);
            txtNombre.TabIndex = 0;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 15F);
            lblEmpleado.Location = new Point(44, 61);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(127, 28);
            lblEmpleado.TabIndex = 1;
            lblEmpleado.Text = "Colaborador:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 15F);
            lblMonto.Location = new Point(48, 163);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(76, 28);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(44, 245);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 3;
            label3.Text = "Detalle";
            // 
            // txtMonto
            // 
            txtMonto.BorderStyle = BorderStyle.FixedSingle;
            txtMonto.Font = new Font("Segoe UI", 15F);
            txtMonto.Location = new Point(44, 194);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(208, 34);
            txtMonto.TabIndex = 5;
            txtMonto.TextChanged += txtMonto_TextChanged;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // txtDetalle
            // 
            txtDetalle.BorderStyle = BorderStyle.FixedSingle;
            txtDetalle.Font = new Font("Segoe UI", 15F);
            txtDetalle.Location = new Point(44, 278);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(398, 34);
            txtDetalle.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 255, 192);
            btnAceptar.Font = new Font("Segoe UI", 15F);
            btnAceptar.Location = new Point(122, 352);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(154, 47);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(48, 143);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(67, 15);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad: 0";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 192, 192);
            btnLimpiar.Font = new Font("Segoe UI", 15F);
            btnLimpiar.Location = new Point(307, 352);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(136, 47);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblCadaUno
            // 
            lblCadaUno.AutoSize = true;
            lblCadaUno.Enabled = false;
            lblCadaUno.Font = new Font("Segoe UI", 15F);
            lblCadaUno.Location = new Point(276, 194);
            lblCadaUno.Name = "lblCadaUno";
            lblCadaUno.Size = new Size(0, 28);
            lblCadaUno.TabIndex = 12;
            // 
            // btnbuscar
            // 
            btnbuscar.Font = new Font("Segoe UI", 12F);
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 30;
            btnbuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnbuscar.Location = new Point(444, 48);
            btnbuscar.Margin = new Padding(3, 2, 3, 2);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(108, 40);
            btnbuscar.TabIndex = 14;
            btnbuscar.Text = "BUSCAR";
            btnbuscar.TextAlign = ContentAlignment.MiddleRight;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 15F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.BottomLeft;
            iconButton1.Location = new Point(386, 433);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(165, 45);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "Pagar Apunte";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // AgregarApunteModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(578, 503);
            Controls.Add(iconButton1);
            Controls.Add(btnbuscar);
            Controls.Add(lblCadaUno);
            Controls.Add(btnLimpiar);
            Controls.Add(lblCantidad);
            Controls.Add(btnAceptar);
            Controls.Add(txtDetalle);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(lblMonto);
            Controls.Add(lblEmpleado);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AgregarApunteModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apuntes Restaurante  v1.1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblEmpleado;
        private Label lblMonto;
        private Label label3;
        private TextBox txtMonto;
        private TextBox txtDetalle;
        private Button btnAceptar;
        private Label lblCantidad;
        private Button btnLimpiar;
        private Label lblCadaUno;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}