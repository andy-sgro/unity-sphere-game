using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class StringMethods
{
    public static bool CompareStrings(this string str, List<string> stringList)
    {
        foreach (string stringElement in stringList)
		{
            if (str.Equals(stringElement))
			{
                return true;
			}
		}
        return false;
    }
}
