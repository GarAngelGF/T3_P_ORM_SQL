namespace T3_P_ORM_SQL
{
    partial class Main
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
            Titulo = new Label();
            CitasBtn = new Button();
            PacientesBtn = new Button();
            DoctorBtn = new Button();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(2, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(230, 74);
            Titulo.TabIndex = 0;
            Titulo.Text = "Tarea 3 \r\nRegistro de citas";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            Titulo.Click += Titulo_Click;
            // 
            // CitasBtn
            // 
            CitasBtn.Location = new Point(77, 100);
            CitasBtn.Name = "CitasBtn";
            CitasBtn.Size = new Size(75, 23);
            CitasBtn.TabIndex = 1;
            CitasBtn.Text = "Citas";
            CitasBtn.UseVisualStyleBackColor = true;
            CitasBtn.Click += CitasBtn_Click;
            // 
            // PacientesBtn
            // 
            PacientesBtn.Location = new Point(77, 181);
            PacientesBtn.Name = "PacientesBtn";
            PacientesBtn.Size = new Size(75, 23);
            PacientesBtn.TabIndex = 2;
            PacientesBtn.Text = "Pacientes";
            PacientesBtn.UseVisualStyleBackColor = true;
            PacientesBtn.Click += PacientesBtn_Click;
            // 
            // DoctorBtn
            // 
            DoctorBtn.Location = new Point(77, 140);
            DoctorBtn.Name = "DoctorBtn";
            DoctorBtn.Size = new Size(75, 23);
            DoctorBtn.TabIndex = 3;
            DoctorBtn.Text = "Doctores";
            DoctorBtn.UseVisualStyleBackColor = true;
            DoctorBtn.Click += DoctorBtn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(234, 222);
            Controls.Add(DoctorBtn);
            Controls.Add(PacientesBtn);
            Controls.Add(CitasBtn);
            Controls.Add(Titulo);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal T3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button CitasBtn;
        private Button PacientesBtn;
        private Button DoctorBtn;
    }
}
