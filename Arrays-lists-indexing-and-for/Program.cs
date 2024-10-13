var names = new List<string> {"André", "Ana", "Felipe"}; // Declarando a variável "names" como uma lista de variáveis que receberá os nomes citados.

names.Add("David");
names.Add("Maria");
names.Add("kaka");

foreach (var name in names[2..4]) //Podemos colocar ranges específicos na lista. Diferentemente do python que utiliza [2:4], em C# utilizamos [2..4]
{
    Console.WriteLine($"Hello {name.ToUpper()}!");  // imprima "Hello (upper name of person)!"  
}

Console.WriteLine(names[0]); //índices começam pelo 0.... Assim como python.
Console.WriteLine(names[^1]); // Diferentemente do python que aceita o "-1" em c# temos que colocar ^1 para identificar que queremos o último (o primeiro de trás pra frente)


// O código acima pode ser escrito por arrays, porém Arrys são IMUTÁVEIS, ou seja, não podemos adicionar, nem removar itens de lá:

var names_1 = new string [] {"André", "Ana", "Felipe"};

names_1 = [..names_1, "Alex"]; // Copiei tudo que estava no primeiro array e criei um novo com 4 slots de memória adicionando o Alex

foreach (var name in names_1) //Podemos colocar ranges específicos na lista. Diferentemente do python que utiliza [2:4], em C# utilizamos [2..4]
{
    Console.WriteLine($"Hello {name.ToUpper()}!");  // imprima "Hello (upper name of person)!"  
}