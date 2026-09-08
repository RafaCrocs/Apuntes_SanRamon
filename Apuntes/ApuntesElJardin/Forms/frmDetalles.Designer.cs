namespace ApuntesElJardin.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gridDetalles = new DataGridView();
            lblDetallesDe = new Label();
            lblNombre = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            Pagar = new DataGridViewButtonColumn();
            IdApunte = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            LugarTrabajo = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridDetalles).BeginInit();
            SuspendLayout();
            // 
            // gridDetalles
            // 
            gridDetalles.BackgroundColor = SystemColors.Control;
            gridDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDetalles.Columns.AddRange(new DataGridViewColumn[] { Pagar, IdApunte, NombreCompleto, LugarTrabajo, Origen, Detalle, Monto, Fecha });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridDetalles.DefaultCellStyle = dataGridViewCellStyle1;
            gridDetalles.Location = new Point(25, 237);
            gridDetalles.Margin = new Padding(3, 4, 3, 4);
            gridDetalles.Name = "gridDetalles";
            gridDetalles.ReadOnly = true;
            gridDetalles.RowHeadersWidth = 51;
            gridDetalles.Size = new Size(1086, 428);
            gridDetalles.TabIndex = 6;
            gridDetalles.CellContentClick += gridDetalles_CellContentClick;
            gridDetalles.CellFormatting += gridDetalles_CellFormatting;
            // 
            // lblDetallesDe
            // 
            lblDetallesDe.AutoSize = true;
            lblDetallesDe.BackColor = SystemColors.ActiveCaption;
            lblDetallesDe.Font = new Font("Segoe UI", 20F);
            lblDetallesDe.Location = new Point(25, 104);
            lblDetallesDe.Name = "lblDetallesDe";
            lblDetallesDe.Size = new Size(202, 46);
            lblDetallesDe.TabIndex = 7;
            lblDetallesDe.Text = "Detalles de: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaption;
            lblNombre.Font = new Font("Segoe UI", 25F);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(227, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 57);
            lblNombre.TabIndex = 8;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 192, 192);
            iconButton1.Font = new Font("Segoe UI", 25F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.BottomCenter;
            iconButton1.Location = new Point(1033, 33);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(78, 83);
            iconButton1.TabIndex = 26;
            iconButton1.TextAlign = ContentAlignment.TopCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1150, 456);
            label3.TabIndex = 27;
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
            NombreCompleto.HeaderText = "Nombre";
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
            Origen.Visible = false;
            Origen.Width = 125;
            // 
            // Detalle
            // 
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.MinimumWidth = 6;
            Detalle.Name = "Detalle";
            Detalle.ReadOnly = true;
            Detalle.Width = 200;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 150;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha de Apunte";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 150;
            // 
            // frmDetalles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 763);
            ControlBox = false;
            Controls.Add(iconButton1);
            Controls.Add(lblNombre);
            Controls.Add(lblDetallesDe);
            Controls.Add(gridDetalles);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDetalles";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetalles";
            Load += frmDetalles_Load;
            ((System.ComponentModel.ISupportInitialize)gridDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridDetalles;
        private Label lblDetallesDe;
        private Label lblNombre;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private DataGridViewButtonColumn Pagar;
        private DataGridViewTextBoxColumn IdApunte;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn LugarTrabajo;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Fecha;
    }
}