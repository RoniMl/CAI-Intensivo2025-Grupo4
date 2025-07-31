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
            GenerarReporteLbl = new Label();
            reporteListView = new ListView();
            carreraListView = new ColumnHeader();
            cumLaudeListview = new ColumnHeader();
            magnaCumLaudeListView = new ColumnHeader();
            summaCumLaudeListView = new ColumnHeader();
            totalListView = new ColumnHeader();
            generarBtn = new Button();
            SuspendLayout();
            // 
            // GenerarReporteLbl
            // 
            GenerarReporteLbl.AutoSize = true;
            GenerarReporteLbl.Location = new Point(40, 20);
            GenerarReporteLbl.Name = "GenerarReporteLbl";
            GenerarReporteLbl.Size = new Size(150, 17);
            GenerarReporteLbl.TabIndex = 1;
            GenerarReporteLbl.Text = "Generacion de Reportes";
            // 
            // reporteListView
            // 
            reporteListView.Columns.AddRange(new ColumnHeader[] { carreraListView, cumLaudeListview, magnaCumLaudeListView, summaCumLaudeListView, totalListView });
            reporteListView.Location = new Point(40, 40);
            reporteListView.Name = "reporteListView";
            reporteListView.Size = new Size(753, 202);
            reporteListView.TabIndex = 2;
            reporteListView.UseCompatibleStateImageBehavior = false;
            reporteListView.View = View.Details;
            // 
            // carreraListView
            // 
            carreraListView.Text = "Carrera";
            carreraListView.Width = 150;
            // 
            // cumLaudeListview
            // 
            cumLaudeListview.Text = "Cum Laude";
            cumLaudeListview.Width = 150;
            // 
            // magnaCumLaudeListView
            // 
            magnaCumLaudeListView.Text = "Magna Cum Laude";
            magnaCumLaudeListView.Width = 150;
            // 
            // summaCumLaudeListView
            // 
            summaCumLaudeListView.Text = "Summa Cum Laude";
            summaCumLaudeListView.Width = 150;
            // 
            // totalListView
            // 
            totalListView.Text = "Total";
            totalListView.Width = 150;
            // 
            // generarBtn
            // 
            generarBtn.Location = new Point(655, 248);
            generarBtn.Name = "generarBtn";
            generarBtn.Size = new Size(138, 30);
            generarBtn.TabIndex = 3;
            generarBtn.Text = "Generar reportes";
            generarBtn.UseVisualStyleBackColor = true;
            generarBtn.Click += generarBtn_Click;
            // 
            // GenerarReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 319);
            Controls.Add(generarBtn);
            Controls.Add(reporteListView);
            Controls.Add(GenerarReporteLbl);
            Name = "GenerarReportes";
            Text = "Generar Reportes";
            Load += GenerarReportes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label GenerarReporteLbl;
        private ListView reporteListView;
        private ColumnHeader carreraListView;
        private ColumnHeader cumLaudeListview;
        private ColumnHeader magnaCumLaudeListView;
        private ColumnHeader summaCumLaudeListView;
        private ColumnHeader totalListView;
        private Button generarBtn;
    }
}