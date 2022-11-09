using CaeserCipherAlgorithm;
using System.Text;

public class Program
{
    public static void Main()
    {
            CaeserCipher ceaserCipher = new CaeserCipher();
            Console.Write("Enter text:");
            string? inputText = Console.ReadLine();
            if (string.IsNullOrEmpty(inputText))
            {
                Console.WriteLine("Input Text Is Empty Or Null");
                throw new InputTextException("Input Text Is Empty Or Null");
            }
            Console.Write("Enter Shifting factor:");
            // check entered factor is valid or not
            bool isValidShiftingFactor = long.TryParse(Console.ReadLine(), out long  shiftingFactor);
            if (isValidShiftingFactor)
            {
                StringBuilder cipheredText = ceaserCipher.DoCeaserCipher(inputText, shiftingFactor);
                Console.WriteLine($"Ciphered Text:{cipheredText}");
            }
            else
            {
                Console.WriteLine("Shifting Factor Is Invalid!!! Shifting factor Must Be A Number Within Range of Underlying Datatype");
                throw new ShiftingFactorException("Shifting Factor Is Invalid!!! Shifting factor Must Be A Number Within Range of Underlying Datatype");

            }
    }



}
