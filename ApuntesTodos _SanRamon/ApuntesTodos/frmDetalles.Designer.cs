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
            cmbTrabajo = new ComboBox();
            label1 = new Label();
            lblNombre = new Label();
            label2 = new Label();
            Pagar = new DataGridViewButtonColumn();
            IdApunte = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            LugarTrabajo = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridDetalles).BeginInit();
            SuspendLayout();
            // 
            // gridDetalles
            // 
            gridDetalles.BackgroundColor = SystemColors.Control;
            gridDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDetalles.Columns.AddRange(new DataGridViewColumn[] { Pagar, IdApunte, NombreCompleto, LugarTrabajo, Origen, Monto, Detalle, Fecha });
            gridDetalles.Font = new Font("Segoe UI", 14F);
            gridDetalles.Location = new Point(125, 213);
            gridDetalles.Name = "gridDetalles";
            gridDetalles.ReadOnly = true;
            gridDetalles.Size = new Size(1155, 536);
            gridDetalles.TabIndex = 0;
            gridDetalles.CellContentClick += gridDetalles_CellContentClick;
            gridDetalles.CellFormatting += gridDetalles_CellFormatting;
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(207, 161);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(186, 36);
            cmbTrabajo.TabIndex = 10;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(125, 164);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 9;
            label1.Text = "Origen:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaption;
            lblNombre.Font = new Font("Segoe UI", 20F);
            lblNombre.Location = new Point(65, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(156, 37);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Detalles de ";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1401, 444);
            label2.TabIndex = 12;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pagar
            // 
            Pagar.HeaderText = "";
            Pagar.Name = "Pagar";
            Pagar.ReadOnly = true;
            Pagar.Text = "Pagar";
            Pagar.UseColumnTextForButtonValue = true;
            // 
            // IdApunte
            // 
            IdApunte.DataPropertyName = "IdApunte";
            IdApunte.HeaderText = "IdApunte";
            IdApunte.Name = "IdApunte";
            IdApunte.ReadOnly = true;
            IdApunte.Visible = false;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // LugarTrabajo
            // 
            LugarTrabajo.DataPropertyName = "LugarTrabajo";
            LugarTrabajo.HeaderText = "LugarTrabajo";
            LugarTrabajo.Name = "LugarTrabajo";
            LugarTrabajo.ReadOnly = true;
            LugarTrabajo.Visible = false;
            // 
            // Origen
            // 
            Origen.DataPropertyName = "Origen";
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            Origen.Width = 200;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // Detalle
            // 
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.Name = "Detalle";
            Detalle.ReadOnly = true;
            Detalle.Width = 300;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 150;
            // 
            // frmDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 797);
            Controls.Add(lblNombre);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(gridDetalles);
            Controls.Add(label2);
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