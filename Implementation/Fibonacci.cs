using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class Fibonacci
    {
        /// <summary>
        /// Fibonacci number is counted with F(n) = F(n-1) + F(n-2), F(0) = 0, F(1)=1
        ///
        /// Implement a function which return nth fibonacci number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long CalculateNth(int n)
        {
            long firstnumber = 0, secondnumber = 1;
            long nth = 0;
            if (n == 0) return 0;  
            if (n == 1) return 1;   
            for (int i = 2; i <= n; i++)
            {
                nth = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = nth;
            }
            return nth;
        }
    }
}
