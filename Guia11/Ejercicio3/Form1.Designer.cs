namespace Ejercicio3
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
            tbNombre = new TextBox();
            btnImprimirNombre = new Button();
            label1 = new Label();
            lsbInvitaciones = new ListBox();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(133, 25);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(115, 29);
            tbNombre.TabIndex = 14;
            // 
            // btnImprimirNombre
            // 
            btnImprimirNombre.Location = new Point(255, 9);
            btnImprimirNombre.Margin = new Padding(4);
            btnImprimirNombre.Name = "btnImprimirNombre";
            btnImprimirNombre.Size = new Size(108, 59);
            btnImprimirNombre.TabIndex = 13;
            btnImprimirNombre.Text = "Imprimir Nombre";
            btnImprimirNombre.UseVisualStyleBackColor = true;
            btnImprimirNombre.Click += btnImprimirNombre_Click;
            // 
            // label1
            // 
            label1.Location = new Point(30, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 46);
            label1.TabIndex = 12;
            label1.Text = "Nombre del Invitado:";
            // 
            // lsbInvitaciones
            // 
            lsbInvitaciones.FormattingEnabled = true;
            lsbInvitaciones.ItemHeight = 21;
            lsbInvitaciones.Location = new Point(12, 80);
            lsbInvitaciones.Name = "lsbInvitaciones";
            lsbInvitaciones.Size = new Size(352, 109);
            lsbInvitaciones.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 200);
            Controls.Add(lsbInvitaciones);
            Controls.Add(tbNombre);
            Controls.Add(btnImprimirNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Invitaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private Button btnImprimirNombre;
        private Label label1;
        private ListBox lsbInvitaciones;
    }
}
