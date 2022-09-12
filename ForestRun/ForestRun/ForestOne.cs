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

        public void Shag(ref Random ran, ref int x, ref int y)
        {
            if ((x >= 20 && x <= 90) && y == 5)
            {
                Console.SetCursorPosition(x += ran.Next(0, 4), y);
                Console.Write((char)(16));
            }

        }
    }
}
