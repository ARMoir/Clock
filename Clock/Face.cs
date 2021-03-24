using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Face
    {
        public static void SetFace()
        {
            Program.Globals.ClockString.Append("   ~-------------~   " + System.Environment.NewLine);
            Program.Globals.ClockString.Append(" ('..'11..12..1'..') " + System.Environment.NewLine);
            Program.Globals.ClockString.Append("| :               : |" + System.Environment.NewLine);
            Program.Globals.ClockString.Append("| :10            2: |" + System.Environment.NewLine);
            Program.Globals.ClockString.Append("| :               : |" + System.Environment.NewLine);
            Program.Globals.ClockString.Append("| :               : |" + System.Environment.NewLine);
            Program.Globals.ClockString.Append("| :9      @      3: |" + System.Environment.NewLine);
            Program.Globals.ClockString.Append("| :               : |" + System.Environment.NewLine);
            Program.Globals.ClockString.Append("| :               : |" + System.Environment.NewLine);
            Program.Globals.ClockString.Append("| :8             4: |" + System.Environment.NewLine);
            Program.Globals.ClockString.Append("| :               : |" + System.Environment.NewLine);
            Program.Globals.ClockString.Append(" ('..'7...6...5'..') " + System.Environment.NewLine);
            Program.Globals.ClockString.Append("   ~-------------~   " + System.Environment.NewLine);
        }
    }
}
