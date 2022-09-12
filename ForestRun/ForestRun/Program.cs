using System;

namespace ForestRun
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            ForestOne one = new ForestOne();
            ForestTwo two = new ForestTwo();
            int i = 0;
            Random ran = new Random();
            Console.SetCursorPosition(one.x, one.y);
            Console.WriteLine('|');
            Console.SetCursorPosition(two.x, two.y);
            Console.WriteLine('|');
            while (run)
            {
                one.Shag(ref ran, ref one.x, ref one.y);
                two.Shag(ref ran, ref two.x, ref two.y);
                Console.ReadKey(true);
            }
            
            //Console.SetCursorPosition(rob.x, rob.y);
            //Console.CursorVisible = false;
            //Console.Write((char)(127));



            Console.ReadKey(true);
        }
    }
}
