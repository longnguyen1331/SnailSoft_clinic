using System;
using System.Collections.Generic;
using System.Text;

namespace BHSNetCoreLib
{
    public static class MathUltil
    {
        public static void SwapValue<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }
}
