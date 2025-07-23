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
            ModuloInscMatBtn.Location = new Point(268, 112);
            ModuloInscMatBtn.Name = "ModuloInscMatBtn";
            ModuloInscMatBtn.Size = new Size(239, 69);
            ModuloInscMatBtn.TabIndex = 0;
            ModuloInscMatBtn.Text = " Modulo de inscripción a materia";
            ModuloInscMatBtn.UseVisualStyleBackColor = true;
            this.ModuloInscMatBtn.Click += new System.EventHandler(this.btnInscripcionMaterias_Click);

            // 
            // ModuloInscFinBtn
            // 
            ModuloInscFinBtn.Location = new Point(268, 235);
            ModuloInscFinBtn.Name = "ModuloInscFinBtn";
            ModuloInscFinBtn.Size = new Size(239, 66);
            ModuloInscFinBtn.TabIndex = 1;
            ModuloInscFinBtn.Text = "Modulo de inscripción a finales";
            ModuloInscFinBtn.UseVisualStyleBackColor = true;
            // 
            // MenuAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ModuloInscFinBtn);
            Controls.Add(ModuloInscMatBtn);
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