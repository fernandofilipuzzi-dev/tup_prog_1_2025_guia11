namespace Ejercicio1
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
            lbNumero = new Label();
            btnGenerar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.BackColor = SystemColors.ActiveCaption;
            lbNumero.Location = new Point(117, 20);
            lbNumero.Margin = new Padding(4, 0, 4, 0);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(81, 21);
            lbNumero.TabIndex = 6;
            lbNumero.Text = "lbNumero";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(238, 14);
            btnGenerar.Margin = new Padding(4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(96, 32);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 46);
            label1.TabIndex = 4;
            label1.Text = "Número Generado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 66);
            Controls.Add(lbNumero);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Numero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumero;
        private Button btnGenerar;
        private Label label1;
    }
}
