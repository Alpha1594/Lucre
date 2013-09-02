using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucre
{
    class SumThings
    {
        public static decimal Sum()
        {
            return Sum(Main.SummingMode, Main.IncPrevious);
        }
        
        public static decimal Sum(Main.SumMode Input, bool IncPrevious)
        {
            switch (Input)
            {
                case Main.SumMode.All:
                    return SumAll(0);

                case Main.SumMode.AAnualy:
                    return 0;

                case Main.SumMode.CAnualy:
                    return 0;

                case Main.SumMode.Semester:
                    return 0;

                case Main.SumMode.Quarterly:
                    return 0;

                case Main.SumMode.Monthly:
                    return 0;

                case Main.SumMode.Weekly:
                    return 0;
                default: return -1;
            }
        }

        private static decimal SumAll(int Type)
        {
            return 0;
        }
    }
}
