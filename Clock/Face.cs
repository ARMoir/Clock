using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Face
    {
        public static void SetFace()
        {
            Program.Clock.ClockString.Append("   ~-------------~    " + (Char)10);
            Program.Clock.ClockString.Append(" ('..'11..12..1'..')  " + (Char)10);
            Program.Clock.ClockString.Append("| :               : | " + (Char)10);
            Program.Clock.ClockString.Append("| :10            2: | " + (Char)10);
            Program.Clock.ClockString.Append("| :               : | " + (Char)10);
            Program.Clock.ClockString.Append("| :               : | " + (Char)10);
            Program.Clock.ClockString.Append("| :9      @      3: | " + (Char)10);
            Program.Clock.ClockString.Append("| :               : | " + (Char)10);
            Program.Clock.ClockString.Append("| :               : | " + (Char)10);
            Program.Clock.ClockString.Append("| :8             4: | " + (Char)10);
            Program.Clock.ClockString.Append("| :               : | " + (Char)10);
            Program.Clock.ClockString.Append(" ('..'7...6...5'..')  " + (Char)10);
            Program.Clock.ClockString.Append("   ~-------------~    " + (Char)10);
        }
    }
}
