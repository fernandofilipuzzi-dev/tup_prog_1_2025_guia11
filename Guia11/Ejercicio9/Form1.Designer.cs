namespace Ejercicio9
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
            label1 = new Label();
            btnQuitar = new Button();
            btnAgregar = new Button();
            lsbServiciosElegidos = new ListBox();
            cmbServicios = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 9;
            label1.Text = "Servicios:";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(557, 17);
            btnQuitar.Margin = new Padding(4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(96, 32);
            btnQuitar.TabIndex = 8;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(295, 60);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 47);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar>";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lsbServiciosElegidos
            // 
            lsbServiciosElegidos.FormattingEnabled = true;
            lsbServiciosElegidos.ItemHeight = 21;
            lsbServiciosElegidos.Location = new Point(395, 60);
            lsbServiciosElegidos.Margin = new Padding(4);
            lsbServiciosElegidos.Name = "lsbServiciosElegidos";
            lsbServiciosElegidos.Size = new Size(291, 193);
            lsbServiciosElegidos.TabIndex = 6;
            // 
            // cmbServicios
            // 
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Items.AddRange(new object[] { "Cambio de aceite", "Reemplazo batería", "Reemplazo Filtros de aire", "Alineación y balanceo", "Verificación de Frenos", "Verificación de luces", "Reemplazo de bobina de arranque" });
            cmbServicios.Location = new Point(13, 60);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(275, 29);
            cmbServicios.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 262);
            Controls.Add(cmbServicios);
            Controls.Add(label1);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lsbServiciosElegidos);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Servicio Ténico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnQuitar;
        private Button btnAgregar;
        private ListBox lsbServiciosElegidos;
        private ComboBox cmbServicios;
    }
}
