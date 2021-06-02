using System;

namespace DO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.BackgroundColor = ConsoleColor.Black;
            int fStone = 0, kHo = 0, gYear = 0;
            int medidaRinfStone, rinMayorfStone = 0, medidaRinkHo, rinMayorkHo = 0, medidaRinGyear, rinMayorGyear = 0;
            int contador=0; //CONTADOR 2
            string marcaNeu;
            do
            {
                Console.WriteLine("Ingrese la marca del neumatico (ingresar en mayusculas)");
                marcaNeu = Console.ReadLine();
                if (marcaNeu == "FIRESTONE")
                {
                    fStone++;
                    Console.WriteLine("Ingrese ingrese el número de rin");
                    medidaRinfStone = int.Parse(Console.ReadLine());
                    if (medidaRinfStone > 15)
                    {
                        rinMayorfStone++;
                        contador++;
                    }
                }
                else if (marcaNeu == "KUMHO")
                {
                    kHo++;
                    Console.WriteLine("Ingrese ingrese el número de rin");
                    medidaRinkHo = int.Parse(Console.ReadLine());
                    if (medidaRinkHo > 15)
                    {
                        rinMayorkHo++;
                        contador++;
                    }
                }
                else if (marcaNeu == "GOODYEAR")//con condicion
                {
                    gYear++;
                    Console.WriteLine("Ingrese ingrese el número de rin");
                    medidaRinGyear = int.Parse(Console.ReadLine());
                    if (medidaRinGyear > 15)
                    {
                        rinMayorGyear++;
                        contador++;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\tLa marca ingresada no se encuetra registrada en el sistema");                    
                    Console.WriteLine("\tIngrese una marca disponible");
                    Console.WriteLine();
                }

            } while (contador!=3);
            Console.WriteLine($"Ha ingresado {contador} de veces, datos validos");
            Console.WriteLine($"Hemos encontrado lo siguiente para la marca FIRESTONE: {fStone} unidades en stock, de las cuales {rinMayorfStone} son rin mayor a 15'' ");
            Console.WriteLine($"Hemos encontrado lo siguiente para la marca KUMHO: {kHo} unidades en stock, de las cuales {rinMayorkHo} son rin mayor a 15'' ");
            Console.WriteLine($"Hemos encontrado lo siguiente para la marca GOODYEAR: {gYear} unidades en stock, de las cuales {rinMayorGyear} son rin mayor a 15'' ");

            Console.WriteLine("\n"); 
        }
    }
}

