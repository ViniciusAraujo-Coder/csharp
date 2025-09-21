Console.WriteLine(@"
█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█   █▀█ █▀▀ █▀█ █ █▀▄▀█ █▀▀ ▀█▀ █▀█ █▀█
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█   █▀▀ ██▄ █▀▄ █ █░▀░█ ██▄ ░█░ █▀▄ █▄█");

double raio = 0;
double pi = 3.14159;

do
{
    Console.Write("\nDigite o raio da circunferencia: ");
    if (double.TryParse(Console.ReadLine(), out raio))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número valido!");
        continue;
    }
} while (true);

double area = pi * raio * raio;
double perimetro = 2 * pi * raio;

Console.WriteLine($"\nRaio: {raio.ToString("F2")}");
Console.WriteLine($"\nÁrea do círculo: {area.ToString("F2")}");
Console.WriteLine($"\nPerímetro do círculo: {perimetro.ToString("F2")}");