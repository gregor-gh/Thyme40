using System;
using Thyme40.BLL;

namespace GL
{
    class Program
    {
        static void Main(string[] args)
        {
            GLAccount acc = new("0400", "Test account");
            Console.WriteLine(acc);
        }
    }
}
