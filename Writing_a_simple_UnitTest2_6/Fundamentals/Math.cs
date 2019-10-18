using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_a_simple_UnitTest2_6.Funndamentals
{
    public class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Max(int a,int b)
        {
            return (a < b) ? a : b;
        }
        public IEnumerable<int>GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (1 % 2 != 0)
                    yield return i;
        }
    }
}
