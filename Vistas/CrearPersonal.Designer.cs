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
            TipoCmb.Location = new Point(170, 266);
            TipoCmb.Name = "TipoCmb";
            TipoCmb.Size = new Size(130, 23);
            TipoCmb.TabIndex = 0;
            // 
            // TipoLbl
            // 
            TipoLbl.AutoSize = true;
            TipoLbl.Location = new Point(113, 266);
            TipoLbl.Name = "TipoLbl";
            TipoLbl.Size = new Size(34, 17);
            TipoLbl.TabIndex = 1;
            TipoLbl.Text = "Tipo";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(113, 98);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(57, 17);
            NombreLbl.TabIndex = 2;
            NombreLbl.Text = "Nombre";
            // 
            // ApellidoLbl
            // 
            ApellidoLbl.AutoSize = true;
            ApellidoLbl.Location = new Point(113, 152);
            ApellidoLbl.Name = "ApellidoLbl";
            ApellidoLbl.Size = new Size(56, 17);
            ApellidoLbl.TabIndex = 3;
            ApellidoLbl.Text = "Apellido";
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(72, 407);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(75, 23);
            AtrasBtn.TabIndex = 6;
            AtrasBtn.Text = "Atras";
            AtrasBtn.UseVisualStyleBackColor = true;
            AtrasBtn.Click += AtrasBtn_Click;
            // 
            // CrearPersonalBtn
            // 
            CrearPersonalBtn.Location = new Point(625, 407);
            CrearPersonalBtn.Name = "CrearPersonalBtn";
            CrearPersonalBtn.Size = new Size(112, 23);
            CrearPersonalBtn.TabIndex = 7;
            CrearPersonalBtn.Text = "Crear Personal";
            CrearPersonalBtn.UseVisualStyleBackColor = true;
            CrearPersonalBtn.Click += CrearPersonalBtn_Click;
            // 
            // NombreTxb
            // 
            NombreTxb.Location = new Point(170, 95);
            NombreTxb.Name = "NombreTxb";
            NombreTxb.Size = new Size(130, 23);
            NombreTxb.TabIndex = 8;
            // 
            // ApellidoTxb
            // 
            ApellidoTxb.Location = new Point(170, 149);
            ApellidoTxb.Name = "ApellidoTxb";
            ApellidoTxb.Size = new Size(130, 23);
            ApellidoTxb.TabIndex = 9;
            // 
            // MateriasLbl
            // 
            MateriasLbl.AutoSize = true;
            MateriasLbl.Location = new Point(438, 28);
            MateriasLbl.Name = "MateriasLbl";
            MateriasLbl.Size = new Size(53, 17);
            MateriasLbl.TabIndex = 10;
            MateriasLbl.Text = "Materia";
            // 
            // CursosLbl
            // 
            CursosLbl.AutoSize = true;
            CursosLbl.Location = new Point(438, 102);
            CursosLbl.Name = "CursosLbl";
            CursosLbl.Size = new Size(42, 17);
            CursosLbl.TabIndex = 11;
            CursosLbl.Text = "Curso";
            // 
            // CursosAsignadosLbl
            // 
            CursosAsignadosLbl.AutoSize = true;
            CursosAsignadosLbl.Location = new Point(438, 191);
            CursosAsignadosLbl.Name = "CursosAsignadosLbl";
            CursosAsignadosLbl.Size = new Size(113, 17);
            CursosAsignadosLbl.TabIndex = 12;
            CursosAsignadosLbl.Text = "Cursos Asignados";
            // 
            // CursosAsignadosListView
            // 
            CursosAsignadosListView.Columns.AddRange(new ColumnHeader[] { MateriaCol, CursoCol });
            CursosAsignadosListView.FullRowSelect = true;
            CursosAsignadosListView.Location = new Point(438, 215);
            CursosAsignadosListView.Margin = new Padding(3, 2, 3, 2);
            CursosAsignadosListView.Name = "CursosAsignadosListView";
            CursosAsignadosListView.Size = new Size(343, 130);
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
            MateriasCmb.Location = new Point(438, 55);
            MateriasCmb.Margin = new Padding(3, 2, 3, 2);
            MateriasCmb.Name = "MateriasCmb";
            MateriasCmb.Size = new Size(218, 23);
            MateriasCmb.TabIndex = 14;
            // 
            // CursosCmb
            // 
            CursosCmb.FormattingEnabled = true;
            CursosCmb.Location = new Point(438, 124);
            CursosCmb.Margin = new Padding(3, 2, 3, 2);
            CursosCmb.Name = "CursosCmb";
            CursosCmb.Size = new Size(218, 23);
            CursosCmb.TabIndex = 15;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(696, 124);
            AgregarBtn.Margin = new Padding(3, 2, 3, 2);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(84, 25);
            AgregarBtn.TabIndex = 16;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // QuitarBtn
            // 
            QuitarBtn.Location = new Point(709, 349);
            QuitarBtn.Margin = new Padding(3, 2, 3, 2);
            QuitarBtn.Name = "QuitarBtn";
            QuitarBtn.Size = new Size(71, 28);
            QuitarBtn.TabIndex = 17;
            QuitarBtn.Text = "Quitar";
            QuitarBtn.UseVisualStyleBackColor = true;
            QuitarBtn.Click += QuitarBtn_Click;
            // 
            // CuitLbl
            // 
            CuitLbl.AutoSize = true;
            CuitLbl.Location = new Point(112, 213);
            CuitLbl.Name = "CuitLbl";
            CuitLbl.Size = new Size(35, 17);
            CuitLbl.TabIndex = 18;
            CuitLbl.Text = "CUIT";
            // 
            // Cuit1Txb
            // 
            Cuit1Txb.Location = new Point(171, 215);
            Cuit1Txb.Margin = new Padding(3, 2, 3, 2);
            Cuit1Txb.Name = "Cuit1Txb";
            Cuit1Txb.Size = new Size(30, 23);
            Cuit1Txb.TabIndex = 19;
            // 
            // Cuit2Txb
            // 
            Cuit2Txb.Location = new Point(206, 215);
            Cuit2Txb.Margin = new Padding(3, 2, 3, 2);
            Cuit2Txb.Name = "Cuit2Txb";
            Cuit2Txb.Size = new Size(70, 23);
            Cuit2Txb.TabIndex = 20;
            // 
            // Cuit3Txb
            // 
            Cuit3Txb.Location = new Point(280, 215);
            Cuit3Txb.Margin = new Padding(3, 2, 3, 2);
            Cuit3Txb.Name = "Cuit3Txb";
            Cuit3Txb.Size = new Size(21, 23);
            Cuit3Txb.TabIndex = 21;
            // 
            // CrearPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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