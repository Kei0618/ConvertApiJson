using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public static class CheckVariant
    {
        public static bool CheckLength(string[] strings)
        {
            if (strings.Length >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}