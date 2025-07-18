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
            PuestoCmbBox = new ComboBox();
            PuestoLbl = new Label();
            NombreLbl = new Label();
            ApellidoLbl = new Label();
            DNILbl = new Label();
            DNITxt = new TextBox();
            AtrasBtn = new Button();
            CrearPersonalBtn = new Button();
            NombreTxt = new TextBox();
            ApellidoTxt = new TextBox();
            ContraseñaTbx = new TextBox();
            ContraseñaLbl = new Label();
            UsuarioTxb = new TextBox();
            UsuarioLbl = new Label();
            SuspendLayout();
            // 
            // PuestoCmbBox
            // 
            PuestoCmbBox.FormattingEnabled = true;
            PuestoCmbBox.Location = new Point(205, 269);
            PuestoCmbBox.Name = "PuestoCmbBox";
            PuestoCmbBox.Size = new Size(121, 23);
            PuestoCmbBox.TabIndex = 0;
            // 
            // PuestoLbl
            // 
            PuestoLbl.AutoSize = true;
            PuestoLbl.Location = new Point(148, 269);
            PuestoLbl.Name = "PuestoLbl";
            PuestoLbl.Size = new Size(47, 17);
            PuestoLbl.TabIndex = 1;
            PuestoLbl.Text = "Puesto";
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(148, 92);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(57, 17);
            NombreLbl.TabIndex = 2;
            NombreLbl.Text = "Nombre";
            // 
            // ApellidoLbl
            // 
            ApellidoLbl.AutoSize = true;
            ApellidoLbl.Location = new Point(148, 146);
            ApellidoLbl.Name = "ApellidoLbl";
            ApellidoLbl.Size = new Size(56, 17);
            ApellidoLbl.TabIndex = 3;
            ApellidoLbl.Text = "Apellido";
            // 
            // DNILbl
            // 
            DNILbl.AutoSize = true;
            DNILbl.Location = new Point(148, 208);
            DNILbl.Name = "DNILbl";
            DNILbl.Size = new Size(30, 17);
            DNILbl.TabIndex = 4;
            DNILbl.Text = "DNI";
            DNILbl.Click += DNILbl_Click;
            // 
            // DNITxt
            // 
            DNITxt.Location = new Point(205, 205);
            DNITxt.Name = "DNITxt";
            DNITxt.Size = new Size(121, 23);
            DNITxt.TabIndex = 5;
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(78, 374);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(75, 23);
            AtrasBtn.TabIndex = 6;
            AtrasBtn.Text = "Atras";
            AtrasBtn.UseVisualStyleBackColor = true;
            AtrasBtn.Click += button1_Click;
            // 
            // CrearPersonalBtn
            // 
            CrearPersonalBtn.Location = new Point(596, 374);
            CrearPersonalBtn.Name = "CrearPersonalBtn";
            CrearPersonalBtn.Size = new Size(112, 23);
            CrearPersonalBtn.TabIndex = 7;
            CrearPersonalBtn.Text = "Crear Personal";
            CrearPersonalBtn.UseVisualStyleBackColor = true;
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(205, 89);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(121, 23);
            NombreTxt.TabIndex = 8;
            // 
            // ApellidoTxt
            // 
            ApellidoTxt.Location = new Point(205, 143);
            ApellidoTxt.Name = "ApellidoTxt";
            ApellidoTxt.Size = new Size(121, 23);
            ApellidoTxt.TabIndex = 9;
            // 
            // ContraseñaTbx
            // 
            ContraseñaTbx.Location = new Point(482, 143);
            ContraseñaTbx.Name = "ContraseñaTbx";
            ContraseñaTbx.Size = new Size(138, 23);
            ContraseñaTbx.TabIndex = 20;
            // 
            // ContraseñaLbl
            // 
            ContraseñaLbl.AutoSize = true;
            ContraseñaLbl.Location = new Point(402, 146);
            ContraseñaLbl.Name = "ContraseñaLbl";
            ContraseñaLbl.Size = new Size(74, 17);
            ContraseñaLbl.TabIndex = 19;
            ContraseñaLbl.Text = "Contraseña";
            // 
            // UsuarioTxb
            // 
            UsuarioTxb.Location = new Point(482, 92);
            UsuarioTxb.Name = "UsuarioTxb";
            UsuarioTxb.Size = new Size(138, 23);
            UsuarioTxb.TabIndex = 18;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(420, 95);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(53, 17);
            UsuarioLbl.TabIndex = 17;
            UsuarioLbl.Text = "Usuario";
            // 
            // CrearPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ContraseñaTbx);
            Controls.Add(ContraseñaLbl);
            Controls.Add(UsuarioTxb);
            Controls.Add(UsuarioLbl);
            Controls.Add(ApellidoTxt);
            Controls.Add(NombreTxt);
            Controls.Add(CrearPersonalBtn);
            Controls.Add(AtrasBtn);
            Controls.Add(DNITxt);
            Controls.Add(DNILbl);
            Controls.Add(ApellidoLbl);
            Controls.Add(NombreLbl);
            Controls.Add(PuestoLbl);
            Controls.Add(PuestoCmbBox);
            Name = "CrearPersonal";
            Text = "Crear Personal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox PuestoCmbBox;
        private Label PuestoLbl;
        private Label NombreLbl;
        private Label ApellidoLbl;
        private Label DNILbl;
        private TextBox DNITxt;
        private Button AtrasBtn;
        private Button CrearPersonalBtn;
        private TextBox NombreTxt;
        private TextBox ApellidoTxt;
        private TextBox ContraseñaTbx;
        private Label ContraseñaLbl;
        private TextBox UsuarioTxb;
        private Label UsuarioLbl;
    }
}