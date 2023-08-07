using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritorio";

byte idade = 30;
int codigo = 5290;
char genero = 'M';


double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.23456700;
Console.WriteLine("Produtos:");
Console.WriteLine($"{produto1}, cujo o preço é R$ {preco1:f2}");
Console.WriteLine($"{produto2}, cujo o preço é R$ {preco2:f2}\n");
Console.WriteLine("Registro:{0} Anos de idade, código {1} e Gênero: {2} \n", idade, codigo, genero);
Console.WriteLine($"Medidas com oito casas decimais: {medida:f8}");
Console.WriteLine($"Medidades com 3 casas decimais: {medida:f3}");
Console.WriteLine($"Medidas com 3 casas decimais: " + medida.ToString("f3", CultureInfo.InvariantCulture));