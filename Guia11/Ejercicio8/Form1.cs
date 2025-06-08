namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idx = lsbServicios.SelectedIndex;

            if (idx > -1)
            {
                string item = Convert.ToString(lsbServicios.Items[idx]);
                lsbServiciosElegidos.Items.Add(item);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int idx = lsbServiciosElegidos.SelectedIndex;

            if (idx > -1)
            {
                lsbServiciosElegidos.Items.RemoveAt(idx);
            }
        }
    }
}
