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
            AtrasBtn = new Button();
            SuspendLayout();
            // 
            // DesbloquearLbl
            // 
            DesbloquearLbl.AutoSize = true;
            DesbloquearLbl.Location = new Point(38, 86);
            DesbloquearLbl.Name = "DesbloquearLbl";
            DesbloquearLbl.Size = new Size(266, 20);
            DesbloquearLbl.TabIndex = 0;
            DesbloquearLbl.Text = "Ingrese el Id del usuario a desbloquear";
            // 
            // DesbloquearBtn
            // 
            DesbloquearBtn.Location = new Point(312, 110);
            DesbloquearBtn.Margin = new Padding(3, 4, 3, 4);
            DesbloquearBtn.Name = "DesbloquearBtn";
            DesbloquearBtn.Size = new Size(112, 33);
            DesbloquearBtn.TabIndex = 1;
            DesbloquearBtn.Text = "Desbloquear";
            DesbloquearBtn.UseVisualStyleBackColor = true;
            DesbloquearBtn.Click += DesbloquearBtn_Click;
            // 
            // DesbloquearTextBox
            // 
            DesbloquearTextBox.Location = new Point(38, 112);
            DesbloquearTextBox.Margin = new Padding(3, 4, 3, 4);
            DesbloquearTextBox.Name = "DesbloquearTextBox";
            DesbloquearTextBox.Size = new Size(267, 27);
            DesbloquearTextBox.TabIndex = 2;
            // 
            // AtrasBtn
            // 
            AtrasBtn.Location = new Point(38, 215);
            AtrasBtn.Name = "AtrasBtn";
            AtrasBtn.Size = new Size(86, 34);
            AtrasBtn.TabIndex = 3;
            AtrasBtn.Text = "Atrás";
            AtrasBtn.UseVisualStyleBackColor = true;
            AtrasBtn.Click += AtrasBtn_Click;
            // 
            // GestionDesbloqueo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 270);
            Controls.Add(AtrasBtn);
            Controls.Add(DesbloquearTextBox);
            Controls.Add(DesbloquearBtn);
            Controls.Add(DesbloquearLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionDesbloqueo";
            Text = "Gestion de desbloqueos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DesbloquearLbl;
        private Button DesbloquearBtn;
        private TextBox DesbloquearTextBox;
        private Button AtrasBtn;
    }
}