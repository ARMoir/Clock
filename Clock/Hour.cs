using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Hour
    {
        public static void SetHour()
        {
            if(Program.Globals.Hours > 12)
            {
                Program.Globals.Hours = Program.Globals.Hours - 12;
            }

            switch (Program.Globals.Hours)
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
            Program.Globals.ClockChar[82] = @"H"; 
            Program.Globals.ClockChar[104] = @"/"; 
        }

        public static void H2()
        {
            Program.Globals.ClockChar[107] = @"H"; 
            Program.Globals.ClockChar[128] = @"/"; 
        }
        public static void H3()
        {
            Program.Globals.ClockChar[153] = @"H"; 
            Program.Globals.ClockChar[152] = @"-"; 
            Program.Globals.ClockChar[151] = @"-";     
        }

        public static void H4()
        {
            Program.Globals.ClockChar[199] = @"H"; 
            Program.Globals.ClockChar[174] = @"\"; 
        }

        public static void H5()
        {

            Program.Globals.ClockChar[220] = @"H"; 
            Program.Globals.ClockChar[196] = @"\"; 
        }

        public static void H6()
        {
            Program.Globals.ClockChar[217] = @"H"; 
            Program.Globals.ClockChar[194] = @"|"; 
        }

        public static void H7()
        {
            Program.Globals.ClockChar[214] = @"H"; 
            Program.Globals.ClockChar[192] = @"/"; 
        }

        public static void H8()
        {
            Program.Globals.ClockChar[189] = @"H"; 
            Program.Globals.ClockChar[168] = @"/"; 
        }

        public static void H9()
        {
            Program.Globals.ClockChar[143] = @"H"; 
            Program.Globals.ClockChar[144] = @"-"; 
            Program.Globals.ClockChar[145] = @"-"; 
        }

        public static void H10()
        {
            Program.Globals.ClockChar[97] = @"H"; 
            Program.Globals.ClockChar[122] = @"\"; 
        }

        public static void H11()
        {
            Program.Globals.ClockChar[76] = @"H"; 
            Program.Globals.ClockChar[100] = @"\"; 
        }

        public static void H12()
        {
            Program.Globals.ClockChar[79] = @"H"; 
            Program.Globals.ClockChar[102] = @"|"; 
        }
    }
}
