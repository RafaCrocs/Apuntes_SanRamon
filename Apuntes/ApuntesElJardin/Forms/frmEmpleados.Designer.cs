namespace ApuntesElJardin.Forms
{
    partial class frmEmpleados
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
            gridEmpleados = new DataGridView();
            lblBuscarNombre = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            cmbTrabajo = new ComboBox();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).BeginInit();
            SuspendLayout();
            // 
            // gridEmpleados
            // 
            gridEmpleados.BackgroundColor = SystemColors.Control;
            gridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridEmpleados.DefaultCellStyle = dataGridViewCellStyle1;
            gridEmpleados.Location = new Point(74, 261);
            gridEmpleados.Margin = new Padding(3, 4, 3, 4);
            gridEmpleados.Name = "gridEmpleados";
            gridEmpleados.ReadOnly = true;
            gridEmpleados.RowHeadersWidth = 51;
            gridEmpleados.Size = new Size(945, 527);
            gridEmpleados.TabIndex = 0;
            gridEmpleados.CellContentDoubleClick += gridEmpleados_CellContentDoubleClick;
            gridEmpleados.CellDoubleClick += gridEmpleados_CellDoubleClick;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 15F);
            lblBuscarNombre.Location = new Point(74, 120);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(239, 35);
            lblBuscarNombre.TabIndex = 1;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(330, 117);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 41);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(74, 181);
            label1.Name = "label1";
            label1.Size = new Size(333, 35);
            label1.TabIndex = 3;
            label1.Text = "Buscar por Lugar de Trabajo:";
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(385, 179);
            cmbTrabajo.Margin = new Padding(3, 4, 3, 4);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(212, 43);
            cmbTrabajo.TabIndex = 4;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 15F);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 30;
            btnNuevo.ImageAlign = ContentAlignment.BottomLeft;
            btnNuevo.Location = new Point(896, 204);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(123, 51);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Visible = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 192, 192);
            iconButton1.Font = new Font("Segoe UI", 20F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.BottomCenter;
            iconButton1.Location = new Point(1018, 29);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(62, 69);
            iconButton1.TabIndex = 25;
            iconButton1.TextAlign = ContentAlignment.TopCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 884);
            ControlBox = false;
            Controls.Add(iconButton1);
            Controls.Add(btnNuevo);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridEmpleados);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Colaboradores";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridEmpleados;
        private Label lblBuscarNombre;
        private TextBox txtNombre;
        private Label label1;
        private ComboBox cmbTrabajo;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}