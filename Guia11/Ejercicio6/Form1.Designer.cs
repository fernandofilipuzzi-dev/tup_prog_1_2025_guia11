namespace Ejercicio6
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
            chbOpcion1 = new CheckBox();
            chbOpcion2 = new CheckBox();
            chbOpcion3 = new CheckBox();
            btnResponder = new Button();
            label1 = new Label();
            label2 = new Label();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // chbOpcion1
            // 
            chbOpcion1.AutoSize = true;
            chbOpcion1.Location = new Point(29, 48);
            chbOpcion1.Margin = new Padding(4);
            chbOpcion1.Name = "chbOpcion1";
            chbOpcion1.Size = new Size(240, 25);
            chbOpcion1.TabIndex = 0;
            chbOpcion1.Text = "No siempre se debe inializarse";
            chbOpcion1.UseVisualStyleBackColor = true;
            // 
            // chbOpcion2
            // 
            chbOpcion2.AutoSize = true;
            chbOpcion2.Location = new Point(29, 81);
            chbOpcion2.Margin = new Padding(4);
            chbOpcion2.Name = "chbOpcion2";
            chbOpcion2.Size = new Size(196, 25);
            chbOpcion2.TabIndex = 1;
            chbOpcion2.Text = "Nunca debe inicializarse";
            chbOpcion2.UseVisualStyleBackColor = true;
            // 
            // chbOpcion3
            // 
            chbOpcion3.AutoSize = true;
            chbOpcion3.Location = new Point(29, 114);
            chbOpcion3.Margin = new Padding(4);
            chbOpcion3.Name = "chbOpcion3";
            chbOpcion3.Size = new Size(209, 25);
            chbOpcion3.TabIndex = 2;
            chbOpcion3.Text = "Siempre debe inicializarse";
            chbOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            btnResponder.Location = new Point(383, 63);
            btnResponder.Margin = new Padding(4);
            btnResponder.Name = "btnResponder";
            btnResponder.Size = new Size(126, 58);
            btnResponder.TabIndex = 3;
            btnResponder.Text = "Responder";
            btnResponder.UseVisualStyleBackColor = true;
            btnResponder.Click += btnResponder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 4;
            label1.Text = "Una variable local:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 159);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 5;
            label2.Text = "Resultado:";
            // 
            // lbResultado
            // 
            lbResultado.BackColor = SystemColors.ActiveCaption;
            lbResultado.Location = new Point(93, 159);
            lbResultado.Margin = new Padding(4, 0, 4, 0);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(416, 110);
            lbResultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 280);
            Controls.Add(lbResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnResponder);
            Controls.Add(chbOpcion3);
            Controls.Add(chbOpcion2);
            Controls.Add(chbOpcion1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Examen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbOpcion1;
        private CheckBox chbOpcion2;
        private CheckBox chbOpcion3;
        private Button btnResponder;
        private Label label1;
        private Label label2;
        private Label lbResultado;
    }
}
