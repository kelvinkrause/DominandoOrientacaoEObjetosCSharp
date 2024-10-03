using ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio1.Modelos;

namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio1
{
    public class Exercicio1
    {
        /*
        Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. 
        Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.
        */

        public Exercicio1()
        {
            Quadrado quadrado = new Quadrado();
            quadrado.Lado = 10;

            Console.WriteLine(quadrado.CalculaArea());
        }

    }
}