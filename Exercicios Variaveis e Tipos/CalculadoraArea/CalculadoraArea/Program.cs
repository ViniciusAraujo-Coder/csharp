Console.WriteLine(@"
█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█   ▄▀█ █▀█ █▀▀ ▄▀█
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█   █▀█ █▀▄ ██▄ █▀█");

double largura;
double comprimento;

do
{
    Console.Write("\nDigite a largura do terreno: ");
} while (!double.TryParse(Console.ReadLine(), out largura));

do
{
    Console.Write("\nDigite o comprimento do terreno: ");
} while (!double.TryParse(Console.ReadLine(), out comprimento));

double area = comprimento * largura;
Console.WriteLine($"\nA área do terreno é: {area:F2} metros quadrados.");