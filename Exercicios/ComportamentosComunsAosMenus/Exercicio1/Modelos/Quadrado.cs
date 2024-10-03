namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio1.Modelos
{
    internal class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }
        public override double CalculaArea()
        {
            return Lado * Lado;
        }

        public override double CalculaPerimetro()
        {
            return Lado * 4;

        }

    }
}