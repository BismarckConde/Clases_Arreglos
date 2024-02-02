double[] Sueldo;
Sueldo = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(" INGRESE EL SUELDO DEL EMPLEANDO "+(i+1));
    Sueldo[i] =double.Parse(Console.ReadLine());
}
Console.WriteLine(" LOS SUELDOS INGRESADOS SON : ");
for (int i = 0; i < 5; i++)
{
    Console.Write("\t"+Sueldo[i]);
}
Console.ReadKey();


