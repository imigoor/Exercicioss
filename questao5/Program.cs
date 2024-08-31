using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a string para inverter: ");
        string texto = Console.ReadLine();
        char[] caracteres = new char[texto.Length];

        for (int i = 0; i < texto.Length; i++)
        {
            caracteres[i] = texto[i];
        }

        int inicio = 0;
        int fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;
            inicio++;
            fim--;
        }

        string invertida = "";
        for (int i = 0; i < caracteres.Length; i++)
        {
            invertida += caracteres[i];
        }

        Console.WriteLine($"String invertida: {invertida}");
    }
}
