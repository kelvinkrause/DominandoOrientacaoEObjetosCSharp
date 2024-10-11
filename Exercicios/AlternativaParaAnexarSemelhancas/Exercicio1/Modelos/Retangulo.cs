namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.Exercicio1.Modelos
{
    public class Retangulo : IForma
    {
        public double Largura { get; }
        public double Comprimento { get; }

        public Retangulo(double largura, double comprimento)
        {
            Largura = largura;
            Comprimento = comprimento;
        }

        public double Area()
        {
            return Largura * Comprimento;
        }

        public double Perimetro()
        {
            return 2 * (Largura * Comprimento);
        }

    }
}