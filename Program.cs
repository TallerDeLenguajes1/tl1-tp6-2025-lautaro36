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
            int digito = numeroAInvertir % 10;           // Extraer el último dígito (ej: 123 % 10 = 3)
            numeroInvertido = (numeroInvertido * 10) + digito; // Construir el número invertido (ej: 0*10+3=3; 3*10+2=32; 32*10+1=321)
            numeroAInvertir /= 10;                       // Eliminar el último dígito (ej: 123 / 10 = 12)
        }
    }
}

Console.WriteLine($"El numero invertido es: {numeroInvertido}");