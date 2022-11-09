using System;
using System.Text;

namespace CaeserCipherAlgorithm
{
    public sealed class CaeserCipher
    {
        private StringBuilder cipheredText = new StringBuilder();
        private char shiftedAlphabet;
        /// <summary>
        /// Method to implement Caser cipher Algorithm
        /// </summary>
        /// <param name="inputText"></param>
        /// <param name="shiftingFactor"></param>
        /// <returns> StringBuilder</returns>
        public StringBuilder DoCeaserCipher(string inputText, long shiftingFactor)
        {
            //Shifting Factor Value must be Between (-25,25) i.e -25 to 25 including both
            shiftingFactor = shiftingFactor % 26;
            Console.WriteLine($"Main Shifting factor:{shiftingFactor}");
            
            foreach (char currentCharacter in inputText)
            {
                if (char.IsLetter(currentCharacter))
                {
                    char alphabet=currentCharacter;
                    
                    shiftedAlphabet = Convert.ToChar(((long)alphabet + shiftingFactor));

                    // if the alphabetsAsciiValueWithShiftinFactor is within alphabet Ascii range
                    if ((char.IsUpper(shiftedAlphabet) && char.IsUpper(alphabet)) || ((char.IsLower(shiftedAlphabet) && char.IsLower(alphabet))))
                    {
                        cipheredText.Append(shiftedAlphabet);
                    }
                    else
                    {
                        if (shiftingFactor > 0)
                        {
                            if (char.IsUpper(alphabet))
                            {
                                while (!char.IsUpper(shiftedAlphabet))
                                {
                                    shiftedAlphabet = Convert.ToChar((('A' - 1) + (shiftedAlphabet - 'Z')));

                                }

                         
                                cipheredText.Append(shiftedAlphabet);
                            }
                            else if (char.IsLower(alphabet))
                            {
                                while (!char.IsLower(shiftedAlphabet))
                                {
                                    shiftedAlphabet = Convert.ToChar((('a' - 1) + (shiftedAlphabet - 'z')));
                                }

                                cipheredText.Append(shiftedAlphabet);
                            }
                        }
                        else
                        {
                            if (char.IsUpper(alphabet))
                            {

                                while (shiftedAlphabet < 'A')
                                {
                                    shiftedAlphabet = Convert.ToChar(('Z' - (('A' - 1) - shiftedAlphabet)));
                                }

                                cipheredText.Append(shiftedAlphabet);
                            }
                            else if (char.IsLower(alphabet))
                            {
                                while (shiftedAlphabet < 'a')
                                {
                                    shiftedAlphabet = Convert.ToChar(('z' - (('a' - 1) - shiftedAlphabet)));
                                }

                                cipheredText.Append(shiftedAlphabet);
                            }
                        }

                    }
                }
                else
                {
                    //if the Ascii Value not corresponds to An Alphabet(Capital Or Small)
                    cipheredText.Append(currentCharacter); 
                }
            }
            return cipheredText;
        }
    }
}

