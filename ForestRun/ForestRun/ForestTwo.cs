using System;
using System.Collections.Generic;
using System.Text;

namespace ForestRun
{
    class ForestTwo
    {
        public int x = 18;
        public int y = 7;
        public int count = 0;   
        
        public void Shag(ref Random ran, ref int x, ref int y)
        {

            if((x >= 18 && x < 88) && y == 7)
                {
                Console.SetCursorPosition(x += ran.Next(0, 4), y);
                if (x > 88)
                {
                    x = 88;
                }
                Console.Write((char)(16));//17 30 31
                
               
            }
            else if ( x == 88 && (y >= 7 && y < 40))
            {
                Console.SetCursorPosition(x, y+= ran.Next(0, 4));
                Console.Write((char)(17));//17 30 31

            }


        }
    }
}
