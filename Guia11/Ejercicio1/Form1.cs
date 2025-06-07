namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random azar = new Random();
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero = azar.Next(1, 101);
            lbNumero.Text = $"{numero}";
        }
    }
}
