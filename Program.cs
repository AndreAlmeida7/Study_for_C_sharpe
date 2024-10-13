// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
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

string friends = $"My friends are {primeiro_nome} and {segundo_nome}";

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

decimal j = 578.5M; // Maior precisão, porém com um range menor. É necessário colocar o prefixo M em decimal para ser explícito.
decimal u = 54.978M;

decimal ju = j + u;
Console.WriteLine(ju);



//----------------------------------------------------------//

//Condicionais, IFs e loops

int number_a = 5;
int number_b = 3;
int sum_a_b = number_a + number_b;

// if (sum_a_b > 10 && number_a > 5) // && refere-se a lógica "e", "and"
// { // É sempre recomendado colocar chaves entre o argumento de if e else. Significa ser mais explícito e direcional com seus comandos
//     Console.WriteLine($"The answer {sum_a_b} is greater than 10"); 
//     Console.WriteLine("And number a is number 5"); 
// } 
// else
// {
//     Console.WriteLine($"The answer {sum_a_b} is less than 10");
//     Console.WriteLine("Or the number a is not number 5"); 
// }

if (sum_a_b > 10 || number_a > 5) // || refere-se a lógica "ou", "or"
{ // É sempre recomendado colocar chaves entre o argumento de if e else. Significa ser mais explícito e direcional com seus comandos
    Console.WriteLine($"The answer {sum_a_b} is greater than 10"); 
    Console.WriteLine("Ou number a is number 5"); 
} 
else
{
    Console.WriteLine($"The answer {sum_a_b} is less than 10");
    Console.WriteLine("Or the number a is not number 5"); 
}
