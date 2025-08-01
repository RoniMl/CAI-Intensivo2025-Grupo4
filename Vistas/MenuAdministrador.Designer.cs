namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class MenuAdministrador
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
            GestionarAlumnosBtn = new Button();
            GestionarPersonalBtn = new Button();
            GestionDeDesbloqueosBtn = new Button();
            CerrarSesionBtn = new Button();
            GenerarReportesBtn = new Button();
            SuspendLayout();
            // 
            // GestionarAlumnosBtn
            // 
            GestionarAlumnosBtn.Location = new Point(312, 37);
            GestionarAlumnosBtn.Margin = new Padding(3, 4, 3, 4);
            GestionarAlumnosBtn.Name = "GestionarAlumnosBtn";
            GestionarAlumnosBtn.Size = new Size(248, 57);
            GestionarAlumnosBtn.TabIndex = 0;
            GestionarAlumnosBtn.Text = "Gestionar Alumnos";
            GestionarAlumnosBtn.UseVisualStyleBackColor = true;
            GestionarAlumnosBtn.Click += GestionarAlumnosBtn_Click;
            // 
            // GestionarPersonalBtn
            // 
            GestionarPersonalBtn.Location = new Point(312, 145);
            GestionarPersonalBtn.Margin = new Padding(3, 4, 3, 4);
            GestionarPersonalBtn.Name = "GestionarPersonalBtn";
            GestionarPersonalBtn.Size = new Size(248, 57);
            GestionarPersonalBtn.TabIndex = 1;
            GestionarPersonalBtn.Text = "Gestionar Personal";
            GestionarPersonalBtn.UseVisualStyleBackColor = true;
            GestionarPersonalBtn.Click += GestionarPersonalBtn_Click;
            // 
            // GestionDeDesbloqueosBtn
            // 
            GestionDeDesbloqueosBtn.Location = new Point(312, 255);
            GestionDeDesbloqueosBtn.Margin = new Padding(3, 4, 3, 4);
            GestionDeDesbloqueosBtn.Name = "GestionDeDesbloqueosBtn";
            GestionDeDesbloqueosBtn.Size = new Size(248, 57);
            GestionDeDesbloqueosBtn.TabIndex = 3;
            GestionDeDesbloqueosBtn.Text = "Gestion de Desbloqueos";
            GestionDeDesbloqueosBtn.UseVisualStyleBackColor = true;
            GestionDeDesbloqueosBtn.Click += GestionDeDesbloqueosBtn_Click;
            // 
            // CerrarSesionBtn
            // 
            CerrarSesionBtn.Location = new Point(701, 532);
            CerrarSesionBtn.Margin = new Padding(3, 4, 3, 4);
            CerrarSesionBtn.Name = "CerrarSesionBtn";
            CerrarSesionBtn.Size = new Size(183, 31);
            CerrarSesionBtn.TabIndex = 4;
            CerrarSesionBtn.Text = "Cerrar Sesion";
            CerrarSesionBtn.UseVisualStyleBackColor = true;
            CerrarSesionBtn.Click += CerrarSesionBtn_Click;
            // 
            // GenerarReportesBtn
            // 
            GenerarReportesBtn.Location = new Point(312, 371);
            GenerarReportesBtn.Margin = new Padding(3, 4, 3, 4);
            GenerarReportesBtn.Name = "GenerarReportesBtn";
            GenerarReportesBtn.Size = new Size(248, 57);
            GenerarReportesBtn.TabIndex = 5;
            GenerarReportesBtn.Text = "Generar Reportes";
            GenerarReportesBtn.UseVisualStyleBackColor = true;
            GenerarReportesBtn.Click += GenerarReportesBtn_Click;
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(GenerarReportesBtn);
            Controls.Add(CerrarSesionBtn);
            Controls.Add(GestionDeDesbloqueosBtn);
            Controls.Add(GestionarPersonalBtn);
            Controls.Add(GestionarAlumnosBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuAdministrador";
            Text = "Menu Administrador";
            ResumeLayout(false);
        }

        #endregion

        private Button GestionarAlumnosBtn;
        private Button GestionarPersonalBtn;
        private Button GestionDeDesbloqueosBtn;
        private Button CerrarSesionBtn;
        private Button GenerarReportesBtn;
    }
}