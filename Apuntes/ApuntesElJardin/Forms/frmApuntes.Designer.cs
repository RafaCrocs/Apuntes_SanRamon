namespace ApuntesElJardin.Forms
{
    partial class frmApuntes
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
            gridApuntes = new DataGridView();
            cmbTrabajo = new ComboBox();
            label1 = new Label();
            btnVerHistorial = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            PagarTodo = new DataGridViewButtonColumn();
            Detalles = new DataGridViewButtonColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            LugarTrabajo = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridApuntes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 18F);
            txtNombre.Location = new Point(343, 220);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(430, 47);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.BackColor = SystemColors.ActiveCaption;
            lblBuscarNombre.Font = new Font("Segoe UI", 18F);
            lblBuscarNombre.Location = new Point(78, 220);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(283, 41);
            lblBuscarNombre.TabIndex = 6;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // gridApuntes
            // 
            gridApuntes.BackgroundColor = SystemColors.Control;
            gridApuntes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridApuntes.Columns.AddRange(new DataGridViewColumn[] { PagarTodo, Detalles, IdEmpleado, NombreCompleto, LugarTrabajo, Monto });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridApuntes.DefaultCellStyle = dataGridViewCellStyle1;
            gridApuntes.Location = new Point(81, 363);
            gridApuntes.Margin = new Padding(3, 4, 3, 4);
            gridApuntes.Name = "gridApuntes";
            gridApuntes.ReadOnly = true;
            gridApuntes.RowHeadersWidth = 51;
            gridApuntes.Size = new Size(1078, 436);
            gridApuntes.TabIndex = 5;
            gridApuntes.CellContentClick += gridApuntes_CellContentClick;
            gridApuntes.CellFormatting += gridApuntes_CellFormatting;
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrabajo.Font = new Font("Segoe UI", 18F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(415, 284);
            cmbTrabajo.Margin = new Padding(3, 4, 3, 4);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(358, 49);
            cmbTrabajo.TabIndex = 9;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(78, 288);
            label1.Name = "label1";
            label1.Size = new Size(361, 41);
            label1.TabIndex = 8;
            label1.Text = "Buscar por donde Trabaja:";
            // 
            // btnVerHistorial
            // 
            btnVerHistorial.BackColor = SystemColors.Control;
            btnVerHistorial.Font = new Font("Segoe UI", 15F);
            btnVerHistorial.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            btnVerHistorial.IconColor = Color.Black;
            btnVerHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerHistorial.IconSize = 30;
            btnVerHistorial.ImageAlign = ContentAlignment.BottomLeft;
            btnVerHistorial.Location = new Point(985, 288);
            btnVerHistorial.Name = "btnVerHistorial";
            btnVerHistorial.Size = new Size(174, 60);
            btnVerHistorial.TabIndex = 17;
            btnVerHistorial.Text = "Ver Historial";
            btnVerHistorial.TextAlign = ContentAlignment.MiddleRight;
            btnVerHistorial.UseVisualStyleBackColor = false;
            btnVerHistorial.Click += btnVerHistorial_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 25F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(75, 81);
            label2.Name = "label2";
            label2.Size = new Size(394, 57);
            label2.TabIndex = 18;
            label2.Text = "Apuntes Pendientes";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1222, 473);
            label3.TabIndex = 19;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 192, 192);
            iconButton1.Font = new Font("Segoe UI", 25F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.BottomCenter;
            iconButton1.Location = new Point(1081, 60);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(78, 83);
            iconButton1.TabIndex = 25;
            iconButton1.TextAlign = ContentAlignment.TopCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // PagarTodo
            // 
            PagarTodo.HeaderText = "";
            PagarTodo.MinimumWidth = 6;
            PagarTodo.Name = "PagarTodo";
            PagarTodo.ReadOnly = true;
            PagarTodo.Resizable = DataGridViewTriState.True;
            PagarTodo.SortMode = DataGridViewColumnSortMode.Automatic;
            PagarTodo.Text = "Pagar Todo";
            PagarTodo.UseColumnTextForButtonValue = true;
            PagarTodo.Width = 150;
            // 
            // Detalles
            // 
            Detalles.HeaderText = "";
            Detalles.MinimumWidth = 6;
            Detalles.Name = "Detalles";
            Detalles.ReadOnly = true;
            Detalles.Text = "Detalles";
            Detalles.UseColumnTextForButtonValue = true;
            Detalles.Width = 125;
            // 
            // IdEmpleado
            // 
            IdEmpleado.DataPropertyName = "IdEmpleado";
            IdEmpleado.HeaderText = "IdEmpleado";
            IdEmpleado.MinimumWidth = 6;
            IdEmpleado.Name = "IdEmpleado";
            IdEmpleado.ReadOnly = true;
            IdEmpleado.Visible = false;
            IdEmpleado.Width = 125;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // LugarTrabajo
            // 
            LugarTrabajo.DataPropertyName = "LugarTrabajo";
            LugarTrabajo.HeaderText = "Trabajo";
            LugarTrabajo.MinimumWidth = 6;
            LugarTrabajo.Name = "LugarTrabajo";
            LugarTrabajo.ReadOnly = true;
            LugarTrabajo.Visible = false;
            LugarTrabajo.Width = 125;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Total en Apuntes";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 200;
            // 
            // frmApuntes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1222, 871);
            ControlBox = false;
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(btnVerHistorial);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridApuntes);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmApuntes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmApuntes";
            Load += frmApuntes_Load;
            ((System.ComponentModel.ISupportInitialize)gridApuntes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Label lblBuscarNombre;
        private DataGridView gridApuntes;
        private ComboBox cmbTrabajo;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnVerHistorial;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridViewButtonColumn PagarTodo;
        private DataGridViewButtonColumn Detalles;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn LugarTrabajo;
        private DataGridViewTextBoxColumn Monto;
    }
}