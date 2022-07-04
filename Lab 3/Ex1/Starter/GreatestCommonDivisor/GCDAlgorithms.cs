﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GAZCSCourseLab3
{
    static class GCDAlgorithms
    {
       
       
        public static int FindGCDEuclid(int a, int b)
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

    }
}
