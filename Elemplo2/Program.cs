Console.Title = " Ejemplo2 de vectores con la funcion Length";
double SumaNotas = 0, Promedio;
double[] Notas = { 10, 7.2, 8.5, 9.1, 6.5 };
string[] Alumnos = { " Juan Perez "," Toño ","Chepe "," Rodrigo "," Marisol "};

for (int i = 0; i < Notas.Length; i++)
{
    Console.WriteLine(" \nLa nota de {o} es {1}"+Alumnos[i]+Notas[i]);
}
for (int i = 0; i < Alumnos.Length; i++)
{
    SumaNotas+= Notas[i];
}
Promedio = SumaNotas / 5;
Console.WriteLine("\n La suma de todas las notas es : "+SumaNotas);
Console.WriteLine("\n El promedio de todas las notas es : "+Math.Round(Promedio,2));
Console.ReadKey();