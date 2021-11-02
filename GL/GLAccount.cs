using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thyme40.BLL
{
    class GLAccount
    {
        public string AccountNumber { get;  }
        public string AccountName { get; set; }
        public decimal AccountBalance { get; }

        public GLAccount(string accountNumber, string accountName)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
        }

        public override string ToString()
        {
            return $"{AccountNumber}: {AccountName}";
        }

        public void SaveAccount()
        {
            // db logic
        }
    }
}
