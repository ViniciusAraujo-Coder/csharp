using System.Text.RegularExpressions;

// Programa para validar se um código de cupom contém apenas números e tem 6 dígitos

Console.WriteLine("Digite o código do cupom: ");
string codigo = Console.ReadLine();

// Padrão: exatamente 6 dígitos
string codigoPadrao = @"^\d{6}$";

// Verifica se o código está no formato correto
bool codigoValido = Regex.IsMatch(codigo, codigoPadrao);

if (codigoValido)
{
    Console.WriteLine("O código é válido");
}
else
{
    Console.WriteLine("O código não é válido.");
}
