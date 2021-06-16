using System;

namespace usoMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 50;
            Console.WriteLine(suma (a, b));
            
        }

        static int suma(int a, int b){
            var result  = a + b;
            return result;
        }


        static int sumaF(int a, int b)=>a+b; // Operador flecha
        static int sumaF(int a, int b, int c)=>a+b+c;//Flecha + sobrecarca



    }
}


