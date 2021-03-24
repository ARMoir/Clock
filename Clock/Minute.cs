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
            Program.Var.ClockChar[60] = @"M"; 
            Program.Var.ClockChar[82] = @"/"; 
            Program.Var.ClockChar[104] = @"/"; 
        }

        public static void M2()
        {
            Program.Var.ClockChar[85] = @"M"; 
            Program.Var.ClockChar[107] = @"/"; 
            Program.Var.ClockChar[128] = @"/"; 

        }
        public static void M3()
        {
            Program.Var.ClockChar[154] = @"M"; 
            Program.Var.ClockChar[153] = @"-"; 
            Program.Var.ClockChar[152] = @"-"; 
            Program.Var.ClockChar[151] = @"-"; 
        }

        public static void M4()
        {
            Program.Var.ClockChar[223] = @"M"; 
            Program.Var.ClockChar[199] = @"\"; 
            Program.Var.ClockChar[174] = @"\"; 
        }

        public static void M5()
        {

            Program.Var.ClockChar[244] = @"M"; 
            Program.Var.ClockChar[220] = @"\"; 
            Program.Var.ClockChar[196] = @"\"; 
        }
        public static void M6()
        {
            Program.Var.ClockChar[240] = @"M";
            Program.Var.ClockChar[217] = @"|"; 
            Program.Var.ClockChar[194] = @"|"; 
        }

        public static void M7()
        {
            Program.Var.ClockChar[236] = @"M"; 
            Program.Var.ClockChar[214] = @"/"; 
            Program.Var.ClockChar[192] = @"/"; 
        }

        public static void M8()
        {
            Program.Var.ClockChar[211] = @"M"; 
            Program.Var.ClockChar[189] = @"/"; 
            Program.Var.ClockChar[168] = @"/"; 
        }

        public static void M9()
        {
            Program.Var.ClockChar[142] = @"M"; 
            Program.Var.ClockChar[143] = @"-"; 
            Program.Var.ClockChar[144] = @"-"; 
            Program.Var.ClockChar[145] = @"-"; 
        }

        public static void M10()
        {

            Program.Var.ClockChar[73] = @"M"; 
            Program.Var.ClockChar[97] = @"\"; 
            Program.Var.ClockChar[122] = @"\"; 
        }

        public static void M11()
        {
            Program.Var.ClockChar[52] = @"M";
            Program.Var.ClockChar[76] = @"\"; 
            Program.Var.ClockChar[100] = @"\"; 
        }

        public static void M12()
        {
            Program.Var.ClockChar[56] = @"M"; 
            Program.Var.ClockChar[79] = @"|"; 
            Program.Var.ClockChar[102] = @"|"; 
        }
    }
}
