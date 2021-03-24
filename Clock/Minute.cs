using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Minute
    {
        public static void SetMinute()
        {
            switch (Program.Globals.Minutes)
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
            Program.Globals.ClockChar[60] = @"M"; 
            Program.Globals.ClockChar[82] = @"/"; 
            Program.Globals.ClockChar[104] = @"/"; 
        }

        public static void M2()
        {
            Program.Globals.ClockChar[85] = @"M"; 
            Program.Globals.ClockChar[107] = @"/"; 
            Program.Globals.ClockChar[128] = @"/"; 

        }
        public static void M3()
        {
            Program.Globals.ClockChar[154] = @"M"; 
            Program.Globals.ClockChar[153] = @"-"; 
            Program.Globals.ClockChar[152] = @"-"; 
            Program.Globals.ClockChar[151] = @"-"; 
        }

        public static void M4()
        {
            Program.Globals.ClockChar[223] = @"M"; 
            Program.Globals.ClockChar[199] = @"\"; 
            Program.Globals.ClockChar[174] = @"\"; 
        }

        public static void M5()
        {

            Program.Globals.ClockChar[244] = @"M"; 
            Program.Globals.ClockChar[220] = @"\"; 
            Program.Globals.ClockChar[196] = @"\"; 
        }
        public static void M6()
        {
            Program.Globals.ClockChar[240] = @"M";
            Program.Globals.ClockChar[217] = @"|"; 
            Program.Globals.ClockChar[194] = @"|"; 
        }

        public static void M7()
        {
            Program.Globals.ClockChar[236] = @"M"; 
            Program.Globals.ClockChar[214] = @"/"; 
            Program.Globals.ClockChar[192] = @"/"; 
        }

        public static void M8()
        {
            Program.Globals.ClockChar[211] = @"M"; 
            Program.Globals.ClockChar[189] = @"/"; 
            Program.Globals.ClockChar[168] = @"/"; 
        }

        public static void M9()
        {
            Program.Globals.ClockChar[142] = @"M"; 
            Program.Globals.ClockChar[143] = @"-"; 
            Program.Globals.ClockChar[144] = @"-"; 
            Program.Globals.ClockChar[145] = @"-"; 
        }

        public static void M10()
        {

            Program.Globals.ClockChar[73] = @"M"; 
            Program.Globals.ClockChar[97] = @"\"; 
            Program.Globals.ClockChar[122] = @"\"; 
        }

        public static void M11()
        {
            Program.Globals.ClockChar[52] = @"M";
            Program.Globals.ClockChar[76] = @"\"; 
            Program.Globals.ClockChar[100] = @"\"; 
        }

        public static void M12()
        {
            Program.Globals.ClockChar[56] = @"M"; 
            Program.Globals.ClockChar[79] = @"|"; 
            Program.Globals.ClockChar[102] = @"|"; 
        }
    }
}
