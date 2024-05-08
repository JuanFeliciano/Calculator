using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número correspondente a opção desejada: ");

            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o PRIMEIRO valor: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o SEGUNDO valor");
            int number2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch(operation)
            {
                case 1:
                    {
                        result = Addition(number, number2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(number, number2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(number, number2);
                        break;
                    }
                case 4:
                    {
                        result = Division(number, number2);
                        break;
                    }
                default: Console.WriteLine("Opção digitada não corresponde as oferecidas. Número inválido!");
                    break;
            }
            Console.WriteLine("O resultado de sua operação entre {0} e {1} é {2}", number, number2, result);

        }

        public static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;

        }
        public static int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public static int Division(int num1, int num2)
        {
            int result = num1 / num2;   
            return result;

        }
    }
}
