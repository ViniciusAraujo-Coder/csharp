Console.WriteLine(@"
█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█   █▄▄ ▄▀█ █▀ █ █▀▀ ▄▀█
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█   █▄█ █▀█ ▄█ █ █▄▄ █▀█");

Console.WriteLine("\nDigite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação (+, -, *, /)");
string operador = Console.ReadLine();

switch (operador)
{
    case "+":
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    case "/":
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        break;
    default:
        Console.WriteLine("Operação inválida");
        break;
}