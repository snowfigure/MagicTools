using System;
using System.Drawing;

namespace MagicTool.Util
{
    public class App
    {
        private static String Name = "Magic Tools";
        private static String V = "1";
        private static String R = "0";
        private static String C = "0";
        private static String Ver = App.V + "." + App.R + App.C;

        public static String Title = App.Name + " " + App.Ver;
    }

    public class AppRecord
    {
        private static String Name = "Magic Tools - Record";
        private static String V = "1";
        private static String R = "0";
        private static String C = "0";
        private static String Ver = AppRecord.V + "." + AppRecord.R + AppRecord.C;

        public static String Title = AppRecord.Name + " " + AppRecord.Ver;
    }
    public class Colors
    {
        

        public static Color ColorCloseBackHover = Color.FromArgb(211, 68, 48);
        public static Color ColorCloseBackDefault = Color.FromArgb(234, 75, 53);

        public static Color RecoreCloseBackDefault = Color.FromArgb(7, 134, 238);
        public static Color RecoreCloseBackHover = Color.FromArgb(234, 75, 53);

        public static Color TabControlDefault = Color.FromArgb(240, 240, 240);
        public static Color TabControlSelected = Color.FromArgb(255, 255, 255);

        public static Color ToDoListItemDefault = Color.Transparent;
        public static Color ToDoListItemSelected = Color.FromArgb(253, 236, 170);
        public static Color ToDoListItemHover = Color.FromArgb(252, 240, 193);
    }

    public class MySql
    {
        public static String username = "root";
        public static String password = "admin1234";
        public static String schema = "magictool";
    }
}
