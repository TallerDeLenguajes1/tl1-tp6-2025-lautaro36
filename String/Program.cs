Console.WriteLine("Ingrese una cadena de caracteres.");
string entrada = Console.ReadLine();

Console.WriteLine($"El largo de su cadena es: {entrada.Length}");

Console.WriteLine("Ingrese una segunda cadena de caracteres.");
entrada = string.Concat(entrada, " ", Console.ReadLine());
Console.WriteLine($"La cadena concadenada es: {entrada}");

Console.WriteLine($"Ingrese el indice desde el cual quiere empezar la subcadena de la cadena, teniendo en cuenta que su largo es: {entrada.Length}");
int indice;
string indiceEntrada = Console.ReadLine();
int.TryParse(indiceEntrada, out indice);
Console.WriteLine($"La subcadena es: {entrada.Substring(indice)}");

//Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado, realizado en calculadora/program.cs

int i = 1;
foreach (char letra in entrada)
{
    Console.WriteLine($"El caracter {i} es {letra}");
    i++;
}


