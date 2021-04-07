using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Minute
    {
        public static void SetMinute()
        {
            switch (Program.Clock.Minutes)
            {

                case int n when (n >= 55):
                    M11();
                    break;

                case int n when (n >= 50):
                    M10();
                    break;

                case int n when (n >= 45):
                    M9();
                    break;

                case int n when (n >= 40):
                    M8();
                    break;

                case int n when (n >= 35):
                    M7();
                    break;

                case int n when (n >= 30):
                    M6();
                    break;

                case int n when (n >= 25):
                    M5();
                    break;

                case int n when (n >= 20):
                    M4();
                    break;

                case int n when (n >= 15):
                    M3();
                    break;

                case int n when (n >= 10):
                    M2();
                    break;

                case int n when (n >= 5):
                    M1();
                    break;

                case int n when (n >= 0):
                    M12();
                    break;
            }
        }

        public static void M1()
        {
            Program.Clock.ClockChar[60] = @"M"; 
            Program.Clock.ClockChar[82] = @"/"; 
            Program.Clock.ClockChar[104] = @"/"; 
        }

        public static void M2()
        {
            Program.Clock.ClockChar[85] = @"M"; 
            Program.Clock.ClockChar[107] = @"/"; 
            Program.Clock.ClockChar[128] = @"/"; 

        }
        public static void M3()
        {
            Program.Clock.ClockChar[154] = @"M"; 
            Program.Clock.ClockChar[153] = @"-"; 
            Program.Clock.ClockChar[152] = @"-"; 
            Program.Clock.ClockChar[151] = @"-"; 
        }

        public static void M4()
        {
            Program.Clock.ClockChar[223] = @"M"; 
            Program.Clock.ClockChar[199] = @"\"; 
            Program.Clock.ClockChar[174] = @"\"; 
        }

        public static void M5()
        {

            Program.Clock.ClockChar[244] = @"M"; 
            Program.Clock.ClockChar[220] = @"\"; 
            Program.Clock.ClockChar[196] = @"\"; 
        }
        public static void M6()
        {
            Program.Clock.ClockChar[240] = @"M";
            Program.Clock.ClockChar[217] = @"|"; 
            Program.Clock.ClockChar[194] = @"|"; 
        }

        public static void M7()
        {
            Program.Clock.ClockChar[236] = @"M"; 
            Program.Clock.ClockChar[214] = @"/"; 
            Program.Clock.ClockChar[192] = @"/"; 
        }

        public static void M8()
        {
            Program.Clock.ClockChar[211] = @"M"; 
            Program.Clock.ClockChar[189] = @"/"; 
            Program.Clock.ClockChar[168] = @"/"; 
        }

        public static void M9()
        {
            Program.Clock.ClockChar[142] = @"M"; 
            Program.Clock.ClockChar[143] = @"-"; 
            Program.Clock.ClockChar[144] = @"-"; 
            Program.Clock.ClockChar[145] = @"-"; 
        }

        public static void M10()
        {

            Program.Clock.ClockChar[73] = @"M"; 
            Program.Clock.ClockChar[97] = @"\"; 
            Program.Clock.ClockChar[122] = @"\"; 
        }

        public static void M11()
        {
            Program.Clock.ClockChar[52] = @"M";
            Program.Clock.ClockChar[76] = @"\"; 
            Program.Clock.ClockChar[100] = @"\"; 
        }

        public static void M12()
        {
            Program.Clock.ClockChar[56] = @"M"; 
            Program.Clock.ClockChar[79] = @"|"; 
            Program.Clock.ClockChar[102] = @"|"; 
        }
    }
}
