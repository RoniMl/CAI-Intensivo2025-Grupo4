namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class GenerarReportes
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
            GenerarBtn = new Button();
            CarreraCmbBox = new ComboBox();
            CarreraLbl = new Label();
            SuspendLayout();
            // 
            // GenerarBtn
            // 
            GenerarBtn.Location = new Point(666, 383);
            GenerarBtn.Name = "GenerarBtn";
            GenerarBtn.Size = new Size(75, 23);
            GenerarBtn.TabIndex = 0;
            GenerarBtn.Text = "Generar";
            GenerarBtn.UseVisualStyleBackColor = true;
            // 
            // CarreraCmbBox
            // 
            CarreraCmbBox.FormattingEnabled = true;
            CarreraCmbBox.Location = new Point(211, 86);
            CarreraCmbBox.Name = "CarreraCmbBox";
            CarreraCmbBox.Size = new Size(206, 23);
            CarreraCmbBox.TabIndex = 1;
            // 
            // CarreraLbl
            // 
            CarreraLbl.AutoSize = true;
            CarreraLbl.Location = new Point(95, 89);
            CarreraLbl.Name = "CarreraLbl";
            CarreraLbl.Size = new Size(110, 15);
            CarreraLbl.TabIndex = 2;
            CarreraLbl.Text = "Seleccione Carrera..";
            // 
            // GenerarReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CarreraLbl);
            Controls.Add(CarreraCmbBox);
            Controls.Add(GenerarBtn);
            Name = "GenerarReportes";
            Text = "Generar Reportes";
            Load += GenerarReportes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerarBtn;
        private ComboBox CarreraCmbBox;
        private Label CarreraLbl;
    }
}