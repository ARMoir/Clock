using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Second
    {
        public static void SetSecond()
        {

            if (Program.Globals.Seconds % 2 == 0)
            {
                switch (Program.Globals.Minute)
                {
                    case 0:
                        S0();
                        break;

                    case 1:
                        S1();
                        break;

                    case 2:
                        S2();
                        break;

                    case 3:
                        S3();
                        break;

                    case 4:
                        S4();
                        break;

                    case 5:
                        S5();
                        break;

                    case 6:
                        S6();
                        break;

                    case 7:
                        S7();
                        break;

                    case 8:
                        S8();
                        break;

                    case 9:
                        S9();
                        break;
                }
            }
        }

        public static void S1()
        {
            Program.Globals.ClockChar[37] = @"*"; 
        }

        public static void S2()
        {
            Program.Globals.ClockChar[86] = @"*"; 
        }

        public static void S3()
        {
            Program.Globals.ClockChar[155] = @"*";
        }

        public static void S4()
        {
            Program.Globals.ClockChar[224] = @"*";
        }

        public static void S5()
        {
            Program.Globals.ClockChar[267] = @"*";
        }

        public static void S6()
        {
            Program.Globals.ClockChar[263] = @"*";
        }

        public static void S7()
        {
            Program.Globals.ClockChar[259] = @"*";
        }

        public static void S8()
        {
            Program.Globals.ClockChar[210] = @"*"; 
        }

        public static void S9()
        {
            Program.Globals.ClockChar[141] = @"*";
        }

        public static void S0()
        {
            Program.Globals.ClockChar[148] = @"*";
        }

    }


}
