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
            GestionatAlumnosBtn = new Button();
            GestionarPersonaBtn = new Button();
            GestionDeDesbloqueosBtn = new Button();
            CerrarSesionBtn = new Button();
            GenerarReportesBtn = new Button();
            SuspendLayout();
            // 
            // GestionatAlumnosBtn
            // 
            GestionatAlumnosBtn.Location = new Point(273, 28);
            GestionatAlumnosBtn.Name = "GestionatAlumnosBtn";
            GestionatAlumnosBtn.Size = new Size(217, 43);
            GestionatAlumnosBtn.TabIndex = 0;
            GestionatAlumnosBtn.Text = "Gestionar Alumnos";
            GestionatAlumnosBtn.UseVisualStyleBackColor = true;
            GestionatAlumnosBtn.Click += GestionatAlumnosBtn_Click;
            // 
            // GestionarPersonaBtn
            // 
            GestionarPersonaBtn.Location = new Point(273, 109);
            GestionarPersonaBtn.Name = "GestionarPersonaBtn";
            GestionarPersonaBtn.Size = new Size(217, 43);
            GestionarPersonaBtn.TabIndex = 1;
            GestionarPersonaBtn.Text = "Gestionar Personal";
            GestionarPersonaBtn.UseVisualStyleBackColor = true;
            // 
            // GestionDeDesbloqueosBtn
            // 
            GestionDeDesbloqueosBtn.Location = new Point(273, 191);
            GestionDeDesbloqueosBtn.Name = "GestionDeDesbloqueosBtn";
            GestionDeDesbloqueosBtn.Size = new Size(217, 43);
            GestionDeDesbloqueosBtn.TabIndex = 3;
            GestionDeDesbloqueosBtn.Text = "Gestion de Desbloqueos";
            GestionDeDesbloqueosBtn.UseVisualStyleBackColor = true;
            GestionDeDesbloqueosBtn.Click += GestionDeDesbloqueosBtn_Click;
            // 
            // CerrarSesionBtn
            // 
            CerrarSesionBtn.Location = new Point(613, 399);
            CerrarSesionBtn.Name = "CerrarSesionBtn";
            CerrarSesionBtn.Size = new Size(160, 23);
            CerrarSesionBtn.TabIndex = 4;
            CerrarSesionBtn.Text = "Cerrar Sesion";
            CerrarSesionBtn.UseVisualStyleBackColor = true;
            CerrarSesionBtn.Click += CerrarSesionBtn_Click;
            // 
            // GenerarReportesBtn
            // 
            GenerarReportesBtn.Location = new Point(273, 278);
            GenerarReportesBtn.Name = "GenerarReportesBtn";
            GenerarReportesBtn.Size = new Size(217, 43);
            GenerarReportesBtn.TabIndex = 5;
            GenerarReportesBtn.Text = "Generar Reportes";
            GenerarReportesBtn.UseVisualStyleBackColor = true;
            GenerarReportesBtn.Click += button1_Click_2;
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GenerarReportesBtn);
            Controls.Add(CerrarSesionBtn);
            Controls.Add(GestionDeDesbloqueosBtn);
            Controls.Add(GestionarPersonaBtn);
            Controls.Add(GestionatAlumnosBtn);
            Name = "MenuAdministrador";
            Text = "Menu Administrador";
            Load += MenuAdministrador_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button GestionatAlumnosBtn;
        private Button GestionarPersonaBtn;
        private Button GestionDeDesbloqueosBtn;
        private Button CerrarSesionBtn;
        private Button GenerarReportesBtn;
    }
}