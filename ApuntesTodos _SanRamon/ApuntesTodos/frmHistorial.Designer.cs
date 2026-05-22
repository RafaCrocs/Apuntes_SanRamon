namespace ApuntesTodos
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
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            txtNombre = new TextBox();
            lblBuscarNombre = new Label();
            gridHistorial = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            btnBuscarFechas = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(-115, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 14;
            label1.Text = "Origen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(30, 41);
            label2.Name = "label2";
            label2.Size = new Size(288, 46);
            label2.TabIndex = 29;
            label2.Text = "Historial de Pagos";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 18F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(314, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 39);
            dateTimePicker1.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(54, 192);
            label3.Name = "label3";
            label3.Size = new Size(230, 32);
            label3.TabIndex = 27;
            label3.Text = "Buscar entre Fechas:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 18F);
            txtNombre.Location = new Point(314, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 39);
            txtNombre.TabIndex = 26;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 18F);
            lblBuscarNombre.Location = new Point(55, 147);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(226, 32);
            lblBuscarNombre.TabIndex = 25;
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
            gridHistorial.Location = new Point(55, 253);
            gridHistorial.Name = "gridHistorial";
            gridHistorial.ReadOnly = true;
            gridHistorial.RowHeadersWidth = 51;
            gridHistorial.Size = new Size(1007, 380);
            gridHistorial.TabIndex = 24;
            gridHistorial.CellFormatting += gridHistorial_CellFormatting;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 192, 192);
            iconButton1.Font = new Font("Segoe UI", 25F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.BottomCenter;
            iconButton1.Location = new Point(1003, 37);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(68, 62);
            iconButton1.TabIndex = 30;
            iconButton1.TextAlign = ContentAlignment.TopCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(481, 197);
            label4.Name = "label4";
            label4.Size = new Size(26, 32);
            label4.TabIndex = 31;
            label4.Text = "a";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 18F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(513, 192);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(161, 39);
            dateTimePicker2.TabIndex = 32;
            // 
            // btnBuscarFechas
            // 
            btnBuscarFechas.BackColor = Color.FromArgb(224, 224, 224);
            btnBuscarFechas.Location = new Point(680, 193);
            btnBuscarFechas.Name = "btnBuscarFechas";
            btnBuscarFechas.Size = new Size(74, 36);
            btnBuscarFechas.TabIndex = 33;
            btnBuscarFechas.Text = "BUSCAR";
            btnBuscarFechas.UseVisualStyleBackColor = false;
            btnBuscarFechas.Click += btnBuscarFechas_Click;
            // 
            // IdHistorialPago
            // 
            IdHistorialPago.DataPropertyName = "IdHistorialPago";
            IdHistorialPago.HeaderText = "IdHistorialPago";
            IdHistorialPago.MinimumWidth = 6;
            IdHistorialPago.Name = "IdHistorialPago";
            IdHistorialPago.ReadOnly = true;
            IdHistorialPago.Visible = false;
            IdHistorialPago.Width = 150;
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
            Origen.Width = 150;
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
            Fecha.Width = 150;
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1097, 704);
            Controls.Add(btnBuscarFechas);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridHistorial);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistorial";
            Text = "frmHistorial";
            Load += frmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)gridHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txtNombre;
        private Label lblBuscarNombre;
        private DataGridView gridHistorial;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Button btnBuscarFechas;
        private DataGridViewTextBoxColumn IdHistorialPago;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn SePagoEn;
        private DataGridViewTextBoxColumn Fecha;
    }
}