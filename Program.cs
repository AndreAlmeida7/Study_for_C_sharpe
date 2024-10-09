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


