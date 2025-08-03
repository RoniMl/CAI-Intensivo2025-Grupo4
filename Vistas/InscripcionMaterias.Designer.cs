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
            Curso1Lbl = new Label();
            Curso2Lbl = new Label();
            Curso3Lbl = new Label();
            Curso2Cmb = new ComboBox();
            Curso3Cmb = new ComboBox();
            Curso1Cmb = new ComboBox();
            Inscripcion3Grp = new GroupBox();
            Inscripcion1Grp = new GroupBox();
            Inscripcion2Grp = new GroupBox();
            Inscripcion3Grp.SuspendLayout();
            Inscripcion1Grp.SuspendLayout();
            Inscripcion2Grp.SuspendLayout();
            SuspendLayout();
            // 
            // Materia1Lbl
            // 
            Materia1Lbl.AutoSize = true;
            Materia1Lbl.Location = new Point(91, 33);
            Materia1Lbl.Name = "Materia1Lbl";
            Materia1Lbl.Size = new Size(135, 20);
            Materia1Lbl.TabIndex = 0;
            Materia1Lbl.Text = "Seleccione Materia";
            // 
            // Materia2Lbl
            // 
            Materia2Lbl.AutoSize = true;
            Materia2Lbl.Location = new Point(91, 38);
            Materia2Lbl.Name = "Materia2Lbl";
            Materia2Lbl.Size = new Size(135, 20);
            Materia2Lbl.TabIndex = 1;
            Materia2Lbl.Text = "Seleccione Materia";
            // 
            // Materia1Cmb
            // 
            Materia1Cmb.FormattingEnabled = true;
            Materia1Cmb.Location = new Point(91, 64);
            Materia1Cmb.Margin = new Padding(3, 2, 3, 2);
            Materia1Cmb.Name = "Materia1Cmb";
            Materia1Cmb.Size = new Size(225, 28);
            Materia1Cmb.TabIndex = 3;
            // 
            // Materia2Cmb
            // 
            Materia2Cmb.FormattingEnabled = true;
            Materia2Cmb.Location = new Point(91, 69);
            Materia2Cmb.Margin = new Padding(3, 2, 3, 2);
            Materia2Cmb.Name = "Materia2Cmb";
            Materia2Cmb.Size = new Size(225, 28);
            Materia2Cmb.TabIndex = 4;
            // 
            // AtrasInscMatBtn
            // 
            AtrasInscMatBtn.Location = new Point(40, 605);
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
            EnviarBtn.Location = new Point(671, 605);
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
            RankingLbl.Location = new Point(293, 21);
            RankingLbl.Name = "RankingLbl";
            RankingLbl.Size = new Size(0, 20);
            RankingLbl.TabIndex = 8;
            // 
            // Materia3Lbl
            // 
            Materia3Lbl.AutoSize = true;
            Materia3Lbl.Location = new Point(91, 38);
            Materia3Lbl.Name = "Materia3Lbl";
            Materia3Lbl.Size = new Size(135, 20);
            Materia3Lbl.TabIndex = 2;
            Materia3Lbl.Text = "Seleccione Materia";
            // 
            // Materia3Cmb
            // 
            Materia3Cmb.FormattingEnabled = true;
            Materia3Cmb.Location = new Point(91, 72);
            Materia3Cmb.Margin = new Padding(3, 2, 3, 2);
            Materia3Cmb.Name = "Materia3Cmb";
            Materia3Cmb.Size = new Size(225, 28);
            Materia3Cmb.TabIndex = 5;
            // 
            // rankingListView
            // 
            rankingListView.Columns.AddRange(new ColumnHeader[] { rankingList });
            rankingListView.Location = new Point(375, 11);
            rankingListView.Margin = new Padding(2);
            rankingListView.Name = "rankingListView";
            rankingListView.Size = new Size(105, 108);
            rankingListView.TabIndex = 10;
            rankingListView.UseCompatibleStateImageBehavior = false;
            rankingListView.View = View.Details;
            // 
            // rankingList
            // 
            rankingList.Text = "RANKING";
            rankingList.Width = 100;
            // 
            // Curso1Lbl
            // 
            Curso1Lbl.AutoSize = true;
            Curso1Lbl.Location = new Point(429, 33);
            Curso1Lbl.Name = "Curso1Lbl";
            Curso1Lbl.Size = new Size(121, 20);
            Curso1Lbl.TabIndex = 11;
            Curso1Lbl.Text = "Seleccione Curso";
            // 
            // Curso2Lbl
            // 
            Curso2Lbl.AutoSize = true;
            Curso2Lbl.Location = new Point(430, 38);
            Curso2Lbl.Name = "Curso2Lbl";
            Curso2Lbl.Size = new Size(121, 20);
            Curso2Lbl.TabIndex = 12;
            Curso2Lbl.Text = "Seleccione Curso";
            // 
            // Curso3Lbl
            // 
            Curso3Lbl.AutoSize = true;
            Curso3Lbl.Location = new Point(430, 40);
            Curso3Lbl.Name = "Curso3Lbl";
            Curso3Lbl.Size = new Size(121, 20);
            Curso3Lbl.TabIndex = 13;
            Curso3Lbl.Text = "Seleccione Curso";
            // 
            // Curso2Cmb
            // 
            Curso2Cmb.FormattingEnabled = true;
            Curso2Cmb.Location = new Point(430, 69);
            Curso2Cmb.Name = "Curso2Cmb";
            Curso2Cmb.Size = new Size(225, 28);
            Curso2Cmb.TabIndex = 14;
            // 
            // Curso3Cmb
            // 
            Curso3Cmb.FormattingEnabled = true;
            Curso3Cmb.Location = new Point(430, 72);
            Curso3Cmb.Name = "Curso3Cmb";
            Curso3Cmb.Size = new Size(225, 28);
            Curso3Cmb.TabIndex = 15;
            // 
            // Curso1Cmb
            // 
            Curso1Cmb.FormattingEnabled = true;
            Curso1Cmb.Location = new Point(429, 64);
            Curso1Cmb.Name = "Curso1Cmb";
            Curso1Cmb.Size = new Size(225, 28);
            Curso1Cmb.TabIndex = 16;
            // 
            // Inscripcion3Grp
            // 
            Inscripcion3Grp.Controls.Add(Materia3Cmb);
            Inscripcion3Grp.Controls.Add(Materia3Lbl);
            Inscripcion3Grp.Controls.Add(Curso3Cmb);
            Inscripcion3Grp.Controls.Add(Curso3Lbl);
            Inscripcion3Grp.Location = new Point(40, 428);
            Inscripcion3Grp.Name = "Inscripcion3Grp";
            Inscripcion3Grp.Size = new Size(742, 152);
            Inscripcion3Grp.TabIndex = 17;
            Inscripcion3Grp.TabStop = false;
            Inscripcion3Grp.Text = "3";
            // 
            // Inscripcion1Grp
            // 
            Inscripcion1Grp.Controls.Add(Materia1Cmb);
            Inscripcion1Grp.Controls.Add(Materia1Lbl);
            Inscripcion1Grp.Controls.Add(Curso1Cmb);
            Inscripcion1Grp.Controls.Add(Curso1Lbl);
            Inscripcion1Grp.Location = new Point(40, 124);
            Inscripcion1Grp.Name = "Inscripcion1Grp";
            Inscripcion1Grp.Size = new Size(742, 150);
            Inscripcion1Grp.TabIndex = 18;
            Inscripcion1Grp.TabStop = false;
            Inscripcion1Grp.Text = "1";
            // 
            // Inscripcion2Grp
            // 
            Inscripcion2Grp.Controls.Add(Materia2Lbl);
            Inscripcion2Grp.Controls.Add(Materia2Cmb);
            Inscripcion2Grp.Controls.Add(Curso2Lbl);
            Inscripcion2Grp.Controls.Add(Curso2Cmb);
            Inscripcion2Grp.Location = new Point(40, 280);
            Inscripcion2Grp.Name = "Inscripcion2Grp";
            Inscripcion2Grp.Size = new Size(742, 142);
            Inscripcion2Grp.TabIndex = 19;
            Inscripcion2Grp.TabStop = false;
            Inscripcion2Grp.Text = "2";
            // 
            // InscripcionMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 658);
            Controls.Add(Inscripcion2Grp);
            Controls.Add(Inscripcion1Grp);
            Controls.Add(Inscripcion3Grp);
            Controls.Add(rankingListView);
            Controls.Add(RankingLbl);
            Controls.Add(EnviarBtn);
            Controls.Add(AtrasInscMatBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InscripcionMaterias";
            Text = "Inscripción a materias";
            this.Load += new System.EventHandler(this.InscripcionMaterias_Load);
            Inscripcion3Grp.ResumeLayout(false);
            Inscripcion3Grp.PerformLayout();
            Inscripcion1Grp.ResumeLayout(false);
            Inscripcion1Grp.PerformLayout();
            Inscripcion2Grp.ResumeLayout(false);
            Inscripcion2Grp.PerformLayout();
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
        private Label Curso1Lbl;
        private Label Curso2Lbl;
        private Label Curso3Lbl;
        private ComboBox Curso2Cmb;
        private ComboBox Curso3Cmb;
        private ComboBox Curso1Cmb;
        private GroupBox Inscripcion3Grp;
        private GroupBox Inscripcion1Grp;
        private GroupBox Inscripcion2Grp;
    }
}