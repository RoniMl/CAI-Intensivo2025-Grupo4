namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class InscripcionMaterias
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
            Materia1Lbl = new Label();
            Materia2Lbl = new Label();
            Materia3Lbl = new Label();
            Materia1Cmb = new ComboBox();
            Materia2Cmb = new ComboBox();
            Materia3Cmb = new ComboBox();
            AtrasInscMatBtn = new Button();
            EnviarInscMatBtn = new Button();
            RankingLbl = new Label();
            SuspendLayout();
            // 
            // Materia1Lbl
            // 
            Materia1Lbl.AutoSize = true;
            Materia1Lbl.Location = new Point(40, 69);
            Materia1Lbl.Name = "Materia1Lbl";
            Materia1Lbl.Size = new Size(135, 20);
            Materia1Lbl.TabIndex = 0;
            Materia1Lbl.Text = "Seleccione Materia";
            // 
            // Materia2Lbl
            // 
            Materia2Lbl.AutoSize = true;
            Materia2Lbl.Location = new Point(40, 205);
            Materia2Lbl.Name = "Materia2Lbl";
            Materia2Lbl.Size = new Size(135, 20);
            Materia2Lbl.TabIndex = 1;
            Materia2Lbl.Text = "Seleccione Materia";
            // 
            // Materia3Lbl
            // 
            Materia3Lbl.AutoSize = true;
            Materia3Lbl.Location = new Point(40, 360);
            Materia3Lbl.Name = "Materia3Lbl";
            Materia3Lbl.Size = new Size(135, 20);
            Materia3Lbl.TabIndex = 2;
            Materia3Lbl.Text = "Seleccione Materia";
            // 
            // Materia1Cmb
            // 
            Materia1Cmb.FormattingEnabled = true;
            Materia1Cmb.Location = new Point(40, 103);
            Materia1Cmb.Name = "Materia1Cmb";
            Materia1Cmb.Size = new Size(135, 28);
            Materia1Cmb.TabIndex = 3;
            // 
            // Materia2Cmb
            // 
            Materia2Cmb.FormattingEnabled = true;
            Materia2Cmb.Location = new Point(40, 244);
            Materia2Cmb.Name = "Materia2Cmb";
            Materia2Cmb.Size = new Size(135, 28);
            Materia2Cmb.TabIndex = 4;
            // 
            // Materia3Cmb
            // 
            Materia3Cmb.FormattingEnabled = true;
            Materia3Cmb.Location = new Point(40, 396);
            Materia3Cmb.Name = "Materia3Cmb";
            Materia3Cmb.Size = new Size(135, 28);
            Materia3Cmb.TabIndex = 5;
            // 
            // AtrasInscMatBtn
            // 
            AtrasInscMatBtn.Location = new Point(40, 503);
            AtrasInscMatBtn.Name = "AtrasInscMatBtn";
            AtrasInscMatBtn.Size = new Size(118, 42);
            AtrasInscMatBtn.TabIndex = 6;
            AtrasInscMatBtn.Text = "Atras";
            AtrasInscMatBtn.UseVisualStyleBackColor = true;
            // 
            // EnviarInscMatBtn
            // 
            EnviarInscMatBtn.Location = new Point(671, 503);
            EnviarInscMatBtn.Name = "EnviarInscMatBtn";
            EnviarInscMatBtn.Size = new Size(111, 42);
            EnviarInscMatBtn.TabIndex = 7;
            EnviarInscMatBtn.Text = "Enviar";
            EnviarInscMatBtn.UseVisualStyleBackColor = true;
            // 
            // RankingLbl
            // 
            RankingLbl.AutoSize = true;
            RankingLbl.Location = new Point(506, 69);
            RankingLbl.Name = "RankingLbl";
            RankingLbl.Size = new Size(151, 20);
            RankingLbl.TabIndex = 8;
            RankingLbl.Text = "RANKINKG: XXXXXXX";
            // 
            // InscripcionMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 575);
            Controls.Add(RankingLbl);
            Controls.Add(EnviarInscMatBtn);
            Controls.Add(AtrasInscMatBtn);
            Controls.Add(Materia3Cmb);
            Controls.Add(Materia2Cmb);
            Controls.Add(Materia1Cmb);
            Controls.Add(Materia3Lbl);
            Controls.Add(Materia2Lbl);
            Controls.Add(Materia1Lbl);
            Name = "InscripcionMaterias";
            Text = "Inscripción a materias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Materia1Lbl;
        private Label Materia2Lbl;
        private Label Materia3Lbl;
        private ComboBox Materia1Cmb;
        private ComboBox Materia2Cmb;
        private ComboBox Materia3Cmb;
        private Button AtrasInscMatBtn;
        private Button EnviarInscMatBtn;
        private Label RankingLbl;
    }
}