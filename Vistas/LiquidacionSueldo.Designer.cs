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
            liquidacionList = new ListView();
            nombreCol = new ColumnHeader();
            apellidoCol = new ColumnHeader();
            cuitCol = new ColumnHeader();
            horasCol = new ColumnHeader();
            totalCol = new ColumnHeader();
            LiquidacionLabel = new Label();
            AtrasBtn = new Button();
            SuspendLayout();
            // 
            // liquidacionList
            // 
            liquidacionList.CheckBoxes = true;
            liquidacionList.Columns.AddRange(new ColumnHeader[] { nombreCol, apellidoCol, cuitCol, horasCol, totalCol });
            liquidacionList.FullRowSelect = true;
            liquidacionList.Location = new Point(14, 49);
            liquidacionList.Margin = new Padding(3, 4, 3, 4);
            liquidacionList.Name = "liquidacionList";
            liquidacionList.Size = new Size(747, 232);
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
            LiquidacionLabel.Location = new Point(14, 23);
            LiquidacionLabel.Name = "LiquidacionLabel";
            LiquidacionLabel.Size = new Size(155, 20);
            LiquidacionLabel.TabIndex = 2;
            LiquidacionLabel.Text = "Liquidacion de sueldo";
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(14, 291);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(90, 37);
            AtrasBtn.TabIndex = 3;
            AtrasBtn.Text = "Atrás";
            AtrasBtn.UseVisualStyleBackColor = true;
            AtrasBtn.Click += AtrasBtn_Click;
            // 
            // LiquidacionSueldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 348);
            Controls.Add(AtrasBtn);
            Controls.Add(LiquidacionLabel);
            Controls.Add(liquidacionList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LiquidacionSueldo";
            Text = "Liquidacion de Sueldo";
            Load += LiquidacionSueldo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView liquidacionList;
        private ColumnHeader nombreCol;
        private ColumnHeader apellidoCol;
        private ColumnHeader cuitCol;
        private ColumnHeader horasCol;
        private ColumnHeader totalCol;
        private Label LiquidacionLabel;
        private Button AtrasBtn;
    }
}