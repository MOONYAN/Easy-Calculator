using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Calculator
{
    class MinusOperate : IOperate
    {
        public int DoOperation(int former, int latter)
        {
            return former - latter;
        }
    }
}
