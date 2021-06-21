using System;

namespace usoClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Color lectorColores = new Color(255, 0, 0);
            lectorColores.nombre="rj";
            Console.WriteLine(lectorColores.nombre);
            Console.WriteLine("Color: "+lectorColores.getRGB());
            Console.WriteLine(""+System.Net.Dns.GetHostName());
            Console.WriteLine(""+System.DateTime.Now);
        }
    }

    public class Color{
        public static readonly Color Red = new Color(255, 0, 0);
        public static readonly Color Green = new Color(0, 255, 0);
        public static readonly Color Blue = new Color(0, 0, 255);

        private byte R{get; set;}
        private byte G{get; set;}
        private byte B{get; set;}

        public string nombre{get; set;}

        public string getRGB(){
            string res = "\nR:"+R+"\nG:"+G+"\nB:"+B;
            return  res;
        }

        public static string info(){
            return "información";
        }

        public Color(byte r, byte g, byte b){
            R = r;
            G = g;
            B = b;
        }
        public Color(){
            R = 0;
            G = 0;
            B = 0;
        }

    }

}
