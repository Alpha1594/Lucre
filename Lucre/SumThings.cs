using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucre
{
    class SumThings
    {
        public static decimal Sum(bool In)
        {
            return Sum(GetDuration(Main.SummingMode, Main.IncPrevious), In);
        }

        public static decimal Sum(Main.DurationN D, bool In)
        {
            decimal Total = 0;
            foreach (Main.Transaction T in GetList(In))
            {
                Total += GetAmmountToAdd(T, D);
            }
            return Total;
        }

        public static List<Main.Transaction> GetList(bool IsIn)
        {
            if (IsIn) return Main.Transactions.In;
            else return Main.Transactions.Out;
        }

        public static Main.DurationN GetDuration(Main.SumMode SM, bool IncPrev)
		{
			switch (SM)
			{
				case Main.SumMode.All:
                    return new Main.DurationN(null, null);

                case Main.SumMode.CAnualy:
                    if (IncPrev)
                        return new Main.DurationN(null, DateTime.Now.AddYears(1));
                    else return new Main.DurationN(DateTime.Now, DateTime.Now.AddYears(1));
			}
            return new Main.DurationN();
		}

        public static decimal GetAmmountToAdd(Main.Transaction T, Main.DurationN D)
        {
            if (!D.Start.HasValue || (D.Start < (T.Real.HasValue ? T.Real.Value.Time : T.Predicted.Time))
                && (!D.End.HasValue || D.End > (T.Real.HasValue ? T.Real.Value.Time : T.Predicted.Time)))
                // (!StartIsNull OR StartInRange) AND (!EndIsNull OR EndInRange)
                return T.Real.HasValue ? T.Real.Value.Capital : T.Predicted.Capital;
            else return 0;
        }
    }
}
