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
            Atrasbtn = new Button();
            SuspendLayout();
            // 
            // GenerarReporteLbl
            // 
            GenerarReporteLbl.AutoSize = true;
            GenerarReporteLbl.Location = new Point(46, 27);
            GenerarReporteLbl.Name = "GenerarReporteLbl";
            GenerarReporteLbl.Size = new Size(168, 20);
            GenerarReporteLbl.TabIndex = 1;
            GenerarReporteLbl.Text = "Generacion de Reportes";
            // 
            // reporteListView
            // 
            reporteListView.Columns.AddRange(new ColumnHeader[] { carreraListView, cumLaudeListview, magnaCumLaudeListView, summaCumLaudeListView, totalListView });
            reporteListView.Location = new Point(46, 53);
            reporteListView.Margin = new Padding(3, 4, 3, 4);
            reporteListView.Name = "reporteListView";
            reporteListView.Size = new Size(860, 268);
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
            generarBtn.Location = new Point(749, 331);
            generarBtn.Margin = new Padding(3, 4, 3, 4);
            generarBtn.Name = "generarBtn";
            generarBtn.Size = new Size(158, 40);
            generarBtn.TabIndex = 3;
            generarBtn.Text = "Generar reportes";
            generarBtn.UseVisualStyleBackColor = true;
            generarBtn.Click += generarBtn_Click;
            // 
            // Atrasbtn
            // 
            Atrasbtn.Location = new Point(46, 331);
            Atrasbtn.Name = "Atrasbtn";
            Atrasbtn.Size = new Size(111, 38);
            Atrasbtn.TabIndex = 4;
            Atrasbtn.Text = "Atrás";
            Atrasbtn.UseVisualStyleBackColor = true;
            Atrasbtn.Click += Atrasbtn_Click;
            // 
            // GenerarReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 425);
            Controls.Add(Atrasbtn);
            Controls.Add(generarBtn);
            Controls.Add(reporteListView);
            Controls.Add(GenerarReporteLbl);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button Atrasbtn;
    }
}