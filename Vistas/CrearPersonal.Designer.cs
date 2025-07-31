namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class CrearPersonal
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
            TipoCmb = new ComboBox();
            TipoLbl = new Label();
            NombreLbl = new Label();
            ApellidoLbl = new Label();
            AtrasBtn = new Button();
            CrearPersonalBtn = new Button();
            NombreTxb = new TextBox();
            ApellidoTxb = new TextBox();
            MateriasLbl = new Label();
            CursosLbl = new Label();
            CursosAsignadosLbl = new Label();
            CursosAsignadosListView = new ListView();
            MateriaCol = new ColumnHeader();
            CursoCol = new ColumnHeader();
            MateriasCmb = new ComboBox();
            CursosCmb = new ComboBox();
            AgregarBtn = new Button();
            QuitarBtn = new Button();
            CuitLbl = new Label();
            Cuit1Txb = new TextBox();
            Cuit2Txb = new TextBox();
            Cuit3Txb = new TextBox();
            SuspendLayout();
            // 
            // TipoCmb
            // 
            TipoCmb.FormattingEnabled = true;
            TipoCmb.Location = new Point(194, 355);
            TipoCmb.Margin = new Padding(3, 4, 3, 4);
            TipoCmb.Name = "TipoCmb";
            TipoCmb.Size = new Size(148, 28);
            TipoCmb.TabIndex = 0;
            // 
            // TipoLbl
            // 
            TipoLbl.AutoSize = true;
            TipoLbl.Location = new Point(129, 355);
            TipoLbl.Name = "TipoLbl";
            TipoLbl.Size = new Size(39, 20);
            TipoLbl.TabIndex = 1;
            TipoLbl.Text = "Tipo";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(129, 131);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(64, 20);
            NombreLbl.TabIndex = 2;
            NombreLbl.Text = "Nombre";
            // 
            // ApellidoLbl
            // 
            ApellidoLbl.AutoSize = true;
            ApellidoLbl.Location = new Point(129, 203);
            ApellidoLbl.Name = "ApellidoLbl";
            ApellidoLbl.Size = new Size(66, 20);
            ApellidoLbl.TabIndex = 3;
            ApellidoLbl.Text = "Apellido";
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(82, 543);
            AtrasBtn.Margin = new Padding(3, 4, 3, 4);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(86, 31);
            AtrasBtn.TabIndex = 6;
            AtrasBtn.Text = "Atras";
            AtrasBtn.UseVisualStyleBackColor = true;
            // 
            // CrearPersonalBtn
            // 
            CrearPersonalBtn.Location = new Point(714, 543);
            CrearPersonalBtn.Margin = new Padding(3, 4, 3, 4);
            CrearPersonalBtn.Name = "CrearPersonalBtn";
            CrearPersonalBtn.Size = new Size(128, 31);
            CrearPersonalBtn.TabIndex = 7;
            CrearPersonalBtn.Text = "Crear Personal";
            CrearPersonalBtn.UseVisualStyleBackColor = true;
            CrearPersonalBtn.Click += CrearPersonalBtn_Click;
            // 
            // NombreTxb
            // 
            NombreTxb.Location = new Point(194, 127);
            NombreTxb.Margin = new Padding(3, 4, 3, 4);
            NombreTxb.Name = "NombreTxb";
            NombreTxb.Size = new Size(148, 27);
            NombreTxb.TabIndex = 8;
            // 
            // ApellidoTxb
            // 
            ApellidoTxb.Location = new Point(194, 199);
            ApellidoTxb.Margin = new Padding(3, 4, 3, 4);
            ApellidoTxb.Name = "ApellidoTxb";
            ApellidoTxb.Size = new Size(148, 27);
            ApellidoTxb.TabIndex = 9;
            // 
            // MateriasLbl
            // 
            MateriasLbl.AutoSize = true;
            MateriasLbl.Location = new Point(500, 37);
            MateriasLbl.Name = "MateriasLbl";
            MateriasLbl.Size = new Size(60, 20);
            MateriasLbl.TabIndex = 10;
            MateriasLbl.Text = "Materia";
            // 
            // CursosLbl
            // 
            CursosLbl.AutoSize = true;
            CursosLbl.Location = new Point(500, 136);
            CursosLbl.Name = "CursosLbl";
            CursosLbl.Size = new Size(46, 20);
            CursosLbl.TabIndex = 11;
            CursosLbl.Text = "Curso";
            // 
            // CursosAsignadosLbl
            // 
            CursosAsignadosLbl.AutoSize = true;
            CursosAsignadosLbl.Location = new Point(500, 255);
            CursosAsignadosLbl.Name = "CursosAsignadosLbl";
            CursosAsignadosLbl.Size = new Size(125, 20);
            CursosAsignadosLbl.TabIndex = 12;
            CursosAsignadosLbl.Text = "Cursos Asignados";
            // 
            // CursosAsignadosListView
            // 
            CursosAsignadosListView.Columns.AddRange(new ColumnHeader[] { MateriaCol, CursoCol });
            CursosAsignadosListView.FullRowSelect = true;
            CursosAsignadosListView.Location = new Point(500, 287);
            CursosAsignadosListView.Name = "CursosAsignadosListView";
            CursosAsignadosListView.Size = new Size(391, 172);
            CursosAsignadosListView.TabIndex = 13;
            CursosAsignadosListView.UseCompatibleStateImageBehavior = false;
            CursosAsignadosListView.View = View.Details;
            // 
            // MateriaCol
            // 
            MateriaCol.Text = "Materia";
            MateriaCol.Width = 150;
            // 
            // CursoCol
            // 
            CursoCol.Text = "Curso";
            CursoCol.Width = 250;
            // 
            // MateriasCmb
            // 
            MateriasCmb.FormattingEnabled = true;
            MateriasCmb.Location = new Point(500, 73);
            MateriasCmb.Name = "MateriasCmb";
            MateriasCmb.Size = new Size(249, 28);
            MateriasCmb.TabIndex = 14;
            // 
            // CursosCmb
            // 
            CursosCmb.FormattingEnabled = true;
            CursosCmb.Location = new Point(500, 165);
            CursosCmb.Name = "CursosCmb";
            CursosCmb.Size = new Size(249, 28);
            CursosCmb.TabIndex = 15;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(795, 165);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(96, 33);
            AgregarBtn.TabIndex = 16;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // QuitarBtn
            // 
            QuitarBtn.Location = new Point(810, 465);
            QuitarBtn.Name = "QuitarBtn";
            QuitarBtn.Size = new Size(81, 37);
            QuitarBtn.TabIndex = 17;
            QuitarBtn.Text = "Quitar";
            QuitarBtn.UseVisualStyleBackColor = true;
            QuitarBtn.Click += QuitarBtn_Click;
            // 
            // CuitLbl
            // 
            CuitLbl.AutoSize = true;
            CuitLbl.Location = new Point(128, 284);
            CuitLbl.Name = "CuitLbl";
            CuitLbl.Size = new Size(40, 20);
            CuitLbl.TabIndex = 18;
            CuitLbl.Text = "CUIT";
            // 
            // Cuit1Txb
            // 
            Cuit1Txb.Location = new Point(195, 287);
            Cuit1Txb.Name = "Cuit1Txb";
            Cuit1Txb.Size = new Size(34, 27);
            Cuit1Txb.TabIndex = 19;
            // 
            // Cuit2Txb
            // 
            Cuit2Txb.Location = new Point(235, 287);
            Cuit2Txb.Name = "Cuit2Txb";
            Cuit2Txb.Size = new Size(79, 27);
            Cuit2Txb.TabIndex = 20;
            // 
            // Cuit3Txb
            // 
            Cuit3Txb.Location = new Point(320, 287);
            Cuit3Txb.Name = "Cuit3Txb";
            Cuit3Txb.Size = new Size(23, 27);
            Cuit3Txb.TabIndex = 21;
            // 
            // CrearPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Cuit3Txb);
            Controls.Add(Cuit2Txb);
            Controls.Add(Cuit1Txb);
            Controls.Add(CuitLbl);
            Controls.Add(QuitarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(CursosCmb);
            Controls.Add(MateriasCmb);
            Controls.Add(CursosAsignadosListView);
            Controls.Add(CursosAsignadosLbl);
            Controls.Add(CursosLbl);
            Controls.Add(MateriasLbl);
            Controls.Add(ApellidoTxb);
            Controls.Add(NombreTxb);
            Controls.Add(CrearPersonalBtn);
            Controls.Add(AtrasBtn);
            Controls.Add(ApellidoLbl);
            Controls.Add(NombreLbl);
            Controls.Add(TipoLbl);
            Controls.Add(TipoCmb);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearPersonal";
            Text = "Crear Personal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox TipoCmb;
        private Label TipoLbl;
        private Label NombreLbl;
        private Label ApellidoLbl;
        private Label DniLbl;
        private TextBox DniTxb;
        private Button AtrasBtn;
        private Button CrearPersonalBtn;
        private TextBox NombreTxb;
        private TextBox ApellidoTxb;
        private Label MateriasLbl;
        private Label CursosLbl;
        private Label CursosAsignadosLbl;
        private ListView CursosAsignadosListView;
        private ComboBox MateriasCmb;
        private ComboBox CursosCmb;
        private Button AgregarBtn;
        private Button QuitarBtn;
        private Label CuitLbl;
        private TextBox Cuit1Txb;
        private TextBox Cuit2Txb;
        private TextBox Cuit3Txb;
        private ColumnHeader MateriaCol;
        private ColumnHeader CursoCol;
    }
}