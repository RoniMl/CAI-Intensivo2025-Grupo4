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
            CarreraCmbBox = new ComboBox();
            AtrasBtn = new Button();
            CrearAlumnoBtn = new Button();
            CarreraListView = new ListView();
            CarrerasLbl = new Label();
            AñadirBtn = new Button();
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
            // 
            // NombreTxb
            // 
            NombreTxb.Location = new Point(183, 87);
            NombreTxb.Name = "NombreTxb";
            NombreTxb.Size = new Size(138, 23);
            NombreTxb.TabIndex = 1;
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
            // ApellidoTxb
            // 
            ApellidoTxb.Location = new Point(183, 127);
            ApellidoTxb.Name = "ApellidoTxb";
            ApellidoTxb.Size = new Size(138, 23);
            ApellidoTxb.TabIndex = 3;
            // 
            // DNILbl
            // 
            DNILbl.AutoSize = true;
            DNILbl.Location = new Point(147, 166);
            DNILbl.Name = "DNILbl";
            DNILbl.Size = new Size(30, 17);
            DNILbl.TabIndex = 4;
            DNILbl.Text = "DNI";
            // 
            // DniTxb
            // 
            DniTxb.Location = new Point(183, 166);
            DniTxb.Name = "DniTxb";
            DniTxb.Size = new Size(138, 23);
            DniTxb.TabIndex = 5;
            // 
            // CarreraLbl
            // 
            CarreraLbl.AutoSize = true;
            CarreraLbl.Location = new Point(124, 209);
            CarreraLbl.Name = "CarreraLbl";
            CarreraLbl.Size = new Size(52, 17);
            CarreraLbl.TabIndex = 6;
            CarreraLbl.Text = "Carrera";
            // 
            // CarreraCmbBox
            // 
            CarreraCmbBox.FormattingEnabled = true;
            CarreraCmbBox.Location = new Point(182, 209);
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
            // 
            // CrearAlumnoBtn
            // 
            CrearAlumnoBtn.Location = new Point(675, 414);
            CrearAlumnoBtn.Name = "CrearAlumnoBtn";
            CrearAlumnoBtn.Size = new Size(113, 29);
            CrearAlumnoBtn.TabIndex = 9;
            CrearAlumnoBtn.Text = "Crear Alumno";
            CrearAlumnoBtn.UseVisualStyleBackColor = true;
            CrearAlumnoBtn.Click += CrearAlumnoBtn_Click;
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
            AñadirBtn.Location = new Point(326, 209);
            AñadirBtn.Name = "AñadirBtn";
            AñadirBtn.Size = new Size(75, 23);
            AñadirBtn.TabIndex = 12;
            AñadirBtn.Text = "Añadir";
            AñadirBtn.UseVisualStyleBackColor = true;
            AñadirBtn.Click += AñadirBtn_Click;
            // 
            // CrearAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 447);
            Controls.Add(AñadirBtn);
            Controls.Add(CarrerasLbl);
            Controls.Add(CarreraListView);
            Controls.Add(CrearAlumnoBtn);
            Controls.Add(AtrasBtn);
            Controls.Add(CarreraCmbBox);
            Controls.Add(CarreraLbl);
            Controls.Add(DniTxb);
            Controls.Add(DNILbl);
            Controls.Add(ApellidoTxb);
            Controls.Add(ApellidoLbl);
            Controls.Add(NombreTxb);
            Controls.Add(NombreLbl);
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
        private ComboBox CarreraCmbBox;
        private Button AtrasBtn;
        private Button CrearAlumnoBtn;
        private ListView CarreraListView;
        private Label CarrerasLbl;
        private Button AñadirBtn;
    }
}