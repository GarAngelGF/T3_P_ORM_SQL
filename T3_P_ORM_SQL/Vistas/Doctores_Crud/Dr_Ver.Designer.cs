namespace T3_P_ORM_SQL.Vistas.Doctores_Crud
{
    partial class Dr_Ver
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
            DgvDoctores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvDoctores).BeginInit();
            SuspendLayout();
            // 
            // DgvDoctores
            // 
            DgvDoctores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDoctores.Location = new Point(12, 17);
            DgvDoctores.Name = "DgvDoctores";
            DgvDoctores.Size = new Size(420, 241);
            DgvDoctores.TabIndex = 1;
            // 
            // Dr_Ver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 274);
            Controls.Add(DgvDoctores);
            Name = "Dr_Ver";
            Text = "Ver Doctores";
            ((System.ComponentModel.ISupportInitialize)DgvDoctores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvDoctores;
    }
}