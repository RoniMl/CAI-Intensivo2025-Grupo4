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
            NombreTxb = new TextBox();
            ApellidoLbl = new Label();
            ApellidoTxb = new TextBox();
            DNILbl = new Label();
            DniTxb = new TextBox();
            CarreraLbl = new Label();
            CarreraCmb = new ComboBox();
            AtrasBtn = new Button();
            CrearAlumnoBtn = new Button();
            CarreraListView = new ListView();
            CarrerasLbl = new Label();
            AgregarBtn = new Button();
            QuitarBtn = new Button();
            SuspendLayout();
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(137, 124);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(64, 20);
            NombreLbl.TabIndex = 0;
            NombreLbl.Text = "Nombre";
            // 
            // NombreTxb
            // 
            NombreTxb.Location = new Point(209, 116);
            NombreTxb.Margin = new Padding(3, 4, 3, 4);
            NombreTxb.Name = "NombreTxb";
            NombreTxb.Size = new Size(157, 27);
            NombreTxb.TabIndex = 1;
            // 
            // ApellidoLbl
            // 
            ApellidoLbl.AutoSize = true;
            ApellidoLbl.Location = new Point(138, 190);
            ApellidoLbl.Name = "ApellidoLbl";
            ApellidoLbl.Size = new Size(66, 20);
            ApellidoLbl.TabIndex = 2;
            ApellidoLbl.Text = "Apellido";
            // 
            // ApellidoTxb
            // 
            ApellidoTxb.Location = new Point(209, 186);
            ApellidoTxb.Margin = new Padding(3, 4, 3, 4);
            ApellidoTxb.Name = "ApellidoTxb";
            ApellidoTxb.Size = new Size(157, 27);
            ApellidoTxb.TabIndex = 3;
            // 
            // DNILbl
            // 
            DNILbl.AutoSize = true;
            DNILbl.Location = new Point(168, 248);
            DNILbl.Name = "DNILbl";
            DNILbl.Size = new Size(35, 20);
            DNILbl.TabIndex = 4;
            DNILbl.Text = "DNI";
            // 
            // DniTxb
            // 
            DniTxb.Location = new Point(209, 248);
            DniTxb.Margin = new Padding(3, 4, 3, 4);
            DniTxb.Name = "DniTxb";
            DniTxb.Size = new Size(157, 27);
            DniTxb.TabIndex = 5;
            // 
            // CarreraLbl
            // 
            CarreraLbl.AutoSize = true;
            CarreraLbl.Location = new Point(143, 325);
            CarreraLbl.Name = "CarreraLbl";
            CarreraLbl.Size = new Size(57, 20);
            CarreraLbl.TabIndex = 6;
            CarreraLbl.Text = "Carrera";
            // 
            // CarreraCmb
            // 
            CarreraCmb.FormattingEnabled = true;
            CarreraCmb.Location = new Point(209, 325);
            CarreraCmb.Margin = new Padding(3, 4, 3, 4);
            CarreraCmb.Name = "CarreraCmb";
            CarreraCmb.Size = new Size(157, 28);
            CarreraCmb.TabIndex = 7;
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(23, 502);
            AtrasBtn.Margin = new Padding(3, 4, 3, 4);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(86, 39);
            AtrasBtn.TabIndex = 8;
            AtrasBtn.Text = "Atras";
            AtrasBtn.UseVisualStyleBackColor = true;
            AtrasBtn.Click += AtrasBtn_Click;
            // 
            // CrearAlumnoBtn
            // 
            CrearAlumnoBtn.Location = new Point(763, 502);
            CrearAlumnoBtn.Margin = new Padding(3, 4, 3, 4);
            CrearAlumnoBtn.Name = "CrearAlumnoBtn";
            CrearAlumnoBtn.Size = new Size(129, 39);
            CrearAlumnoBtn.TabIndex = 9;
            CrearAlumnoBtn.Text = "Crear Alumno";
            CrearAlumnoBtn.UseVisualStyleBackColor = true;
            CrearAlumnoBtn.Click += CrearAlumnoBtn_Click;
            // 
            // CarreraListView
            // 
            CarreraListView.Location = new Point(557, 147);
            CarreraListView.Margin = new Padding(3, 4, 3, 4);
            CarreraListView.Name = "CarreraListView";
            CarreraListView.Size = new Size(271, 128);
            CarreraListView.TabIndex = 10;
            CarreraListView.UseCompatibleStateImageBehavior = false;
            // 
            // CarrerasLbl
            // 
            CarrerasLbl.AutoSize = true;
            CarrerasLbl.Location = new Point(557, 120);
            CarrerasLbl.Name = "CarrerasLbl";
            CarrerasLbl.Size = new Size(69, 20);
            CarrerasLbl.TabIndex = 11;
            CarrerasLbl.Text = "Carrera/s";
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(374, 325);
            AgregarBtn.Margin = new Padding(3, 4, 3, 4);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(86, 31);
            AgregarBtn.TabIndex = 12;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AñadirBtn_Click;
            // 
            // QuitarBtn
            // 
            QuitarBtn.Location = new Point(741, 288);
            QuitarBtn.Name = "QuitarBtn";
            QuitarBtn.Size = new Size(87, 35);
            QuitarBtn.TabIndex = 13;
            QuitarBtn.Text = "Quitar";
            QuitarBtn.UseVisualStyleBackColor = true;
            QuitarBtn.Click += QuitarBtn_Click;
            // 
            // CrearAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 556);
            Controls.Add(QuitarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(CarrerasLbl);
            Controls.Add(CarreraListView);
            Controls.Add(CrearAlumnoBtn);
            Controls.Add(AtrasBtn);
            Controls.Add(CarreraCmb);
            Controls.Add(CarreraLbl);
            Controls.Add(DniTxb);
            Controls.Add(DNILbl);
            Controls.Add(ApellidoTxb);
            Controls.Add(ApellidoLbl);
            Controls.Add(NombreTxb);
            Controls.Add(NombreLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearAlumno";
            Text = "Crear Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreLbl;
        private TextBox NombreTxb;
        private Label ApellidoLbl;
        private TextBox ApellidoTxb;
        private Label DNILbl;
        private TextBox DniTxb;
        private Label CarreraLbl;
        private ComboBox CarreraCmb;
        private Button AtrasBtn;
        private Button CrearAlumnoBtn;
        private ListView CarreraListView;
        private Label CarrerasLbl;
        private Button AgregarBtn;
        private Button QuitarBtn;
    }
}