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
            EnviarBtn = new Button();
            RankingLbl = new Label();
            Materia3Lbl = new Label();
            Materia3Cmb = new ComboBox();
            rankingListView = new ListView();
            rankingList = new ColumnHeader();
            SuspendLayout();
            // 
            // Materia1Lbl
            // 
            Materia1Lbl.AutoSize = true;
            Materia1Lbl.Location = new Point(40, 80);
            Materia1Lbl.Name = "Materia1Lbl";
            Materia1Lbl.Size = new Size(135, 20);
            Materia1Lbl.TabIndex = 0;
            Materia1Lbl.Text = "Seleccione Materia";
            // 
            // Materia2Lbl
            // 
            Materia2Lbl.AutoSize = true;
            Materia2Lbl.Location = new Point(40, 222);
            Materia2Lbl.Name = "Materia2Lbl";
            Materia2Lbl.Size = new Size(135, 20);
            Materia2Lbl.TabIndex = 1;
            Materia2Lbl.Text = "Seleccione Materia";
            // 
            // Materia1Cmb
            // 
            Materia1Cmb.FormattingEnabled = true;
            Materia1Cmb.Location = new Point(40, 102);
            Materia1Cmb.Margin = new Padding(3, 2, 3, 2);
            Materia1Cmb.Name = "Materia1Cmb";
            Materia1Cmb.Size = new Size(225, 28);
            Materia1Cmb.TabIndex = 3;
            // 
            // Materia2Cmb
            // 
            Materia2Cmb.FormattingEnabled = true;
            Materia2Cmb.Location = new Point(40, 244);
            Materia2Cmb.Margin = new Padding(3, 2, 3, 2);
            Materia2Cmb.Name = "Materia2Cmb";
            Materia2Cmb.Size = new Size(225, 28);
            Materia2Cmb.TabIndex = 4;
            // 
            // AtrasInscMatBtn
            // 
            AtrasInscMatBtn.Location = new Point(40, 502);
            AtrasInscMatBtn.Margin = new Padding(3, 2, 3, 2);
            AtrasInscMatBtn.Name = "AtrasInscMatBtn";
            AtrasInscMatBtn.Size = new Size(118, 42);
            AtrasInscMatBtn.TabIndex = 6;
            AtrasInscMatBtn.Text = "Atras";
            AtrasInscMatBtn.UseVisualStyleBackColor = true;
            AtrasInscMatBtn.Click += AtrasInscMatBtn_Click;
            // 
            // EnviarBtn
            // 
            EnviarBtn.Location = new Point(671, 502);
            EnviarBtn.Margin = new Padding(3, 2, 3, 2);
            EnviarBtn.Name = "EnviarBtn";
            EnviarBtn.Size = new Size(111, 42);
            EnviarBtn.TabIndex = 7;
            EnviarBtn.Text = "Enviar";
            EnviarBtn.UseVisualStyleBackColor = true;
            EnviarBtn.Click += EnviarBtn_Click;
            // 
            // RankingLbl
            // 
            RankingLbl.AutoSize = true;
            RankingLbl.Location = new Point(498, 105);
            RankingLbl.Name = "RankingLbl";
            RankingLbl.Size = new Size(62, 20);
            RankingLbl.TabIndex = 8;
            RankingLbl.Text = "Ranking";
            // 
            // Materia3Lbl
            // 
            Materia3Lbl.AutoSize = true;
            Materia3Lbl.Location = new Point(40, 374);
            Materia3Lbl.Name = "Materia3Lbl";
            Materia3Lbl.Size = new Size(135, 20);
            Materia3Lbl.TabIndex = 2;
            Materia3Lbl.Text = "Seleccione Materia";
            // 
            // Materia3Cmb
            // 
            Materia3Cmb.FormattingEnabled = true;
            Materia3Cmb.Location = new Point(40, 396);
            Materia3Cmb.Margin = new Padding(3, 2, 3, 2);
            Materia3Cmb.Name = "Materia3Cmb";
            Materia3Cmb.Size = new Size(225, 28);
            Materia3Cmb.TabIndex = 5;
            // 
            // rankingListView
            // 
            rankingListView.Columns.AddRange(new ColumnHeader[] { rankingList });
            rankingListView.Location = new Point(564, 95);
            rankingListView.Margin = new Padding(2);
            rankingListView.Name = "rankingListView";
            rankingListView.Size = new Size(141, 34);
            rankingListView.TabIndex = 10;
            rankingListView.UseCompatibleStateImageBehavior = false;
            // 
            // rankingList
            // 
            rankingList.Text = "Ranking";
            rankingList.Width = 100;
            // 
            // InscripcionMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 574);
            Controls.Add(rankingListView);
            Controls.Add(RankingLbl);
            Controls.Add(EnviarBtn);
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
        private Button EnviarBtn;
        private Label RankingLbl;
        private Label Materia3Lbl;
        private ComboBox Materia3Cmb;
        private ListView rankingListView;
        private ColumnHeader rankingList;
    }
}