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
        /// <param name="alphabetsAsciiValue"></param>
        /// <returns></returns>
        private bool IsAlphabet(int alphabetsAsciiValue)
        {
            return ((IsCapitalAlphabet(alphabetsAsciiValue) || IsSmallAlphabet(alphabetsAsciiValue)));
        }
        /// <summary>
        /// To check An Ascii value belongs to Capital Alphabet or not
        /// </summary>
        /// <param name="alphabetsAsciiValue"></param>
        /// <returns></returns>
        private bool IsCapitalAlphabet(int alphabetsAsciiValue)
        {
            return (alphabetsAsciiValue >= 65 && alphabetsAsciiValue <= 90);
        }
        /// <summary>
        /// To checkk is an Ascii value belongs to small alphabet
        /// </summary>
        /// <param name="alphabetsAsciiValue"></param>
        /// <returns></returns>
        private bool IsSmallAlphabet(int alphabetsAsciiValue)
        {
            return (alphabetsAsciiValue >= 97 && alphabetsAsciiValue <= 122);
        }

        /// <summary>
        /// Method to implement Caser cipher Algorithm
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="shiftingFactor"></param>
        /// <returns> StringBuilder</returns>
        public StringBuilder DoCeaserCipher(string inputString, int shiftingFactor)
        {
            char alphabetToBeAdded;
            for (int count = 0; count < inputString.Length; count++)
            {
                int alphabetsAsciiValue = (int)(inputString[count]);
                if (IsAlphabet(alphabetsAsciiValue))
                {
                    int alphabetsAsciiValueWithShiftinFactor = alphabetsAsciiValue + shiftingFactor;

                    // if the alphabetsAsciiValueWithShiftinFactor is within alphabet Ascii range
                    if ((IsCapitalAlphabet(alphabetsAsciiValueWithShiftinFactor) && IsCapitalAlphabet(alphabetsAsciiValue)) || ((IsSmallAlphabet(alphabetsAsciiValueWithShiftinFactor) && IsSmallAlphabet(alphabetsAsciiValue))))
                    {
                        char cipheredCharacter = (char)alphabetsAsciiValueWithShiftinFactor;
                        cipheredText.Append(cipheredCharacter);
                    }
                    else
                    {
                        if (shiftingFactor > 0)
                        {
                            if (IsCapitalAlphabet(alphabetsAsciiValue))
                            {
                                while (!IsCapitalAlphabet(alphabetsAsciiValueWithShiftinFactor))
                                {
                                    alphabetsAsciiValueWithShiftinFactor = 64 + (alphabetsAsciiValueWithShiftinFactor - 90);
                                }

                                alphabetToBeAdded = (char)alphabetsAsciiValueWithShiftinFactor;
                                cipheredText.Append(alphabetToBeAdded);
                            }
                            else if (IsSmallAlphabet(alphabetsAsciiValue))
                            {
                                while (!IsSmallAlphabet(alphabetsAsciiValueWithShiftinFactor))
                                {
                                    alphabetsAsciiValueWithShiftinFactor = 96 + (alphabetsAsciiValueWithShiftinFactor - 122);
                                }

                                alphabetToBeAdded = (char)alphabetsAsciiValueWithShiftinFactor;
                                cipheredText.Append(alphabetToBeAdded);
                            }
                        }
                        else
                        {
                            if (IsCapitalAlphabet(alphabetsAsciiValue))
                            {

                                while(alphabetsAsciiValueWithShiftinFactor < 65)
                                {
                                    alphabetsAsciiValueWithShiftinFactor = 90 - (64 - alphabetsAsciiValueWithShiftinFactor);
                                }
                                alphabetToBeAdded = (char)alphabetsAsciiValueWithShiftinFactor;
                                cipheredText.Append(alphabetToBeAdded);
                            }
                            else if (IsSmallAlphabet(alphabetsAsciiValue))
                            {
                                while(alphabetsAsciiValueWithShiftinFactor < 97)
                                {
                                    alphabetsAsciiValueWithShiftinFactor = 122 - (96 - alphabetsAsciiValueWithShiftinFactor);
                                }
                                alphabetToBeAdded = (char)alphabetsAsciiValueWithShiftinFactor;
                                cipheredText.Append(alphabetToBeAdded);
                            }
                        }

                    }
                }
                else
                {
                    //if the Ascii Value not corresponds to An Alphabet(Capital Or Small)
                    cipheredText.Append(inputString[count]); 
                }
            }
            return cipheredText;
        }
    }
}

