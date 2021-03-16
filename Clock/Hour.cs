using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Hour
    {
        public static void SetHour()
        {
            switch (Program.Var.Hours)
            {
                case 1:
                    H1();
                    break;

                case 2:
                    H2();
                    break;

                case 3:
                    H3();
                    break;

                case 4:
                    H4();
                    break;

                case 5:
                    H5();
                    break;

                case 6:
                    H6();
                    break;

                case 7:
                    H7();
                    break;

                case 8:
                    H8();
                    break;

                case 9:
                    H9();
                    break;

                case 10:
                    H10();
                    break;

                case 11:
                    H11();
                    break;

                case 12:
                    H12();
                    break;
            }
        }

        public static void H1()
        {
            Program.Var.ClockChar[82] = @"H"; //1M
            Program.Var.ClockChar[104] = @"/"; //1M
        }

        public static void H2()
        {
            Program.Var.ClockChar[107] = @"H"; //2M
            Program.Var.ClockChar[128] = @"/"; //2M
        }
        public static void H3()
        {
            Program.Var.ClockChar[153] = @"H"; //3M
            Program.Var.ClockChar[152] = @"-"; //3M
            Program.Var.ClockChar[151] = @"-"; //3M    
        }

        public static void H4()
        {
            Program.Var.ClockChar[199] = @"H"; //4M
            Program.Var.ClockChar[174] = @"\"; //4M
        }

        public static void H5()
        {

            Program.Var.ClockChar[220] = @"H"; //5M
            Program.Var.ClockChar[196] = @"\"; //5M
        }

        public static void H6()
        {
            Program.Var.ClockChar[217] = @"H"; //6M
            Program.Var.ClockChar[194] = @"|"; //6M
        }

        public static void H7()
        {
            Program.Var.ClockChar[214] = @"H"; //7M
            Program.Var.ClockChar[192] = @"/"; //7M
        }

        public static void H8()
        {
            Program.Var.ClockChar[189] = @"H"; //8M
            Program.Var.ClockChar[168] = @"/"; //8M
        }

        public static void H9()
        {
            Program.Var.ClockChar[143] = @"H"; //9M
            Program.Var.ClockChar[144] = @"-"; //9M
            Program.Var.ClockChar[145] = @"-"; //9M
        }

        public static void H10()
        {
            Program.Var.ClockChar[97] = @"H"; //10M
            Program.Var.ClockChar[122] = @"\"; //10M
        }

        public static void H11()
        {
            Program.Var.ClockChar[76] = @"H"; //11M
            Program.Var.ClockChar[100] = @"\"; //11M
        }

        public static void H12()
        {
            Program.Var.ClockChar[79] = @"H"; //12M
            Program.Var.ClockChar[102] = @"|"; //12M
        }
    }
}
