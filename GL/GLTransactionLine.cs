using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thyme40.BLL
{
    class GLTransactionLine
    {
        public GLAccount Account { get; }
        public decimal Amount { get; }
        public GLTransactionLine(GLAccount account, decimal amount)
        {
            Account = account;
            Amount = amount;
        }
    }
}
