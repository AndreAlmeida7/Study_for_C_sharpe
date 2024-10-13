//Condicionais, IFs 

int number_a = 5;
int number_b = 3;
int sum_a_b = number_a + number_b;

if (sum_a_b > 10 && number_a > 5) // && refere-se a lógica "e", "and"
{ // É sempre recomendado colocar chaves entre o argumento de if e else. Significa ser mais explícito e direcional com seus comandos
    Console.WriteLine($"The answer {sum_a_b} is greater than 10"); 
    Console.WriteLine("And number a is number 5"); 
} 
else
{
    Console.WriteLine($"The answer {sum_a_b} is less than 10");
    Console.WriteLine("Or the number a is not number 5"); 
}

if (sum_a_b > 10 || number_a > 5) // || refere-se a lógica "ou", "or"
{ // É sempre recomendado colocar chaves entre o argumento de if e else. Significa ser mais explícito e direcional com seus comandos
    Console.WriteLine($"The answer {sum_a_b} is greater than 10"); 
    Console.WriteLine("Or number a is number 5"); 
} 
else
{
    Console.WriteLine($"The answer {sum_a_b} is less than 10");
    Console.WriteLine("And the number a is not number 5"); 
}


