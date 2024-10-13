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

