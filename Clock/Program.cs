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
            public static int Minute { get; set; } = 0;
            public static int Seconds { get; set; } = 0;
        }

        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Face.SetFace();

            do
            {
                Var.ClockChar.Clear();
                Var.ClockChar.AddRange(Var.ClockString.ToString().Select(Chars => Chars.ToString()));

                Var.Hours = DateTime.Now.Hour;
                Var.Minutes = DateTime.Now.Minute;
                Var.Seconds = DateTime.Now.Second;
                Var.Minute = Var.Minutes % 10;

                Minute.SetMinute();
                Hour.SetHour();
                Second.SetSecond();

                Var.Display.Clear();
                Var.ClockChar.ForEach(Item => Var.Display.Append(Item));

                Console.Clear();
                Console.Write(Var.Display);

                System.Threading.Thread.Sleep(1000);

            } while (true);
            
        }
    }
}
