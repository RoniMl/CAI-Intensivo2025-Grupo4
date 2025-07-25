namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class InscripcionFinales
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
            MateriaFinalLbl = new Label();
            MateriaFinalCmb = new ComboBox();
            AtrasInscFinBtn = new Button();
            this.AtrasInscFinBtn.Click += new System.EventHandler(this.AtrasBtn_Click);
            EnviarInscFinBtn = new Button();
            this.EnviarInscFinBtn.Click += new System.EventHandler(this.EnviarInscFinBtn_Click);
            this.Load += new System.EventHandler(this.InscripcionFinales_Load);
            SuspendLayout();
            // 
            // MateriaFinalLbl
            // 
            MateriaFinalLbl.AutoSize = true;
            MateriaFinalLbl.Location = new Point(66, 49);
            MateriaFinalLbl.Name = "MateriaFinalLbl";
            MateriaFinalLbl.Size = new Size(118, 17);
            MateriaFinalLbl.TabIndex = 0;
            MateriaFinalLbl.Text = "Seleccione Materia";
            // 
            // MateriaFinalCmb
            // 
            MateriaFinalCmb.FormattingEnabled = true;
            MateriaFinalCmb.Location = new Point(66, 68);
            MateriaFinalCmb.Margin = new Padding(3, 2, 3, 2);
            MateriaFinalCmb.Name = "MateriaFinalCmb";
            MateriaFinalCmb.Size = new Size(133, 23);
            MateriaFinalCmb.TabIndex = 1;
            // 
            // AtrasInscFinBtn
            // 
            AtrasInscFinBtn.Location = new Point(66, 294);
            AtrasInscFinBtn.Margin = new Padding(3, 2, 3, 2);
            AtrasInscFinBtn.Name = "AtrasInscFinBtn";
            AtrasInscFinBtn.Size = new Size(74, 26);
            AtrasInscFinBtn.TabIndex = 2;
            AtrasInscFinBtn.Text = "Atras";
            AtrasInscFinBtn.UseVisualStyleBackColor = true;
            // 
            // EnviarInscFinBtn
            // 
            EnviarInscFinBtn.Location = new Point(550, 294);
            EnviarInscFinBtn.Margin = new Padding(3, 2, 3, 2);
            EnviarInscFinBtn.Name = "EnviarInscFinBtn";
            EnviarInscFinBtn.Size = new Size(79, 26);
            EnviarInscFinBtn.TabIndex = 3;
            EnviarInscFinBtn.Text = "Enviar";
            EnviarInscFinBtn.UseVisualStyleBackColor = true;
            // 
            // InscripcionFinales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(EnviarInscFinBtn);
            Controls.Add(AtrasInscFinBtn);
            Controls.Add(MateriaFinalCmb);
            Controls.Add(MateriaFinalLbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InscripcionFinales";
            Text = "Inscripción a finales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MateriaFinalLbl;
        private ComboBox MateriaFinalCmb;
        private Button AtrasInscFinBtn;
        private Button EnviarInscFinBtn;
    }
}