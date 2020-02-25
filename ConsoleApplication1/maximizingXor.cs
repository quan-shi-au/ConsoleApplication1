using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class MaximizingXor
{

    // Complete the maximizingXor function below.
    public static int maximizingXor(int l, int r)
    {
        int temp = 0, xtemp = 0;

        for (int x = l; x <= r; x++)
        {
            for (int y = l; y <= r; y++)
            {
                xtemp = x ^ y;
                if (temp < xtemp)
                    temp = xtemp;
            }

        }

        return temp;

    }

}
