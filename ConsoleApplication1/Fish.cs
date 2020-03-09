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

class Solutionx
{

    static List<int> getGroup (List<List<int>> groups, int fish)
    {
        foreach(var group in groups)
        {
            if (group.Any(x => x == fish))
                return group;
        }

        return null;
    }

    // Complete the numGroups function below.
    static int numGroups(List<string> greatBarrierReef)
    {
        var groups = new List<List<int>>();
        var fishTotal = greatBarrierReef[0].Length;

        for (int fish = 0; fish < fishTotal; fish++)
        {
            var currentGroup = getGroup(groups, fish);
            if (currentGroup == null)
            {
                currentGroup = new List<int>();
                currentGroup.Add(fish);
                groups.Add(currentGroup);
            }

            for (int other = fish + 1; other < fishTotal; other++)
            {
                if (greatBarrierReef[fish][other] == '1')
                    currentGroup.Add(other);
            }


        }

        return groups.Count();
    }

    static void Main(string[] args)
    {

        List<string> greatBarrierReef = new List<string>();
        greatBarrierReef.Add("1100");
        greatBarrierReef.Add("1110");
        greatBarrierReef.Add("0110");
        greatBarrierReef.Add("0001");


        int res = numGroups(greatBarrierReef);

    }
}
