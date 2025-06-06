using System;

Console.WriteLine("Ingrese un numero:");
string entrada = Console.ReadLine();
double numero;
double.TryParse(entrada, out numero);

Console.WriteLine($"El valor absoluto es: {Math.Abs(numero)}");
Console.WriteLine($"El cuadrado es: {Math.Pow(numero, 2)}");
if (numero >= 0)
{
    Console.WriteLine($"La raiz cuadrada es: {Math.Sqrt(numero)}");
}
else
{
    Console.WriteLine("Para calcular su raiz cuadrada, el numero debe ser mayor o igual a 0.");
}
Console.WriteLine($"El seno es: {Math.Sin(numero)}");
Console.WriteLine($"EL coseno es: {Math.Cos(numero)}");
if (numero % 1 != 0)
{
    Console.WriteLine($"Su parte entera es {(int)numero}");
}

Console.WriteLine("Ingrese un primer numero:");
entrada = Console.ReadLine();
double primero;
double.TryParse(entrada, out primero);
Console.WriteLine("Ahora ingrese un segundo numero:");
entrada = Console.ReadLine();
double segundo;
double.TryParse(entrada, out segundo);

if (primero > segundo)
{
    Console.WriteLine($"El maximo entre los dos numeros es: {primero}");
    Console.WriteLine($"El minimo entre los dos numeros es: {segundo}");
}
else if (segundo > primero)
{
    Console.WriteLine($"El maximo entre los dos numeros es: {segundo}");
    Console.WriteLine($"El minimo entre los dos numeros es: {primero}");
}
else
{
    Console.WriteLine($"Los numeros ingresados son iguales.");
}