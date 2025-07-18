namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class CrearAlumno
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
            NombreLbl = new Label();
            NombreTxt = new TextBox();
            ApellidoLbl = new Label();
            ApellidoTxt = new TextBox();
            DNILbl = new Label();
            DNITxt = new TextBox();
            CarreraLbl = new Label();
            CarreraCmbBox = new ComboBox();
            AtrasBtn = new Button();
            CrearAlumnoBtn = new Button();
            CarreraListView = new ListView();
            CarrerasLbl = new Label();
            AñadirBtn = new Button();
            ContraseñaTbx = new TextBox();
            ContraseñaLbl = new Label();
            UsuarioTxb = new TextBox();
            UsuarioLbl = new Label();
            SuspendLayout();
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(120, 93);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(57, 17);
            NombreLbl.TabIndex = 0;
            NombreLbl.Text = "Nombre";
            NombreLbl.Click += Nombrelbl_Click;
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(183, 87);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(138, 23);
            NombreTxt.TabIndex = 1;
            // 
            // ApellidoLbl
            // 
            ApellidoLbl.AutoSize = true;
            ApellidoLbl.Location = new Point(121, 130);
            ApellidoLbl.Name = "ApellidoLbl";
            ApellidoLbl.Size = new Size(56, 17);
            ApellidoLbl.TabIndex = 2;
            ApellidoLbl.Text = "Apellido";
            // 
            // ApellidoTxt
            // 
            ApellidoTxt.Location = new Point(183, 127);
            ApellidoTxt.Name = "ApellidoTxt";
            ApellidoTxt.Size = new Size(138, 23);
            ApellidoTxt.TabIndex = 3;
            // 
            // DNILbl
            // 
            DNILbl.AutoSize = true;
            DNILbl.Location = new Point(147, 166);
            DNILbl.Name = "DNILbl";
            DNILbl.Size = new Size(30, 17);
            DNILbl.TabIndex = 4;
            DNILbl.Text = "DNI";
            DNILbl.Click += label1_Click;
            // 
            // DNITxt
            // 
            DNITxt.Location = new Point(183, 166);
            DNITxt.Name = "DNITxt";
            DNITxt.Size = new Size(138, 23);
            DNITxt.TabIndex = 5;
            // 
            // CarreraLbl
            // 
            CarreraLbl.AutoSize = true;
            CarreraLbl.Location = new Point(125, 291);
            CarreraLbl.Name = "CarreraLbl";
            CarreraLbl.Size = new Size(52, 17);
            CarreraLbl.TabIndex = 6;
            CarreraLbl.Text = "Carrera";
            // 
            // CarreraCmbBox
            // 
            CarreraCmbBox.FormattingEnabled = true;
            CarreraCmbBox.Location = new Point(183, 291);
            CarreraCmbBox.Name = "CarreraCmbBox";
            CarreraCmbBox.Size = new Size(138, 23);
            CarreraCmbBox.TabIndex = 7;
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(12, 414);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(75, 29);
            AtrasBtn.TabIndex = 8;
            AtrasBtn.Text = "Atras";
            AtrasBtn.UseVisualStyleBackColor = true;
            AtrasBtn.Click += button1_Click;
            // 
            // CrearAlumnoBtn
            // 
            CrearAlumnoBtn.Location = new Point(675, 414);
            CrearAlumnoBtn.Name = "CrearAlumnoBtn";
            CrearAlumnoBtn.Size = new Size(113, 29);
            CrearAlumnoBtn.TabIndex = 9;
            CrearAlumnoBtn.Text = "Crear Alumno";
            CrearAlumnoBtn.UseVisualStyleBackColor = true;
            // 
            // CarreraListView
            // 
            CarreraListView.Location = new Point(487, 110);
            CarreraListView.Name = "CarreraListView";
            CarreraListView.Size = new Size(238, 97);
            CarreraListView.TabIndex = 10;
            CarreraListView.UseCompatibleStateImageBehavior = false;
            // 
            // CarrerasLbl
            // 
            CarrerasLbl.AutoSize = true;
            CarrerasLbl.Location = new Point(487, 90);
            CarrerasLbl.Name = "CarrerasLbl";
            CarrerasLbl.Size = new Size(63, 17);
            CarrerasLbl.TabIndex = 11;
            CarrerasLbl.Text = "Carrera/s";
            // 
            // AñadirBtn
            // 
            AñadirBtn.Location = new Point(327, 291);
            AñadirBtn.Name = "AñadirBtn";
            AñadirBtn.Size = new Size(75, 23);
            AñadirBtn.TabIndex = 12;
            AñadirBtn.Text = "Añadir";
            AñadirBtn.UseVisualStyleBackColor = true;
            AñadirBtn.Click += button1_Click_1;
            // 
            // ContraseñaTbx
            // 
            ContraseñaTbx.Location = new Point(183, 249);
            ContraseñaTbx.Name = "ContraseñaTbx";
            ContraseñaTbx.Size = new Size(138, 23);
            ContraseñaTbx.TabIndex = 16;
            // 
            // ContraseñaLbl
            // 
            ContraseñaLbl.AutoSize = true;
            ContraseñaLbl.Location = new Point(103, 252);
            ContraseñaLbl.Name = "ContraseñaLbl";
            ContraseñaLbl.Size = new Size(74, 17);
            ContraseñaLbl.TabIndex = 15;
            ContraseñaLbl.Text = "Contraseña";
            // 
            // UsuarioTxb
            // 
            UsuarioTxb.Location = new Point(183, 207);
            UsuarioTxb.Name = "UsuarioTxb";
            UsuarioTxb.Size = new Size(138, 23);
            UsuarioTxb.TabIndex = 14;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(121, 210);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(53, 17);
            UsuarioLbl.TabIndex = 13;
            UsuarioLbl.Text = "Usuario";
            // 
            // CrearAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 447);
            Controls.Add(ContraseñaTbx);
            Controls.Add(ContraseñaLbl);
            Controls.Add(UsuarioTxb);
            Controls.Add(UsuarioLbl);
            Controls.Add(AñadirBtn);
            Controls.Add(CarrerasLbl);
            Controls.Add(CarreraListView);
            Controls.Add(CrearAlumnoBtn);
            Controls.Add(AtrasBtn);
            Controls.Add(CarreraCmbBox);
            Controls.Add(CarreraLbl);
            Controls.Add(DNITxt);
            Controls.Add(DNILbl);
            Controls.Add(ApellidoTxt);
            Controls.Add(ApellidoLbl);
            Controls.Add(NombreTxt);
            Controls.Add(NombreLbl);
            Name = "CrearAlumno";
            Text = "Crear Alumno";
            Load += CrearAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreLbl;
        private TextBox NombreTxt;
        private Label ApellidoLbl;
        private TextBox ApellidoTxt;
        private Label DNILbl;
        private TextBox DNITxt;
        private Label CarreraLbl;
        private ComboBox CarreraCmbBox;
        private Button AtrasBtn;
        private Button CrearAlumnoBtn;
        private ListView CarreraListView;
        private Label CarrerasLbl;
        private Button AñadirBtn;
        private TextBox ContraseñaTbx;
        private Label ContraseñaLbl;
        private TextBox UsuarioTxb;
        private Label UsuarioLbl;
    }
}