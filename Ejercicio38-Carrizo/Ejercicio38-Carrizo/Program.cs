internal class PrimosEJ38
{

    /* - Utilice esta función en un programa que determine e imprima todos los números primos *
     * entre 1 y 10,000. ¿Cuántos de estos 10,000 números tiene que verificar realmente       *
     * antes de que esté seguro de que encontró todos los números primos? -                   */          
    private static void Main(string[] args)
    {
        //Defino las variables que voy a utilizar, ingreso a un while para vericar cuantos numeros
        //primos hay en X cantidad de numeros enteros.

        int contador = 0, numero = 1;
        while (numero <= 10000)
        {
            contador += valPrimo(numero);
            numero++;

        }
        Console.WriteLine("Hay " + contador + " numeros primos.");
        Console.WriteLine("Presione una tecla para finalizar.");
        Console.ReadKey();
    }

    static int valPrimo(int numero)
    {

        // Defino funcion y verifico si el numero es primo.
        //Si es primo, lo imprimo y devuelvo un 1 para sumar a la cantidad de numeros primos encontrados.
        int divisor = 1, contador = 0;
        while (divisor <= numero)
        {
            if (numero % divisor == 0)
            {
                contador++;
            }
            divisor++;

        }
        if (contador == 2)
        {
            Console.WriteLine($"El numero {numero} es primo.");
            return 1;
        }
        return 0;
    }
}
