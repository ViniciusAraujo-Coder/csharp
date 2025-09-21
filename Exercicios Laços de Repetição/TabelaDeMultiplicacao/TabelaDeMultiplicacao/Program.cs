int numero;

do
{
    Console.Clear();
    Console.Write("Digite um número para ver sua tabuada: ");

    if (int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine($"\nTabuda do número {numero}: \n");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{numero} X {i} = {numero * i}");
        }
    }

    else
    {
        Console.WriteLine("\nErro. Por favor digite um número inteiro válido!");
        Console.Write("\nAperte qualquer tecla para retornar.");
        Console.ReadKey();
        continue;
    }

    break;
} while (true);