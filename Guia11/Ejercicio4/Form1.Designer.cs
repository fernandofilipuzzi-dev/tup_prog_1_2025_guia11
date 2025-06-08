namespace Ejercicio4
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
            nudHora = new NumericUpDown();
            nudMinuto = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConvertir = new Button();
            lbMinutos = new Label();
            ((System.ComponentModel.ISupportInitialize)nudHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).BeginInit();
            SuspendLayout();
            // 
            // nudHora
            // 
            nudHora.Location = new Point(196, 16);
            nudHora.Margin = new Padding(4);
            nudHora.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
            nudHora.Name = "nudHora";
            nudHora.Size = new Size(62, 29);
            nudHora.TabIndex = 0;
            // 
            // nudMinuto
            // 
            nudMinuto.Location = new Point(287, 16);
            nudMinuto.Margin = new Padding(4);
            nudMinuto.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinuto.Name = "nudMinuto";
            nudMinuto.Size = new Size(62, 29);
            nudMinuto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 2;
            label1.Text = "Tiempo en H:M";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 3;
            label2.Text = "Tiempo en minutos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 19);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(13, 21);
            label3.TabIndex = 4;
            label3.Text = ":";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(377, 29);
            btnConvertir.Margin = new Padding(4);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(91, 63);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lbMinutos
            // 
            lbMinutos.AutoSize = true;
            lbMinutos.BackColor = SystemColors.ActiveCaption;
            lbMinutos.Location = new Point(196, 82);
            lbMinutos.Margin = new Padding(4, 0, 4, 0);
            lbMinutos.Name = "lbMinutos";
            lbMinutos.Size = new Size(80, 21);
            lbMinutos.TabIndex = 6;
            lbMinutos.Text = "lbMinutos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 127);
            Controls.Add(lbMinutos);
            Controls.Add(btnConvertir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudMinuto);
            Controls.Add(nudHora);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convertir de Horas:Minutos a Minutos";
            ((System.ComponentModel.ISupportInitialize)nudHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudHora;
        private NumericUpDown nudMinuto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConvertir;
        private Label lbMinutos;
    }
}
