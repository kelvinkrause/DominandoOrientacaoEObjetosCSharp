namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio1.Modelos
{
    internal class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalculaArea()
        {
            return Math.PI * Raio * Raio;
        }

        public override double CalculaPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

    }
}