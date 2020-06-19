using System;

/*
[console: PesoIdeal] Solicite que o usuário digite sua altura e o seu sexo ('M' para masculino, 'F' para feminino). Calcule e exiba seu peso ideal.
*/
namespace PesoIdeal_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Declarar variáveis
            decimal alturaUsuario, pesoIdeal;
            string sexoUsuario;
            // 2 - Solicitar entradas ao usuário
            Console.Write("Digite sua altura em m..........: ");

            if (!Decimal.TryParse(Console.ReadLine(), out alturaUsuario))
            {
                Console.WriteLine("\nA altura não é um número válido. Tente novamente.");
                Environment.Exit(1);
            }

            Console.Write("Sexo [M]asculino / [F]eminino...: ");
            sexoUsuario = Console.ReadLine();

            //3 - Usar estrutura de decisão, para calcular o peso ideal a partir do sexo
            switch(sexoUsuario.ToUpper())
            {
                case "M":
                    //4 - Realizar os cálculos, conforme a situação
                    pesoIdeal = alturaUsuario * 72.7m - 58.0m;
                    //5 - Exibir o peso ideal.
                    Console.WriteLine($"\nSeu peso ideal é {pesoIdeal:N1}kg.");
                    break;
                case "F":
                    //4 - Realizar os cálculos, conforme a situação
                    pesoIdeal = alturaUsuario * 62.1m - 44.7m;
                    //5 - Exibir o peso ideal.
                    Console.WriteLine($"\nSeu peso ideal é {pesoIdeal:N1}kg.");
                    break;
                default:
                    Console.WriteLine($"\nO sexo informado não é valido {sexoUsuario}");
                    break;
            }
            
            
                        
        }
    }
}
