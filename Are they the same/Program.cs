using System;
using System.Collections.Generic;
using System.Linq;

class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (a?.Length != b?.Length) return false;

        List<int> listA = a.ToList();
        List<int> listB = b.ToList();

        foreach (var x in listB)
        {

            // if (x is null) return false;
            int temp = (int)Math.Pow((double)x, 0.5f);
            if (!listA.Contains(temp))
                return false;
            else
                listA.Remove(temp);

        }
        return true;
    }
}