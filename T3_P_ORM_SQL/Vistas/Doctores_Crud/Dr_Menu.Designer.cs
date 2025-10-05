namespace T3_P_ORM_SQL.Vistas.Doctores_Crud
{
    partial class Dr_Menu
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
            BtnEliminar = new Button();
            BtnModificar = new Button();
            BtnCrear = new Button();
            Titulo = new Label();
            BtnVer = new Button();
            SuspendLayout();
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(244, 182);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 23);
            BtnEliminar.TabIndex = 10;
            BtnEliminar.Text = "Eliminar Doctor";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(67, 182);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(123, 23);
            BtnModificar.TabIndex = 9;
            BtnModificar.Text = "Modificar Doctores";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(244, 144);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(107, 23);
            BtnCrear.TabIndex = 8;
            BtnCrear.Text = "Crear Doctor";
            BtnCrear.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(85, 59);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(252, 37);
            Titulo.TabIndex = 7;
            Titulo.Text = "Menu de Doctores";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnVer
            // 
            BtnVer.Location = new Point(67, 144);
            BtnVer.Name = "BtnVer";
            BtnVer.Size = new Size(107, 23);
            BtnVer.TabIndex = 6;
            BtnVer.Text = "Ver Doctores";
            BtnVer.UseVisualStyleBackColor = true;
            // 
            // Dr_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 285);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnCrear);
            Controls.Add(Titulo);
            Controls.Add(BtnVer);
            Name = "Dr_Menu";
            Text = "Menu de Doctores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEliminar;
        private Button BtnModificar;
        private Button BtnCrear;
        private Label Titulo;
        private Button BtnVer;
    }
}