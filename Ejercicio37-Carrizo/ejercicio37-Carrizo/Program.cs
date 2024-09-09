using System;

internal class NumeroPrimoEj37
{
    private static void Main(string[] args)
    {

        /* Se dice que un entero es primo si sólo es divisible entre 1 y entre sí mismo. Por ejemplo, 2, 3, 5 y 7 
           son primos, pero 4, 6, 8 y 9 no lo son. Escriba una función que determine si un número es primo. */
        
        Console.WriteLine("Ingrese un numero entero para verificar si es primo: ");
        int numero = 1;
        numero = int.Parse(s: Console.ReadLine());
        int divisor = 1, contador = 0;
        while( divisor <= numero)
        {
            if( numero % divisor == 0)
            {
                contador++;
            }
            divisor++;

        }
        if( contador == 2 )
        {
            Console.WriteLine("El numero es primo.");
        }
        else
        {
            Console.WriteLine("El numero no es primo");
        }
        Console.WriteLine("Presione una tecla para finalizar.");
        Console.ReadKey();
    }

}