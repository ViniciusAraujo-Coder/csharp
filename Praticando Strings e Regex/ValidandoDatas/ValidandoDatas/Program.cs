using System.Text.RegularExpressions;

string regex = @"^\d{2}/\d{2}/\d{4}$";

Console.WriteLine("Digite a data (dd/mm/aaaa):");
string data = Console.ReadLine();

bool formatoCorreto = Regex.IsMatch(data, regex);

if (formatoCorreto)
{
    Console.WriteLine("A data está no formato correto.");
}
else
{
    Console.WriteLine("Formato inválido! Use dd/mm/aaaa.");
}