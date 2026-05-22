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
            ((System.ComponentModel.ISupportInitialize)gridDetalles).BeginInit();
            SuspendLayout();
            // 
            // gridDetalles
            // 
            gridDetalles.BackgroundColor = SystemColors.Control;
            gridDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridDetalles.DefaultCellStyle = dataGridViewCellStyle1;
            gridDetalles.Location = new Point(22, 178);
            gridDetalles.Name = "gridDetalles";
            gridDetalles.ReadOnly = true;
            gridDetalles.RowHeadersWidth = 51;
            gridDetalles.Size = new Size(950, 321);
            gridDetalles.TabIndex = 6;
            gridDetalles.CellContentClick += gridDetalles_CellContentClick;
            gridDetalles.CellFormatting += gridDetalles_CellFormatting;
            // 
            // lblDetallesDe
            // 
            lblDetallesDe.AutoSize = true;
            lblDetallesDe.BackColor = SystemColors.ActiveCaption;
            lblDetallesDe.Font = new Font("Segoe UI", 20F);
            lblDetallesDe.Location = new Point(22, 78);
            lblDetallesDe.Name = "lblDetallesDe";
            lblDetallesDe.Size = new Size(162, 37);
            lblDetallesDe.TabIndex = 7;
            lblDetallesDe.Text = "Detalles de: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaption;
            lblNombre.Font = new Font("Segoe UI", 25F);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(199, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 46);
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
            iconButton1.Location = new Point(904, 25);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(68, 62);
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
            label3.Size = new Size(1006, 342);
            label3.TabIndex = 27;
            // 
            // frmDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 572);
            ControlBox = false;
            Controls.Add(iconButton1);
            Controls.Add(lblNombre);
            Controls.Add(lblDetallesDe);
            Controls.Add(gridDetalles);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}