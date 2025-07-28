namespace CAI_Intensivo2025_Grupo4.Vistas
{
    partial class LiquidacionSueldo
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
            CalcularBtn = new Button();
            liquidacionList = new ListView();
            nombreCol = new ColumnHeader();
            apellidoCol = new ColumnHeader();
            cuitCol = new ColumnHeader();
            horasCol = new ColumnHeader();
            totalCol = new ColumnHeader();
            LiquidacionLabel = new Label();
            SuspendLayout();
            // 
            // CalcularBtn
            // 
            CalcularBtn.Location = new Point(568, 218);
            CalcularBtn.Name = "CalcularBtn";
            CalcularBtn.Size = new Size(98, 31);
            CalcularBtn.TabIndex = 0;
            CalcularBtn.Text = "Calcular";
            CalcularBtn.UseVisualStyleBackColor = true;
            // 
            // liquidacionList
            // 
            liquidacionList.CheckBoxes = true;
            liquidacionList.Columns.AddRange(new ColumnHeader[] { nombreCol, apellidoCol, cuitCol, horasCol, totalCol });
            liquidacionList.FullRowSelect = true;
            liquidacionList.Location = new Point(12, 37);
            liquidacionList.Name = "liquidacionList";
            liquidacionList.Size = new Size(654, 175);
            liquidacionList.TabIndex = 1;
            liquidacionList.UseCompatibleStateImageBehavior = false;
            liquidacionList.View = View.Details;
            // 
            // nombreCol
            // 
            nombreCol.Text = "Nombre";
            nombreCol.Width = 120;
            // 
            // apellidoCol
            // 
            apellidoCol.Text = "Apellido";
            apellidoCol.Width = 120;
            // 
            // cuitCol
            // 
            cuitCol.Text = "CUIT";
            cuitCol.Width = 120;
            // 
            // horasCol
            // 
            horasCol.Text = "Horas";
            // 
            // totalCol
            // 
            totalCol.Text = "Total a cobrar";
            totalCol.Width = 200;
            // 
            // LiquidacionLabel
            // 
            LiquidacionLabel.AutoSize = true;
            LiquidacionLabel.Location = new Point(12, 17);
            LiquidacionLabel.Name = "LiquidacionLabel";
            LiquidacionLabel.Size = new Size(136, 17);
            LiquidacionLabel.TabIndex = 2;
            LiquidacionLabel.Text = "Liquidacion de sueldo";
            // 
            // LiquidacionSueldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 261);
            Controls.Add(LiquidacionLabel);
            Controls.Add(liquidacionList);
            Controls.Add(CalcularBtn);
            Name = "LiquidacionSueldo";
            Text = "Liquidacion de Sueldo";
            Load += LiquidacionSueldo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalcularBtn;
        private ListView liquidacionList;
        private ColumnHeader nombreCol;
        private ColumnHeader apellidoCol;
        private ColumnHeader cuitCol;
        private ColumnHeader horasCol;
        private ColumnHeader totalCol;
        private Label LiquidacionLabel;
    }
}