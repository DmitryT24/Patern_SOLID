using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Patern_SOLID
{
    public class UsualMethod: IAccountCalculator 
    {
        public double CalculateInterest(Account usualAccount)
        {

            // расчет процентной ставки обычного аккаунта по правилам банка
            usualAccount.Interest = usualAccount.Balance * 0.4;

                if (usualAccount.Balance < 1000)
                usualAccount.Interest -= usualAccount.Balance * 0.2;

                if (usualAccount.Balance >= 1000)
                usualAccount.Interest -= usualAccount.Balance * 0.4;
            
                return usualAccount.Interest;
        }
    }
}
