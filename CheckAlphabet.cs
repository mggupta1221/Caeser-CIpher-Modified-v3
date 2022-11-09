using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipherAlgorithm
{
    public static class CheckAlphabet
    {
        /// <summary>
        /// To check Passed ascii value is an alphabet or not
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public static bool IsAlphabet(char alphabet)
        {
            return ((IsCapitalAlphabet(alphabet) || IsSmallAlphabet(alphabet)));
        }
        /// <summary>
        /// To check An Ascii value belongs to Capital Alphabet or not
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public static bool IsCapitalAlphabet(char alphabet)
        {
            return (alphabet >= 'A' && alphabet <= 'Z');
        }
        /// <summary>
        /// To check if an Ascii value belongs to small alphabet
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public static bool IsSmallAlphabet(char alphabet)
        {
            return (alphabet >= 'a' && alphabet <= 'z');
        }
    }
}
