namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            bool esCorrecto = chbOpcion1.Checked && !chbOpcion2.Checked && !chbOpcion3.Checked;

            if (esCorrecto)
                lbResultado.Text = "Respuesta correcta";
            else
            {
                lbResultado.Text = "Respuesta incorrecta\r\n";
                if(!chbOpcion1.Checked)
                    lbResultado.Text += "  No siempre se debe inializarse. Es Verdadero\r\n";
                if (chbOpcion2.Checked)
                    lbResultado.Text += "  Nunca debe inicializarse. Es Falso\r\n";
                if (chbOpcion3.Checked)
                    lbResultado.Text += "  Siempre debe inicializarse. Es Falso";
            }
        }
    }
}
