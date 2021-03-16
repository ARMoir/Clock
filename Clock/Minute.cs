using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Minute
    {
        public static void SetMinute()
        {
            switch (Program.Var.Minutes)
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
            Program.Var.ClockChar[60] = @"M"; //1M
            Program.Var.ClockChar[82] = @"/"; //1M
            Program.Var.ClockChar[104] = @"/"; //1M
        }

        public static void M2()
        {
            Program.Var.ClockChar[85] = @"M"; //2M
            Program.Var.ClockChar[107] = @"/"; //2M
            Program.Var.ClockChar[128] = @"/"; //2M

        }
        public static void M3()
        {
            Program.Var.ClockChar[154] = @"M"; //3M
            Program.Var.ClockChar[153] = @"-"; //3M
            Program.Var.ClockChar[152] = @"-"; //3M
            Program.Var.ClockChar[151] = @"-"; //3M    
        }

        public static void M4()
        {
            Program.Var.ClockChar[223] = @"M"; //4M
            Program.Var.ClockChar[199] = @"\"; //4M
            Program.Var.ClockChar[174] = @"\"; //4M
        }

        public static void M5()
        {

            Program.Var.ClockChar[244] = @"M"; //5M
            Program.Var.ClockChar[220] = @"\"; //5M
            Program.Var.ClockChar[196] = @"\"; //5M
        }
        public static void M6()
        {
            Program.Var.ClockChar[240] = @"M"; //6M
            Program.Var.ClockChar[217] = @"|"; //6M
            Program.Var.ClockChar[194] = @"|"; //6M
        }

        public static void M7()
        {
            Program.Var.ClockChar[236] = @"M"; //7M
            Program.Var.ClockChar[214] = @"/"; //7M
            Program.Var.ClockChar[192] = @"/"; //7M
        }

        public static void M8()
        {
            Program.Var.ClockChar[211] = @"M"; //8M
            Program.Var.ClockChar[189] = @"/"; //8M
            Program.Var.ClockChar[168] = @"/"; //8M
        }

        public static void M9()
        {
            Program.Var.ClockChar[142] = @"M"; //9M
            Program.Var.ClockChar[143] = @"-"; //9M
            Program.Var.ClockChar[144] = @"-"; //9M
            Program.Var.ClockChar[145] = @"-"; //9M
        }

        public static void M10()
        {

            Program.Var.ClockChar[73] = @"M"; //10M
            Program.Var.ClockChar[97] = @"\"; //10M
            Program.Var.ClockChar[122] = @"\"; //10M
        }

        public static void M11()
        {
            Program.Var.ClockChar[52] = @"M"; //11M
            Program.Var.ClockChar[76] = @"\"; //11M
            Program.Var.ClockChar[100] = @"\"; //11M
        }

        public static void M12()
        {
            Program.Var.ClockChar[56] = @"M"; //12M
            Program.Var.ClockChar[79] = @"|"; //12M
            Program.Var.ClockChar[102] = @"|"; //12M
        }
    }
}
