internal class MultiplosEj43
{

    /* Escriba una función multiplo que determine para un par de enteros, si el segundo es múltiplo del 
     * primero. La función debe tomar dos argumentos enteros y devolver 1 (verdadero) si el segundo es 
     * un múltiplo del primero, y de lo contrario 0 (falso). Utilice esta función en un programa que 
     * introduzca una serie de pares de enteros.
     */
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine());

        int multiplo = verificaMultiplo(numero1, numero2);
        if (multiplo == 1)
        {
            Console.WriteLine($"El numero {numero1} es multiplo del numero {numero2}");
        }
        else
        {
            Console.WriteLine("Los numeros no son multipos.");

        }

        static int verificaMultiplo(int n1, int n2)
        {
            if ( n1 < n2 )
            {
                if (n2 % n1 == 0)
                    return 1;
            }
           
            if (n1 % n2 == 0)
                return 1;

            else return 0;
        }
        Console.WriteLine("Presione una tecla para finalizar.");
        Console.ReadKey();
    }
}   