/*using System;

namespace ProcessoSeletivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int numero = int.Parse(Console.ReadLine());  // Corrigido "Readline()" para "ReadLine()"
            bool pertence = VerificarFibonacci(numero);

            if (pertence)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
        }

        static bool VerificarFibonacci(int num)
        {
            int a = 0, b = 1, c = 0;

            if (num == 0 || num == 1) return true;

            while (c < num)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c == num;
        }
    }
}
*/