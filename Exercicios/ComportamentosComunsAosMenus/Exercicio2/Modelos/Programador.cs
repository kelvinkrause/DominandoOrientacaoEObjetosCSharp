namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio2.Modelos
{
    public class Programador : Funcionario
    {
        public List<string> Linguagem = new List<string>();

        public void AdicionarLinguagem(string linguagem)
        {
            if (linguagem == "") 
            {
                Console.WriteLine("Linguagem branca não existe.");
            }
            else
            {
                this.Linguagem.Add(linguagem);
            }
        }

    }
}