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
            Console.Write('|');
            var forestOne = '#';
            Console.Write(forestOne);
            Console.SetCursorPosition(two.x, two.y);
            var forestTwo = '@';
            Console.Write('|');
            Console.Write(forestTwo);
            while (run)
            {
                one.Shag(ref ran, ref one.x, ref one.y);
                two.Shag(ref ran, ref two.x, ref two.y);

                Console.WriteLine(one.count);
                Console.ReadKey();
            }
            
            //Console.SetCursorPosition(rob.x, rob.y);
            //Console.CursorVisible = false;
            //Console.Write((char)(127));



            Console.ReadKey(true);
        }
    }
}
