void logo()
{
    Console.WriteLine(@"
█▀▄▀█ █▀▀ █▀▄ █ ▄▀█   ▄▀█ █▀█ █ ▀█▀ █ █▀▄▀█ █▀▀ ▀█▀ █ █▀▀ ▄▀█
█░▀░█ ██▄ █▄▀ █ █▀█   █▀█ █▀▄ █ ░█░ █ █░▀░█ ██▄ ░█░ █ █▄▄ █▀█");

}

void calcularMedia()
{
    float nota1 = 0;
    float nota2 = 0;
    float nota3 = 0;

    do
    {
        Console.Write("\nDigite a 1ºNota: ");
        if (float.TryParse(Console.ReadLine(), out nota1) && nota1 >= 0 && nota1 <= 10)
        {
            break;
        }
        Console.WriteLine("\nDigite um valor válido entre 0 e 10.");
    } while (true);

    do
    {
        Console.Write("\nDigite a 2ºNota: ");
        if (float.TryParse(Console.ReadLine(), out nota2) && nota2 >= 0 && nota2 <= 10)
        {
            break;
        }
        Console.WriteLine("\nDigite um valor válido entre 0 e 10.");
    } while (true);

    do
    {
        Console.Write("\nDigite a 3ºNota: ");
        if (float.TryParse(Console.ReadLine(), out nota3) && nota3 >= 0 && nota3 <= 10)
        {
            break;
        }
        Console.WriteLine("\nDigite um valor válido entre 0 e 10.");
    } while (true);

    Console.Clear();

    float media = (nota1 + nota2 + nota3) / 3;

    logo();
    Console.WriteLine($"\nNota 1 = {nota1}");
    Console.WriteLine($"Nota 2 = {nota2}");
    Console.WriteLine($"Nota 3 = {nota3}");

    Console.WriteLine($"\nMédia final = {media:F1}");

}

logo();
calcularMedia();