using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clock
{
    class Program
    {
        public static class Var
        {
            public static List<string> ClockChar { get; set; } = new List<string>();
            public static StringBuilder ClockString { get; set; } = new StringBuilder();
            public static StringBuilder Display { get; set; } = new StringBuilder();
            public static int Hours { get; set; } = 0;
            public static int Minutes { get; set; } = 0;
            public static int Count { get; set; } = 0;
        }

        public static void Main(string[] args)
        {

            Face.SetFace();

            do
            {
                Var.Count++;

                Var.ClockChar.Clear();
                Var.ClockChar.AddRange(Var.ClockString.ToString().Select(Chars => Chars.ToString()));

                Var.Hours = Int32.Parse(DateTime.Now.ToString("hh"));
                Var.Minutes = Int32.Parse(DateTime.Now.ToString("mm"));

                Minute.SetMinute();
                Hour.SetHour();

                Var.Display.Clear();
                Var.ClockChar.ForEach(Item => Var.Display.Append(Item));

                Console.CursorVisible = false;
                Console.Clear();
                Console.Write(Var.Display);

                System.Threading.Thread.Sleep(1000);

            } while (true);
            
        }
    }
}
