using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipherAlgorithm
{

    public class InputTextException : Exception
    {
        public InputTextException(string message) : base(message) { }

    }

    public class ShiftingFactorException : Exception
    {
        public ShiftingFactorException(string message) : base(message) { }
    }
}
