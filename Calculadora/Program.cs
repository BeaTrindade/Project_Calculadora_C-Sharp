using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
                 int menu = 1;
            while (menu == 1)
            {
                Console.WriteLine("\n ===========================");
                Console.WriteLine("    Calculadora Virtual    ");
                Console.WriteLine(" =========================== \n");

                Console.WriteLine("\n Digite '1' para CONTINUAR ou '0' para SAIR.");

                menu = int.Parse(Console.ReadLine());
                if (menu != 1)
                {
                    Console.WriteLine("\n > Sair < O Programa será finalizado.");
                    break;
                }
                Console.Clear();

                Console.WriteLine("\n ===========================");
                Console.WriteLine("    Calculadora Virtual    ");
                Console.WriteLine(" =========================== \n");

                    Console.WriteLine("\n Digite o 1º Numero: ");
                    double x = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n Digite a operação (+ - x / ): ");
                    string operador = Console.ReadLine();

                    Console.WriteLine("\n Digite o 2º Numero: ");
                    double y = int.Parse(Console.ReadLine());

                    double total = 0;

                 switch (operador)
                 {
                        case "+":
                            total = x + y;
                            break;
                        case "-":
                            total = x - y;
                            break;
                        case "x":
                            total = x * y;
                            break;
                        case "*":
                            total = x * y;
                            break;
                        case "/":
                            total = x / y;
                            break;
                }

                if (y == 0 && operador == "/")
                {
                    Console.WriteLine("\n -----> ZERO não é um divisor! <-----");
                    total = 1;
                }

                Console.WriteLine("\n ---> RESULTADO: {0} {1} {2} = {3}", x, operador, y, total);

                 Console.ReadKey();
            }
        }    
    }
}
