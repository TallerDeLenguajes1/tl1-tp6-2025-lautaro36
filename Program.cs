
Console.WriteLine("Ingrese el numero que desea invertir:");
string entrada = Console.ReadLine();
int numeroAInvertir = 0;
bool esNumero = int.TryParse(entrada, out numeroAInvertir);
int numeroInvertido = 0;

if (esNumero)
{
    if (numeroAInvertir > 0)
    {
        while (numeroAInvertir > 0)
        {
            int digito = numeroAInvertir % 10;           // Extraer el último dígito
            numeroInvertido = (numeroInvertido * 10) + digito; // Construir el número invertido 
            numeroAInvertir /= 10;                       // Eliminar el último dígito
        }
    }
}

Console.WriteLine($"El numero invertido es: {numeroInvertido}");