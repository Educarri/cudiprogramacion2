using System;

internal class NumeroPerfectoEj36
{
    private static void Main(string[] args)
    {
        bool perf = false; //defino una variable para verificar si un numero es perfecto.

       //Consultar como evitar Posible NULL

        for (int i=1; i < 1000 ; i++)
        {
            perf = CheckNumberPerfect(i);
              
            if (perf)
            {
                Console.WriteLine($"El numero {i} es Perfecto!");
                factoresNumPerfect(i);
            }
            
        }
        Console.WriteLine("Presione una tecla para finalizar.");
        Console.ReadKey();
    }

    static bool CheckNumberPerfect(int num)
        {
            int sumador = 0;
            bool perfecto = false;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sumador = sumador + i;
                    //Console.WriteLine("El numero " + i.ToString() + "es" + sumador);
                }
            }

            if (sumador == num)
            {
                perfecto = true;
                //Console.WriteLine($"El numero {numPerfecto} es Perfecto!");
            }
            return perfecto;
        }

        static void factoresNumPerfect(int num)
        {
            //En esta funcion obtengo los factores del numero perfecto que encuentra la funcion CheckNumberPerfect.
            //Esta funcion solo imprime los valores, es un funcion void.
        
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("El numero " + i.ToString() + " es factor de: " + num);
                }
            }

        }
}
