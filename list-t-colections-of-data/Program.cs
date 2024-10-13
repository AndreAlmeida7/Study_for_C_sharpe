var names = new List<string> {"André", "Ana", "Felipe"}; // Declarando a variável "names" como uma lista de variáveis que receberá os nomes citados.

names.Add("David");
names.Add("Maria");
names.Add("kaka");

foreach (var name in names) // Para cada nome dentro da lista de nomes faça o seguinte:
{
    Console.WriteLine($"Hello {name.ToUpper()}!");  // imprima "Hello (upper name of person)!"  
}