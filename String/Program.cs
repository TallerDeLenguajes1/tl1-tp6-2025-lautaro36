using System.Text.RegularExpressions; //using para poder usar la funcion regex.split()
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

int contadorOcurrencias = 0;
int indiceInicio = 0;
Console.WriteLine("Ingrese la palabra que desee encontrar dentro de su cadena:");
string palabraBuscada = Console.ReadLine();

while ((indiceInicio = entrada.ToLower().IndexOf(palabraBuscada.ToLower(), indiceInicio)) != -1)
{
    contadorOcurrencias++;
    indiceInicio += palabraBuscada.Length; // Mueve el índice de inicio más allá de la palabra encontrada
}

if (contadorOcurrencias >= 1)
{
    Console.WriteLine($"La palabra fue encontrada {contadorOcurrencias} veces en su cadena.");
}
else
{
    Console.WriteLine($"La palabra no fue encontrada en su cadena.");
}
Console.WriteLine($"Su cadena en mayusculas es: {entrada.ToUpper()}.\nSu cadena en minusculas es: {entrada.ToLower()}.");

string listaPerros = "Rocco,Tobi,Cabeza";
char delimitador = ',';

string[] misPerros = listaPerros.Split(delimitador);

Console.WriteLine("Mis perros <3 :");
foreach (string perro in misPerros)
{
    Console.WriteLine($"- {perro}");
}

Console.WriteLine("Ingrese una operacion simple de dos numeros:");
entrada = Console.ReadLine();
string delimitadores = "([-+*/])";
string[] operacion = Regex.Split(entrada, delimitadores);
double valor1, valor2, resultado;

switch (operacion[1])
{
    case "+":
        double.TryParse(operacion[0], out valor1);
        double.TryParse(operacion[2], out valor2);
        resultado = valor1 + valor2;
        Console.WriteLine($"El resultado de la suma es: {resultado}");
        break;
    case "-":
        double.TryParse(operacion[0], out valor1);
        double.TryParse(operacion[2], out valor2);
        resultado = valor1 - valor2;
        Console.WriteLine($"El resultado de la resta es: {resultado}");
        break;
    case "*":
        double.TryParse(operacion[0], out valor1);
        double.TryParse(operacion[2], out valor2);
        resultado = valor1 * valor2;
        Console.WriteLine($"El resultado del producto es: {resultado}");
        break;
    case "/":
        double.TryParse(operacion[0], out valor1);
        double.TryParse(operacion[2], out valor2);
        resultado = valor1 / valor2;
        Console.WriteLine($"El resultado de la division es: {resultado}");
        break;
}