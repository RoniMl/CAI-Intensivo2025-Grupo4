namespace Vistas
{
    partial class GestionDesbloqueo
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
            DesbloquearLbl = new Label();
            DesbloquearBtn = new Button();
            DesbloquearTextBox = new TextBox();
            SuspendLayout();
            // 
            // DesbloquearLbl
            // 
            DesbloquearLbl.AutoSize = true;
            DesbloquearLbl.Location = new Point(12, 86);
            DesbloquearLbl.Name = "DesbloquearLbl";
            DesbloquearLbl.Size = new Size(238, 17);
            DesbloquearLbl.TabIndex = 0;
            DesbloquearLbl.Text = "Ingrese el Id del usuario a desbloquear";
            // 
            // DesbloquearBtn
            // 
            DesbloquearBtn.Location = new Point(252, 104);
            DesbloquearBtn.Name = "DesbloquearBtn";
            DesbloquearBtn.Size = new Size(98, 25);
            DesbloquearBtn.TabIndex = 1;
            DesbloquearBtn.Text = "Desboquear";
            DesbloquearBtn.UseVisualStyleBackColor = true;
            //DesbloquearBtn.Click += this.DesbloquearBtn_Click;
            // 
            // DesbloquearTextBox
            // 
            DesbloquearTextBox.Location = new Point(12, 106);
            DesbloquearTextBox.Name = "DesbloquearTextBox";
            DesbloquearTextBox.Size = new Size(234, 23);
            DesbloquearTextBox.TabIndex = 2;
            // 
            // GestionDesbloqueo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 180);
            Controls.Add(DesbloquearTextBox);
            Controls.Add(DesbloquearBtn);
            Controls.Add(DesbloquearLbl);
            Name = "GestionDesbloqueo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DesbloquearLbl;
        private Button DesbloquearBtn;
        private TextBox DesbloquearTextBox;
    }
}