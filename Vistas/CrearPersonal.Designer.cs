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
            DniLbl = new Label();
            DniTxb = new TextBox();
            AtrasBtn = new Button();
            CrearPersonalBtn = new Button();
            NombreTxb = new TextBox();
            ApellidoTxb = new TextBox();
            MateriasLbl = new Label();
            CursosLbl = new Label();
            CursosAsignadosLbl = new Label();
            CursosAsignadosListView = new ListView();
            MateriasCmb = new ComboBox();
            CursosCmb = new ComboBox();
            AgregarBtn = new Button();
            QuitarBtn = new Button();
            CuitLbl = new Label();
            CuitTxb = new TextBox();
            SuspendLayout();
            // 
            // TipoCmb
            // 
            TipoCmb.FormattingEnabled = true;
            TipoCmb.Location = new Point(234, 431);
            TipoCmb.Margin = new Padding(3, 4, 3, 4);
            TipoCmb.Name = "TipoCmb";
            TipoCmb.Size = new Size(138, 28);
            TipoCmb.TabIndex = 0;
            // 
            // TipoLbl
            // 
            TipoLbl.AutoSize = true;
            TipoLbl.Location = new Point(169, 431);
            TipoLbl.Name = "TipoLbl";
            TipoLbl.Size = new Size(39, 20);
            TipoLbl.TabIndex = 1;
            TipoLbl.Text = "Tipo";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(169, 123);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(64, 20);
            NombreLbl.TabIndex = 2;
            NombreLbl.Text = "Nombre";
            // 
            // ApellidoLbl
            // 
            ApellidoLbl.AutoSize = true;
            ApellidoLbl.Location = new Point(169, 195);
            ApellidoLbl.Name = "ApellidoLbl";
            ApellidoLbl.Size = new Size(66, 20);
            ApellidoLbl.TabIndex = 3;
            ApellidoLbl.Text = "Apellido";
            // 
            // DniLbl
            // 
            DniLbl.AutoSize = true;
            DniLbl.Location = new Point(169, 277);
            DniLbl.Name = "DniLbl";
            DniLbl.Size = new Size(35, 20);
            DniLbl.TabIndex = 4;
            DniLbl.Text = "DNI";
            // 
            // DniTxb
            // 
            DniTxb.Location = new Point(234, 273);
            DniTxb.Margin = new Padding(3, 4, 3, 4);
            DniTxb.Name = "DniTxb";
            DniTxb.Size = new Size(138, 27);
            DniTxb.TabIndex = 5;
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
            NombreTxb.Location = new Point(234, 119);
            NombreTxb.Margin = new Padding(3, 4, 3, 4);
            NombreTxb.Name = "NombreTxb";
            NombreTxb.Size = new Size(138, 27);
            NombreTxb.TabIndex = 8;
            // 
            // ApellidoTxb
            // 
            ApellidoTxb.Location = new Point(234, 191);
            ApellidoTxb.Margin = new Padding(3, 4, 3, 4);
            ApellidoTxb.Name = "ApellidoTxb";
            ApellidoTxb.Size = new Size(138, 27);
            ApellidoTxb.TabIndex = 9;
            // 
            // MateriasLbl
            // 
            MateriasLbl.AutoSize = true;
            MateriasLbl.Location = new Point(569, 40);
            MateriasLbl.Name = "MateriasLbl";
            MateriasLbl.Size = new Size(60, 20);
            MateriasLbl.TabIndex = 10;
            MateriasLbl.Text = "Materia";
            // 
            // CursosLbl
            // 
            CursosLbl.AutoSize = true;
            CursosLbl.Location = new Point(569, 139);
            CursosLbl.Name = "CursosLbl";
            CursosLbl.Size = new Size(46, 20);
            CursosLbl.TabIndex = 11;
            CursosLbl.Text = "Curso";
            // 
            // CursosAsignadosLbl
            // 
            CursosAsignadosLbl.AutoSize = true;
            CursosAsignadosLbl.Location = new Point(569, 255);
            CursosAsignadosLbl.Name = "CursosAsignadosLbl";
            CursosAsignadosLbl.Size = new Size(125, 20);
            CursosAsignadosLbl.TabIndex = 12;
            CursosAsignadosLbl.Text = "Cursos Asignados";
            // 
            // CursosAsignadosListView
            // 
            CursosAsignadosListView.Location = new Point(569, 287);
            CursosAsignadosListView.Name = "CursosAsignadosListView";
            CursosAsignadosListView.Size = new Size(322, 172);
            CursosAsignadosListView.TabIndex = 13;
            CursosAsignadosListView.UseCompatibleStateImageBehavior = false;
            // 
            // MateriasCmb
            // 
            MateriasCmb.FormattingEnabled = true;
            MateriasCmb.Location = new Point(569, 76);
            MateriasCmb.Name = "MateriasCmb";
            MateriasCmb.Size = new Size(177, 28);
            MateriasCmb.TabIndex = 14;
            // 
            // CursosCmb
            // 
            CursosCmb.FormattingEnabled = true;
            CursosCmb.Location = new Point(569, 168);
            CursosCmb.Name = "CursosCmb";
            CursosCmb.Size = new Size(177, 28);
            CursosCmb.TabIndex = 15;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(795, 126);
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
            CuitLbl.Location = new Point(167, 360);
            CuitLbl.Name = "CuitLbl";
            CuitLbl.Size = new Size(40, 20);
            CuitLbl.TabIndex = 18;
            CuitLbl.Text = "CUIT";
            // 
            // CuitTxb
            // 
            CuitTxb.Location = new Point(234, 363);
            CuitTxb.Name = "CuitTxb";
            CuitTxb.Size = new Size(138, 27);
            CuitTxb.TabIndex = 19;
            // 
            // CrearPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(CuitTxb);
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
            Controls.Add(DniTxb);
            Controls.Add(DniLbl);
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
        private TextBox CuitTxb;
    }
}