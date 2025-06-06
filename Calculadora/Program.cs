int bandera = 1;

while (bandera == 1)
{
    Console.WriteLine("Elija la operacion que desea realizar:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Producto");
    Console.WriteLine("4. Division");
    string entrada = Console.ReadLine();
    int operacion = 0;
    bool conversion = int.TryParse(entrada, out operacion);

    double primerValor;
    double segundoValor;

    switch (operacion)
    {
        case 1:
            Console.WriteLine("Ingrese el primer valor:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out primerValor);
            Console.WriteLine("Ingrese el segundo valor:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out segundoValor);
            primerValor += segundoValor;
            Console.WriteLine($"El resultado de la suma es: {primerValor}");
            break;
        case 2:
            Console.WriteLine("Ingrese el primer valor:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out primerValor);
            Console.WriteLine("Ingrese el segundo valor:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out segundoValor);
            primerValor -= segundoValor;
            Console.WriteLine($"El resultado de la resta es: {primerValor}");
            break;
        case 3:
            Console.WriteLine("Ingrese el primer valor:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out primerValor);
            Console.WriteLine("Ingrese el segundo valor:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out segundoValor);
            primerValor *= segundoValor;
            Console.WriteLine($"El resultado del producto es: {primerValor}");
            break;
        case 4:
            Console.WriteLine("Ingrese el primer valor:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out primerValor);
            Console.WriteLine("Ingrese el segundo valor:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out segundoValor);
            primerValor /= segundoValor;
            Console.WriteLine($"El resultado de la division es: {primerValor}");
            break;
    }
    Console.WriteLine("Desea realizar otra operacion sobre el resultado?\n1.Si\n2.No");
    entrada = Console.ReadLine();
    int.TryParse(entrada, out bandera);
}


