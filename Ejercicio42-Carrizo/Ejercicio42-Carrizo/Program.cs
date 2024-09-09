internal class Reloj12Ej42
{
    private static void Main(string[] args)
    {
        int segundosHora1, segundosHora2; //Defino 2 variables para convertir hora y minutos a segundos.
        Console.WriteLine("Ingrese la primer horas minutos y segundos: ");
        segundosHora1 = ingresoHoras();
        Console.WriteLine("Ingrese la segunda hora, minutos y segundos: ");
        segundosHora2 = ingresoHoras();

        //Realizo la resta entre las 2 variables en segudos.
        if (segundosHora2 < segundosHora1)
        {
            Console.WriteLine("La diferencia entre las dos es: " + (segundosHora1 - segundosHora2));
        }
        else
        {
            Console.WriteLine("La diferencia entre las dos es: " + (segundosHora2 - segundosHora1));
        }
        //Los separo en 2 variables por si la segunda variables es menor a la primera
        //y que el resultado no me de en formato negativo

        Console.WriteLine("Presione una tecla para finalizar.");
        Console.ReadKey();
    }

    static int ingresoHoras()
    {
        Console.WriteLine("Ingrese la hora: ");
        int horas = int.Parse(s: Console.ReadLine());
        Console.WriteLine("Ingrese los minutos: ");
        int minutos = int.Parse(s: Console.ReadLine());
        Console.WriteLine("Ingrese los segundos: ");
        int segundos = int.Parse(s: Console.ReadLine());

        return horas * 3600 + minutos * 60 + segundos;
    }
}