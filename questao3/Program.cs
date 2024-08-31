/*using System;

namespace ProcessoSeletivo 
{
    class Program
    {
        static void Main()
        {
            double[] faturamentoDiario = { 22174.1664, 24537.6698, 0.0, 0.0, 26139.6134, 0.0, 26742.6612, 0.0, 42889.2258, 
                                        46251.174, 11191.4722, 0.0, 0.0, 3847.4823, 373.7838, 2659.7563, 48924.2448, 
                                        18419.2614, 0.0, 0.0, 35240.1826, 43829.1667, 18235.6852, 4355.0662, 
                                        13327.1025, 0.0, 0.0, 25681.8318, 1718.1221, 13220.495, 8414.61 };

            double menorFaturamento = faturamentoDiario[0];
            double maiorFaturamento = faturamentoDiario[0];
            double somaFaturamento = 0;
            int diasComFaturamento = 0;

            for (int i = 0; i < faturamentoDiario.Length; i++)
            {
                if (faturamentoDiario[i] > 0)
                {
                    if (faturamentoDiario[i] < menorFaturamento) menorFaturamento = faturamentoDiario[i];
                    if (faturamentoDiario[i] > maiorFaturamento) maiorFaturamento = faturamentoDiario[i];
                    somaFaturamento += faturamentoDiario[i];
                    diasComFaturamento++;
                }
            }

            double mediaMensal = somaFaturamento / diasComFaturamento;
            int diasAcimaDaMedia = 0;

            for (int i = 0; i < faturamentoDiario.Length; i++)
            {
                if (faturamentoDiario[i] > mediaMensal)
                {
                    diasAcimaDaMedia++;
                }
            }

            Console.WriteLine($"Menor Faturamento: {menorFaturamento:C}");
            Console.WriteLine($"Maior Faturamento: {maiorFaturamento:C}");
            Console.WriteLine($"Dias com Faturamento Acima da Média: {diasAcimaDaMedia}");
        }
    }
}*/