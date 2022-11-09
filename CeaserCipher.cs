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

            foreach(char alphabet in inputText)
            {
                if (char.IsLetter(alphabet))
                {
                    
                    char ShiftedAlphabet = Convert.ToChar(((long)alphabet + shiftingFactor));

                    // if the alphabetsAsciiValueWithShiftinFactor is within alphabet Ascii range
                    if ((char.IsUpper(ShiftedAlphabet) && char.IsUpper(alphabet)) || ((char.IsLower(ShiftedAlphabet) && char.IsLower(alphabet))))
                    {
                        cipheredText.Append(ShiftedAlphabet);
                    }
                    else
                    {
                        if (shiftingFactor > 0)
                        {
                            if (char.IsUpper(alphabet))
                            {
                                while (!char.IsUpper(ShiftedAlphabet))
                                {
                                    ShiftedAlphabet = Convert.ToChar((('A' - 1) + (ShiftedAlphabet - 'Z')));

                                }

                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                            else if (char.IsLower(alphabet))
                            {
                                while (!char.IsLower(ShiftedAlphabet))
                                {
                                    ShiftedAlphabet = Convert.ToChar((('a' - 1) + (ShiftedAlphabet - 'z')));
                                }

                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                        }
                        else
                        {
                            if (char.IsUpper(alphabet))
                            {

                                while (ShiftedAlphabet < 'A')
                                {
                                    ShiftedAlphabet = Convert.ToChar(('Z' - (('A' - 1) - ShiftedAlphabet)));
                                }
                                appendAlphabet = ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                            else if (char.IsLower(alphabet))
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
                    cipheredText.Append(alphabet); 
                }
            }
            return cipheredText;
        }
    }
}

