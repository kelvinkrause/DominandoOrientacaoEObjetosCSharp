using System.Security;
using ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.Exercicio1.Modelos;

namespace ScreenSound.Exercicios.AlternativaParaAnexarSemelhancas.Exercicio1;

public class Exercicio1
{
    /*
     * Criar uma interface chamada IForma que declare métodos para calcular a área e o perímetro de uma forma geométrica. 
     * Implemente esta interface em duas classes: Circulo e Retangulo.
     */

     public Exercicio1()
     {
        Console.WriteLine("Bem-vindo ao IForma\n");
        Opcao();
     }

     void Opcao()
     {
        Console.WriteLine("Digite 1 para calcular o Perimetro de um Circulo");
        Console.WriteLine("Digite 2 para calcular o Area de um Circulo");
        Console.WriteLine("Digite 3 para calcular o Perimetro de um Retangulo");
        Console.WriteLine("Digite 4 para calcular o Area de um Retangulo");
        Console.WriteLine("Digite 0 para sair");

        Console.Write("\nEscolha uma opcao: ");

        
        try
        {
            string opcaoEscolhida = Console.ReadLine()!;
            int resultado = int.Parse(opcaoEscolhida);

            if (resultado >= 0 || resultado <= 4)
            {
                switch (resultado)
                {
                    case 0:
                        OpcaoSair();
                        break;
                    case 1:
                        OpcaoPerimetroOuAreaCirculo("P");
                        break;
                    case 2:
                        OpcaoPerimetroOuAreaCirculo("A");
                        break;
                    case 3:
                        OpcaoPerimetroOuAreaRetangulo("P");
                        break;
                    case 4: 
                        OpcaoPerimetroOuAreaRetangulo("A");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        Thread.Sleep(500);
                        Console.Clear();
                        Opcao();
                        break;
                }

            }
            else 
            {
                Console.WriteLine("\nValor Inválido.");
                Thread.Sleep(800);
                Console.Clear();
                Opcao();
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("\nValor informado deve ser numérico.");
            Thread.Sleep(800);
            Console.Clear();
            Opcao();
        }
     }

     void OpcaoSair()
     {
        Console.Clear();
        Console.WriteLine("Saindo...");
        Thread.Sleep(500);
        Console.Clear();
     }

    void OpcaoPerimetroOuAreaCirculo(string areaOuPerimetro)
    {
        Titulo(areaOuPerimetro, "C");
        Console.Write("Informe o raio do Circulo: ");
        string raio = Console.ReadLine()!;
        Boolean valorNumerico = double.TryParse(raio, out double resultado);
        if(valorNumerico)
        {
            Circulo circulo = new Circulo(resultado);

            if(areaOuPerimetro.Equals("P")) Console.WriteLine($"\nO Perimetro do Circulo é: {circulo.Perimetro()}");
            if(areaOuPerimetro.Equals("A")) Console.WriteLine($"\nA Area do Circulo é: {circulo.Area()}");

            Console.Write("\nDigite algo para retornar ao menu principal ");
            Console.ReadKey(true);
        }
        else
        {
            Console.WriteLine($"Valor informado tem que ser numérico.");
        }
        Console.Clear();
        Opcao();
    }

    void OpcaoPerimetroOuAreaRetangulo(string areaOuPerimetro)
    {
        Titulo(areaOuPerimetro, "R");
        Console.Write("Informe a Largura do Retangulo: ");
        Boolean larguraNumerico = double.TryParse(Console.ReadLine()!, out double largura);
        Console.Write("Informe a Comprimento do Retangulo: ");
        Boolean comprimentoNumerico = double.TryParse(Console.ReadLine()!, out double comprimento);

        if(comprimentoNumerico || larguraNumerico)
        {
            Retangulo retangulo = new Retangulo(largura: largura, comprimento: comprimento);

            if(areaOuPerimetro.Equals("P")) Console.WriteLine($"\nO Perimetro do Retangulo é: {retangulo.Perimetro()}");
            if(areaOuPerimetro.Equals("A")) Console.WriteLine($"\nA Area do Retangulo é: {retangulo.Area()}");

            Console.Write("\nDigite algo para retornar ao menu principal ");
            Console.ReadKey(true);
        }
        else
        {
            Console.WriteLine($"Valor informado tem que ser numérico.");
        }
        Console.Clear();
        Opcao();
    }

    void Titulo(string areaOuPerimetro, string circuloOuRetangulo)
    {
        Console.Clear();
        string titulo = areaOuPerimetro.Equals("A") ? "Area" : "Perimetro";
        string forma = circuloOuRetangulo.Equals("C") ? "Circulo" : "Retangulo";
        Console.WriteLine($"{titulo} do {forma}");
    }


}
