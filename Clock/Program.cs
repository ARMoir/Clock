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
            //Resize Window in Windows
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetWindowSize(22, 14);
            }

            //Setup the Clock Face
            Console.Clear();
            Console.CursorVisible = false;
            Face.SetFace();

            //Clock Loop
            do
            {
                //Populate ClockChar
                Clock.ClockChar.Clear();
                Clock.ClockChar.AddRange(Clock.ClockString.ToString().Select(Chars => Chars.ToString()));

                //Get the Current Time
                var Time = DateTime.Now;
                Clock.Hours = Time.Hour;
                Clock.Minutes = Time.Minute;
                Clock.Seconds = Time.Second;
                Clock.Minute = Clock.Minutes % 10;

                //Set time to Clock
                Minute.SetMinute();
                Hour.SetHour();
                Second.SetSecond();

                //Populate Display values
                Clock.Display.Clear();
                Clock.ClockChar.ForEach(Item => Clock.Display.Append(Item));

                //Write Dsplay to Console
                Console.SetCursorPosition(0, 0);
                Console.Write(Clock.Display);

                //Wait one Second
                System.Threading.Thread.Sleep(1000);

            } while (true);  
        }
    }
}
