using CaeserCipherAlgorithm;
using System.Text;

public class Program
{
    public static void Main()
    {
            CaeserCipher ceaserCipher = new CaeserCipher();
            Console.Write("Enter text:");
            string inputText = Console.ReadLine();
            if (string.IsNullOrEmpty(inputText))
            {
                Console.WriteLine("Input Text is Empty or Null");
                throw new InputTextException("Input Text is Empty or Null");
            }
            Console.Write("Enter Shifting factor:");
            bool isValidShiftingFactor = long.TryParse(Console.ReadLine(), out long  shiftingFactor);
            if (isValidShiftingFactor)
            {
                StringBuilder cipheredText = ceaserCipher.DoCeaserCipher(inputText, shiftingFactor);
                Console.WriteLine($"Ciphered Text:{cipheredText}");
            }
            else
            {
                Console.WriteLine("Shifting Factor is invalid");
                throw new ShiftingFactorException("Shifting Factor is invalid");

            }
    }



}
