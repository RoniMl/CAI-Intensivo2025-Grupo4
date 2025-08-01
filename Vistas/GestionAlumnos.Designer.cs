namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class GestionAlumnos
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
            BuscarAlumnoLbl = new Label();
            BuscarDniTxb = new TextBox();
            AlumnosListView = new ListView();
            IdCol = new ColumnHeader();
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            DniCol = new ColumnHeader();
            AlumnosLbl = new Label();
            EliminarBtn = new Button();
            EditarBtn = new Button();
            NuevoAlumnoBtn = new Button();
            EdicionGroup = new GroupBox();
            IdGrpTxb = new TextBox();
            IdGrpLbl = new Label();
            CarrerasAsignadasLbl = new Label();
            AgregarGrpBtn = new Button();
            QuitarGrpBtn = new Button();
            CarrerasGrpListView = new ListView();
            CarrerasGrpCmb = new ComboBox();
            CarrerasGrpLbl = new Label();
            DniGrpTxb = new TextBox();
            DniGrpLbl = new Label();
            ApellidoGrpTxb = new TextBox();
            ApellidoGrpLbl = new Label();
            NombreGrpTxb = new TextBox();
            NombreGrpLbl = new Label();
            AceptarGrpBtn = new Button();
            CancelarGrpBtn = new Button();
            AtrasBtn = new Button();
            BuscarBtn = new Button();
            EdicionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // BuscarAlumnoLbl
            // 
            BuscarAlumnoLbl.AutoSize = true;
            BuscarAlumnoLbl.Location = new Point(38, 32);
            BuscarAlumnoLbl.Name = "BuscarAlumnoLbl";
            BuscarAlumnoLbl.Size = new Size(163, 20);
            BuscarAlumnoLbl.TabIndex = 0;
            BuscarAlumnoLbl.Text = "Buscar alumno por DNI";
            // 
            // BuscarDniTxb
            // 
            BuscarDniTxb.Location = new Point(209, 28);
            BuscarDniTxb.Margin = new Padding(3, 4, 3, 4);
            BuscarDniTxb.Name = "BuscarDniTxb";
            BuscarDniTxb.Size = new Size(157, 27);
            BuscarDniTxb.TabIndex = 1;
            // 
            // AlumnosListView
            // 
            AlumnosListView.Columns.AddRange(new ColumnHeader[] { IdCol, NombreCol, ApellidoCol, DniCol });
            AlumnosListView.FullRowSelect = true;
            AlumnosListView.Location = new Point(38, 131);
            AlumnosListView.Margin = new Padding(3, 4, 3, 4);
            AlumnosListView.Name = "AlumnosListView";
            AlumnosListView.Size = new Size(863, 189);
            AlumnosListView.TabIndex = 2;
            AlumnosListView.UseCompatibleStateImageBehavior = false;
            AlumnosListView.View = View.Details;
            // 
            // IdCol
            // 
            IdCol.Text = "Id";
            IdCol.Width = 200;
            // 
            // NombreCol
            // 
            NombreCol.Text = "Nombre";
            NombreCol.Width = 220;
            // 
            // ApellidoCol
            // 
            ApellidoCol.Text = "Apellido";
            ApellidoCol.Width = 220;
            // 
            // DniCol
            // 
            DniCol.Text = "Dni";
            DniCol.Width = 220;
            // 
            // AlumnosLbl
            // 
            AlumnosLbl.AutoSize = true;
            AlumnosLbl.Location = new Point(38, 95);
            AlumnosLbl.Name = "AlumnosLbl";
            AlumnosLbl.Size = new Size(67, 20);
            AlumnosLbl.TabIndex = 3;
            AlumnosLbl.Text = "Alumnos";
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(736, 338);
            EliminarBtn.Margin = new Padding(3, 4, 3, 4);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(165, 39);
            EliminarBtn.TabIndex = 4;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            EliminarBtn.Click += EliminarBtn_Click;
            // 
            // EditarBtn
            // 
            EditarBtn.Location = new Point(567, 338);
            EditarBtn.Margin = new Padding(3, 4, 3, 4);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(162, 39);
            EditarBtn.TabIndex = 5;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            EditarBtn.Click += EditarBtn_Click;
            // 
            // NuevoAlumnoBtn
            // 
            NuevoAlumnoBtn.Location = new Point(382, 338);
            NuevoAlumnoBtn.Margin = new Padding(3, 4, 3, 4);
            NuevoAlumnoBtn.Name = "NuevoAlumnoBtn";
            NuevoAlumnoBtn.Size = new Size(178, 39);
            NuevoAlumnoBtn.TabIndex = 6;
            NuevoAlumnoBtn.Text = "Nuevo Alumno";
            NuevoAlumnoBtn.UseVisualStyleBackColor = true;
            NuevoAlumnoBtn.Click += NuevoAlumnoBtn_Click;
            // 
            // EdicionGroup
            // 
            EdicionGroup.Controls.Add(IdGrpTxb);
            EdicionGroup.Controls.Add(IdGrpLbl);
            EdicionGroup.Controls.Add(CarrerasAsignadasLbl);
            EdicionGroup.Controls.Add(AgregarGrpBtn);
            EdicionGroup.Controls.Add(QuitarGrpBtn);
            EdicionGroup.Controls.Add(CarrerasGrpListView);
            EdicionGroup.Controls.Add(CarrerasGrpCmb);
            EdicionGroup.Controls.Add(CarrerasGrpLbl);
            EdicionGroup.Controls.Add(DniGrpTxb);
            EdicionGroup.Controls.Add(DniGrpLbl);
            EdicionGroup.Controls.Add(ApellidoGrpTxb);
            EdicionGroup.Controls.Add(ApellidoGrpLbl);
            EdicionGroup.Controls.Add(NombreGrpTxb);
            EdicionGroup.Controls.Add(NombreGrpLbl);
            EdicionGroup.Controls.Add(AceptarGrpBtn);
            EdicionGroup.Controls.Add(CancelarGrpBtn);
            EdicionGroup.Enabled = false;
            EdicionGroup.Location = new Point(14, 407);
            EdicionGroup.Margin = new Padding(3, 4, 3, 4);
            EdicionGroup.Name = "EdicionGroup";
            EdicionGroup.Padding = new Padding(3, 4, 3, 4);
            EdicionGroup.Size = new Size(887, 381);
            EdicionGroup.TabIndex = 7;
            EdicionGroup.TabStop = false;
            EdicionGroup.Text = "Edicion ";
            // 
            // IdGrpTxb
            // 
            IdGrpTxb.Location = new Point(35, 71);
            IdGrpTxb.Name = "IdGrpTxb";
            IdGrpTxb.Size = new Size(174, 27);
            IdGrpTxb.TabIndex = 15;
            // 
            // IdGrpLbl
            // 
            IdGrpLbl.AutoSize = true;
            IdGrpLbl.Location = new Point(35, 44);
            IdGrpLbl.Name = "IdGrpLbl";
            IdGrpLbl.Size = new Size(22, 20);
            IdGrpLbl.TabIndex = 14;
            IdGrpLbl.Text = "Id";
            // 
            // CarrerasAsignadasLbl
            // 
            CarrerasAsignadasLbl.AutoSize = true;
            CarrerasAsignadasLbl.Location = new Point(553, 44);
            CarrerasAsignadasLbl.Name = "CarrerasAsignadasLbl";
            CarrerasAsignadasLbl.Size = new Size(135, 20);
            CarrerasAsignadasLbl.TabIndex = 13;
            CarrerasAsignadasLbl.Text = "Carreras Asignadas";
            // 
            // AgregarGrpBtn
            // 
            AgregarGrpBtn.Location = new Point(410, 65);
            AgregarGrpBtn.Margin = new Padding(3, 4, 3, 4);
            AgregarGrpBtn.Name = "AgregarGrpBtn";
            AgregarGrpBtn.Size = new Size(87, 39);
            AgregarGrpBtn.TabIndex = 12;
            AgregarGrpBtn.Text = "Agregar";
            AgregarGrpBtn.UseVisualStyleBackColor = true;
            // 
            // QuitarGrpBtn
            // 
            QuitarGrpBtn.Location = new Point(794, 236);
            QuitarGrpBtn.Margin = new Padding(3, 4, 3, 4);
            QuitarGrpBtn.Name = "QuitarGrpBtn";
            QuitarGrpBtn.Size = new Size(87, 31);
            QuitarGrpBtn.TabIndex = 11;
            QuitarGrpBtn.Text = "Quitar";
            QuitarGrpBtn.UseVisualStyleBackColor = true;
            QuitarGrpBtn.Click += QuitarGrpBtn_Click;
            // 
            // CarrerasGrpListView
            // 
            CarrerasGrpListView.Location = new Point(553, 71);
            CarrerasGrpListView.Margin = new Padding(3, 4, 3, 4);
            CarrerasGrpListView.Name = "CarrerasGrpListView";
            CarrerasGrpListView.Size = new Size(326, 147);
            CarrerasGrpListView.TabIndex = 10;
            CarrerasGrpListView.UseCompatibleStateImageBehavior = false;
            // 
            // CarrerasGrpCmb
            // 
            CarrerasGrpCmb.FormattingEnabled = true;
            CarrerasGrpCmb.Location = new Point(264, 71);
            CarrerasGrpCmb.Margin = new Padding(3, 4, 3, 4);
            CarrerasGrpCmb.Name = "CarrerasGrpCmb";
            CarrerasGrpCmb.Size = new Size(139, 28);
            CarrerasGrpCmb.TabIndex = 9;
            // 
            // CarrerasGrpLbl
            // 
            CarrerasGrpLbl.AutoSize = true;
            CarrerasGrpLbl.Location = new Point(264, 44);
            CarrerasGrpLbl.Name = "CarrerasGrpLbl";
            CarrerasGrpLbl.Size = new Size(63, 20);
            CarrerasGrpLbl.TabIndex = 8;
            CarrerasGrpLbl.Text = "Carreras";
            // 
            // DniGrpTxb
            // 
            DniGrpTxb.Location = new Point(35, 287);
            DniGrpTxb.Margin = new Padding(3, 4, 3, 4);
            DniGrpTxb.Name = "DniGrpTxb";
            DniGrpTxb.Size = new Size(174, 27);
            DniGrpTxb.TabIndex = 7;
            // 
            // DniGrpLbl
            // 
            DniGrpLbl.AutoSize = true;
            DniGrpLbl.Location = new Point(35, 260);
            DniGrpLbl.Name = "DniGrpLbl";
            DniGrpLbl.Size = new Size(35, 20);
            DniGrpLbl.TabIndex = 6;
            DniGrpLbl.Text = "DNI";
            // 
            // ApellidoGrpTxb
            // 
            ApellidoGrpTxb.Location = new Point(35, 211);
            ApellidoGrpTxb.Margin = new Padding(3, 4, 3, 4);
            ApellidoGrpTxb.Name = "ApellidoGrpTxb";
            ApellidoGrpTxb.Size = new Size(174, 27);
            ApellidoGrpTxb.TabIndex = 5;
            // 
            // ApellidoGrpLbl
            // 
            ApellidoGrpLbl.AutoSize = true;
            ApellidoGrpLbl.Location = new Point(35, 184);
            ApellidoGrpLbl.Name = "ApellidoGrpLbl";
            ApellidoGrpLbl.Size = new Size(66, 20);
            ApellidoGrpLbl.TabIndex = 4;
            ApellidoGrpLbl.Text = "Apellido";
            // 
            // NombreGrpTxb
            // 
            NombreGrpTxb.Location = new Point(35, 131);
            NombreGrpTxb.Margin = new Padding(3, 4, 3, 4);
            NombreGrpTxb.Name = "NombreGrpTxb";
            NombreGrpTxb.Size = new Size(174, 27);
            NombreGrpTxb.TabIndex = 3;
            // 
            // NombreGrpLbl
            // 
            NombreGrpLbl.AutoSize = true;
            NombreGrpLbl.Location = new Point(35, 104);
            NombreGrpLbl.Name = "NombreGrpLbl";
            NombreGrpLbl.Size = new Size(64, 20);
            NombreGrpLbl.TabIndex = 2;
            NombreGrpLbl.Text = "Nombre";
            // 
            // AceptarGrpBtn
            // 
            AceptarGrpBtn.Location = new Point(793, 333);
            AceptarGrpBtn.Margin = new Padding(3, 4, 3, 4);
            AceptarGrpBtn.Name = "AceptarGrpBtn";
            AceptarGrpBtn.Size = new Size(87, 33);
            AceptarGrpBtn.TabIndex = 1;
            AceptarGrpBtn.Text = "Aceptar";
            AceptarGrpBtn.UseVisualStyleBackColor = true;
            AceptarGrpBtn.Click += AceptarGrpBtn_Click;
            // 
            // CancelarGrpBtn
            // 
            CancelarGrpBtn.Location = new Point(699, 333);
            CancelarGrpBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarGrpBtn.Name = "CancelarGrpBtn";
            CancelarGrpBtn.Size = new Size(87, 33);
            CancelarGrpBtn.TabIndex = 0;
            CancelarGrpBtn.Text = "Cancelar";
            CancelarGrpBtn.UseVisualStyleBackColor = true;
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(14, 799);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(99, 33);
            AtrasBtn.TabIndex = 8;
            AtrasBtn.Text = "Atrás";
            AtrasBtn.UseVisualStyleBackColor = true;
            AtrasBtn.Click += AtrasBtn_Click;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(394, 28);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(101, 27);
            BuscarBtn.TabIndex = 9;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // GestionAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 844);
            Controls.Add(BuscarBtn);
            Controls.Add(AtrasBtn);
            Controls.Add(EdicionGroup);
            Controls.Add(NuevoAlumnoBtn);
            Controls.Add(EditarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(AlumnosLbl);
            Controls.Add(AlumnosListView);
            Controls.Add(BuscarDniTxb);
            Controls.Add(BuscarAlumnoLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionAlumnos";
            Text = "Gestion de Almunos";
            EdicionGroup.ResumeLayout(false);
            EdicionGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BuscarAlumnoLbl;
        private TextBox BuscarDniTxb;
        private ListView AlumnosListView;
        private Label AlumnosLbl;
        private Button EliminarBtn;
        private Button EditarBtn;
        private Button NuevoAlumnoBtn;
        private GroupBox EdicionGroup;
        private Button AceptarGrpBtn;
        private Button CancelarGrpBtn;
        private TextBox ApellidoGrpTxb;
        private Label ApellidoGrpLbl;
        private TextBox NombreGrpTxb;
        private Label NombreGrpLbl;
        private TextBox DniGrpTxb;
        private Label DniGrpLbl;
        private Label CarrerasGrpLbl;
        private ListView CarrerasGrpListView;
        private ComboBox CarrerasGrpCmb;
        private Button AgregarGrpBtn;
        private Button QuitarGrpBtn;
        private Button AtrasBtn;
        private Label CarrerasAsignadasLbl;
        private Button BuscarBtn;
        private TextBox IdGrpTxb;
        private Label IdGrpLbl;
        private ColumnHeader IdCol;
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader DniCol;
    }
}