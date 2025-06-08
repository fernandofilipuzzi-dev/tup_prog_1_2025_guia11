namespace Ejercicio7
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
            lbInsuficientes = new Label();
            lbBuenos = new Label();
            lbExcelentes = new Label();
            lbTotal = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVotar = new Button();
            rbInsuficiente = new RadioButton();
            rbBueno = new RadioButton();
            rbExcelente = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbBase = new RadioButton();
            rbFULL = new RadioButton();
            groupBox3 = new GroupBox();
            label5 = new Label();
            lbFULL = new Label();
            label6 = new Label();
            lbBase = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lbInsuficientes
            // 
            lbInsuficientes.BackColor = SystemColors.ActiveCaption;
            lbInsuficientes.Location = new Point(222, 156);
            lbInsuficientes.Name = "lbInsuficientes";
            lbInsuficientes.Size = new Size(87, 21);
            lbInsuficientes.TabIndex = 23;
            lbInsuficientes.Text = "  ";
            // 
            // lbBuenos
            // 
            lbBuenos.BackColor = SystemColors.ActiveCaption;
            lbBuenos.Location = new Point(222, 112);
            lbBuenos.Name = "lbBuenos";
            lbBuenos.Size = new Size(87, 21);
            lbBuenos.TabIndex = 22;
            lbBuenos.Text = "  ";
            // 
            // lbExcelentes
            // 
            lbExcelentes.BackColor = SystemColors.ActiveCaption;
            lbExcelentes.Location = new Point(222, 73);
            lbExcelentes.Name = "lbExcelentes";
            lbExcelentes.Size = new Size(87, 21);
            lbExcelentes.TabIndex = 21;
            lbExcelentes.Text = "  ";
            // 
            // lbTotal
            // 
            lbTotal.BackColor = SystemColors.ActiveCaption;
            lbTotal.Location = new Point(222, 35);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(87, 21);
            lbTotal.TabIndex = 20;
            lbTotal.Text = "  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 156);
            label4.Name = "label4";
            label4.Size = new Size(186, 21);
            label4.TabIndex = 19;
            label4.Text = "Cantidad de Insuficientes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 112);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 18;
            label3.Text = "Cantidad de Buenos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 73);
            label2.Name = "label2";
            label2.Size = new Size(171, 21);
            label2.TabIndex = 17;
            label2.Text = "Cantidad de Excelentes:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 16;
            label1.Text = "Cantidad de Votaciones:";
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(206, 112);
            btnVotar.Margin = new Padding(4);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(96, 48);
            btnVotar.TabIndex = 15;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // rbInsuficiente
            // 
            rbInsuficiente.AutoSize = true;
            rbInsuficiente.Location = new Point(24, 109);
            rbInsuficiente.Margin = new Padding(4);
            rbInsuficiente.Name = "rbInsuficiente";
            rbInsuficiente.Size = new Size(107, 25);
            rbInsuficiente.TabIndex = 14;
            rbInsuficiente.TabStop = true;
            rbInsuficiente.Text = "Insuficiente";
            rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            rbBueno.AutoSize = true;
            rbBueno.Location = new Point(24, 74);
            rbBueno.Margin = new Padding(4);
            rbBueno.Name = "rbBueno";
            rbBueno.Size = new Size(72, 25);
            rbBueno.TabIndex = 13;
            rbBueno.TabStop = true;
            rbBueno.Text = "Bueno";
            rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbExcelente
            // 
            rbExcelente.AutoSize = true;
            rbExcelente.Location = new Point(24, 39);
            rbExcelente.Margin = new Padding(4);
            rbExcelente.Name = "rbExcelente";
            rbExcelente.Size = new Size(92, 25);
            rbExcelente.TabIndex = 12;
            rbExcelente.TabStop = true;
            rbExcelente.Text = "Excelente";
            rbExcelente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbExcelente);
            groupBox1.Controls.Add(rbBueno);
            groupBox1.Controls.Add(rbInsuficiente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 148);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opinión";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbBase);
            groupBox2.Controls.Add(rbFULL);
            groupBox2.Location = new Point(12, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 113);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Producto";
            // 
            // rbBase
            // 
            rbBase.AutoSize = true;
            rbBase.Location = new Point(24, 39);
            rbBase.Margin = new Padding(4);
            rbBase.Name = "rbBase";
            rbBase.Size = new Size(60, 25);
            rbBase.TabIndex = 12;
            rbBase.TabStop = true;
            rbBase.Text = "Base";
            rbBase.UseVisualStyleBackColor = true;
            // 
            // rbFULL
            // 
            rbFULL.AutoSize = true;
            rbFULL.Location = new Point(24, 74);
            rbFULL.Margin = new Padding(4);
            rbFULL.Name = "rbFULL";
            rbFULL.Size = new Size(63, 25);
            rbFULL.TabIndex = 13;
            rbFULL.TabStop = true;
            rbFULL.Text = "FULL";
            rbFULL.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lbFULL);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(lbBase);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lbInsuficientes);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(lbBuenos);
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Controls.Add(lbExcelentes);
            groupBox3.Location = new Point(12, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 288);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados de la encuesta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 201);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 24;
            label5.Text = "Cantidad de Base:";
            // 
            // lbFULL
            // 
            lbFULL.BackColor = SystemColors.ActiveCaption;
            lbFULL.Location = new Point(222, 245);
            lbFULL.Name = "lbFULL";
            lbFULL.Size = new Size(87, 21);
            lbFULL.TabIndex = 27;
            lbFULL.Text = "  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 245);
            label6.Name = "label6";
            label6.Size = new Size(186, 21);
            label6.TabIndex = 25;
            label6.Text = "Cantidad de Insuficientes:";
            // 
            // lbBase
            // 
            lbBase.BackColor = SystemColors.ActiveCaption;
            lbBase.Location = new Point(222, 201);
            lbBase.Name = "lbBase";
            lbBase.Size = new Size(87, 21);
            lbBase.TabIndex = 26;
            lbBase.Text = "  ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 577);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnVotar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Encuesta de servicio";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbInsuficientes;
        private Label lbBuenos;
        private Label lbExcelentes;
        private Label lbTotal;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnVotar;
        private RadioButton rbInsuficiente;
        private RadioButton rbBueno;
        private RadioButton rbExcelente;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbBase;
        private RadioButton rbFULL;
        private GroupBox groupBox3;
        private Label label5;
        private Label lbFULL;
        private Label label6;
        private Label lbBase;
    }
}
