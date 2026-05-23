namespace ApuntesTodos
{
    partial class frmDetalles
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
            gridDetalles = new DataGridView();
            Pagar = new DataGridViewButtonColumn();
            IdApunte = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            LugarTrabajo = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            cmbTrabajo = new ComboBox();
            label1 = new Label();
            lblNombre = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridDetalles).BeginInit();
            SuspendLayout();
            // 
            // gridDetalles
            // 
            gridDetalles.BackgroundColor = SystemColors.Control;
            gridDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDetalles.Columns.AddRange(new DataGridViewColumn[] { Pagar, IdApunte, NombreCompleto, LugarTrabajo, Origen, Monto, Detalle, Fecha });
            gridDetalles.Font = new Font("Segoe UI", 14F);
            gridDetalles.Location = new Point(143, 284);
            gridDetalles.Margin = new Padding(3, 4, 3, 4);
            gridDetalles.Name = "gridDetalles";
            gridDetalles.ReadOnly = true;
            gridDetalles.RowHeadersWidth = 51;
            gridDetalles.Size = new Size(1320, 559);
            gridDetalles.TabIndex = 0;
            gridDetalles.CellContentClick += gridDetalles_CellContentClick;
            gridDetalles.CellFormatting += gridDetalles_CellFormatting;
            // 
            // Pagar
            // 
            Pagar.HeaderText = "";
            Pagar.MinimumWidth = 6;
            Pagar.Name = "Pagar";
            Pagar.ReadOnly = true;
            Pagar.Text = "Pagar";
            Pagar.UseColumnTextForButtonValue = true;
            Pagar.Width = 125;
            // 
            // IdApunte
            // 
            IdApunte.DataPropertyName = "IdApunte";
            IdApunte.HeaderText = "IdApunte";
            IdApunte.MinimumWidth = 6;
            IdApunte.Name = "IdApunte";
            IdApunte.ReadOnly = true;
            IdApunte.Visible = false;
            IdApunte.Width = 125;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // LugarTrabajo
            // 
            LugarTrabajo.DataPropertyName = "LugarTrabajo";
            LugarTrabajo.HeaderText = "LugarTrabajo";
            LugarTrabajo.MinimumWidth = 6;
            LugarTrabajo.Name = "LugarTrabajo";
            LugarTrabajo.ReadOnly = true;
            LugarTrabajo.Visible = false;
            LugarTrabajo.Width = 125;
            // 
            // Origen
            // 
            Origen.DataPropertyName = "Origen";
            Origen.HeaderText = "Origen";
            Origen.MinimumWidth = 6;
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            Origen.Width = 200;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 125;
            // 
            // Detalle
            // 
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.MinimumWidth = 6;
            Detalle.Name = "Detalle";
            Detalle.ReadOnly = true;
            Detalle.Width = 300;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 150;
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(237, 215);
            cmbTrabajo.Margin = new Padding(3, 4, 3, 4);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(212, 43);
            cmbTrabajo.TabIndex = 10;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(143, 219);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 9;
            label1.Text = "Origen:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaption;
            lblNombre.Font = new Font("Segoe UI", 20F);
            lblNombre.Location = new Point(74, 95);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(195, 46);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Detalles de ";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1601, 592);
            label2.TabIndex = 12;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmDetalles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 857);
            Controls.Add(lblNombre);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(gridDetalles);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDetalles";
            Text = "frmDetalles";
            Load += frmDetalles_Load;
            ((System.ComponentModel.ISupportInitialize)gridDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridDetalles;
        private ComboBox cmbTrabajo;
        private Label label1;
        private Label lblNombre;
        private Label label2;
        private DataGridViewButtonColumn Pagar;
        private DataGridViewTextBoxColumn IdApunte;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn LugarTrabajo;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Fecha;
    }
}