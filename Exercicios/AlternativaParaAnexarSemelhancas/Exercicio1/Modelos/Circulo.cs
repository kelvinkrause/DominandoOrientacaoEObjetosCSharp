namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.Exercicio1.Modelos
{
    public class Circulo : IForma
    {
        public double Raio { get; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double Area()
        {
            return Math.PI * Raio * Raio;
        }

        public double Perimetro()
        {
            return 2 * Math.PI * Raio;
        }

    }
}