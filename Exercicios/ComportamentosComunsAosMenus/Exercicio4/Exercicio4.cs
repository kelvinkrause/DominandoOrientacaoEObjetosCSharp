using ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio4.Modelos;

namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio4
{
    public class Exercicio4
    {
        /*
         * Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. 
         * Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom 
         * que represente o som característico de cada tipo de animal.
        */

        public Exercicio4()
        {
            Animal animal = new Mamifero();

            Console.WriteLine(animal.EmitirSom());

        }
        
    }
}