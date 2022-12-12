using System.Diagnostics;

namespace ArrowName
{
    public class Arrows
    {
        public static int max;
        public static int min;
        public Arrows(int _min, int _max)
        {
            max = _max;
            min = _min;
        }
    
        public void ShowArrow(int mincoord, int step, string selector, List<string> _dirs)
        {
            int coord = mincoord;
            List<string> dirs = _dirs;
            int counter = 0;
            while (true)
            {
                
                Console.SetCursorPosition(0, coord);
                Console.WriteLine(selector);
                ConsoleKeyInfo key = Console.ReadKey();
                if (coord == 0)
                {
                    counter = 0;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (coord - step >= min)
                    {
                        Console.SetCursorPosition(0, coord);
                        Console.WriteLine("  ");
                        coord -= step;
                        counter += 1;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (coord + step < max)
                    {
                        Console.SetCursorPosition(0, coord);
                        Console.WriteLine("  ");
                        coord += step;
                        if (counter - 1 > 0)
                        {
                            counter -= 1;
                        }

                    }
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                }
            }
        }
    }
}