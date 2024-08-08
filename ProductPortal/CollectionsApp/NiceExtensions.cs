using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp
{
    internal static class NiceExtensions
    {
        public static void MyUpperCase(this string str)
        {
            str = str.ToUpper();
        }

    }
}
