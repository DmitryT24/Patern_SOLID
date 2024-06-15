using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_SOLID
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static double CalculateInterest(Account needfulAccount, IAccountCalculator accountCalculator)
        {
          return  accountCalculator.CalculateInterest(needfulAccount);
        }
    }
}
