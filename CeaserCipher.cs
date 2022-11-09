using System;
using System.Text;

namespace CaeserCipherAlgorithm
{
    public class CaeserCipher
    {
        private StringBuilder cipheredText = new StringBuilder();



        private bool IsAlphabet(int alphabetsAsciiValue)
        {
            return ((IsCapitalAlphabet(alphabetsAsciiValue) || IsSmallAlphabet(alphabetsAsciiValue)));
        }
        private bool IsCapitalAlphabet(int alphabetsAsciiValue)
        {
            return (alphabetsAsciiValue >= 65 && alphabetsAsciiValue <= 90);
        }
        private bool IsSmallAlphabet(int alphabetsAsciiValue)
        {
            return (alphabetsAsciiValue >= 97 && alphabetsAsciiValue <= 122);
        }


        public StringBuilder DoCeaserCipher(string inputString, int shiftingFactor)
        {
            char alphabetToBeAdded;
            for (int count = 0; count < inputString.Length; count++)
            {
                int alphabetsAsciiValue = (int)(inputString[count]);
                if (IsAlphabet(alphabetsAsciiValue))
                {
                    int alphabetsAsciiValueWithShiftinFactor = alphabetsAsciiValue + shiftingFactor;
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
                                if (alphabetsAsciiValueWithShiftinFactor < 65)
                                {
                                    alphabetsAsciiValueWithShiftinFactor = 90 - (64 - alphabetsAsciiValueWithShiftinFactor);
                                }
                                alphabetToBeAdded = (char)alphabetsAsciiValueWithShiftinFactor;
                                cipheredText.Append(alphabetToBeAdded);
                            }
                            else if (IsSmallAlphabet(alphabetsAsciiValue) && alphabetsAsciiValueWithShiftinFactor < 97)
                            {
                                alphabetsAsciiValueWithShiftinFactor = 122 - (96 - alphabetsAsciiValueWithShiftinFactor);
                                alphabetToBeAdded = (char)alphabetsAsciiValueWithShiftinFactor;
                                cipheredText.Append(alphabetToBeAdded);
                            }
                        }

                    }
                }
                else
                {
                    cipheredText.Append(inputString[count]);
                }
            }
            return cipheredText;
        }
    }
}

