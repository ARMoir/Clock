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
            Program.Var.ClockChar[82] = @"H"; 
            Program.Var.ClockChar[104] = @"/"; 
        }

        public static void H2()
        {
            Program.Var.ClockChar[107] = @"H"; 
            Program.Var.ClockChar[128] = @"/"; 
        }
        public static void H3()
        {
            Program.Var.ClockChar[153] = @"H"; 
            Program.Var.ClockChar[152] = @"-"; 
            Program.Var.ClockChar[151] = @"-";     
        }

        public static void H4()
        {
            Program.Var.ClockChar[199] = @"H"; 
            Program.Var.ClockChar[174] = @"\"; 
        }

        public static void H5()
        {

            Program.Var.ClockChar[220] = @"H"; 
            Program.Var.ClockChar[196] = @"\"; 
        }

        public static void H6()
        {
            Program.Var.ClockChar[217] = @"H"; 
            Program.Var.ClockChar[194] = @"|"; 
        }

        public static void H7()
        {
            Program.Var.ClockChar[214] = @"H"; 
            Program.Var.ClockChar[192] = @"/"; 
        }

        public static void H8()
        {
            Program.Var.ClockChar[189] = @"H"; 
            Program.Var.ClockChar[168] = @"/"; 
        }

        public static void H9()
        {
            Program.Var.ClockChar[143] = @"H"; 
            Program.Var.ClockChar[144] = @"-"; 
            Program.Var.ClockChar[145] = @"-"; 
        }

        public static void H10()
        {
            Program.Var.ClockChar[97] = @"H"; 
            Program.Var.ClockChar[122] = @"\"; 
        }

        public static void H11()
        {
            Program.Var.ClockChar[76] = @"H"; 
            Program.Var.ClockChar[100] = @"\"; 
        }

        public static void H12()
        {
            Program.Var.ClockChar[79] = @"H"; 
            Program.Var.ClockChar[102] = @"|"; 
        }
    }
}
