Console.WriteLine("Ingrese una cantidad de elementos: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];
Random rnd = new Random();
for ( int i=0; i < n; i++)
{
    numeros[i] = rnd.Next(50, 89 + 1);
}
string todos = string.Join(",", numeros);
Console.WriteLine($"Numeros {todos}");
string op;
int pares=0, impares=0;
Console.WriteLine("Prefiere saber la cantidad de números pares o impares(P/I)");
op = Console.ReadLine().ToLower();
if (op == "p")
{
    pares = numeros[i] % 2 = 0;

}
else if (op == "i")
{
    impares = numeros % [i] != 0;

}

