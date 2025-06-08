namespace Ejercicio5
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
            rbExcelente = new RadioButton();
            rbBueno = new RadioButton();
            rbInsuficiente = new RadioButton();
            btnVotar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbTotal = new Label();
            lbExcelentes = new Label();
            lbBuenos = new Label();
            lbInsuficientes = new Label();
            SuspendLayout();
            // 
            // rbExcelente
            // 
            rbExcelente.AutoSize = true;
            rbExcelente.Location = new Point(63, 30);
            rbExcelente.Margin = new Padding(4);
            rbExcelente.Name = "rbExcelente";
            rbExcelente.Size = new Size(92, 25);
            rbExcelente.TabIndex = 0;
            rbExcelente.TabStop = true;
            rbExcelente.Text = "Excelente";
            rbExcelente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            rbBueno.AutoSize = true;
            rbBueno.Location = new Point(63, 65);
            rbBueno.Margin = new Padding(4);
            rbBueno.Name = "rbBueno";
            rbBueno.Size = new Size(72, 25);
            rbBueno.TabIndex = 1;
            rbBueno.TabStop = true;
            rbBueno.Text = "Bueno";
            rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbInsuficiente
            // 
            rbInsuficiente.AutoSize = true;
            rbInsuficiente.Location = new Point(63, 100);
            rbInsuficiente.Margin = new Padding(4);
            rbInsuficiente.Name = "rbInsuficiente";
            rbInsuficiente.Size = new Size(107, 25);
            rbInsuficiente.TabIndex = 2;
            rbInsuficiente.TabStop = true;
            rbInsuficiente.Text = "Insuficiente";
            rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(247, 53);
            btnVotar.Margin = new Padding(4);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(96, 48);
            btnVotar.TabIndex = 3;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 157);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 4;
            label1.Text = "Cantidad de Votaciones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 195);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 5;
            label2.Text = "Excelentes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 234);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 6;
            label3.Text = "Buenos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 278);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 7;
            label4.Text = "Insuficientes:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = SystemColors.ActiveCaption;
            lbTotal.Location = new Point(296, 157);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(18, 21);
            lbTotal.TabIndex = 8;
            lbTotal.Text = "  ";
            // 
            // lbExcelentes
            // 
            lbExcelentes.AutoSize = true;
            lbExcelentes.BackColor = SystemColors.ActiveCaption;
            lbExcelentes.Location = new Point(296, 195);
            lbExcelentes.Name = "lbExcelentes";
            lbExcelentes.Size = new Size(18, 21);
            lbExcelentes.TabIndex = 9;
            lbExcelentes.Text = "  ";
            // 
            // lbBuenos
            // 
            lbBuenos.AutoSize = true;
            lbBuenos.BackColor = SystemColors.ActiveCaption;
            lbBuenos.Location = new Point(296, 234);
            lbBuenos.Name = "lbBuenos";
            lbBuenos.Size = new Size(18, 21);
            lbBuenos.TabIndex = 10;
            lbBuenos.Text = "  ";
            // 
            // lbInsuficientes
            // 
            lbInsuficientes.AutoSize = true;
            lbInsuficientes.BackColor = SystemColors.ActiveCaption;
            lbInsuficientes.Location = new Point(296, 278);
            lbInsuficientes.Name = "lbInsuficientes";
            lbInsuficientes.Size = new Size(18, 21);
            lbInsuficientes.TabIndex = 11;
            lbInsuficientes.Text = "  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 325);
            Controls.Add(lbInsuficientes);
            Controls.Add(lbBuenos);
            Controls.Add(lbExcelentes);
            Controls.Add(lbTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVotar);
            Controls.Add(rbInsuficiente);
            Controls.Add(rbBueno);
            Controls.Add(rbExcelente);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Encuesta de servicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbExcelente;
        private RadioButton rbBueno;
        private RadioButton rbInsuficiente;
        private Button btnVotar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbTotal;
        private Label lbExcelentes;
        private Label lbBuenos;
        private Label lbInsuficientes;
    }
}
