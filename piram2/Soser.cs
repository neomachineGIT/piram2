using System;

namespace piram2
{
    internal class Soser
    {
        //NEO-mach
        public void Impre()
        {

            const int ocho = 8;
            long salida;
            long a = 1;
            const int b = 10;
            int c = 2;
            int espacio = 10;
            for (int i = 1; i <= 9; i++)
            {
                salida = a * ocho + i;
                Console.SetCursorPosition(espacio, i);
                Console.WriteLine("{0} x {1} + {2} = {3}", a, ocho, i, salida);
                a = a * b + c;
                c += 1;
                espacio -= 1;

            }
            Console.WriteLine("             NEO-mach");
            Console.ReadKey();
        }
    }
}
