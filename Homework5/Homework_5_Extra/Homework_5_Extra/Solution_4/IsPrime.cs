using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class IsPrime
    {
        public static bool Prime(int num)
        {
            if ((num & 1) == 0)
            {
                if (num == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i*i) <= num; i += 2)
            {
                if ((num%i) == 0)
                {
                    return false;
                }
            }
            return num != 1;
        }
    }
}
