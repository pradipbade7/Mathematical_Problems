using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypes;

namespace Implementation
{
    public class RgbToHex
    {
        /// <summary>
        /// In programming color is usually represented as a RGB value or as hex string where hexadecimal values of rgb values are concatenated as as string
        /// 0, 0, 0 => 000000 or 255, 0, 0 => FF0000
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ConvertRgbToHex(Rgb value)
        {
            Color myColor = Color.FromArgb(value.R, value.G, value.B);
            return myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2"); //gives hexadecimal values
        }
    }
}
