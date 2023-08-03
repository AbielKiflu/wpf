using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Communication
{
    public static class StringExtension
    {
        public static (int, int) GetDevicePoint(this string value)
        {
            string[] points = value.Split('=')[1].Split(",");
            int x = int.Parse(points[0]);
            int y = int.Parse(points[1]);
            return (x, y);
        }

        public static int GetDeviceValue(this string value)
        {
            int val = -1;
            //Todo
            // -100 = format exception
            // -101 = undefined

            string[] valueSplited = value.Split(',');
            if (valueSplited.Length == 2)
            {
                try
                {
                    val = int.Parse(valueSplited[1]);
                    return val;
                }
                finally
                {
                    val = -100;

                }
            }
            return -1;
        }
    }
}
