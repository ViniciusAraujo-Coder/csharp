void menu()
{

    Console.WriteLine(@"
█▀▀ █▀█ █▄░█ █░█ █▀▀ █▀█ █▀ █▀█ █▀█   ▀█▀ █▀▀ █▀▄▀█ █▀█ █▀▀ █▀█ ▄▀█ ▀█▀ █░█ █▀█ ▄▀█
█▄▄ █▄█ █░▀█ ▀▄▀ ██▄ █▀▄ ▄█ █▄█ █▀▄   ░█░ ██▄ █░▀░█ █▀▀ ██▄ █▀▄ █▀█ ░█░ █▄█ █▀▄ █▀█");

    Console.Write("""

        Selecione uma opção:
        1 - Celsius para Fahrenheit
        2 - Fahrenheit para Celsius
        3 - Sair
        
        Opção: 
        """);
}

double celsius;
double fahrenheit;
int opcao;

do
{
    menu();

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.Write("\nOpção inválida. Digite um dos números disponíveis!");
        Thread.Sleep(1500);
        Console.Clear();
        continue;
    }

    switch (opcao)
    {
        case 1:
            Console.Write("\nDigite a temperatura em Celsius: ");
            if (double.TryParse(Console.ReadLine(), out celsius))
            {
                double conversaoFahrenheit = (celsius * 9.0 / 5.0) + 32.0;
                Console.WriteLine($"\n{celsius:F2}ºC equivalem a {conversaoFahrenheit:F2}ºF");
                Console.Write("\nDigite qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Write("\nOpção inválida. Digite um número válido!");
                Thread.Sleep(1500);
                Console.Clear();
                continue;
            }
            break;

        case 2:
            Console.Write("\nDigite a temperatura em Fahrenheit: ");
            if (double.TryParse(Console.ReadLine(), out fahrenheit))
            {
                double conversaoCelsius = (fahrenheit - 32.0) * 5.0 / 9.0;
                Console.WriteLine($"\n{fahrenheit:F2}ºF equivalem a {conversaoCelsius:F2}ºC");
                Console.Write("\nDigite qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Write("\nOpção inválida. Digite um número válido!");
                Thread.Sleep(1500);
                Console.Clear();
                continue;
            }
            break;

        case 3:
            Console.WriteLine("\nEncerrando o sistema.");
            break;

        default:
            {
                Console.Write("Opção inválida.");
                Thread.Sleep(1000);
                break;
            }
    }
} while (opcao != 3);