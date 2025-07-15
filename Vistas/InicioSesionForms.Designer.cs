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
            UniversidadLbl.Location = new Point(137, 42);
            UniversidadLbl.Name = "UniversidadLbl";
            UniversidadLbl.Size = new Size(93, 17);
            UniversidadLbl.TabIndex = 0;
            UniversidadLbl.Text = "Universidad ....";
            // 
            // UsuarioTextBox
            // 
            UsuarioTextBox.Location = new Point(121, 115);
            UsuarioTextBox.Name = "UsuarioTextBox";
            UsuarioTextBox.Size = new Size(147, 23);
            UsuarioTextBox.TabIndex = 1;
            // 
            // UsuarioLbl
            // 
            UsuarioLbl.AutoSize = true;
            UsuarioLbl.Location = new Point(121, 95);
            UsuarioLbl.Name = "UsuarioLbl";
            UsuarioLbl.Size = new Size(53, 17);
            UsuarioLbl.TabIndex = 2;
            UsuarioLbl.Text = "Usuario";
            // 
            // ContraseñaLbl
            // 
            ContraseñaLbl.AutoSize = true;
            ContraseñaLbl.Location = new Point(121, 173);
            ContraseñaLbl.Name = "ContraseñaLbl";
            ContraseñaLbl.Size = new Size(74, 17);
            ContraseñaLbl.TabIndex = 4;
            ContraseñaLbl.Text = "Contraseña";
            // 
            // ContraseñaTextBox
            // 
            ContraseñaTextBox.Location = new Point(121, 193);
            ContraseñaTextBox.Name = "ContraseñaTextBox";
            ContraseñaTextBox.Size = new Size(147, 23);
            ContraseñaTextBox.TabIndex = 3;
            // 
            // Ingresar
            // 
            Ingresar.Location = new Point(137, 254);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(102, 28);
            Ingresar.TabIndex = 5;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += Ingresar_Click;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(Ingresar);
            Controls.Add(ContraseñaLbl);
            Controls.Add(ContraseñaTextBox);
            Controls.Add(UsuarioLbl);
            Controls.Add(UsuarioTextBox);
            Controls.Add(UniversidadLbl);
            Name = "InicioSesion";
            Text = "Form1";
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