using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clock
{
    class Program
    {
        public static class Globals
        {
            public static List<string> ClockChar { get; set; } = new List<string>();
            public static StringBuilder ClockString { get; set; } = new StringBuilder();
            public static StringBuilder Display { get; set; } = new StringBuilder();
            public static int Hours { get; set; } = 0;
            public static int Minutes { get; set; } = 0;
            public static int Minute { get; set; } = 0;
            public static int Seconds { get; set; } = 0;
        }

        public static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Face.SetFace();

            do
            {
                Globals.ClockChar.Clear();
                Globals.ClockChar.AddRange(Globals.ClockString.ToString().Select(Chars => Chars.ToString()));

                Globals.Hours = DateTime.Now.Hour;
                Globals.Minutes = DateTime.Now.Minute;
                Globals.Seconds = DateTime.Now.Second;
                Globals.Minute = Globals.Minutes % 10;

                Minute.SetMinute();
                Hour.SetHour();
                Second.SetSecond();

                Globals.Display.Clear();
                Globals.ClockChar.ForEach(Item => Globals.Display.Append(Item));

                Console.Clear();
                Console.Write(Globals.Display);

                System.Threading.Thread.Sleep(1000);

            } while (true);  
        }
    }
}
