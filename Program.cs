// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

// Para defirnir uma variável em C#, temos que especificar qual o tipo da variável primeiramente
// Strings são escritas com duas aspas
//Todo final de linha no código precisa ter ponto e vírgula
// o "f string" do python se escreve com o símbolo do cifrão

string primeiro_nome = "Maria";
string segundo_nome = "Antonieta";
string terceiro_nome = "André Luiz Rodrigues";
//Console.WriteLine($"Meu amigos são {primeiro_nome} e {segundo_nome}");

// Aprendendo sobre a variável replace

string friends = $"Meu amigos são {primeiro_nome} e {segundo_nome}";

// Estou subtituindo a pavra antonieta por Luis
Console.WriteLine(friends.Replace("Antonieta", "Luis"));

// A variável "terceiro_nome" contém a string "André"? True or false?
Console.WriteLine(terceiro_nome.Contains("André"));


//----------------------------------------------------------------------------------//

//Operadores matemáticos

int a = 2100000000;
int b = 2100000000; // o formato inteiro só suporta até 2^32 (32 bits)
long c = (long)a + (long)b; //long já aceita até 2^64 (64 bits)
Console.WriteLine(c);

//Ou

long d = 4100000000000;
long e = 4100000000000;

long f = d + e;
Console.WriteLine(f);


// Para utilizar número com ponto flutuante podemos usar Decimal, float ou double (mais usual)

double z = 42.2;
float g = 56.4F; //É necessário explicitar que o número é um float com o F ao final dele. Além disso, deixa o número com a maior precisão possível.

double t = z + g;

Console.WriteLine(t);

decimal j = 578.5M;
decimal u = 54.978M;

decimal ju = j + u;
Console.WriteLine(ju);


