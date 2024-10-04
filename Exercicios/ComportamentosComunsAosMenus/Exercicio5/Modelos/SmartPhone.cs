namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio5.Modelos
{
    internal class SmartPhone : Produto
    {
        public string Informacao { get; set; }
        public SmartPhone(string nome, string informacao)
        {
            base.Nome = nome;
            this.Informacao = informacao;
        }

        public override void ExibeInformacoes()
        {
            Console.WriteLine(this.Informacao);
        }

    }
}