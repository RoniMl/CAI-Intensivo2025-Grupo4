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
            IdCol = new ColumnHeader();
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            DniCol = new ColumnHeader();
            CuitCol = new ColumnHeader();
            TipoCol = new ColumnHeader();
            EdicionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // BuscarPersonalLbl
            // 
            BuscarPersonalLbl.AutoSize = true;
            BuscarPersonalLbl.Location = new Point(27, 37);
            BuscarPersonalLbl.Name = "BuscarPersonalLbl";
            BuscarPersonalLbl.Size = new Size(170, 20);
            BuscarPersonalLbl.TabIndex = 0;
            BuscarPersonalLbl.Text = "Buscar personal por DNI";
            // 
            // BuscarDniTxb
            // 
            BuscarDniTxb.Location = new Point(203, 35);
            BuscarDniTxb.Name = "BuscarDniTxb";
            BuscarDniTxb.Size = new Size(163, 27);
            BuscarDniTxb.TabIndex = 1;
            // 
            // PersonalLbl
            // 
            PersonalLbl.AutoSize = true;
            PersonalLbl.Location = new Point(27, 107);
            PersonalLbl.Name = "PersonalLbl";
            PersonalLbl.Size = new Size(64, 20);
            PersonalLbl.TabIndex = 2;
            PersonalLbl.Text = "Personal";
            // 
            // PersonalListView
            // 
            PersonalListView.Columns.AddRange(new ColumnHeader[] { IdCol, NombreCol, ApellidoCol, DniCol, CuitCol, TipoCol });
            PersonalListView.FullRowSelect = true;
            PersonalListView.Location = new Point(27, 147);
            PersonalListView.MultiSelect = false;
            PersonalListView.Name = "PersonalListView";
            PersonalListView.Size = new Size(875, 171);
            PersonalListView.TabIndex = 3;
            PersonalListView.UseCompatibleStateImageBehavior = false;
            PersonalListView.View = View.Details;
            // 
            // NuevoDocenteBtn
            // 
            NuevoDocenteBtn.Location = new Point(426, 341);
            NuevoDocenteBtn.Name = "NuevoDocenteBtn";
            NuevoDocenteBtn.Size = new Size(152, 37);
            NuevoDocenteBtn.TabIndex = 4;
            NuevoDocenteBtn.Text = "Nuevo Docente";
            NuevoDocenteBtn.UseVisualStyleBackColor = true;
            // 
            // EditarBtn
            // 
            EditarBtn.Location = new Point(599, 341);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(133, 37);
            EditarBtn.TabIndex = 5;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(749, 341);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(128, 37);
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
            EdicionGroup.Location = new Point(27, 421);
            EdicionGroup.Name = "EdicionGroup";
            EdicionGroup.Size = new Size(1176, 339);
            EdicionGroup.TabIndex = 7;
            EdicionGroup.TabStop = false;
            EdicionGroup.Text = "Edicion";
            // 
            // Cuit3GroupTxb
            // 
            Cuit3GroupTxb.Location = new Point(176, 244);
            Cuit3GroupTxb.Name = "Cuit3GroupTxb";
            Cuit3GroupTxb.Size = new Size(19, 27);
            Cuit3GroupTxb.TabIndex = 23;
            // 
            // Cuit2GroupTxb
            // 
            Cuit2GroupTxb.Location = new Point(101, 244);
            Cuit2GroupTxb.Name = "Cuit2GroupTxb";
            Cuit2GroupTxb.Size = new Size(70, 27);
            Cuit2GroupTxb.TabIndex = 22;
            // 
            // Cuit1GroupTxb
            // 
            Cuit1GroupTxb.Location = new Point(73, 244);
            Cuit1GroupTxb.Name = "Cuit1GroupTxb";
            Cuit1GroupTxb.Size = new Size(21, 27);
            Cuit1GroupTxb.TabIndex = 21;
            // 
            // CuitGroupLbl
            // 
            CuitGroupLbl.AutoSize = true;
            CuitGroupLbl.Location = new Point(71, 221);
            CuitGroupLbl.Name = "CuitGroupLbl";
            CuitGroupLbl.Size = new Size(35, 20);
            CuitGroupLbl.TabIndex = 20;
            CuitGroupLbl.Text = "Cuit";
            // 
            // CursosComboBox
            // 
            CursosComboBox.FormattingEnabled = true;
            CursosComboBox.Location = new Point(229, 144);
            CursosComboBox.Name = "CursosComboBox";
            CursosComboBox.Size = new Size(261, 28);
            CursosComboBox.TabIndex = 19;
            // 
            // CursosLbl
            // 
            CursosLbl.AutoSize = true;
            CursosLbl.Location = new Point(229, 121);
            CursosLbl.Name = "CursosLbl";
            CursosLbl.Size = new Size(52, 20);
            CursosLbl.TabIndex = 18;
            CursosLbl.Text = "Cursos";
            // 
            // TipoDocenteGroupCmb
            // 
            TipoDocenteGroupCmb.FormattingEnabled = true;
            TipoDocenteGroupCmb.Location = new Point(73, 301);
            TipoDocenteGroupCmb.Name = "TipoDocenteGroupCmb";
            TipoDocenteGroupCmb.Size = new Size(159, 28);
            TipoDocenteGroupCmb.TabIndex = 17;
            // 
            // TipoDocenteGroupLbl
            // 
            TipoDocenteGroupLbl.AutoSize = true;
            TipoDocenteGroupLbl.Location = new Point(73, 277);
            TipoDocenteGroupLbl.Name = "TipoDocenteGroupLbl";
            TipoDocenteGroupLbl.Size = new Size(120, 20);
            TipoDocenteGroupLbl.TabIndex = 16;
            TipoDocenteGroupLbl.Text = "Tipo de Docente";
            // 
            // AgregarGroupBtn
            // 
            AgregarGroupBtn.Location = new Point(529, 141);
            AgregarGroupBtn.Name = "AgregarGroupBtn";
            AgregarGroupBtn.Size = new Size(95, 33);
            AgregarGroupBtn.TabIndex = 15;
            AgregarGroupBtn.Text = "Agregar";
            AgregarGroupBtn.UseVisualStyleBackColor = true;
            AgregarGroupBtn.Click += AgregarGroupBtn_Click;
            // 
            // NombreGroupTxb
            // 
            NombreGroupTxb.Location = new Point(73, 117);
            NombreGroupTxb.Name = "NombreGroupTxb";
            NombreGroupTxb.Size = new Size(122, 27);
            NombreGroupTxb.TabIndex = 14;
            // 
            // ApellidoGroupLbl
            // 
            ApellidoGroupLbl.AutoSize = true;
            ApellidoGroupLbl.Location = new Point(73, 160);
            ApellidoGroupLbl.Name = "ApellidoGroupLbl";
            ApellidoGroupLbl.Size = new Size(66, 20);
            ApellidoGroupLbl.TabIndex = 13;
            ApellidoGroupLbl.Text = "Apellido";
            // 
            // AceptarGroupbtn
            // 
            AceptarGroupbtn.Location = new Point(1055, 285);
            AceptarGroupbtn.Name = "AceptarGroupbtn";
            AceptarGroupbtn.Size = new Size(96, 33);
            AceptarGroupbtn.TabIndex = 12;
            AceptarGroupbtn.Text = "Aceptar";
            AceptarGroupbtn.UseVisualStyleBackColor = true;
            // 
            // CancelarGroupbtn
            // 
            CancelarGroupbtn.Location = new Point(927, 285);
            CancelarGroupbtn.Name = "CancelarGroupbtn";
            CancelarGroupbtn.Size = new Size(102, 33);
            CancelarGroupbtn.TabIndex = 11;
            CancelarGroupbtn.Text = "Cancelar";
            CancelarGroupbtn.UseVisualStyleBackColor = true;
            // 
            // QuitarGroupBtn
            // 
            QuitarGroupBtn.Location = new Point(1074, 215);
            QuitarGroupBtn.Name = "QuitarGroupBtn";
            QuitarGroupBtn.Size = new Size(77, 32);
            QuitarGroupBtn.TabIndex = 10;
            QuitarGroupBtn.Text = "Quitar";
            QuitarGroupBtn.UseVisualStyleBackColor = true;
            QuitarGroupBtn.Click += QuitarGroupBtn_Click;
            // 
            // MatAsignadasGroupListView
            // 
            MatAsignadasGroupListView.Columns.AddRange(new ColumnHeader[] { MateriaColumna, CursoColumna });
            MatAsignadasGroupListView.FullRowSelect = true;
            MatAsignadasGroupListView.Location = new Point(750, 79);
            MatAsignadasGroupListView.Name = "MatAsignadasGroupListView";
            MatAsignadasGroupListView.Size = new Size(401, 128);
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
            CursosAsignadosGroupLbl.Location = new Point(750, 51);
            CursosAsignadosGroupLbl.Name = "CursosAsignadosGroupLbl";
            CursosAsignadosGroupLbl.Size = new Size(125, 20);
            CursosAsignadosGroupLbl.TabIndex = 8;
            CursosAsignadosGroupLbl.Text = "Cursos Asignados";
            // 
            // MateriasGroupCmb
            // 
            MateriasGroupCmb.FormattingEnabled = true;
            MateriasGroupCmb.Location = new Point(229, 79);
            MateriasGroupCmb.Name = "MateriasGroupCmb";
            MateriasGroupCmb.Size = new Size(261, 28);
            MateriasGroupCmb.TabIndex = 7;
            // 
            // MateriasGroupLbl
            // 
            MateriasGroupLbl.AutoSize = true;
            MateriasGroupLbl.Location = new Point(229, 52);
            MateriasGroupLbl.Name = "MateriasGroupLbl";
            MateriasGroupLbl.Size = new Size(66, 20);
            MateriasGroupLbl.TabIndex = 6;
            MateriasGroupLbl.Text = "Materias";
            // 
            // NombreGroupLbl
            // 
            NombreGroupLbl.AutoSize = true;
            NombreGroupLbl.Location = new Point(73, 93);
            NombreGroupLbl.Name = "NombreGroupLbl";
            NombreGroupLbl.Size = new Size(64, 20);
            NombreGroupLbl.TabIndex = 4;
            NombreGroupLbl.Text = "Nombre";
            // 
            // ApellidoGroupTxb
            // 
            ApellidoGroupTxb.Location = new Point(73, 181);
            ApellidoGroupTxb.Name = "ApellidoGroupTxb";
            ApellidoGroupTxb.Size = new Size(122, 27);
            ApellidoGroupTxb.TabIndex = 2;
            // 
            // IdGroupTxb
            // 
            IdGroupTxb.Location = new Point(73, 52);
            IdGroupTxb.Name = "IdGroupTxb";
            IdGroupTxb.Size = new Size(63, 27);
            IdGroupTxb.TabIndex = 1;
            // 
            // IdGroupLbl
            // 
            IdGroupLbl.AutoSize = true;
            IdGroupLbl.Location = new Point(70, 24);
            IdGroupLbl.Name = "IdGroupLbl";
            IdGroupLbl.Size = new Size(24, 20);
            IdGroupLbl.TabIndex = 0;
            IdGroupLbl.Text = "ID";
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(374, 33);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(117, 32);
            BuscarBtn.TabIndex = 8;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(38, 777);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(103, 28);
            AtrasBtn.TabIndex = 9;
            AtrasBtn.Text = "Atrás";
            AtrasBtn.UseVisualStyleBackColor = true;
            AtrasBtn.Click += AtrasBtn_Click;
            // 
            // IdCol
            // 
            IdCol.Text = "ID";
            IdCol.Width = 50;
            // 
            // NombreCol
            // 
            NombreCol.Text = "Nombre";
            NombreCol.Width = 150;
            // 
            // ApellidoCol
            // 
            ApellidoCol.Text = "Apellido";
            ApellidoCol.Width = 150;
            // 
            // DniCol
            // 
            DniCol.Text = "DNI";
            DniCol.Width = 100;
            // 
            // CuitCol
            // 
            CuitCol.Text = "CUIT";
            CuitCol.Width = 120;
            // 
            // TipoCol
            // 
            TipoCol.Text = "Tipo de docente";
            TipoCol.Width = 180;
            // 
            // GestionPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 811);
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
        private ColumnHeader IdCol;
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader DniCol;
        private ColumnHeader CuitCol;
        private ColumnHeader TipoCol;
    }
}