namespace Calculadoras
{
    public partial class CalculadoraIMC : Form
    {
        public CalculadoraIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(mtbPeso.Text);
            altura = Convert.ToDouble(mtbAltura.Text);

            var (descricaoImc, resultadoImc) = CalcularImc(peso, (altura / 100));

            lblResultado1.Text = $"{descricaoImc}\nSeu IMC: {resultadoImc}";
        }
        private (string,double) CalcularImc(double peso, double altura)
        {
            double imc = peso / (altura * altura);
            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };

            return (resultado, imc);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mtbPeso.Text = "";
            mtbAltura.Clear();
            lblResultado1.Text = String.Empty;
            mtbPeso.Focus();
        }

    }
}