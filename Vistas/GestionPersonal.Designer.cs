namespace Vistas
{
    partial class GestionPersonal
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
            BuscarPersonalLbl = new Label();
            BuscarDniTxb = new TextBox();
            PersonalLbl = new Label();
            PersonalListView = new ListView();
            NuevoDocenteBtn = new Button();
            EditarBtn = new Button();
            EliminarBtn = new Button();
            EdicionGroup = new GroupBox();
            Cuit3GroupTxb = new TextBox();
            Cuit2GroupTxb = new TextBox();
            Cuit1GroupTxb = new TextBox();
            CuitGroupLbl = new Label();
            CursosComboBox = new ComboBox();
            CursosLbl = new Label();
            TipoDocenteGroupCmb = new ComboBox();
            TipoDocenteGroupLbl = new Label();
            AgregarGroupBtn = new Button();
            NombreGroupTxb = new TextBox();
            ApellidoGroupLbl = new Label();
            AceptarGroupbtn = new Button();
            CancelarGroupbtn = new Button();
            QuitarGroupBtn = new Button();
            MatAsignadasGroupListView = new ListView();
            MateriaColumna = new ColumnHeader();
            CursoColumna = new ColumnHeader();
            CursosAsignadosGroupLbl = new Label();
            MateriasGroupCmb = new ComboBox();
            MateriasGroupLbl = new Label();
            NombreGroupLbl = new Label();
            ApellidoGroupTxb = new TextBox();
            IdGroupTxb = new TextBox();
            IdGroupLbl = new Label();
            BuscarBtn = new Button();
            AtrasBtn = new Button();
            EdicionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // BuscarPersonalLbl
            // 
            BuscarPersonalLbl.AutoSize = true;
            BuscarPersonalLbl.Location = new Point(24, 28);
            BuscarPersonalLbl.Name = "BuscarPersonalLbl";
            BuscarPersonalLbl.Size = new Size(152, 17);
            BuscarPersonalLbl.TabIndex = 0;
            BuscarPersonalLbl.Text = "Buscar personal por DNI";
            // 
            // BuscarDniTxb
            // 
            BuscarDniTxb.Location = new Point(178, 26);
            BuscarDniTxb.Margin = new Padding(3, 2, 3, 2);
            BuscarDniTxb.Name = "BuscarDniTxb";
            BuscarDniTxb.Size = new Size(143, 23);
            BuscarDniTxb.TabIndex = 1;
            // 
            // PersonalLbl
            // 
            PersonalLbl.AutoSize = true;
            PersonalLbl.Location = new Point(24, 80);
            PersonalLbl.Name = "PersonalLbl";
            PersonalLbl.Size = new Size(58, 17);
            PersonalLbl.TabIndex = 2;
            PersonalLbl.Text = "Personal";
            // 
            // PersonalListView
            // 
            PersonalListView.FullRowSelect = true;
            PersonalListView.Location = new Point(24, 110);
            PersonalListView.Margin = new Padding(3, 2, 3, 2);
            PersonalListView.MultiSelect = false;
            PersonalListView.Name = "PersonalListView";
            PersonalListView.Size = new Size(766, 129);
            PersonalListView.TabIndex = 3;
            PersonalListView.UseCompatibleStateImageBehavior = false;
            PersonalListView.View = View.Details;
            // 
            // NuevoDocenteBtn
            // 
            NuevoDocenteBtn.Location = new Point(373, 256);
            NuevoDocenteBtn.Margin = new Padding(3, 2, 3, 2);
            NuevoDocenteBtn.Name = "NuevoDocenteBtn";
            NuevoDocenteBtn.Size = new Size(133, 28);
            NuevoDocenteBtn.TabIndex = 4;
            NuevoDocenteBtn.Text = "Nuevo Docente";
            NuevoDocenteBtn.UseVisualStyleBackColor = true;
            // 
            // EditarBtn
            // 
            EditarBtn.Location = new Point(524, 256);
            EditarBtn.Margin = new Padding(3, 2, 3, 2);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(116, 28);
            EditarBtn.TabIndex = 5;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(655, 256);
            EliminarBtn.Margin = new Padding(3, 2, 3, 2);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(112, 28);
            EliminarBtn.TabIndex = 6;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // EdicionGroup
            // 
            EdicionGroup.Controls.Add(Cuit3GroupTxb);
            EdicionGroup.Controls.Add(Cuit2GroupTxb);
            EdicionGroup.Controls.Add(Cuit1GroupTxb);
            EdicionGroup.Controls.Add(CuitGroupLbl);
            EdicionGroup.Controls.Add(CursosComboBox);
            EdicionGroup.Controls.Add(CursosLbl);
            EdicionGroup.Controls.Add(TipoDocenteGroupCmb);
            EdicionGroup.Controls.Add(TipoDocenteGroupLbl);
            EdicionGroup.Controls.Add(AgregarGroupBtn);
            EdicionGroup.Controls.Add(NombreGroupTxb);
            EdicionGroup.Controls.Add(ApellidoGroupLbl);
            EdicionGroup.Controls.Add(AceptarGroupbtn);
            EdicionGroup.Controls.Add(CancelarGroupbtn);
            EdicionGroup.Controls.Add(QuitarGroupBtn);
            EdicionGroup.Controls.Add(MatAsignadasGroupListView);
            EdicionGroup.Controls.Add(CursosAsignadosGroupLbl);
            EdicionGroup.Controls.Add(MateriasGroupCmb);
            EdicionGroup.Controls.Add(MateriasGroupLbl);
            EdicionGroup.Controls.Add(NombreGroupLbl);
            EdicionGroup.Controls.Add(ApellidoGroupTxb);
            EdicionGroup.Controls.Add(IdGroupTxb);
            EdicionGroup.Controls.Add(IdGroupLbl);
            EdicionGroup.Location = new Point(24, 316);
            EdicionGroup.Margin = new Padding(3, 2, 3, 2);
            EdicionGroup.Name = "EdicionGroup";
            EdicionGroup.Padding = new Padding(3, 2, 3, 2);
            EdicionGroup.Size = new Size(1029, 254);
            EdicionGroup.TabIndex = 7;
            EdicionGroup.TabStop = false;
            EdicionGroup.Text = "Edicion";
            // 
            // Cuit3GroupTxb
            // 
            Cuit3GroupTxb.Location = new Point(154, 183);
            Cuit3GroupTxb.Margin = new Padding(3, 2, 3, 2);
            Cuit3GroupTxb.Name = "Cuit3GroupTxb";
            Cuit3GroupTxb.Size = new Size(17, 23);
            Cuit3GroupTxb.TabIndex = 23;
            // 
            // Cuit2GroupTxb
            // 
            Cuit2GroupTxb.Location = new Point(88, 183);
            Cuit2GroupTxb.Margin = new Padding(3, 2, 3, 2);
            Cuit2GroupTxb.Name = "Cuit2GroupTxb";
            Cuit2GroupTxb.Size = new Size(62, 23);
            Cuit2GroupTxb.TabIndex = 22;
            // 
            // Cuit1GroupTxb
            // 
            Cuit1GroupTxb.Location = new Point(64, 183);
            Cuit1GroupTxb.Margin = new Padding(3, 2, 3, 2);
            Cuit1GroupTxb.Name = "Cuit1GroupTxb";
            Cuit1GroupTxb.Size = new Size(19, 23);
            Cuit1GroupTxb.TabIndex = 21;
            // 
            // CuitGroupLbl
            // 
            CuitGroupLbl.AutoSize = true;
            CuitGroupLbl.Location = new Point(62, 166);
            CuitGroupLbl.Name = "CuitGroupLbl";
            CuitGroupLbl.Size = new Size(30, 17);
            CuitGroupLbl.TabIndex = 20;
            CuitGroupLbl.Text = "Cuit";
            // 
            // CursosComboBox
            // 
            CursosComboBox.FormattingEnabled = true;
            CursosComboBox.Location = new Point(200, 108);
            CursosComboBox.Margin = new Padding(3, 2, 3, 2);
            CursosComboBox.Name = "CursosComboBox";
            CursosComboBox.Size = new Size(229, 23);
            CursosComboBox.TabIndex = 19;
            // 
            // CursosLbl
            // 
            CursosLbl.AutoSize = true;
            CursosLbl.Location = new Point(200, 91);
            CursosLbl.Name = "CursosLbl";
            CursosLbl.Size = new Size(48, 17);
            CursosLbl.TabIndex = 18;
            CursosLbl.Text = "Cursos";
            // 
            // TipoDocenteGroupCmb
            // 
            TipoDocenteGroupCmb.FormattingEnabled = true;
            TipoDocenteGroupCmb.Location = new Point(64, 226);
            TipoDocenteGroupCmb.Margin = new Padding(3, 2, 3, 2);
            TipoDocenteGroupCmb.Name = "TipoDocenteGroupCmb";
            TipoDocenteGroupCmb.Size = new Size(140, 23);
            TipoDocenteGroupCmb.TabIndex = 17;
            // 
            // TipoDocenteGroupLbl
            // 
            TipoDocenteGroupLbl.AutoSize = true;
            TipoDocenteGroupLbl.Location = new Point(64, 208);
            TipoDocenteGroupLbl.Name = "TipoDocenteGroupLbl";
            TipoDocenteGroupLbl.Size = new Size(105, 17);
            TipoDocenteGroupLbl.TabIndex = 16;
            TipoDocenteGroupLbl.Text = "Tipo de Docente";
            // 
            // AgregarGroupBtn
            // 
            AgregarGroupBtn.Location = new Point(463, 106);
            AgregarGroupBtn.Margin = new Padding(3, 2, 3, 2);
            AgregarGroupBtn.Name = "AgregarGroupBtn";
            AgregarGroupBtn.Size = new Size(83, 25);
            AgregarGroupBtn.TabIndex = 15;
            AgregarGroupBtn.Text = "Agregar";
            AgregarGroupBtn.UseVisualStyleBackColor = true;
            AgregarGroupBtn.Click += AgregarGroupBtn_Click;
            // 
            // NombreGroupTxb
            // 
            NombreGroupTxb.Location = new Point(64, 88);
            NombreGroupTxb.Margin = new Padding(3, 2, 3, 2);
            NombreGroupTxb.Name = "NombreGroupTxb";
            NombreGroupTxb.Size = new Size(107, 23);
            NombreGroupTxb.TabIndex = 14;
            // 
            // ApellidoGroupLbl
            // 
            ApellidoGroupLbl.AutoSize = true;
            ApellidoGroupLbl.Location = new Point(64, 120);
            ApellidoGroupLbl.Name = "ApellidoGroupLbl";
            ApellidoGroupLbl.Size = new Size(56, 17);
            ApellidoGroupLbl.TabIndex = 13;
            ApellidoGroupLbl.Text = "Apellido";
            // 
            // AceptarGroupbtn
            // 
            AceptarGroupbtn.Location = new Point(923, 214);
            AceptarGroupbtn.Margin = new Padding(3, 2, 3, 2);
            AceptarGroupbtn.Name = "AceptarGroupbtn";
            AceptarGroupbtn.Size = new Size(84, 25);
            AceptarGroupbtn.TabIndex = 12;
            AceptarGroupbtn.Text = "Aceptar";
            AceptarGroupbtn.UseVisualStyleBackColor = true;
            // 
            // CancelarGroupbtn
            // 
            CancelarGroupbtn.Location = new Point(811, 214);
            CancelarGroupbtn.Margin = new Padding(3, 2, 3, 2);
            CancelarGroupbtn.Name = "CancelarGroupbtn";
            CancelarGroupbtn.Size = new Size(89, 25);
            CancelarGroupbtn.TabIndex = 11;
            CancelarGroupbtn.Text = "Cancelar";
            CancelarGroupbtn.UseVisualStyleBackColor = true;
            // 
            // QuitarGroupBtn
            // 
            QuitarGroupBtn.Location = new Point(940, 161);
            QuitarGroupBtn.Margin = new Padding(3, 2, 3, 2);
            QuitarGroupBtn.Name = "QuitarGroupBtn";
            QuitarGroupBtn.Size = new Size(67, 24);
            QuitarGroupBtn.TabIndex = 10;
            QuitarGroupBtn.Text = "Quitar";
            QuitarGroupBtn.UseVisualStyleBackColor = true;
            QuitarGroupBtn.Click += QuitarGroupBtn_Click;
            // 
            // MatAsignadasGroupListView
            // 
            MatAsignadasGroupListView.Columns.AddRange(new ColumnHeader[] { MateriaColumna, CursoColumna });
            MatAsignadasGroupListView.FullRowSelect = true;
            MatAsignadasGroupListView.Location = new Point(656, 59);
            MatAsignadasGroupListView.Margin = new Padding(3, 2, 3, 2);
            MatAsignadasGroupListView.Name = "MatAsignadasGroupListView";
            MatAsignadasGroupListView.Size = new Size(351, 97);
            MatAsignadasGroupListView.TabIndex = 9;
            MatAsignadasGroupListView.UseCompatibleStateImageBehavior = false;
            MatAsignadasGroupListView.View = View.Details;
            // 
            // MateriaColumna
            // 
            MateriaColumna.Text = "Materia";
            MateriaColumna.Width = 150;
            // 
            // CursoColumna
            // 
            CursoColumna.Text = "Curso";
            CursoColumna.Width = 250;
            // 
            // CursosAsignadosGroupLbl
            // 
            CursosAsignadosGroupLbl.AutoSize = true;
            CursosAsignadosGroupLbl.Location = new Point(656, 38);
            CursosAsignadosGroupLbl.Name = "CursosAsignadosGroupLbl";
            CursosAsignadosGroupLbl.Size = new Size(113, 17);
            CursosAsignadosGroupLbl.TabIndex = 8;
            CursosAsignadosGroupLbl.Text = "Cursos Asignados";
            // 
            // MateriasGroupCmb
            // 
            MateriasGroupCmb.FormattingEnabled = true;
            MateriasGroupCmb.Location = new Point(200, 59);
            MateriasGroupCmb.Margin = new Padding(3, 2, 3, 2);
            MateriasGroupCmb.Name = "MateriasGroupCmb";
            MateriasGroupCmb.Size = new Size(229, 23);
            MateriasGroupCmb.TabIndex = 7;
            // 
            // MateriasGroupLbl
            // 
            MateriasGroupLbl.AutoSize = true;
            MateriasGroupLbl.Location = new Point(200, 39);
            MateriasGroupLbl.Name = "MateriasGroupLbl";
            MateriasGroupLbl.Size = new Size(59, 17);
            MateriasGroupLbl.TabIndex = 6;
            MateriasGroupLbl.Text = "Materias";
            // 
            // NombreGroupLbl
            // 
            NombreGroupLbl.AutoSize = true;
            NombreGroupLbl.Location = new Point(64, 70);
            NombreGroupLbl.Name = "NombreGroupLbl";
            NombreGroupLbl.Size = new Size(57, 17);
            NombreGroupLbl.TabIndex = 4;
            NombreGroupLbl.Text = "Nombre";
            // 
            // ApellidoGroupTxb
            // 
            ApellidoGroupTxb.Location = new Point(64, 136);
            ApellidoGroupTxb.Margin = new Padding(3, 2, 3, 2);
            ApellidoGroupTxb.Name = "ApellidoGroupTxb";
            ApellidoGroupTxb.Size = new Size(107, 23);
            ApellidoGroupTxb.TabIndex = 2;
            // 
            // IdGroupTxb
            // 
            IdGroupTxb.Location = new Point(64, 39);
            IdGroupTxb.Margin = new Padding(3, 2, 3, 2);
            IdGroupTxb.Name = "IdGroupTxb";
            IdGroupTxb.Size = new Size(56, 23);
            IdGroupTxb.TabIndex = 1;
            // 
            // IdGroupLbl
            // 
            IdGroupLbl.AutoSize = true;
            IdGroupLbl.Location = new Point(61, 18);
            IdGroupLbl.Name = "IdGroupLbl";
            IdGroupLbl.Size = new Size(20, 17);
            IdGroupLbl.TabIndex = 0;
            IdGroupLbl.Text = "ID";
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(327, 25);
            BuscarBtn.Margin = new Padding(3, 2, 3, 2);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(102, 24);
            BuscarBtn.TabIndex = 8;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(33, 583);
            AtrasBtn.Margin = new Padding(3, 2, 3, 2);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(90, 21);
            AtrasBtn.TabIndex = 9;
            AtrasBtn.Text = "Atrás";
            AtrasBtn.UseVisualStyleBackColor = true;
            AtrasBtn.Click += AtrasBtn_Click;
            // 
            // GestionPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 608);
            Controls.Add(AtrasBtn);
            Controls.Add(BuscarBtn);
            Controls.Add(EdicionGroup);
            Controls.Add(EliminarBtn);
            Controls.Add(EditarBtn);
            Controls.Add(NuevoDocenteBtn);
            Controls.Add(PersonalListView);
            Controls.Add(PersonalLbl);
            Controls.Add(BuscarDniTxb);
            Controls.Add(BuscarPersonalLbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestionPersonal";
            Text = "Gestion de Personal";
            EdicionGroup.ResumeLayout(false);
            EdicionGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BuscarPersonalLbl;
        private TextBox BuscarDniTxb;
        private Label PersonalLbl;
        private ListView PersonalListView;
        private Button NuevoDocenteBtn;
        private Button EditarBtn;
        private Button EliminarBtn;
        private GroupBox EdicionGroup;
        private Label IdGroupLbl;
        private TextBox IdGroupTxb;
        private Label NombreGroupLbl;
        private TextBox ApellidoGroupTxb;
        private Label MateriasGroupLbl;
        private ListView MatAsignadasGroupListView;
        private Label CursosAsignadosGroupLbl;
        private ComboBox MateriasGroupCmb;
        private Button QuitarGroupBtn;
        private Button AceptarGroupbtn;
        private Button CancelarGroupbtn;
        private Button BuscarBtn;
        private TextBox NombreGroupTxb;
        private Label ApellidoGroupLbl;
        private Button AgregarGroupBtn;
        private ComboBox TipoDocenteGroupCmb;
        private Label TipoDocenteGroupLbl;
        private ComboBox CursosComboBox;
        private Label CursosLbl;
        private ColumnHeader MateriaColumna;
        private ColumnHeader CursoColumna;
        private TextBox Cuit1GroupTxb;
        private Label CuitGroupLbl;
        private TextBox Cuit3GroupTxb;
        private TextBox Cuit2GroupTxb;
        private Button AtrasBtn;
    }
}