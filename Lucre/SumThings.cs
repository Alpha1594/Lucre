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
                    return SumAll();

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

        private static decimal SumAll()
        {
            decimal Total = 0;
            foreach (Main.Transaction T in Main.Transactions)
            {
                Total += T.Real.HasValue ? T.Real.Value.Capital : T.Predicted.Capital;
            }
            return Total;
        }
    }
}
