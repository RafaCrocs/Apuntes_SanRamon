namespace ApuntesElJardin.Modals
{
    partial class AgregarEmpleadoModal
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
            txtNombreCompleto = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblNombreCompleto = new Label();
            lblTrabajo = new Label();
            cmbTrabajo = new ComboBox();
            SuspendLayout();
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 15F);
            txtNombreCompleto.Location = new Point(20, 130);
            txtNombreCompleto.MaxLength = 100;
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(340, 34);
            txtNombreCompleto.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.Font = new Font("Segoe UI", 15F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(53, 336);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 51);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Font = new Font("Segoe UI", 15F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(214, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 51);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new Font("Segoe UI", 15F);
            lblNombreCompleto.Location = new Point(20, 88);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(181, 28);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // lblTrabajo
            // 
            lblTrabajo.AutoSize = true;
            lblTrabajo.Font = new Font("Segoe UI", 15F);
            lblTrabajo.Location = new Point(20, 177);
            lblTrabajo.Name = "lblTrabajo";
            lblTrabajo.Size = new Size(161, 28);
            lblTrabajo.TabIndex = 2;
            lblTrabajo.Text = "Lugar de Trabajo:";
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(20, 215);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(247, 36);
            cmbTrabajo.TabIndex = 6;
            // 
            // AgregarEmpleadoModal
            // 
            ClientSize = new Size(403, 480);
            ControlBox = false;
            Controls.Add(cmbTrabajo);
            Controls.Add(lblNombreCompleto);
            Controls.Add(txtNombreCompleto);
            Controls.Add(lblTrabajo);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarEmpleadoModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Colaborador";
            Load += AgregarEmpleadoModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Declaración de controles
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblTrabajo;
        private ComboBox cmbTrabajo;
    }
}