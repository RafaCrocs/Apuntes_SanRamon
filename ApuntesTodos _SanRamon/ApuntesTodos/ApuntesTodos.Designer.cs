namespace ApuntesTodos
{
    partial class ApuntesTodos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gridApuntes = new DataGridView();
            Pagado = new DataGridViewButtonColumn();
            Detalles = new DataGridViewButtonColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
            LugarTrabajo = new DataGridViewTextBoxColumn();
            Zarcereño = new DataGridViewTextBoxColumn();
            Souvenir = new DataGridViewTextBoxColumn();
            Restaurante = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            cmbTrabajo = new ComboBox();
            label1 = new Label();
            txtNombre = new TextBox();
            lblBuscarNombre = new Label();
            btnActualizar = new Button();
            label2 = new Label();
            button1 = new Button();
            btnAgreagrColaborador = new Button();
            ((System.ComponentModel.ISupportInitialize)gridApuntes).BeginInit();
            SuspendLayout();
            // 
            // gridApuntes
            // 
            gridApuntes.BackgroundColor = SystemColors.Control;
            gridApuntes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridApuntes.Columns.AddRange(new DataGridViewColumn[] { Pagado, Detalles, NombreCompleto, IdEmpleado, LugarTrabajo, Zarcereño, Souvenir, Restaurante, Total });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridApuntes.DefaultCellStyle = dataGridViewCellStyle1;
            gridApuntes.Location = new Point(80, 203);
            gridApuntes.Margin = new Padding(3, 4, 3, 4);
            gridApuntes.Name = "gridApuntes";
            gridApuntes.ReadOnly = true;
            gridApuntes.RowHeadersWidth = 51;
            gridApuntes.Size = new Size(1289, 564);
            gridApuntes.TabIndex = 0;
            gridApuntes.CellContentClick += gridApuntes_CellContentClick;
            gridApuntes.CellFormatting += gridApuntes_CellFormatting;
            // 
            // Pagado
            // 
            Pagado.HeaderText = "";
            Pagado.MinimumWidth = 6;
            Pagado.Name = "Pagado";
            Pagado.ReadOnly = true;
            Pagado.Text = "Pagado";
            Pagado.UseColumnTextForButtonValue = true;
            Pagado.Width = 125;
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
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "Nombre";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
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
            // LugarTrabajo
            // 
            LugarTrabajo.DataPropertyName = "LugarTrabajo";
            LugarTrabajo.HeaderText = "De:";
            LugarTrabajo.MinimumWidth = 6;
            LugarTrabajo.Name = "LugarTrabajo";
            LugarTrabajo.ReadOnly = true;
            LugarTrabajo.Visible = false;
            LugarTrabajo.Width = 125;
            // 
            // Zarcereño
            // 
            Zarcereño.DataPropertyName = "Zarcereño";
            Zarcereño.HeaderText = "Zarcereño";
            Zarcereño.MinimumWidth = 6;
            Zarcereño.Name = "Zarcereño";
            Zarcereño.ReadOnly = true;
            Zarcereño.Width = 125;
            // 
            // Souvenir
            // 
            Souvenir.DataPropertyName = "Souvenir";
            Souvenir.HeaderText = "Souvenir";
            Souvenir.MinimumWidth = 6;
            Souvenir.Name = "Souvenir";
            Souvenir.ReadOnly = true;
            Souvenir.Width = 125;
            // 
            // Restaurante
            // 
            Restaurante.DataPropertyName = "Restaurante";
            Restaurante.HeaderText = "Restaurante";
            Restaurante.MinimumWidth = 6;
            Restaurante.Name = "Restaurante";
            Restaurante.ReadOnly = true;
            Restaurante.Width = 125;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 150;
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(409, 144);
            cmbTrabajo.Margin = new Padding(3, 4, 3, 4);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(212, 43);
            cmbTrabajo.TabIndex = 8;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(80, 147);
            label1.Name = "label1";
            label1.Size = new Size(327, 35);
            label1.TabIndex = 7;
            label1.Text = "Buscar por lugar de Trabajo:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(354, 77);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 41);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.BackColor = SystemColors.ActiveCaption;
            lblBuscarNombre.Font = new Font("Segoe UI", 15F);
            lblBuscarNombre.Location = new Point(80, 84);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(239, 35);
            lblBuscarNombre.TabIndex = 5;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(192, 255, 192);
            btnActualizar.Location = new Point(1210, 147);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(159, 48);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1489, 492);
            label2.TabIndex = 13;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Location = new Point(1045, 147);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(159, 48);
            button1.TabIndex = 14;
            button1.Text = "HISTORIAL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAgreagrColaborador
            // 
            btnAgreagrColaborador.BackColor = Color.FromArgb(192, 192, 255);
            btnAgreagrColaborador.Location = new Point(830, 147);
            btnAgreagrColaborador.Margin = new Padding(3, 4, 3, 4);
            btnAgreagrColaborador.Name = "btnAgreagrColaborador";
            btnAgreagrColaborador.Size = new Size(209, 48);
            btnAgreagrColaborador.TabIndex = 15;
            btnAgreagrColaborador.Text = "Agregar Colaborador";
            btnAgreagrColaborador.UseVisualStyleBackColor = false;
            btnAgreagrColaborador.Click += btnAgreagrColaborador_Click;
            // 
            // ApuntesTodos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 916);
            Controls.Add(btnAgreagrColaborador);
            Controls.Add(button1);
            Controls.Add(btnActualizar);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridApuntes);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApuntesTodos";
            Text = "Apuntes Todos    v1.0.0";
            Load += ApuntesTodos_Load;
            ((System.ComponentModel.ISupportInitialize)gridApuntes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridApuntes;
        private ComboBox cmbTrabajo;
        private Label label1;
        private TextBox txtNombre;
        private Label lblBuscarNombre;
        private Button btnActualizar;
        private Label label2;
        private Button button1;
        private DataGridViewButtonColumn Pagado;
        private DataGridViewButtonColumn Detalles;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn LugarTrabajo;
        private DataGridViewTextBoxColumn Zarcereño;
        private DataGridViewTextBoxColumn Souvenir;
        private DataGridViewTextBoxColumn Restaurante;
        private DataGridViewTextBoxColumn Total;
        private Button btnAgreagrColaborador;
    }
}
