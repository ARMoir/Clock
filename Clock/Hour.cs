using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Hour
    {
        public static void SetHour()
        {
            if(Program.Clock.Hours > 12)
            {
                Program.Clock.Hours -= 12;
            }

            switch (Program.Clock.Hours)
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
            Program.Clock.ClockChar[82] = @"H"; 
            Program.Clock.ClockChar[104] = @"/"; 
        }

        public static void H2()
        {
            Program.Clock.ClockChar[107] = @"H"; 
            Program.Clock.ClockChar[128] = @"/"; 
        }
        public static void H3()
        {
            Program.Clock.ClockChar[153] = @"H"; 
            Program.Clock.ClockChar[152] = @"-"; 
            Program.Clock.ClockChar[151] = @"-";     
        }

        public static void H4()
        {
            Program.Clock.ClockChar[199] = @"H"; 
            Program.Clock.ClockChar[174] = @"\"; 
        }

        public static void H5()
        {

            Program.Clock.ClockChar[220] = @"H"; 
            Program.Clock.ClockChar[196] = @"\"; 
        }

        public static void H6()
        {
            Program.Clock.ClockChar[217] = @"H"; 
            Program.Clock.ClockChar[194] = @"|"; 
        }

        public static void H7()
        {
            Program.Clock.ClockChar[214] = @"H"; 
            Program.Clock.ClockChar[192] = @"/"; 
        }

        public static void H8()
        {
            Program.Clock.ClockChar[189] = @"H"; 
            Program.Clock.ClockChar[168] = @"/"; 
        }

        public static void H9()
        {
            Program.Clock.ClockChar[143] = @"H"; 
            Program.Clock.ClockChar[144] = @"-"; 
            Program.Clock.ClockChar[145] = @"-"; 
        }

        public static void H10()
        {
            Program.Clock.ClockChar[97] = @"H"; 
            Program.Clock.ClockChar[122] = @"\"; 
        }

        public static void H11()
        {
            Program.Clock.ClockChar[76] = @"H"; 
            Program.Clock.ClockChar[100] = @"\"; 
        }

        public static void H12()
        {
            Program.Clock.ClockChar[79] = @"H"; 
            Program.Clock.ClockChar[102] = @"|"; 
        }
    }
}
