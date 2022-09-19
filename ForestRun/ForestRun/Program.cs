using System;

namespace ForestRun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 60);
            bool run = true;
            ForestOne one = new ForestOne();
            ForestTwo two = new ForestTwo();
            int i = 0;
            //Random ran = new Random();
            Console.SetCursorPosition(one.x-1, one.y);
            Console.Write('|');
            Console.SetCursorPosition(two.x-1, two.y);   
            Console.Write('|');

            while (run)
            {
                
                Console.SetCursorPosition(one.x, one.y);
                one.Shag(ref one.x, ref one.y);
                
                Console.SetCursorPosition(two.x, two.y);
                two.Shag(ref two.x, ref two.y);
                if (run)
                {
                    run = one.endOne();
                }
                if (run)
                {
                    run = two.endTwo();
                }
               
                
                
                Console.ReadKey();
            }
         
        }
    }
}
