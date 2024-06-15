using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Patern_SOLID
{
    public class PayDay: IAccountCalculator
    {
        public double CalculateInterest(Account payDayAccount)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            return payDayAccount.Balance * 0.5;
        }
    }
}
