using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //tuleb kasutada while ja omakorda while whiel sisse panna
            //while nesting 
            //White kordab ennast 5 korda
            //kui kood valmis,siis teha vooskeem

            Console.WriteLine("While nesting");

            int a = 1;
            //kasutada while while sees

            while (a <= 5)
            {
                int b = 1;

                while (b <= 5)
                {
                    Console.Write(b+ " ");
                    b++;
                }

                Console.WriteLine();
                a++;
            }
        }
    }
}
