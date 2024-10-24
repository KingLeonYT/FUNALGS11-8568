Console.WriteLine("Ingrese una cantidad de elementos: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    numeros[i] = rnd.Next(50, 89 + 1);
}
string todos = string.Join(",", numeros);
Console.WriteLine($"Numeros {todos}");
string op;
int pares, impares, cp=0 , ci=0,Cont=0;
Console.WriteLine("Prefiere saber la cantidad de números pares o impares(P/I)");
op = Console.ReadLine().ToLower();
if (op == "p")
{
    int i = 0;
    if ((pares = numeros[i] % 2) == 0)
    {
        Cont = cp + 1;
        cp = cp + 1;
        
    }
    Console.WriteLine($"La cantidad de números pares son de {Cont}");
}
else if (op == "i")
{
    int b;
    int i = 0;
    for (b = 0; b < n; b++)
    {
        Console.WriteLine(numeros[ i]);
        
    }
    
    Console.WriteLine(ci);
    if (ci != 0)
    {
        Cont = Cont + 1;
    }

    Console.WriteLine($"La cantidad de números impares son de {Cont}");

}