using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Calculator
{
    class Model
    {
        int _number;
        IOperate _minusOperate;
        IOperate _plusOperate;
        IOperate _currentOperate;

        public Model()
        {
            _number = 0;
            _minusOperate = new MinusOperate();
            _plusOperate = new PlusOperate();
            _currentOperate = new DefaultOperate();
        }

        public void DoOperation(int number)
        {
            _number = _currentOperate.DoOperation(_number, number);
        }

        public int GetResult()
        {
            _currentOperate = new DefaultOperate();
            return _number;
        }

        public void SetPlusMode(int number)
        {
            _number = number;
            _currentOperate = _plusOperate;
        }

        public void SetMinusMode(int number)
        {
            _number = number;
            _currentOperate = _minusOperate;
        }
    }
}
