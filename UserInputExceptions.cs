using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipherAlgorithm
{
    /// <summary>
    /// Exception: Throw If Input Text Is Null Or Empty
    /// </summary>
    public sealed class InputTextException : Exception
    {
        public InputTextException(string message) : base(message) { }

    }
    /// <summary>
    /// Exception: Throw If ShiftingFactor Is Not Valid
    /// </summary>
    public sealed class ShiftingFactorException : Exception
    {
        public ShiftingFactorException(string message) : base(message) { }
    }
}
