namespace Vistas
{
    partial class MenuPersonal
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
            LiquidarBtn = new Button();
            SuspendLayout();
            // 
            // LiquidarBtn
            // 
            LiquidarBtn.Location = new Point(149, 75);
            LiquidarBtn.Name = "LiquidarBtn";
            LiquidarBtn.Size = new Size(197, 46);
            LiquidarBtn.TabIndex = 0;
            LiquidarBtn.Text = "Liquidar sueldo";
            LiquidarBtn.UseVisualStyleBackColor = true;
            // 
            // MenuPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 380);
            Controls.Add(LiquidarBtn);
            Name = "MenuPersonal";
            Text = "Menu de Personal";
            ResumeLayout(false);
        }

        #endregion

        private Button LiquidarBtn;
    }
}