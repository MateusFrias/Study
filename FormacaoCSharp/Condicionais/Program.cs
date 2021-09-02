using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodoWhile();
            //metodoFor();
            //multiplos(5);
            fatorial();

            Console.ReadLine();

        }

        static void metodoWhile()
        {
            Console.WriteLine("Método While");

            double valorInvestido = 1000;

            int mes = 1;
            //0.36% = 0.0036
            while (mes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;

                Console.WriteLine("Após " + mes + "meses, você terá R$" + valorInvestido);

                mes++;
            }
        }

        static void metodoFor()
        {
            Console.WriteLine("Método For");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int ano = 1; ano <=5; ano++)
            {
                for (int i = 1; i <= 12; i++)
                {
                    valorInvestido = valorInvestido * fatorRendimento;

                    Console.WriteLine("Após " + (ano - 1) + " anos e " + i + " meses, você terá R$" + valorInvestido);

                }

                fatorRendimento = fatorRendimento + 0.0010;
            }
        }

        static void multiplos(int valor)
        {
            for (int i = 1; i<=100; i++)
            {
                if (i % valor == 0)
                    Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        static void fatorial()
        {
            int i, j, valorTotal;

            for (j = 1; j <= 10; j++)
            {
                valorTotal = j;

                for (i = j; i > 1; i--)
                {
                    valorTotal = valorTotal * (i - 1);
                }
                Console.WriteLine("Fatorial de " + j + " é " + valorTotal);
            }
            
        }
    }
}
