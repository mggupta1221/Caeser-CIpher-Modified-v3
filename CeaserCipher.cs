using System;
using System.Text;

namespace CaeserCipherAlgorithm
{
    public class CaeserCipher
    {
        private StringBuilder cipheredText = new StringBuilder();
        

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
        /// To checkk is an Ascii value belongs to small alphabet
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
        public StringBuilder DoCeaserCipher(string inputText, int shiftingFactor)
        {
            char appendAlphabet;
            for (int count = 0; count < inputText.Length; count++)
            {
                char alphabet = inputText[count];
                if (IsAlphabet(alphabet))
                {
                    
                    char ShiftedAlphabet = (char)((int)alphabet + (int)shiftingFactor);

                    // if the alphabetsAsciiValueWithShiftinFactor is within alphabet Ascii range
                    if ((IsCapitalAlphabet(ShiftedAlphabet) && IsCapitalAlphabet(alphabet)) || ((IsSmallAlphabet(ShiftedAlphabet) && IsSmallAlphabet(alphabet))))
                    {
                        char cipheredCharacter = (char)ShiftedAlphabet;
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
                                    ShiftedAlphabet = (char)(('A'-1)+ (ShiftedAlphabet - 'Z'));

                                }

                                appendAlphabet = (char)ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                            else if (IsSmallAlphabet(alphabet))
                            {
                                while (!IsSmallAlphabet(ShiftedAlphabet))
                                {
                                    ShiftedAlphabet = (char)(('a'-1) + (ShiftedAlphabet - 'z'));
                                }

                                appendAlphabet = (char)ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                        }
                        else
                        {
                            if (IsCapitalAlphabet(alphabet))
                            {

                                while(ShiftedAlphabet < 'A')
                                {
                                    ShiftedAlphabet = (char)('Z' - (('A'-1) - ShiftedAlphabet));
                                }
                                appendAlphabet = (char)ShiftedAlphabet;
                                cipheredText.Append(appendAlphabet);
                            }
                            else if (IsSmallAlphabet(alphabet))
                            {
                                while(ShiftedAlphabet < 'a')
                                {
                                    ShiftedAlphabet = (char)('z' - (('a'-1) - ShiftedAlphabet));
                                }
                                appendAlphabet = (char)ShiftedAlphabet;
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

