using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace pulsee.engine.Utils
{
    class ListFinder
    {
        public static int FindIndexFromRegex<T>(List<T> list, string regex)
        {
            return list.FindIndex(s => new Regex(string.Format(@"{0}", regex)).Match(s.ToString()).Success);
        }

        public static T FindElementFromRegex<T>(List<T> list, string regex)
        {
            return list[FindIndexFromRegex(list, regex)];
        }
    }
}
