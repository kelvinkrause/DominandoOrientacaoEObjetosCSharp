namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio5.Modelos
{
    public class Laptop : Produto
    {
        public string Informacao { get; set; }

        public Laptop(string nome, string informacao)
        {
            base.Nome = nome;
            this.Informacao = informacao;
        }

        public override void ExibeInformacoes()
        {
            Console.WriteLine(Informacao);
        }


    }
}