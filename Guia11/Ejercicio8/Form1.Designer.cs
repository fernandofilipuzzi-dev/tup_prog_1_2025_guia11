namespace Ejercicio8
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
            lsbServicios = new ListBox();
            lsbServiciosElegidos = new ListBox();
            btnAgregar = new Button();
            btnQuitar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lsbServicios
            // 
            lsbServicios.FormattingEnabled = true;
            lsbServicios.ItemHeight = 21;
            lsbServicios.Items.AddRange(new object[] { "Cambio de aceite", "Reemplazo batería", "Reemplazo Filtros de aire", "Alineación y balanceo", "Verificación de Frenos", "Verificación de luces", "Reemplazo de bobina de arranque" });
            lsbServicios.Location = new Point(15, 56);
            lsbServicios.Margin = new Padding(4);
            lsbServicios.Name = "lsbServicios";
            lsbServicios.Size = new Size(270, 193);
            lsbServicios.TabIndex = 0;
            // 
            // lsbServiciosElegidos
            // 
            lsbServiciosElegidos.FormattingEnabled = true;
            lsbServiciosElegidos.ItemHeight = 21;
            lsbServiciosElegidos.Location = new Point(397, 56);
            lsbServiciosElegidos.Margin = new Padding(4);
            lsbServiciosElegidos.Name = "lsbServiciosElegidos";
            lsbServiciosElegidos.Size = new Size(291, 193);
            lsbServiciosElegidos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(293, 132);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 32);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar>";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(559, 13);
            btnQuitar.Margin = new Padding(4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(96, 32);
            btnQuitar.TabIndex = 3;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 4;
            label1.Text = "Servicios:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 258);
            Controls.Add(label1);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lsbServiciosElegidos);
            Controls.Add(lsbServicios);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicio Técnico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbServicios;
        private ListBox lsbServiciosElegidos;
        private Button btnAgregar;
        private Button btnQuitar;
        private Label label1;
    }
}
