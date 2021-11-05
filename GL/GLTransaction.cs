using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thyme40.BLL {
  class GLTransaction {
    public List<GLTransactionLine> GLTransactionLines {
      get {
        return GLTransactionLines.ToList();
      }
    }
    public GLTransaction() {


    }

    public void AddTransactionLine(GLTransactionLine line) {
      GLTransactionLines.Add(line);
    }

    public void ParseTransaction() {
      decimal sum = GLTransactionLines.Sum(line => line.Amount);
      if (sum != 0) {
        throw new TransactionImbalanceException();
      }
    }

    public void Save() {
      // db logic
    }
  }
}
