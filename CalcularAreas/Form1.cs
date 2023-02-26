namespace CalcularAreas
{
    public partial class Indice : Form
    {
        public Indice()
        {
            InitializeComponent();
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            F_Quadrado f_Quadrado = new F_Quadrado();
            f_Quadrado.ShowDialog();
        }

        private void btnTri_Click(object sender, EventArgs e)
        {
            F_Triangulo f_triangulo = new F_Triangulo();
            f_triangulo.ShowDialog();
        }

        private void btnCir_Click(object sender, EventArgs e)
        {
            F_Circulo f_Circulo = new F_Circulo();
            f_Circulo.ShowDialog();
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            F_Retangulo f_retangulo = new F_Retangulo();
            f_retangulo.ShowDialog();
        }

        private void btnLos_Click(object sender, EventArgs e)
        {
            F_Losango f_losango = new F_Losango();
            f_losango.ShowDialog();
        }

        private void btnTrap_Click(object sender, EventArgs e)
        {
            F_Trapezio f_trapezio = new F_Trapezio();
            f_trapezio.ShowDialog();
        }
    }
}