namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class InicioSesionForms
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
            UniversidadLbl = new Label();
            UsuarioTextBox = new TextBox();
            UsuarioLbl = new Label();
            ContraseñaLbl = new Label();
            ContraseñaTextBox = new TextBox();
            Ingresar = new Button();
            SuspendLayout();
            // 
            // UniversidadLbl
            // 
            UniversidadLbl.AutoSize = true;
            UniversidadLbl.Location = new Point(157, 56);
            UniversidadLbl.Name = "UniversidadLbl";
            UniversidadLbl.Size = new Size(103, 20);
            UniversidadLbl.TabIndex = 0;
            UniversidadLbl.Text = "Universidad ....";
            // 
            // UsuarioTextBox
            // 
            UsuarioTextBox.Location = new Point(138, 153);
            UsuarioTextBox.Margin = new Padding(3, 4, 3, 4);
            UsuarioTextBox.Name = "UsuarioTextBox";
            UsuarioTextBox.Size = new Size(167, 27);
            UsuarioTextBox.TabIndex = 1;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(138, 127);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(59, 20);
            UsuarioLbl.TabIndex = 2;
            UsuarioLbl.Text = "Usuario";
            // 
            // ContraseñaLbl
            // 
            ContraseñaLbl.AutoSize = true;
            ContraseñaLbl.Location = new Point(138, 231);
            ContraseñaLbl.Name = "ContraseñaLbl";
            ContraseñaLbl.Size = new Size(83, 20);
            ContraseñaLbl.TabIndex = 4;
            ContraseñaLbl.Text = "Contraseña";
            // 
            // ContraseñaTextBox
            // 
            ContraseñaTextBox.Location = new Point(138, 257);
            ContraseñaTextBox.Margin = new Padding(3, 4, 3, 4);
            ContraseñaTextBox.Name = "ContraseñaTextBox";
            ContraseñaTextBox.Size = new Size(167, 27);
            ContraseñaTextBox.TabIndex = 3;
            // 
            // Ingresar
            // 
            Ingresar.Location = new Point(157, 339);
            Ingresar.Margin = new Padding(3, 4, 3, 4);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(117, 37);
            Ingresar.TabIndex = 5;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += Ingresar_Click;
            // 
            // InicioSesionForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 481);
            Controls.Add(Ingresar);
            Controls.Add(ContraseñaLbl);
            Controls.Add(ContraseñaTextBox);
            Controls.Add(UsuarioLbl);
            Controls.Add(UsuarioTextBox);
            Controls.Add(UniversidadLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InicioSesionForms";
            Text = "Inicio de sesion";
            Load += InicioSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UniversidadLbl;
        private TextBox UsuarioTextBox;
        private Label UsuarioLbl;
        private Label ContraseñaLbl;
        private TextBox ContraseñaTextBox;
        private Button Ingresar;
    }
}