namespace T3_P_ORM_SQL.Vistas.Pacientes_Crud
{
    partial class Pacientes_Ver
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
            DgvPacientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // DgvPacientes
            // 
            DgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPacientes.Location = new Point(12, 17);
            DgvPacientes.Name = "DgvPacientes";
            DgvPacientes.Size = new Size(420, 241);
            DgvPacientes.TabIndex = 1;
            // 
            // Pacientes_Ver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 274);
            Controls.Add(DgvPacientes);
            Name = "Pacientes_Ver";
            Text = "Ver Pacientes";
            ((System.ComponentModel.ISupportInitialize)DgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvPacientes;
    }
}