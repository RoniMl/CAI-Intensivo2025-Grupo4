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
            EliminarBtn = new Button();
            EditarBtn = new Button();
            NuevoAlumnoBtn = new Button();
            EdicionGroup = new GroupBox();
            AgregarGrpBtn = new Button();
            QuitarGrpBtn = new Button();
            listView1 = new ListView();
            MateriasGrpCmb = new ComboBox();
            MateriaGrpLbl = new Label();
            DniGrpTxb = new TextBox();
            DniGrpLbl = new Label();
            ApellidoGrpTxb = new TextBox();
            ApellidoGrpLbl = new Label();
            NombreGrpTxb = new TextBox();
            NombreGrpLbl = new Label();
            AceptarGrpBtn = new Button();
            CancelarGrpBtn = new Button();
            EdicionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // BuscarAlumnoLbl
            // 
            BuscarAlumnoLbl.AutoSize = true;
            BuscarAlumnoLbl.Location = new Point(14, 32);
            BuscarAlumnoLbl.Name = "BuscarAlumnoLbl";
            BuscarAlumnoLbl.Size = new Size(163, 20);
            BuscarAlumnoLbl.TabIndex = 0;
            BuscarAlumnoLbl.Text = "Buscar alumno por DNI";
            // 
            // BuscarDniTxb
            // 
            BuscarDniTxb.Location = new Point(185, 28);
            BuscarDniTxb.Margin = new Padding(3, 4, 3, 4);
            BuscarDniTxb.Name = "BuscarDniTxb";
            BuscarDniTxb.Size = new Size(157, 27);
            BuscarDniTxb.TabIndex = 1;
            // 
            // AlumnosListView
            // 
            AlumnosListView.Columns.AddRange(new ColumnHeader[] { NombreCol, ApellidoCol, DniCol });
            AlumnosListView.Location = new Point(14, 124);
            AlumnosListView.Margin = new Padding(3, 4, 3, 4);
            AlumnosListView.Name = "AlumnosListView";
            AlumnosListView.Size = new Size(889, 300);
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
            AlumnosLbl.Location = new Point(14, 97);
            AlumnosLbl.Name = "AlumnosLbl";
            AlumnosLbl.Size = new Size(67, 20);
            AlumnosLbl.TabIndex = 3;
            AlumnosLbl.Text = "Alumnos";
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(736, 433);
            EliminarBtn.Margin = new Padding(3, 4, 3, 4);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(165, 39);
            EliminarBtn.TabIndex = 4;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // EditarBtn
            // 
            EditarBtn.Location = new Point(567, 433);
            EditarBtn.Margin = new Padding(3, 4, 3, 4);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(162, 39);
            EditarBtn.TabIndex = 5;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            // 
            // NuevoAlumnoBtn
            // 
            NuevoAlumnoBtn.Location = new Point(382, 433);
            NuevoAlumnoBtn.Margin = new Padding(3, 4, 3, 4);
            NuevoAlumnoBtn.Name = "NuevoAlumnoBtn";
            NuevoAlumnoBtn.Size = new Size(178, 39);
            NuevoAlumnoBtn.TabIndex = 6;
            NuevoAlumnoBtn.Text = "Nuevo Alumno";
            NuevoAlumnoBtn.UseVisualStyleBackColor = true;
            // 
            // EdicionGroup
            // 
            EdicionGroup.Controls.Add(AgregarGrpBtn);
            EdicionGroup.Controls.Add(QuitarGrpBtn);
            EdicionGroup.Controls.Add(listView1);
            EdicionGroup.Controls.Add(MateriasGrpCmb);
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
            EdicionGroup.Location = new Point(14, 523);
            EdicionGroup.Margin = new Padding(3, 4, 3, 4);
            EdicionGroup.Name = "EdicionGroup";
            EdicionGroup.Padding = new Padding(3, 4, 3, 4);
            EdicionGroup.Size = new Size(887, 375);
            EdicionGroup.TabIndex = 7;
            EdicionGroup.TabStop = false;
            EdicionGroup.Text = "Edicion ";
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
            QuitarGrpBtn.Location = new Point(793, 200);
            QuitarGrpBtn.Margin = new Padding(3, 4, 3, 4);
            QuitarGrpBtn.Name = "QuitarGrpBtn";
            QuitarGrpBtn.Size = new Size(87, 31);
            QuitarGrpBtn.TabIndex = 11;
            QuitarGrpBtn.Text = "Quitar";
            QuitarGrpBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(553, 68);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(326, 123);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MateriasGrpCmb
            // 
            MateriasGrpCmb.FormattingEnabled = true;
            MateriasGrpCmb.Location = new Point(264, 71);
            MateriasGrpCmb.Margin = new Padding(3, 4, 3, 4);
            MateriasGrpCmb.Name = "MateriasGrpCmb";
            MateriasGrpCmb.Size = new Size(139, 28);
            MateriasGrpCmb.TabIndex = 9;
            // 
            // MateriaGrpLbl
            // 
            MateriaGrpLbl.AutoSize = true;
            MateriaGrpLbl.Location = new Point(264, 44);
            MateriaGrpLbl.Name = "MateriaGrpLbl";
            MateriaGrpLbl.Size = new Size(66, 20);
            MateriaGrpLbl.TabIndex = 8;
            MateriaGrpLbl.Text = "Materias";
            // 
            // DniGrpTxb
            // 
            DniGrpTxb.Location = new Point(32, 227);
            DniGrpTxb.Margin = new Padding(3, 4, 3, 4);
            DniGrpTxb.Name = "DniGrpTxb";
            DniGrpTxb.Size = new Size(174, 27);
            DniGrpTxb.TabIndex = 7;
            // 
            // DniGrpLbl
            // 
            DniGrpLbl.AutoSize = true;
            DniGrpLbl.Location = new Point(32, 200);
            DniGrpLbl.Name = "DniGrpLbl";
            DniGrpLbl.Size = new Size(35, 20);
            DniGrpLbl.TabIndex = 6;
            DniGrpLbl.Text = "DNI";
            // 
            // ApellidoGrpTxb
            // 
            ApellidoGrpTxb.Location = new Point(32, 151);
            ApellidoGrpTxb.Margin = new Padding(3, 4, 3, 4);
            ApellidoGrpTxb.Name = "ApellidoGrpTxb";
            ApellidoGrpTxb.Size = new Size(174, 27);
            ApellidoGrpTxb.TabIndex = 5;
            // 
            // ApellidoGrpLbl
            // 
            ApellidoGrpLbl.AutoSize = true;
            ApellidoGrpLbl.Location = new Point(32, 124);
            ApellidoGrpLbl.Name = "ApellidoGrpLbl";
            ApellidoGrpLbl.Size = new Size(66, 20);
            ApellidoGrpLbl.TabIndex = 4;
            ApellidoGrpLbl.Text = "Apellido";
            // 
            // NombreGrpTxb
            // 
            NombreGrpTxb.Location = new Point(32, 71);
            NombreGrpTxb.Margin = new Padding(3, 4, 3, 4);
            NombreGrpTxb.Name = "NombreGrpTxb";
            NombreGrpTxb.Size = new Size(174, 27);
            NombreGrpTxb.TabIndex = 3;
            // 
            // NombreGrpLbl
            // 
            NombreGrpLbl.AutoSize = true;
            NombreGrpLbl.Location = new Point(32, 44);
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
            // GestionAlumnosForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 913);
            Controls.Add(EdicionGroup);
            Controls.Add(NuevoAlumnoBtn);
            Controls.Add(EditarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(AlumnosLbl);
            Controls.Add(AlumnosListView);
            Controls.Add(BuscarDniTxb);
            Controls.Add(BuscarAlumnoLbl);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label MateriaGrpLbl;
        private ListView listView1;
        private ComboBox MateriasGrpCmb;
        private Button AgregarGrpBtn;
        private Button QuitarGrpBtn;
    }
}