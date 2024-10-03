namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio1.Modelos
{
    internal class Triangulo : FormaGeometrica
    {
        public double Area { get; set; }
        public double Base { get; set; }

        public override double CalculaArea()
        {
            return (Area + Base) / 2;
        }

        public override double CalculaPerimetro()
        {
            Console.WriteLine("Não implementado.");
            return 0;
        }

    }
}