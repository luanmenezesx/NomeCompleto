Console.Clear();

string nome;
string sobrenome;


Console.Write("Digite o seu primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome: ");
sobrenome = Console.ReadLine()!.ToUpper();

Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de Catálogo: {sobrenome}, {nome}");

