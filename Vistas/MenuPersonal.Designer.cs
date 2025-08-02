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
            cerrarSesion = new Button();
            SuspendLayout();
            // 
            // LiquidarBtn
            // 
            LiquidarBtn.Location = new Point(170, 100);
            LiquidarBtn.Margin = new Padding(3, 4, 3, 4);
            LiquidarBtn.Name = "LiquidarBtn";
            LiquidarBtn.Size = new Size(225, 62);
            LiquidarBtn.TabIndex = 0;
            LiquidarBtn.Text = "Liquidar sueldo";
            LiquidarBtn.UseVisualStyleBackColor = true;
            // 
            // cerrarSesion
            // 
            cerrarSesion.Location = new Point(11, 235);
            cerrarSesion.Margin = new Padding(2, 2, 2, 2);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(119, 37);
            cerrarSesion.TabIndex = 3;
            cerrarSesion.Text = "Cerrar Sesion";
            cerrarSesion.UseVisualStyleBackColor = true;
            cerrarSesion.Click += cerrarSesion_Click;
            // 
            // MenuPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 283);
            Controls.Add(cerrarSesion);
            Controls.Add(LiquidarBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPersonal";
            Text = "Menu de Personal";
            ResumeLayout(false);
        }

        #endregion

        private Button LiquidarBtn;
        private Button cerrarSesion;
    }
}