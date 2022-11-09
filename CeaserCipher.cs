using System;
using System.Text;

namespace CaeserCipherAlgorithm
{
    public class CaeserCipher
    {
        private StringBuilder cipheredText = new StringBuilder();
        
        private char ConvertToChar(long alphabetAscii)
        {
            return (char)(alphabetAscii);
        }
        /// <summary>
        /// To check Passed ascii value is an alphabet or not
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        private bool IsAlphabet(char alphabet)
        {
            return ((IsCapitalAlphabet(alphabet) || IsSmallAlphabet(alphabet)));
        }
        /// <summary>
        /// To check An Ascii value belongs to Capital Alphabet or not
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        private bool IsCapitalAlphabet(char alphabet)
        {
            return (alphabet >= 'A' && alphabet <= 'Z');
        }
        /// <summary>
        /// To check if an Ascii value belongs to small alphabet
        /// </summary>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        private bool IsSmallAlphabet(char alphabet)
        {
            return (alphabet >= 'a' && alphabet <= 'z');
        }

        /// <summary>
        /// Method to implement Caser cipher Algorithm
        /// </summary>
        /// <param name="inputText"></param>
        /// <param name="shiftingFactor"></param>
        /// <returns> StringBuilder</returns>
        public StringBuilder DoCeaserCipher(string inputText, long shiftingFactor)
        {
            char appendAlphabet;
            //Shifting Factor Value must be Between (-25,25) i.e -25 to 25 including both
            shiftingFactor = shiftingFactor % 26;
            Console.WriteLine($"Main Shifting factor:{shiftingFactor}");
            for (int count = 0; count < inputText.Length; count++)
            {
                char alphabet = inputText[count];
                if (IsAlphabet(alphabet))
                {
                    
                    char ShiftedAlphabet = ConvertToChar(((long)alphabet + shiftingFactor));

                    // if the alphabetsAsciiValueWithShiftinFactor is within alphabet Ascii range
                    if ((IsCapitalAlphabet(ShiftedAlphabet) && IsCapitalAlphabet(alphabet)) || ((IsSmallAlphabet(ShiftedAlphabet) && IsSmallAlphabet(alphabet))))
                    {
                        char cipheredCharacter = ShiftedAlphabet;
                        cipheredText.Append(cipheredCharacter);
                    }
                    else
                    {
                        if (shiftingFactor > 0)
                        {
                            if (IsCapitalAlphabet(alphabet))
                            {
                                while (!IsCapitalAlphabet(ShiftedAlphabet))
                                {
                                    ShiftedAlphabet = ConvertToChar((('A' - 1) + (ShiftedAlphabet - 'Z')));

                                }

                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                            else if (IsSmallAlphabet(alphabet))
                            {
                                while (!IsSmallAlphabet(ShiftedAlphabet))
                                {
                                    ShiftedAlphabet = ConvertToChar((('a' - 1) + (ShiftedAlphabet - 'z')));
                                }

                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                        }
                        else
                        {
                            if (IsCapitalAlphabet(alphabet))
                            {

                                while (ShiftedAlphabet < 'A')
                                {
                                    ShiftedAlphabet = ConvertToChar(('Z' - (('A' - 1) - ShiftedAlphabet)));
                                }
                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                            else if (IsSmallAlphabet(alphabet))
                            {
                                while (ShiftedAlphabet < 'a')
                                {
                                    ShiftedAlphabet = ConvertToChar(('z' - (('a' - 1) - ShiftedAlphabet)));
                                }
                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                        }

                    }
                }
                else
                {
                    //if the Ascii Value not corresponds to An Alphabet(Capital Or Small)
                    cipheredText.Append(inputText[count]); 
                }
            }
            return cipheredText;
        }
    }
}

