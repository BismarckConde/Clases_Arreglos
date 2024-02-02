Console.Title = " Ejemplo4 utilizando la instruccion Foreach";
int[] Edades = new int[5];
int Total = 0;
Edades=new int[5];
for (int i = 0; i < Edades.Length; i++)
{
    Console.WriteLine(" Ingresa la edad del estudiante "+(i+1));
    Edades[i] = int.Parse(Console.ReadLine());
}
foreach (int Element in Edades)
{
    Total+=Element;
}
Console.WriteLine(" La sumatoria de las edades es : "+Total);