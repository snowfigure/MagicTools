using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

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
    public class Const
    {
        

        public static Color ColorCloseBackHover = Color.FromArgb(211, 68, 48);
        public static Color ColorCloseBackDefault = Color.FromArgb(234, 75, 53);
    }
}
