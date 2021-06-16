using System;

namespace SintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            //var num = 20;
            //int num2 = 50;
            //Console.WriteLine("Asignación automatica: "+num);
            //Console.WriteLine("Asignación de tipo explicita: "+num2);

            Console.WriteLine("Ingrese un valor numerico");
            int num = int.Parse(Console.ReadLine());

            if(num >= 20){
                Console.WriteLine("Num mayor o igual a  20");
            } else if(num == 0){
                Console.WriteLine("Num igual a 0 ");
            } else if(num >= 20){
                Console.WriteLine("Num menor que 20");
            }

            Console.WriteLine("Num : "+ num);




        }
    }
}
