
using ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio3.Modelos;

namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio3
{
    internal class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        public virtual void Executar(Dictionary<string, ContaBancaria> contas)
        {
            Console.Clear();
        }
    }
}