namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImprimirNombre = new Button();
            label1 = new Label();
            tbNombre = new TextBox();
            tbInvitaciones = new TextBox();
            SuspendLayout();
            // 
            // btnImprimirNombre
            // 
            btnImprimirNombre.Location = new Point(244, 25);
            btnImprimirNombre.Margin = new Padding(4);
            btnImprimirNombre.Name = "btnImprimirNombre";
            btnImprimirNombre.Size = new Size(96, 59);
            btnImprimirNombre.TabIndex = 8;
            btnImprimirNombre.Text = "Imprimir Nombre";
            btnImprimirNombre.UseVisualStyleBackColor = true;
            btnImprimirNombre.Click += btnImprimirNombre_Click;
            // 
            // label1
            // 
            label1.Location = new Point(19, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 46);
            label1.TabIndex = 7;
            label1.Text = "Nombre del Invitado:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(122, 34);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(115, 29);
            tbNombre.TabIndex = 10;
            // 
            // tbInvitaciones
            // 
            tbInvitaciones.Location = new Point(19, 105);
            tbInvitaciones.Multiline = true;
            tbInvitaciones.Name = "tbInvitaciones";
            tbInvitaciones.Size = new Size(252, 107);
            tbInvitaciones.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 224);
            Controls.Add(tbInvitaciones);
            Controls.Add(tbNombre);
            Controls.Add(btnImprimirNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invitaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimirNombre;
        private Label label1;
        private TextBox tbNombre;
        private TextBox tbInvitaciones;
    }
}
