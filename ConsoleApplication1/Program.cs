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

class Solution1
{

    static bool IsMatching(char? openChar, char? closeChar)
    {
        var matchingPairs = new Dictionary<char?, char?>()
        {
            {'[', ']' },
            {'{', '}' },
            {'(', ')' },
        };

        if (!matchingPairs.ContainsKey(openChar))
            return false;

        return matchingPairs[openChar] == closeChar;
    }

    static string IsSyntaxCorrect(string input)
    {
        Stack st = new Stack();

        foreach (var item in input)
        {
            if (st.Count == 0)
            {
                st.Push(item);
                continue;
            }

            var topone = st.Peek() as char?;
            if (IsMatching(topone, item))
                st.Pop();
            else
                st.Push(item);
        }

        return st.Count == 0 ? "YES" : "NO";

    }

    // Complete the correctness function below.
    static List<string> correctness(List<string> roktx)
    {
        var result = new List<string>();

        foreach (var oneInput in roktx)
        {
            result.Add(IsSyntaxCorrect(oneInput));
        }

        return result;

    }

    static void Main1(string[] args)
    {
        var x = new List<string>();
        x.Add("[]{}()");
        x.Add("[{]}");


        List<string> res = correctness(x);

    }
}
