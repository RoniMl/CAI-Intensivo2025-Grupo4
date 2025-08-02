namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class MenuAlumno
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
            ModuloInscMatBtn = new Button();
            ModuloInscFinBtn = new Button();
            cerrarSesion = new Button();
            SuspendLayout();
            // 
            // ModuloInscMatBtn
            // 
            ModuloInscMatBtn.Location = new Point(334, 140);
            ModuloInscMatBtn.Margin = new Padding(4, 3, 4, 3);
            ModuloInscMatBtn.Name = "ModuloInscMatBtn";
            ModuloInscMatBtn.Size = new Size(299, 87);
            ModuloInscMatBtn.TabIndex = 0;
            ModuloInscMatBtn.Text = " Modulo de inscripción a materia";
            ModuloInscMatBtn.UseVisualStyleBackColor = true;
            ModuloInscMatBtn.Click += btnInscripcionMaterias_Click;
            // 
            // ModuloInscFinBtn
            // 
            ModuloInscFinBtn.Location = new Point(336, 293);
            ModuloInscFinBtn.Margin = new Padding(4, 3, 4, 3);
            ModuloInscFinBtn.Name = "ModuloInscFinBtn";
            ModuloInscFinBtn.Size = new Size(299, 83);
            ModuloInscFinBtn.TabIndex = 1;
            ModuloInscFinBtn.Text = "Modulo de inscripción a finales";
            ModuloInscFinBtn.UseVisualStyleBackColor = true;
            ModuloInscFinBtn.Click += btnInscripcionFinales_Click;
            // 
            // cerrarSesion
            // 
            cerrarSesion.Location = new Point(839, 505);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(149, 46);
            cerrarSesion.TabIndex = 2;
            cerrarSesion.Text = "Cerrar Sesion";
            cerrarSesion.UseVisualStyleBackColor = true;
            cerrarSesion.Click += cerrarSesion_Click;
            // 
            // MenuAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 563);
            Controls.Add(cerrarSesion);
            Controls.Add(ModuloInscFinBtn);
            Controls.Add(ModuloInscMatBtn);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuAlumno";
            Text = "Menu";
            Load += MenuAlumno_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ModuloInscMatBtn;
        private Button ModuloInscFinBtn;
        private Button cerrarSesion;
    }
}