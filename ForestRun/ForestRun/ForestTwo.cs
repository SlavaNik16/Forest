using System;
using System.Collections.Generic;
using System.Text;

namespace ForestRun
{
    class ForestTwo
    {
        public int x = 80;
        public int y = 5;
        public int count = 0;
        public bool up = false;
        public bool down = false;
        public bool left = false;
        public bool right = true;
        Random ran = new Random();

        public void Shag(ref int x, ref int y)
        {

            if (x >= 70 && y == 5 && right)
            {
                if(x >= 75 && x <= 78)
                {
                    count++;                 
                    right = false;
                }
                if (x >= 120)
                {
                    Console.WriteLine(' ');
                    x = 120;
                    Console.SetCursorPosition(x, y);
                    right = false;
                    down = true;
                }
                else
                {
                    Console.SetCursorPosition(x += ran.Next(0, 4), y);
                    Console.Write((char)(16));
                }
                
            }
            else if (x == 120 && y >= 5 && down)
            {
                if (y >= 24)
                {
                    Console.WriteLine(' ');
                    y = 24;
                    Console.SetCursorPosition(x, y);
                    down = false;
                    left = true;
                }
                else
                {
                    Console.SetCursorPosition(x, y += ran.Next(0, 4));
                    Console.Write((char)(31));//17 30 31
                }


            }
            else if (x <= 120 && y == 24 && left)
            {
                if (x <= 70)
                {
                    Console.WriteLine(' ');
                    x = 70;
                    Console.SetCursorPosition(x, y);
                    left = false;
                    up = true;
                }
                else
                {
                    Console.SetCursorPosition(x -= ran.Next(0, 4), y);
                    Console.Write((char)(17));//17 30 31
                }


            }
            else if (x == 70 && y <= 24 && up)
            {
                if (y <= 5)
                {
                    Console.WriteLine(' ');
                    y = 5;
                    Console.SetCursorPosition(x, y);
                    up = false;
                    right = true;
                }
                else
                {
                    Console.SetCursorPosition(x, y -= ran.Next(0, 4));
                    Console.Write((char)(30));//17 30 31
                }
            }
           
        }
        public bool endTwo()
        {
            if (count == 1)
            {
                Console.SetCursorPosition(x -= 30, y += 30);
                Console.WriteLine("Вторая лошадь выиграла!");
                return false;
            }
            return true;
        }
    }
}
