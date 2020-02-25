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



class Result
{

    /*
     * Complete the 'oddNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER l
     *  2. INTEGER r
     */

    public static List<int> oddNumbers(int l, int r)
    {
        var result = new List<int>();

        for (int i = l; i <= r; i++)
        {
            if (i % 2 != 0)
                result.Add(i);

        }

        return result;



    }

    static void Main1()
    {
        oddNumbers(2, 5);
        }

}

