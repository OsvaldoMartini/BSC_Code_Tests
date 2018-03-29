using System.Collections.Generic;
using System.Linq;

namespace BSC.Code.Library.Utils
{
    public class TestResult
    {
        public static List<int> ArrayOfInteger(int initial, int final)
        {
            return Enumerable.Range(initial , final).ToList();
        }
    }
}
