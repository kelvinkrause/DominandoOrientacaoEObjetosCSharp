using ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio2.Modelos;

namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio2
{
    public class Exercicio2
    {

        /*
        Crie uma hierarquia de classes representando funcionários de uma empresa. 
        Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, 
        além das propriedades comuns a todos os funcionários, como Nome e Salário.
        */
        public Exercicio2()
        {
            Gerente gerente = new Gerente();
            gerente.Nome = "Kelvin";
            gerente.SalarioEmCent = 2000000;
            gerente.Setor = "Financeiro";

            Console.WriteLine($"Salário: {gerente.SalarioEmCent / 100}");

            Programador kelvin = new Programador();
            kelvin.Nome = "Kelvin";
            kelvin.SalarioEmCent = 1000000;
            kelvin.AdicionarLinguagem("");
            kelvin.AdicionarLinguagem("C#");
            kelvin.AdicionarLinguagem("Magic XPA");

            foreach(string linguagem in kelvin.Linguagem)
            {
                Console.WriteLine(linguagem);
            }

        }
    }
}