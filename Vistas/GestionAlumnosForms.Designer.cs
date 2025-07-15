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
            textBox1 = new TextBox();
            AlumnosListView = new ListView();
            AlumnosLbl = new Label();
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            DniCol = new ColumnHeader();
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
            // textBox1
            // 
            textBox1.Location = new Point(162, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 1;
            // 
            // AlumnosListView
            // 
            AlumnosListView.Columns.AddRange(new ColumnHeader[] { NombreCol, ApellidoCol, DniCol });
            AlumnosListView.Location = new Point(12, 93);
            AlumnosListView.Name = "AlumnosListView";
            AlumnosListView.Size = new Size(778, 226);
            AlumnosListView.TabIndex = 2;
            AlumnosListView.UseCompatibleStateImageBehavior = false;
            AlumnosListView.SelectedIndexChanged += this.AlumnosListView_SelectedIndexChanged;
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
            // GestionAlumnosForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(AlumnosLbl);
            Controls.Add(AlumnosListView);
            Controls.Add(textBox1);
            Controls.Add(BuscarAlumnoLbl);
            Name = "GestionAlumnosForms";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BuscarAlumnoLbl;
        private TextBox textBox1;
        private ListView AlumnosListView;
        private Label AlumnosLbl;
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader DniCol;
    }
}