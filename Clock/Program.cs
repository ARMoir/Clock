using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clock
{
    class Program
    {
        public static List<string> ClockChar { get; set; } = new List<string>();

        static void Main(string[] args)
        {
            StringBuilder ClockString = new StringBuilder();

            ClockString.Append("   ~-------------~   " + System.Environment.NewLine);
            ClockString.Append(" ('..'11..12..1'..') " + System.Environment.NewLine);
            ClockString.Append("| :               : |" + System.Environment.NewLine);
            ClockString.Append("| :10            2: |" + System.Environment.NewLine);
            ClockString.Append("| :               : |" + System.Environment.NewLine);
            ClockString.Append("| :               : |" + System.Environment.NewLine);
            ClockString.Append("| :9      @      3: |" + System.Environment.NewLine);
            ClockString.Append("| :               : |" + System.Environment.NewLine);
            ClockString.Append("| :               : |" + System.Environment.NewLine);
            ClockString.Append("| :8             4: |" + System.Environment.NewLine);
            ClockString.Append("| :               : |" + System.Environment.NewLine);
            ClockString.Append(" ('..'7...6...5'..') " + System.Environment.NewLine);
            ClockString.Append("   ~-------------~   " + System.Environment.NewLine);

            do
            {
                ClockChar.Clear();
                ClockChar.AddRange(ClockString.ToString().Select(Chars => Chars.ToString()));

                int Hour = Int32.Parse(DateTime.Now.ToString("hh"));
                int Min = Int32.Parse(DateTime.Now.ToString("mm"));

                switch (Min)
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

                switch (Hour)
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

                Console.CursorVisible = false;
                var Display = new StringBuilder();
                
                Display.Clear();
                ClockChar.ForEach(Item => Display.Append(Item));
                Console.Clear();
                Console.Write(Display);
                System.Threading.Thread.Sleep(1000);

            } while (true);
            
        }

        public static void H1()
        {
            ClockChar[82] = @"H"; //1M
            ClockChar[104] = @"/"; //1M
        }

        public static void H2()
        {
            ClockChar[107] = @"H"; //2M
            ClockChar[128] = @"/"; //2M
        }
        public static void H3()
        {
            ClockChar[153] = @"H"; //3M
            ClockChar[152] = @"-"; //3M
            ClockChar[151] = @"-"; //3M    
        }

        public static void H4()
        {
            ClockChar[199] = @"H"; //4M
            ClockChar[174] = @"\"; //4M
        }

        public static void H5()
        {

            ClockChar[220] = @"H"; //5M
            ClockChar[196] = @"\"; //5M
        }

        public static void H6()
        {
            ClockChar[217] = @"H"; //6M
            ClockChar[194] = @"|"; //6M
        }

        public static void H7()
        {
            ClockChar[214] = @"H"; //7M
            ClockChar[192] = @"/"; //7M
        }

        public static void H8()
        {
            ClockChar[189] = @"H"; //8M
            ClockChar[168] = @"/"; //8M
        }

        public static void H9()
        {
            ClockChar[143] = @"H"; //9M
            ClockChar[144] = @"-"; //9M
            ClockChar[145] = @"-"; //9M
        }

        public static void H10()
        {
            ClockChar[97] = @"H"; //10M
            ClockChar[122] = @"\"; //10M
        }

        public static void H11()
        {
            ClockChar[76] = @"H"; //11M
            ClockChar[100] = @"\"; //11M
        }

        public static void H12()
        {
            ClockChar[79] = @"H"; //12M
            ClockChar[102] = @"|"; //12M
        }

        public static void M1()
        {
            ClockChar[60] = @"M"; //1M
            ClockChar[82] = @"/"; //1M
            ClockChar[104] = @"/"; //1M
        }

        public static void M2()
        {
            ClockChar[85] = @"M"; //2M
            ClockChar[107] = @"/"; //2M
            ClockChar[128] = @"/"; //2M

        }
        public static void M3()
        {
            ClockChar[154] = @"M"; //3M
            ClockChar[153] = @"-"; //3M
            ClockChar[152] = @"-"; //3M
            ClockChar[151] = @"-"; //3M    
        }

        public static void M4()
        {
            ClockChar[223] = @"M"; //4M
            ClockChar[199] = @"\"; //4M
            ClockChar[174] = @"\"; //4M
        }

        public static void M5()
        {

            ClockChar[244] = @"M"; //5M
            ClockChar[220] = @"\"; //5M
            ClockChar[196] = @"\"; //5M
        }
        public static void M6()
        {
            ClockChar[240] = @"M"; //6M
            ClockChar[217] = @"|"; //6M
            ClockChar[194] = @"|"; //6M
        }

        public static void M7()
        {
            ClockChar[236] = @"M"; //7M
            ClockChar[214] = @"/"; //7M
            ClockChar[192] = @"/"; //7M
        }

        public static void M8()
        {
            ClockChar[211] = @"M"; //8M
            ClockChar[189] = @"/"; //8M
            ClockChar[168] = @"/"; //8M
        }

        public static void M9()
        {
            ClockChar[142] = @"M"; //9M
            ClockChar[143] = @"-"; //9M
            ClockChar[144] = @"-"; //9M
            ClockChar[145] = @"-"; //9M
        }

        public static void M10()
        {

            ClockChar[73] = @"M"; //10M
            ClockChar[97] = @"\"; //10M
            ClockChar[122] = @"\"; //10M
        }

        public static void M11()
        {
            ClockChar[52] = @"M"; //11M
            ClockChar[76] = @"\"; //11M
            ClockChar[100] = @"\"; //11M
        }

        public static void M12()
        {
            ClockChar[56] = @"M"; //12M
            ClockChar[79] = @"|"; //12M
            ClockChar[102] = @"|"; //12M
        }
    }
}
