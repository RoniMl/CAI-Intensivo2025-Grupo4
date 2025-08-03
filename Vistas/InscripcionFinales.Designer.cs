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
            EnviarInscFinBtn = new Button();
            SuspendLayout();
            // 
            // MateriaFinalLbl
            // 
            MateriaFinalLbl.AutoSize = true;
            MateriaFinalLbl.Location = new Point(94, 81);
            MateriaFinalLbl.Margin = new Padding(4, 0, 4, 0);
            MateriaFinalLbl.Name = "MateriaFinalLbl";
            MateriaFinalLbl.Size = new Size(158, 25);
            MateriaFinalLbl.TabIndex = 0;
            MateriaFinalLbl.Text = "Seleccione Materia";
            // 
            // MateriaFinalCmb
            // 
            MateriaFinalCmb.FormattingEnabled = true;
            MateriaFinalCmb.Location = new Point(94, 114);
            MateriaFinalCmb.Margin = new Padding(4, 4, 4, 4);
            MateriaFinalCmb.Name = "MateriaFinalCmb";
            MateriaFinalCmb.Size = new Size(188, 33);
            MateriaFinalCmb.TabIndex = 1;
            // 
            // AtrasInscFinBtn
            // 
            AtrasInscFinBtn.Location = new Point(94, 314);
            AtrasInscFinBtn.Margin = new Padding(4, 4, 4, 4);
            AtrasInscFinBtn.Name = "AtrasInscFinBtn";
            AtrasInscFinBtn.Size = new Size(106, 44);
            AtrasInscFinBtn.TabIndex = 2;
            AtrasInscFinBtn.Text = "Atras";
            AtrasInscFinBtn.UseVisualStyleBackColor = true;
            // 
            // EnviarInscFinBtn
            // 
            EnviarInscFinBtn.Location = new Point(309, 110);
            EnviarInscFinBtn.Margin = new Padding(4, 4, 4, 4);
            EnviarInscFinBtn.Name = "EnviarInscFinBtn";
            EnviarInscFinBtn.Size = new Size(109, 39);
            EnviarInscFinBtn.TabIndex = 3;
            EnviarInscFinBtn.Text = "Enviar";
            EnviarInscFinBtn.UseVisualStyleBackColor = true;
            EnviarInscFinBtn.Click += EnviarInscFinBtn_Click;
            // 
            // InscripcionFinales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 396);
            Controls.Add(EnviarInscFinBtn);
            Controls.Add(AtrasInscFinBtn);
            Controls.Add(MateriaFinalCmb);
            Controls.Add(MateriaFinalLbl);
            Margin = new Padding(4, 4, 4, 4);
            Name = "InscripcionFinales";
            Text = "Inscripción a finales";
            Load += InscripcionFinales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label MateriaFinalLbl;
        public ComboBox MateriaFinalCmb;
        public Button AtrasInscFinBtn;
        public Button EnviarInscFinBtn;
    }
}