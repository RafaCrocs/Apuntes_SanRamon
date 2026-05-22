namespace ApuntesElJardin.Forms
{
    partial class frmHistorial
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
            txtNombre = new TextBox();
            lblBuscarNombre = new Label();
            gridHistorial = new DataGridView();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            IdHistorialPago = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            SePagoEn = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridHistorial).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 18F);
            txtNombre.Location = new Point(303, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 39);
            txtNombre.TabIndex = 20;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 18F);
            lblBuscarNombre.Location = new Point(46, 130);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(226, 32);
            lblBuscarNombre.TabIndex = 19;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // gridHistorial
            // 
            gridHistorial.BackgroundColor = SystemColors.Control;
            gridHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHistorial.Columns.AddRange(new DataGridViewColumn[] { IdHistorialPago, NombreCompleto, Monto, Detalle, Origen, SePagoEn, Fecha });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridHistorial.DefaultCellStyle = dataGridViewCellStyle1;
            gridHistorial.Location = new Point(45, 246);
            gridHistorial.Name = "gridHistorial";
            gridHistorial.ReadOnly = true;
            gridHistorial.RowHeadersWidth = 51;
            gridHistorial.Size = new Size(985, 380);
            gridHistorial.TabIndex = 18;
            gridHistorial.CellFormatting += gridHistorial_CellFormatting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(45, 175);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 21;
            label1.Text = "Buscar por Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 18F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(303, 175);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 39);
            dateTimePicker1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(23, 44);
            label2.Name = "label2";
            label2.Size = new Size(288, 46);
            label2.TabIndex = 23;
            label2.Text = "Historial de Pagos";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 192, 192);
            iconButton1.Font = new Font("Segoe UI", 25F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.BottomCenter;
            iconButton1.Location = new Point(962, 34);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(68, 62);
            iconButton1.TabIndex = 24;
            iconButton1.TextAlign = ContentAlignment.TopCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // IdHistorialPago
            // 
            IdHistorialPago.DataPropertyName = "IdHistorialPago";
            IdHistorialPago.HeaderText = "IdHistorialPago";
            IdHistorialPago.MinimumWidth = 6;
            IdHistorialPago.Name = "IdHistorialPago";
            IdHistorialPago.ReadOnly = true;
            IdHistorialPago.Visible = false;
            IdHistorialPago.Width = 125;
            // 
            // NombreCompleto
            // 
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 300;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // Detalle
            // 
            Detalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.MinimumWidth = 6;
            Detalle.Name = "Detalle";
            Detalle.ReadOnly = true;
            // 
            // Origen
            // 
            Origen.DataPropertyName = "Origen";
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            Origen.Visible = false;
            // 
            // SePagoEn
            // 
            SePagoEn.DataPropertyName = "SePagoEn";
            SePagoEn.HeaderText = "Se Pago En:";
            SePagoEn.Name = "SePagoEn";
            SePagoEn.ReadOnly = true;
            SePagoEn.Width = 150;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "FechaPago";
            Fecha.HeaderText = "Fecha Pagado";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1083, 673);
            ControlBox = false;
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridHistorial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHistorial";
            Load += frmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)gridHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblBuscarNombre;
        private DataGridView gridHistorial;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridViewTextBoxColumn IdHistorialPago;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn SePagoEn;
        private DataGridViewTextBoxColumn Fecha;
    }
}