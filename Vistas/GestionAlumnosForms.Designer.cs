namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class GestionAlumnosForms
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
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            DniCol = new ColumnHeader();
            AlumnosLbl = new Label();
            ModificarBtn = new Button();
            EditarBtn = new Button();
            NuevoAlumnoBtn = new Button();
            EdicionGroup = new GroupBox();
            CancelarGrpBtn = new Button();
            AceptarGrpBtn = new Button();
            NombreGrpLbl = new Label();
            NombreGrpTxb = new TextBox();
            ApellidoGrpTxb = new TextBox();
            ApellidoGrpLbl = new Label();
            DniGrpTxb = new TextBox();
            DniGrpLbl = new Label();
            MateriaGrpLbl = new Label();
            MateriasGrpCb = new ComboBox();
            listView1 = new ListView();
            QuitarGrpBtn = new Button();
            AgregarGrpBtn = new Button();
            EdicionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // BuscarAlumnoLbl
            // 
            BuscarAlumnoLbl.AutoSize = true;
            BuscarAlumnoLbl.Location = new Point(12, 24);
            BuscarAlumnoLbl.Name = "BuscarAlumnoLbl";
            BuscarAlumnoLbl.Size = new Size(144, 17);
            BuscarAlumnoLbl.TabIndex = 0;
            BuscarAlumnoLbl.Text = "Buscar alumno por DNI";
            // 
            // BuscarDniTxb
            // 
            BuscarDniTxb.Location = new Point(162, 21);
            BuscarDniTxb.Name = "BuscarDniTxb";
            BuscarDniTxb.Size = new Size(138, 23);
            BuscarDniTxb.TabIndex = 1;
            // 
            // AlumnosListView
            // 
            AlumnosListView.Columns.AddRange(new ColumnHeader[] { NombreCol, ApellidoCol, DniCol });
            AlumnosListView.Location = new Point(12, 93);
            AlumnosListView.Name = "AlumnosListView";
            AlumnosListView.Size = new Size(778, 226);
            AlumnosListView.TabIndex = 2;
            AlumnosListView.UseCompatibleStateImageBehavior = false;
            // 
            // NombreCol
            // 
            NombreCol.Text = "Nombre";
            NombreCol.Width = 200;
            // 
            // ApellidoCol
            // 
            ApellidoCol.Tag = "";
            ApellidoCol.Text = "Apellido";
            ApellidoCol.Width = 200;
            // 
            // DniCol
            // 
            DniCol.Text = "DNI";
            DniCol.Width = 200;
            // 
            // AlumnosLbl
            // 
            AlumnosLbl.AutoSize = true;
            AlumnosLbl.Location = new Point(12, 73);
            AlumnosLbl.Name = "AlumnosLbl";
            AlumnosLbl.Size = new Size(58, 17);
            AlumnosLbl.TabIndex = 3;
            AlumnosLbl.Text = "Alumnos";
            // 
            // ModificarBtn
            // 
            ModificarBtn.Location = new Point(644, 325);
            ModificarBtn.Name = "ModificarBtn";
            ModificarBtn.Size = new Size(144, 29);
            ModificarBtn.TabIndex = 4;
            ModificarBtn.Text = "Modificar";
            ModificarBtn.UseVisualStyleBackColor = true;
            // 
            // EditarBtn
            // 
            EditarBtn.Location = new Point(496, 325);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(142, 29);
            EditarBtn.TabIndex = 5;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            // 
            // NuevoAlumnoBtn
            // 
            NuevoAlumnoBtn.Location = new Point(334, 325);
            NuevoAlumnoBtn.Name = "NuevoAlumnoBtn";
            NuevoAlumnoBtn.Size = new Size(156, 29);
            NuevoAlumnoBtn.TabIndex = 6;
            NuevoAlumnoBtn.Text = "Nuevo Alumno";
            NuevoAlumnoBtn.UseVisualStyleBackColor = true;
            // 
            // EdicionGroup
            // 
            EdicionGroup.Controls.Add(AgregarGrpBtn);
            EdicionGroup.Controls.Add(QuitarGrpBtn);
            EdicionGroup.Controls.Add(listView1);
            EdicionGroup.Controls.Add(MateriasGrpCb);
            EdicionGroup.Controls.Add(MateriaGrpLbl);
            EdicionGroup.Controls.Add(DniGrpTxb);
            EdicionGroup.Controls.Add(DniGrpLbl);
            EdicionGroup.Controls.Add(ApellidoGrpTxb);
            EdicionGroup.Controls.Add(ApellidoGrpLbl);
            EdicionGroup.Controls.Add(NombreGrpTxb);
            EdicionGroup.Controls.Add(NombreGrpLbl);
            EdicionGroup.Controls.Add(AceptarGrpBtn);
            EdicionGroup.Controls.Add(CancelarGrpBtn);
            EdicionGroup.Enabled = false;
            EdicionGroup.Location = new Point(12, 392);
            EdicionGroup.Name = "EdicionGroup";
            EdicionGroup.Size = new Size(776, 281);
            EdicionGroup.TabIndex = 7;
            EdicionGroup.TabStop = false;
            EdicionGroup.Text = "Edicion ";
            // 
            // CancelarGrpBtn
            // 
            CancelarGrpBtn.Location = new Point(612, 250);
            CancelarGrpBtn.Name = "CancelarGrpBtn";
            CancelarGrpBtn.Size = new Size(76, 25);
            CancelarGrpBtn.TabIndex = 0;
            CancelarGrpBtn.Text = "Cancelar";
            CancelarGrpBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarGrpBtn
            // 
            AceptarGrpBtn.Location = new Point(694, 250);
            AceptarGrpBtn.Name = "AceptarGrpBtn";
            AceptarGrpBtn.Size = new Size(76, 25);
            AceptarGrpBtn.TabIndex = 1;
            AceptarGrpBtn.Text = "Aceptar";
            AceptarGrpBtn.UseVisualStyleBackColor = true;
            // 
            // NombreGrpLbl
            // 
            NombreGrpLbl.AutoSize = true;
            NombreGrpLbl.Location = new Point(28, 33);
            NombreGrpLbl.Name = "NombreGrpLbl";
            NombreGrpLbl.Size = new Size(57, 17);
            NombreGrpLbl.TabIndex = 2;
            NombreGrpLbl.Text = "Nombre";
            // 
            // NombreGrpTxb
            // 
            NombreGrpTxb.Location = new Point(28, 53);
            NombreGrpTxb.Name = "NombreGrpTxb";
            NombreGrpTxb.Size = new Size(153, 23);
            NombreGrpTxb.TabIndex = 3;
            // 
            // ApellidoGrpTxb
            // 
            ApellidoGrpTxb.Location = new Point(28, 113);
            ApellidoGrpTxb.Name = "ApellidoGrpTxb";
            ApellidoGrpTxb.Size = new Size(153, 23);
            ApellidoGrpTxb.TabIndex = 5;
            // 
            // ApellidoGrpLbl
            // 
            ApellidoGrpLbl.AutoSize = true;
            ApellidoGrpLbl.Location = new Point(28, 93);
            ApellidoGrpLbl.Name = "ApellidoGrpLbl";
            ApellidoGrpLbl.Size = new Size(56, 17);
            ApellidoGrpLbl.TabIndex = 4;
            ApellidoGrpLbl.Text = "Apellido";
            // 
            // DniGrpTxb
            // 
            DniGrpTxb.Location = new Point(28, 170);
            DniGrpTxb.Name = "DniGrpTxb";
            DniGrpTxb.Size = new Size(153, 23);
            DniGrpTxb.TabIndex = 7;
            // 
            // DniGrpLbl
            // 
            DniGrpLbl.AutoSize = true;
            DniGrpLbl.Location = new Point(28, 150);
            DniGrpLbl.Name = "DniGrpLbl";
            DniGrpLbl.Size = new Size(30, 17);
            DniGrpLbl.TabIndex = 6;
            DniGrpLbl.Text = "DNI";
            // 
            // MateriaGrpLbl
            // 
            MateriaGrpLbl.AutoSize = true;
            MateriaGrpLbl.Location = new Point(231, 33);
            MateriaGrpLbl.Name = "MateriaGrpLbl";
            MateriaGrpLbl.Size = new Size(59, 17);
            MateriaGrpLbl.TabIndex = 8;
            MateriaGrpLbl.Text = "Materias";
            // 
            // MateriasGrpCb
            // 
            MateriasGrpCb.FormattingEnabled = true;
            MateriasGrpCb.Location = new Point(231, 53);
            MateriasGrpCb.Name = "MateriasGrpCb";
            MateriasGrpCb.Size = new Size(122, 23);
            MateriasGrpCb.TabIndex = 9;
            // 
            // listView1
            // 
            listView1.Location = new Point(484, 51);
            listView1.Name = "listView1";
            listView1.Size = new Size(286, 93);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // QuitarGrpBtn
            // 
            QuitarGrpBtn.Location = new Point(694, 150);
            QuitarGrpBtn.Name = "QuitarGrpBtn";
            QuitarGrpBtn.Size = new Size(76, 23);
            QuitarGrpBtn.TabIndex = 11;
            QuitarGrpBtn.Text = "Quitar";
            QuitarGrpBtn.UseVisualStyleBackColor = true;
            // 
            // AgregarGrpBtn
            // 
            AgregarGrpBtn.Location = new Point(359, 49);
            AgregarGrpBtn.Name = "AgregarGrpBtn";
            AgregarGrpBtn.Size = new Size(76, 29);
            AgregarGrpBtn.TabIndex = 12;
            AgregarGrpBtn.Text = "Agregar";
            AgregarGrpBtn.UseVisualStyleBackColor = true;
            // 
            // GestionAlumnosForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 685);
            Controls.Add(EdicionGroup);
            Controls.Add(NuevoAlumnoBtn);
            Controls.Add(EditarBtn);
            Controls.Add(ModificarBtn);
            Controls.Add(AlumnosLbl);
            Controls.Add(AlumnosListView);
            Controls.Add(BuscarDniTxb);
            Controls.Add(BuscarAlumnoLbl);
            Name = "GestionAlumnosForms";
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
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader DniCol;
        private Button ModificarBtn;
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
        private Label MateriaGrpLbl;
        private ListView listView1;
        private ComboBox MateriasGrpCb;
        private Button AgregarGrpBtn;
        private Button QuitarGrpBtn;
    }
}