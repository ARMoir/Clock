using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Second
    {
        public static void SetSecond()
        {

            if (Program.Var.Seconds % 2 == 0)
            {
                switch (Program.Var.Minute)
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
        //Program.Var.ClockChar[37] = @"*"; //1
        //Program.Var.ClockChar[86] = @"*"; //2
        //Program.Var.ClockChar[155] = @"*"; //3
        //Program.Var.ClockChar[224] = @"*"; //4
        //Program.Var.ClockChar[267] = @"*"; //5
        //Program.Var.ClockChar[263] = @"*"; //6
        //Program.Var.ClockChar[259] = @"*"; //7
        //Program.Var.ClockChar[210] = @"*"; //8
        //Program.Var.ClockChar[141] = @"*"; //9
        //Program.Var.ClockChar[72] = @"*"; //10
        //Program.Var.ClockChar[29] = @"*"; //11
        //Program.Var.ClockChar[30] = @"*"; //11
        //Program.Var.ClockChar[33] = @"*"; //12
        //Program.Var.ClockChar[34] = @"*"; //12

        public static void S1()
        {
            Program.Var.ClockChar[37] = @"*"; //1
        }

        public static void S2()
        {
            Program.Var.ClockChar[86] = @"*"; //2
        }

        public static void S3()
        {
            Program.Var.ClockChar[155] = @"*"; //3
        }

        public static void S4()
        {
            Program.Var.ClockChar[224] = @"*"; //4
        }

        public static void S5()
        {
            Program.Var.ClockChar[267] = @"*"; //5
        }

        public static void S6()
        {
            Program.Var.ClockChar[263] = @"*"; //6
        }

        public static void S7()
        {
            Program.Var.ClockChar[259] = @"*"; //7
        }

        public static void S8()
        {
            Program.Var.ClockChar[210] = @"*"; //8
        }

        public static void S9()
        {
            Program.Var.ClockChar[141] = @"*"; //9
        }

        public static void S0()
        {
            Program.Var.ClockChar[148] = @"*"; //10
        }

        public static void S11()
        {
            Program.Var.ClockChar[29] = @"*"; //11
            Program.Var.ClockChar[30] = @"*"; //11
        }

        public static void S12()
        {
            Program.Var.ClockChar[33] = @"*"; //12
            Program.Var.ClockChar[34] = @"*"; //12 
        }
    }


}
