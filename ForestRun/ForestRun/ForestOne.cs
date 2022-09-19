using System;
using System.Collections.Generic;
using System.Text;

namespace ForestRun
{
    class ForestOne
    {
        public int x = 20;
        public int y = 5;
        public int count = 0;
        public bool up = false;
        public bool down = false;
        public bool left = false;
        public bool right = true;
        Random ran = new Random();
        public void Shag(ref int x, ref int y)
        {
            if (x >= 10 && y == 5 && right)
            {
                if (x >= 15 && x <= 18)
                {
                    count++;
                    right = false;
                }
                if (x >= 60)
                {
                    Console.WriteLine(' ');
                    x = 60;
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
            else if (x == 60 && y >= 5 && down)
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
            else if (x <= 60 && y == 24 && left)
            {
                if (x <= 10)
                {
                    Console.WriteLine(' ');
                    x = 10;
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
            else if (x == 10  && y <= 24 && up)
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

        public bool endOne()
        {
            if (count == 1)
            {
                Console.SetCursorPosition(x += 30, y += 50);
                Console.WriteLine("Перавая лошадь выиграла!");
                return false;
            }
            return true;
        }
    }
}
