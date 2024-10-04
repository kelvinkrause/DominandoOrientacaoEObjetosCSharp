namespace ScreenSound.Exercicios.ComportamentosComunsAosMenus.Exercicio5.Modelos
{
    public class Produto
    {
        public string? Nome { get; set; }

        public virtual void ExibeInformacoes()
        {
            Console.WriteLine("Exibe informação produto");
        }
    }
}