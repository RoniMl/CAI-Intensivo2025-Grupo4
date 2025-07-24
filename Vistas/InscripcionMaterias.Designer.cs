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
            Materia1Cmb = new ComboBox();
            Materia2Cmb = new ComboBox();
            AtrasInscMatBtn = new Button();
            AtrasInscMatBtn.Click += AtrasInscMatBtn_Click;
            EnviarInscMatBtn = new Button();
            EnviarInscMatBtn.Click += EnviarInscMatBtn_Click;
            RankingLbl = new Label();
            RankingTxt = new TextBox();
            Materia3Lbl = new Label();
            Materia3Cmb = new ComboBox();
            SuspendLayout();
            // 
            // Materia1Lbl
            // 
            Materia1Lbl.AutoSize = true;
            Materia1Lbl.Location = new Point(35, 52);
            Materia1Lbl.Name = "Materia1Lbl";
            Materia1Lbl.Size = new Size(106, 15);
            Materia1Lbl.TabIndex = 0;
            Materia1Lbl.Text = "Seleccione Materia";
            // 
            // Materia2Lbl
            // 
            Materia2Lbl.AutoSize = true;
            Materia2Lbl.Location = new Point(35, 154);
            Materia2Lbl.Name = "Materia2Lbl";
            Materia2Lbl.Size = new Size(106, 15);
            Materia2Lbl.TabIndex = 1;
            Materia2Lbl.Text = "Seleccione Materia";
            // 
            // Materia1Cmb
            // 
            Materia1Cmb.FormattingEnabled = true;
            Materia1Cmb.Location = new Point(35, 77);
            Materia1Cmb.Margin = new Padding(3, 2, 3, 2);
            Materia1Cmb.Name = "Materia1Cmb";
            Materia1Cmb.Size = new Size(119, 23);
            Materia1Cmb.TabIndex = 3;
            // 
            // Materia2Cmb
            // 
            Materia2Cmb.FormattingEnabled = true;
            Materia2Cmb.Location = new Point(35, 183);
            Materia2Cmb.Margin = new Padding(3, 2, 3, 2);
            Materia2Cmb.Name = "Materia2Cmb";
            Materia2Cmb.Size = new Size(119, 23);
            Materia2Cmb.TabIndex = 4;
            // 
            // AtrasInscMatBtn
            // 
            AtrasInscMatBtn.Location = new Point(35, 377);
            AtrasInscMatBtn.Margin = new Padding(3, 2, 3, 2);
            AtrasInscMatBtn.Name = "AtrasInscMatBtn";
            AtrasInscMatBtn.Size = new Size(103, 32);
            AtrasInscMatBtn.TabIndex = 6;
            AtrasInscMatBtn.Text = "Atras";
            AtrasInscMatBtn.UseVisualStyleBackColor = true;
            // 
            // EnviarInscMatBtn
            // 
            EnviarInscMatBtn.Location = new Point(587, 377);
            EnviarInscMatBtn.Margin = new Padding(3, 2, 3, 2);
            EnviarInscMatBtn.Name = "EnviarInscMatBtn";
            EnviarInscMatBtn.Size = new Size(97, 32);
            EnviarInscMatBtn.TabIndex = 7;
            EnviarInscMatBtn.Text = "Enviar";
            EnviarInscMatBtn.UseVisualStyleBackColor = true;
            // 
            // RankingLbl
            // 
            RankingLbl.AutoSize = true;
            RankingLbl.Location = new Point(443, 52);
            RankingLbl.Name = "RankingLbl";
            RankingLbl.Size = new Size(50, 15);
            RankingLbl.TabIndex = 8;
            RankingLbl.Text = "Ranking";
            // 
            // RankingTxt
            // 
            RankingTxt.Location = new Point(527, 49);
            RankingTxt.Name = "RankingTxt";
            RankingTxt.Size = new Size(100, 23);
            RankingTxt.TabIndex = 9;
            // 
            // Materia3Lbl
            // 
            Materia3Lbl.AutoSize = true;
            Materia3Lbl.Location = new Point(35, 270);
            Materia3Lbl.Name = "Materia3Lbl";
            Materia3Lbl.Size = new Size(106, 15);
            Materia3Lbl.TabIndex = 2;
            Materia3Lbl.Text = "Seleccione Materia";
            // 
            // Materia3Cmb
            // 
            Materia3Cmb.FormattingEnabled = true;
            Materia3Cmb.Location = new Point(35, 297);
            Materia3Cmb.Margin = new Padding(3, 2, 3, 2);
            Materia3Cmb.Name = "Materia3Cmb";
            Materia3Cmb.Size = new Size(119, 23);
            Materia3Cmb.TabIndex = 5;
            // 
            // InscripcionMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 431);
            Controls.Add(RankingTxt);
            Controls.Add(RankingLbl);
            Controls.Add(EnviarInscMatBtn);
            Controls.Add(AtrasInscMatBtn);
            Controls.Add(Materia3Cmb);
            Controls.Add(Materia2Cmb);
            Controls.Add(Materia1Cmb);
            Controls.Add(Materia3Lbl);
            Controls.Add(Materia2Lbl);
            Controls.Add(Materia1Lbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InscripcionMaterias";
            Text = "Inscripción a materias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Materia1Lbl;
        private Label Materia2Lbl;
        private ComboBox Materia1Cmb;
        private ComboBox Materia2Cmb;
        private Button AtrasInscMatBtn;
        private Button EnviarInscMatBtn;
        private Label RankingLbl;
        private TextBox RankingTxt;
        private Label Materia3Lbl;
        private ComboBox Materia3Cmb;
    }
}