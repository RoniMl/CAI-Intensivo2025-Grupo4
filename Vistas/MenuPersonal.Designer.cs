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
            LiquidarBtn.Location = new Point(213, 125);
            LiquidarBtn.Margin = new Padding(4, 5, 4, 5);
            LiquidarBtn.Name = "LiquidarBtn";
            LiquidarBtn.Size = new Size(281, 77);
            LiquidarBtn.TabIndex = 0;
            LiquidarBtn.Text = "Liquidar sueldo";
            LiquidarBtn.UseVisualStyleBackColor = true;
            // 
            // cerrarSesion
            // 
            cerrarSesion.Location = new Point(589, 254);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(149, 46);
            cerrarSesion.TabIndex = 3;
            cerrarSesion.Text = "Cerrar Sesion";
            cerrarSesion.UseVisualStyleBackColor = true;
            // 
            // MenuPersonal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 312);
            Controls.Add(cerrarSesion);
            Controls.Add(LiquidarBtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuPersonal";
            Text = "Menu de Personal";
            ResumeLayout(false);
        }

        #endregion

        private Button LiquidarBtn;
        private Button cerrarSesion;
    }
}