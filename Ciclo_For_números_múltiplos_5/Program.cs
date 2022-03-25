// See https://aka.ms/new-console-template for more information
int rango = 0, sumatotal = 0;
Console.WriteLine("Imgrese el rango a evaluar: ");
rango = Int32.Parse(Console.ReadLine());
string mensaje = "";
for (int i = 0; i <= rango; i++)
{
    if (i % 5 ==0)
    {
        Console.WriteLine(i);
    }

}
