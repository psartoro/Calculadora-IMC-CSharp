using IMC.Models;

string? peso = "";
string? altura = "";

Console.WriteLine("\n### CALCULADORA IMC ###\n");

Console.WriteLine("Digite seu peso (ex.: 68.5)");
peso = Console.ReadLine();

Console.WriteLine("Digite sua altura (ex.: 1.70)");
altura = Console.ReadLine();

bool isNumeric = double.TryParse(peso, out double n);

while (!isNumeric)
{
    Console.WriteLine("Dados Inválidos!");
    Console.WriteLine("Digite seu peso (ex.: 68.5)");
    peso = Console.ReadLine();

    Console.WriteLine("Digite sua altura (ex.: 1.70)");
    altura = Console.ReadLine();

    isNumeric = double.TryParse(peso, out double nn);
}

Calculadora calc = new Calculadora(double.Parse(peso), double.Parse(altura));

if(calc.CalculaIMC() == 0)
{
    Console.WriteLine("Não foi possível realizar o cálculo do IMC, desculpe.");
}


Console.WriteLine("Encerrando programa...\n");
Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();