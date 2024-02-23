using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z64DungeonTracker.Utilities
{
    internal static class StringUtils
    {
        /// <summary>
        /// Compares <paramref name="caller"/> to <paramref name="target"/> for equality.
        /// </summary>
        /// <param name="caller">The calling string</param>
        /// <param name="target">The target string</param>
        /// <returns>False if either string is null/empty, True if strings are equal</returns>
        public static bool EqualsNull(this string caller, string target)
        {
            if (string.IsNullOrEmpty(target) || string.IsNullOrEmpty(caller))
            {
                return false;
            }
            else
            {
                return caller.Equals(target, StringComparison.InvariantCultureIgnoreCase);
            }
        }
    }
}
