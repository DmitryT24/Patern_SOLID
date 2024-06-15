using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_SOLID
{
    public interface IAccountCalculator
    {
         double CalculateInterest(Account account);
    }
}
