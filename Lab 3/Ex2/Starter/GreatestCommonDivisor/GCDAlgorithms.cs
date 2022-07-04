using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GAZCSCourseLab3Ex2
{
    static class GCDAlgorithms
    {
        
        static public int FindGCDEuclid(int a, int b)
        {
            
            if (a == 0) return b;

            while (b != 0)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;
        }

        
        public static int FindGCDEuclid(int a, int b, int c)
        {
            int d = FindGCDEuclid(a, b);
            int e = FindGCDEuclid(d, c);
            return e;
        }
        
        public static int FindGCDEuclid(int a, int b, int c, int d)
        {
            int e = FindGCDEuclid(a, b, c);
            int f = FindGCDEuclid(e, d);
            return f;
        }

        public static int FindGCDEuclid(int a, int b, int c, int d, int e)
        {
            int f = FindGCDEuclid(a, b, c, d);
            int g = FindGCDEuclid(f, e);
            return g;
        }
    }
}
