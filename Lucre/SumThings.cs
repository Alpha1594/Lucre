using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucre
{
    class SumThings
    {
        public static decimal Sum(bool? In)
        {
            return Sum(Main.SummingMode, Main.IncPrevious, In);
        }
        
        public static decimal Sum(Main.SumMode Input, bool IncPrevious, bool? In)
        {
            decimal Total = 0;
            if (In.HasValue)
            {
                if (In.Value)
                {
                    foreach (Main.Transaction T in Main.Transactions.In)
                        Total += T.Real.HasValue ? T.Real.Value.Capital : T.Predicted.Capital;
                }
                else
                {
                    foreach (Main.Transaction T in Main.Transactions.Out)
                        Total += T.Real.HasValue ? T.Real.Value.Capital : T.Predicted.Capital;
                }
            }
            return Total;
        }
    }
}
