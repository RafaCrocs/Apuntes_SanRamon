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
            txtNombre.Location = new Point(50, 129);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(580, 41);
            txtNombre.TabIndex = 0;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 15F);
            lblEmpleado.Location = new Point(50, 81);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(160, 35);
            lblEmpleado.TabIndex = 1;
            lblEmpleado.Text = "Colaborador:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 15F);
            lblMonto.Location = new Point(55, 217);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(94, 35);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(50, 327);
            label3.Name = "label3";
            label3.Size = new Size(92, 35);
            label3.TabIndex = 3;
            label3.Text = "Detalle";
            // 
            // txtMonto
            // 
            txtMonto.BorderStyle = BorderStyle.FixedSingle;
            txtMonto.Font = new Font("Segoe UI", 15F);
            txtMonto.Location = new Point(50, 259);
            txtMonto.Margin = new Padding(3, 4, 3, 4);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(237, 41);
            txtMonto.TabIndex = 5;
            txtMonto.TextChanged += txtMonto_TextChanged;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // txtDetalle
            // 
            txtDetalle.BorderStyle = BorderStyle.FixedSingle;
            txtDetalle.Font = new Font("Segoe UI", 15F);
            txtDetalle.Location = new Point(50, 371);
            txtDetalle.Margin = new Padding(3, 4, 3, 4);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(455, 41);
            txtDetalle.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 255, 192);
            btnAceptar.Font = new Font("Segoe UI", 15F);
            btnAceptar.Location = new Point(139, 469);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(176, 63);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 192, 192);
            btnLimpiar.Font = new Font("Segoe UI", 15F);
            btnLimpiar.Location = new Point(351, 469);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(155, 63);
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
            lblCadaUno.Location = new Point(315, 259);
            lblCadaUno.Name = "lblCadaUno";
            lblCadaUno.Size = new Size(0, 35);
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
            btnbuscar.Location = new Point(507, 64);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(123, 53);
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
            iconButton1.Location = new Point(441, 577);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(189, 60);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "Pagar Apunte";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // AgregarApunteModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(661, 671);
            Controls.Add(iconButton1);
            Controls.Add(btnbuscar);
            Controls.Add(lblCadaUno);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDetalle);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(lblMonto);
            Controls.Add(lblEmpleado);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AgregarApunteModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apuntes Zarcereño  v1.1.0";
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
        private Button btnLimpiar;
        private Label lblCadaUno;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}