using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Clock
{
    class Program
    {
        public static class Clock
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
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetWindowSize(21, 14);
            }

            Console.CursorVisible = false;
            Face.SetFace();
            var Time = DateTime.Now;

            do
            {
                Clock.ClockChar.Clear();
                Clock.ClockChar.AddRange(Clock.ClockString.ToString().Select(Chars => Chars.ToString()));

                Time = DateTime.Now;
                Clock.Hours = Time.Hour;
                Clock.Minutes = Time.Minute;
                Clock.Seconds = Time.Second;
                Clock.Minute = Clock.Minutes % 10;

                Minute.SetMinute();
                Hour.SetHour();
                Second.SetSecond();

                Clock.Display.Clear();
                Clock.ClockChar.ForEach(Item => Clock.Display.Append(Item));

                Console.Clear();
                Console.Write(Clock.Display);

                System.Threading.Thread.Sleep(1000);

            } while (true);  
        }
    }
}
