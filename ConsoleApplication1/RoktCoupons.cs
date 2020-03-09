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

class Solution
{



    // Complete the numberOfPayment function below.
    static int numberOfPayment(List<int> roktCoupons, long k)
    {
        var answers = new List<int>();

        if (k % 2 == 0 && roktCoupons.Where(x => x == k / 2).Count() >= 2)
        {
            answers.Add(Convert.ToInt32(k / 2));
        }
        roktCoupons.RemoveAll(x => x == k / 2);

        roktCoupons = roktCoupons.Distinct().ToList();

        while (roktCoupons.Count > 0)
        {
            var item = roktCoupons[0];
            var theOther = Convert.ToInt32(k - item);

            var matching = roktCoupons.FirstOrDefault(x => x == theOther);

            if (matching != 0 && !answers.Contains(item) && !answers.Contains(theOther))
            {
                answers.Add(item);
            }

            roktCoupons.RemoveAll(x => x == item || x == matching);
        }

        return answers.Count;
    }

    static void Mainx(string[] args)
    {

        var x = new List<int>() {
6,
12,
3,
9,
3,
5,
1    };

        int res = numberOfPayment(x, 12);

    }
}
