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
            SuspendLayout();
            // 
            // ModuloInscMatBtn
            // 
            ModuloInscMatBtn.Location = new Point(234, 84);
            ModuloInscMatBtn.Margin = new Padding(3, 2, 3, 2);
            ModuloInscMatBtn.Name = "ModuloInscMatBtn";
            ModuloInscMatBtn.Size = new Size(209, 52);
            ModuloInscMatBtn.TabIndex = 0;
            ModuloInscMatBtn.Text = " Modulo de inscripción a materia";
            ModuloInscMatBtn.UseVisualStyleBackColor = true;
            ModuloInscMatBtn.Click += btnInscripcionMaterias_Click;
            // 
            // ModuloInscFinBtn
            // 
            ModuloInscFinBtn.Location = new Point(235, 176);
            ModuloInscFinBtn.Margin = new Padding(3, 2, 3, 2);
            ModuloInscFinBtn.Name = "ModuloInscFinBtn";
            ModuloInscFinBtn.Size = new Size(209, 50);
            ModuloInscFinBtn.TabIndex = 1;
            ModuloInscFinBtn.Text = "Modulo de inscripción a finales";
            ModuloInscFinBtn.UseVisualStyleBackColor = true;
            ModuloInscFinBtn.Click += btnInscripcionFinales_Click;
            // 
            // MenuAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(ModuloInscFinBtn);
            Controls.Add(ModuloInscMatBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuAlumno";
            Text = "Menu";
            Load += MenuAlumno_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ModuloInscMatBtn;
        private Button ModuloInscFinBtn;
    }
}