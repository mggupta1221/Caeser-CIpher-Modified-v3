using System;
using System.Text;

namespace CaeserCipherAlgorithm
{
    public sealed class CaeserCipher
    {
        private StringBuilder cipheredText = new StringBuilder();

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
                if (CheckAlphabet.IsAlphabet(alphabet))
                {
                    
                    char ShiftedAlphabet = Convert.ToChar(((long)alphabet + shiftingFactor));

                    // if the alphabetsAsciiValueWithShiftinFactor is within alphabet Ascii range
                    if ((CheckAlphabet.IsCapitalAlphabet(ShiftedAlphabet) && CheckAlphabet.IsCapitalAlphabet(alphabet)) || ((CheckAlphabet.IsSmallAlphabet(ShiftedAlphabet) && CheckAlphabet.IsSmallAlphabet(alphabet))))
                    {
                        char cipheredCharacter = ShiftedAlphabet;
                        cipheredText.Append(cipheredCharacter);
                    }
                    else
                    {
                        if (shiftingFactor > 0)
                        {
                            if (CheckAlphabet.IsCapitalAlphabet(alphabet))
                            {
                                while (!CheckAlphabet.IsCapitalAlphabet(ShiftedAlphabet))
                                {
                                    ShiftedAlphabet = Convert.ToChar((('A' - 1) + (ShiftedAlphabet - 'Z')));

                                }

                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                            else if (CheckAlphabet.IsSmallAlphabet(alphabet))
                            {
                                while (!CheckAlphabet.IsSmallAlphabet(ShiftedAlphabet))
                                {
                                    ShiftedAlphabet = Convert.ToChar((('a' - 1) + (ShiftedAlphabet - 'z')));
                                }

                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                        }
                        else
                        {
                            if (CheckAlphabet.IsCapitalAlphabet(alphabet))
                            {

                                while (ShiftedAlphabet < 'A')
                                {
                                    ShiftedAlphabet = Convert.ToChar(('Z' - (('A' - 1) - ShiftedAlphabet)));
                                }
                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                            else if (CheckAlphabet.IsSmallAlphabet(alphabet))
                            {
                                while (ShiftedAlphabet < 'a')
                                {
                                    ShiftedAlphabet = Convert.ToChar(('z' - (('a' - 1) - ShiftedAlphabet)));
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

