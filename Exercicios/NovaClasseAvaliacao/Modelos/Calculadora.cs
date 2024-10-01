namespace ScreenSound.Exercicios.NovaClasseAvaliacao.Modelos
{
    public class Calculadora
    {
        public Calculadora()
        {
            IdentificaCaracteres("10+2");
            IdentificaCaracteres("10-2");
            IdentificaCaracteres("10*2");
            IdentificaCaracteres("10/2");
            IdentificaCaracteres("10/0");
        }

        void IdentificaCaracteres(string expressao)
        {
            List<string> numeros = new List<string> {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            List<string> operadores = new List<string> {"+", "-", "*", "/"};

            string num1 = "", num2 = "", operador = "";

            for (int i = 0; i < expressao.Length; i++)
            {
                string valor = expressao.Substring(i,1);

                if (numeros.Contains(valor) && operador.Equals("")) num1 += valor;
                if (numeros.Contains(valor) && !operador.Equals("")) num2 += valor;
                if (operadores.Contains(valor)) operador = valor;
                
            }

            Calcula(operador, num1, num2);

        }

        void Calcula(string operador, string num1, string num2)
        {

            if(operador.Equals("/") && num2.Equals("0"))
            {
                Console.WriteLine($"Não é possível dividir {num1} por {num2}.");
                return;
            }

            double numero1 = Convert.ToDouble(num1);//Double.Parse(num1);
            double numero2 = Convert.ToDouble(num2);//Double.Parse(num2);

            switch(operador)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {numero1 + numero2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {numero1 - numero2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {numero1 * numero2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {numero1 / numero2}");
                    break;
                default:
                    Console.WriteLine("Valor não encontrado.");
                    break;
            }
        }
    }
}