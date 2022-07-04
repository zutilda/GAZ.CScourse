using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GreatestCommonDivisor
{
    static class GCDAlgorithms
    {
            
        static public int FindGCDStein(int u, int v,out long time)
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int k;
           
            if (u == 0 || v == 0)
            return u | v;
           
            for (k = 0; ((u | v) & 1) == 0; ++k)
            {
            u >>= 1;
            v >>= 1;
            }
         
            while ((u & 1) == 0)
            u >>= 1;
            
            do
            {
            while ((v & 1) == 0) 
            v >>= 1;           
            if (u < v)
            {
            v -= u;
            }
            else
            {
            int diff = u - v;
            u = v;
            v = diff;
            }
            v >>= 1;
           
            } while (v != 0);
            u <<= k;
            sw.Stop();
            time = sw.ElapsedTicks;
            return u;
            
    }
        static public int FindGCDEuclid(int a, int b, out long time)
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();            
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
            sw.Stop();
            time = sw.ElapsedTicks;
            return a;
        }

    }
}
