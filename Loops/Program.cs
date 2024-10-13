// Loop while
/*

// Contador - Forma primária

int counter = 0;
Console.WriteLine("Esta será a forma primária de realizar contagem");
Console.WriteLine(" ");
counter = counter + 1;
Console.WriteLine(counter);
counter = counter + 1;
Console.WriteLine(counter);
counter = counter + 1;
Console.WriteLine(counter);
counter = counter + 1;
Console.WriteLine(counter);
Console.WriteLine(" ");



// // Contador - Forma secundária

int counter_1 = 0;
Console.WriteLine("Esta será a forma secundária de realizar contagem");
Console.WriteLine(" ");
counter_1++;
Console.WriteLine(counter_1);
counter_1++;
Console.WriteLine(counter_1);
counter_1++;
Console.WriteLine(counter_1);
counter_1++;
Console.WriteLine(counter_1);
Console.WriteLine(" ");

// Contador - Forma eficaz e correta

int counter_2 = 0;
Console.WriteLine("Esta será a forma eficaz de realizar contagem");
while (counter_2 <= 4) 
{ // É extremamente necessário utilizar as chaves para definir o que você realmente quer dentro das condições
    Console.WriteLine(counter_2); 
    counter_2++;
}
Console.WriteLine(' ');

// Contador - Forma inusitada e correta

int counter_3 = 0;
Console.WriteLine("Esta será a forma inusitada de realizar contagem");
do
{ // É extremamente necessário utilizar as chaves para definir o que você realmente quer dentro das condições
    Console.WriteLine(counter_3); 
    counter_3++;
}
while (counter_3 <= 4);
*/

//-----------------------------------------------------------------------------//

//Loop for (contador)

int length = 5;
for ( //for loop aguarda 3 comandos dentro dele:
    int i = 0; // Inicializando o for com a variável (índice)
    i < length; // Condição
    i++) // iteração (incremento)
{
   Console.WriteLine(i);
}