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
            AgregarGroupBtn = new Button();
            NombreGroupTxb = new TextBox();
            ApellidoGroupLbl = new Label();
            AceptarGroupbtn = new Button();
            CancelarGroupbtn = new Button();
            QuitarGroupBtn = new Button();
            MatAsignadasGroupListView = new ListView();
            MatAsignadasGroupLbl = new Label();
            MateriasGroupCmb = new ComboBox();
            MateriasGroupLbl = new Label();
            DniGroupLbl = new Label();
            NombreGroupLbl = new Label();
            DniGroupTxb = new TextBox();
            ApellidoGroupTxb = new TextBox();
            IdGroupTxb = new TextBox();
            IdGroupLbl = new Label();
            BuscarBtn = new Button();
            TipoDocenteGroupLbl = new Label();
            TipoDocenteGroupCmb = new ComboBox();
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
            BuscarDniTxb.Location = new Point(203, 34);
            BuscarDniTxb.Name = "BuscarDniTxb";
            BuscarDniTxb.Size = new Size(163, 27);
            BuscarDniTxb.TabIndex = 1;
            // 
            // PersonalLbl
            // 
            PersonalLbl.AutoSize = true;
            PersonalLbl.Location = new Point(27, 106);
            PersonalLbl.Name = "PersonalLbl";
            PersonalLbl.Size = new Size(64, 20);
            PersonalLbl.TabIndex = 2;
            PersonalLbl.Text = "Personal";
            // 
            // PersonalListView
            // 
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
            NuevoDocenteBtn.Size = new Size(152, 38);
            NuevoDocenteBtn.TabIndex = 4;
            NuevoDocenteBtn.Text = "Nuevo Docente";
            NuevoDocenteBtn.UseVisualStyleBackColor = true;
            // 
            // EditarBtn
            // 
            EditarBtn.Location = new Point(599, 341);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(132, 38);
            EditarBtn.TabIndex = 5;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(749, 341);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(128, 38);
            EliminarBtn.TabIndex = 6;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // EdicionGroup
            // 
            EdicionGroup.Controls.Add(TipoDocenteGroupCmb);
            EdicionGroup.Controls.Add(TipoDocenteGroupLbl);
            EdicionGroup.Controls.Add(AgregarGroupBtn);
            EdicionGroup.Controls.Add(NombreGroupTxb);
            EdicionGroup.Controls.Add(ApellidoGroupLbl);
            EdicionGroup.Controls.Add(AceptarGroupbtn);
            EdicionGroup.Controls.Add(CancelarGroupbtn);
            EdicionGroup.Controls.Add(QuitarGroupBtn);
            EdicionGroup.Controls.Add(MatAsignadasGroupListView);
            EdicionGroup.Controls.Add(MatAsignadasGroupLbl);
            EdicionGroup.Controls.Add(MateriasGroupCmb);
            EdicionGroup.Controls.Add(MateriasGroupLbl);
            EdicionGroup.Controls.Add(DniGroupLbl);
            EdicionGroup.Controls.Add(NombreGroupLbl);
            EdicionGroup.Controls.Add(DniGroupTxb);
            EdicionGroup.Controls.Add(ApellidoGroupTxb);
            EdicionGroup.Controls.Add(IdGroupTxb);
            EdicionGroup.Controls.Add(IdGroupLbl);
            EdicionGroup.Location = new Point(27, 421);
            EdicionGroup.Name = "EdicionGroup";
            EdicionGroup.Size = new Size(875, 329);
            EdicionGroup.TabIndex = 7;
            EdicionGroup.TabStop = false;
            EdicionGroup.Text = "Edicion";
            // 
            // AgregarGroupBtn
            // 
            AgregarGroupBtn.Location = new Point(456, 77);
            AgregarGroupBtn.Name = "AgregarGroupBtn";
            AgregarGroupBtn.Size = new Size(95, 30);
            AgregarGroupBtn.TabIndex = 15;
            AgregarGroupBtn.Text = "Agregar";
            AgregarGroupBtn.UseVisualStyleBackColor = true;
            // 
            // NombreGroupTxb
            // 
            NombreGroupTxb.Location = new Point(56, 144);
            NombreGroupTxb.Name = "NombreGroupTxb";
            NombreGroupTxb.Size = new Size(122, 27);
            NombreGroupTxb.TabIndex = 14;
            // 
            // ApellidoGroupLbl
            // 
            ApellidoGroupLbl.AutoSize = true;
            ApellidoGroupLbl.Location = new Point(56, 186);
            ApellidoGroupLbl.Name = "ApellidoGroupLbl";
            ApellidoGroupLbl.Size = new Size(66, 20);
            ApellidoGroupLbl.TabIndex = 13;
            ApellidoGroupLbl.Text = "Apellido";
            // 
            // AceptarGroupbtn
            // 
            AceptarGroupbtn.Location = new Point(745, 284);
            AceptarGroupbtn.Name = "AceptarGroupbtn";
            AceptarGroupbtn.Size = new Size(96, 33);
            AceptarGroupbtn.TabIndex = 12;
            AceptarGroupbtn.Text = "Aceptar";
            AceptarGroupbtn.UseVisualStyleBackColor = true;
            // 
            // CancelarGroupbtn
            // 
            CancelarGroupbtn.Location = new Point(618, 284);
            CancelarGroupbtn.Name = "CancelarGroupbtn";
            CancelarGroupbtn.Size = new Size(102, 33);
            CancelarGroupbtn.TabIndex = 11;
            CancelarGroupbtn.Text = "Cancelar";
            CancelarGroupbtn.UseVisualStyleBackColor = true;
            // 
            // QuitarGroupBtn
            // 
            QuitarGroupBtn.Location = new Point(762, 213);
            QuitarGroupBtn.Name = "QuitarGroupBtn";
            QuitarGroupBtn.Size = new Size(77, 32);
            QuitarGroupBtn.TabIndex = 10;
            QuitarGroupBtn.Text = "Quitar";
            QuitarGroupBtn.UseVisualStyleBackColor = true;
            // 
            // MatAsignadasGroupListView
            // 
            MatAsignadasGroupListView.Location = new Point(618, 79);
            MatAsignadasGroupListView.Name = "MatAsignadasGroupListView";
            MatAsignadasGroupListView.Size = new Size(221, 128);
            MatAsignadasGroupListView.TabIndex = 9;
            MatAsignadasGroupListView.UseCompatibleStateImageBehavior = false;
            // 
            // MatAsignadasGroupLbl
            // 
            MatAsignadasGroupLbl.AutoSize = true;
            MatAsignadasGroupLbl.Location = new Point(618, 51);
            MatAsignadasGroupLbl.Name = "MatAsignadasGroupLbl";
            MatAsignadasGroupLbl.Size = new Size(138, 20);
            MatAsignadasGroupLbl.TabIndex = 8;
            MatAsignadasGroupLbl.Text = "Materias Asignadas";
            // 
            // MateriasGroupCmb
            // 
            MateriasGroupCmb.FormattingEnabled = true;
            MateriasGroupCmb.Location = new Point(299, 79);
            MateriasGroupCmb.Name = "MateriasGroupCmb";
            MateriasGroupCmb.Size = new Size(140, 28);
            MateriasGroupCmb.TabIndex = 7;
            // 
            // MateriasGroupLbl
            // 
            MateriasGroupLbl.AutoSize = true;
            MateriasGroupLbl.Location = new Point(299, 51);
            MateriasGroupLbl.Name = "MateriasGroupLbl";
            MateriasGroupLbl.Size = new Size(66, 20);
            MateriasGroupLbl.TabIndex = 6;
            MateriasGroupLbl.Text = "Materias";
            // 
            // DniGroupLbl
            // 
            DniGroupLbl.AutoSize = true;
            DniGroupLbl.Location = new Point(56, 243);
            DniGroupLbl.Name = "DniGroupLbl";
            DniGroupLbl.Size = new Size(35, 20);
            DniGroupLbl.TabIndex = 5;
            DniGroupLbl.Text = "DNI";
            // 
            // NombreGroupLbl
            // 
            NombreGroupLbl.AutoSize = true;
            NombreGroupLbl.Location = new Point(56, 121);
            NombreGroupLbl.Name = "NombreGroupLbl";
            NombreGroupLbl.Size = new Size(64, 20);
            NombreGroupLbl.TabIndex = 4;
            NombreGroupLbl.Text = "Nombre";
            // 
            // DniGroupTxb
            // 
            DniGroupTxb.Location = new Point(56, 266);
            DniGroupTxb.Name = "DniGroupTxb";
            DniGroupTxb.Size = new Size(122, 27);
            DniGroupTxb.TabIndex = 3;
            // 
            // ApellidoGroupTxb
            // 
            ApellidoGroupTxb.Location = new Point(56, 209);
            ApellidoGroupTxb.Name = "ApellidoGroupTxb";
            ApellidoGroupTxb.Size = new Size(119, 27);
            ApellidoGroupTxb.TabIndex = 2;
            // 
            // IdGroupTxb
            // 
            IdGroupTxb.Location = new Point(56, 79);
            IdGroupTxb.Name = "IdGroupTxb";
            IdGroupTxb.Size = new Size(66, 27);
            IdGroupTxb.TabIndex = 1;
            // 
            // IdGroupLbl
            // 
            IdGroupLbl.AutoSize = true;
            IdGroupLbl.Location = new Point(53, 51);
            IdGroupLbl.Name = "IdGroupLbl";
            IdGroupLbl.Size = new Size(24, 20);
            IdGroupLbl.TabIndex = 0;
            IdGroupLbl.Text = "ID";
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(404, 34);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(117, 27);
            BuscarBtn.TabIndex = 8;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // TipoDocenteGroupLbl
            // 
            TipoDocenteGroupLbl.AutoSize = true;
            TipoDocenteGroupLbl.Location = new Point(219, 242);
            TipoDocenteGroupLbl.Name = "TipoDocenteGroupLbl";
            TipoDocenteGroupLbl.Size = new Size(120, 20);
            TipoDocenteGroupLbl.TabIndex = 16;
            TipoDocenteGroupLbl.Text = "Tipo de Docente";
            // 
            // TipoDocenteGroupCmb
            // 
            TipoDocenteGroupCmb.FormattingEnabled = true;
            TipoDocenteGroupCmb.Location = new Point(219, 265);
            TipoDocenteGroupCmb.Name = "TipoDocenteGroupCmb";
            TipoDocenteGroupCmb.Size = new Size(160, 28);
            TipoDocenteGroupCmb.TabIndex = 17;
            // 
            // GestionPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 762);
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
        private Label DniGroupLbl;
        private Label NombreGroupLbl;
        private TextBox DniGroupTxb;
        private TextBox ApellidoGroupTxb;
        private Label MateriasGroupLbl;
        private ListView MatAsignadasGroupListView;
        private Label MatAsignadasGroupLbl;
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
    }
}