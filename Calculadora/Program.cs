using System;
int bandera = 1;

while (bandera == 1)
{
    Console.WriteLine("Elija la operacion que desea realizar:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Producto");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Operaciones especiales.");
    Console.WriteLine("6. Mayor o menor entre dos numeros.");
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
        case 5:
            Console.WriteLine("Ingrese un numero:");
            entrada = Console.ReadLine();
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
            break;
        case 6:
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
            break;
    }
    Console.WriteLine("Desea realizar otra operacion sobre el resultado?\n1.Si\n2.No");
    entrada = Console.ReadLine();
    int.TryParse(entrada, out bandera);
}


