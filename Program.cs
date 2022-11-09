using CaeserCipherAlgorithm;
using System.Text;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter text:");
            string inputText = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputText))
            {
                Console.WriteLine("Input Text is Empty,Null Or Contains Whitespaces");
                throw new Exception("Input Text is Empty,Null Or Contains Whitespaces");
            }
            Console.Write("Enter Shifting factor:");
            bool isValidShiftingFactor = long.TryParse(Console.ReadLine(), out long  shiftingFactor);
            if (isValidShiftingFactor)
            {
                CaeserCipher ceaserCipher = new CaeserCipher();
                StringBuilder cipheredText = ceaserCipher.DoCeaserCipher(inputText, shiftingFactor);
                Console.WriteLine("Ciphered Text:" + cipheredText);
            }
            else
            {
                Console.WriteLine("Shifting Factor is not A Number");
                throw new Exception("Shifting Factor is not A Number");

            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
        catch (NullReferenceException ex1)
        {
            Console.WriteLine(ex1.Message);
            Console.WriteLine();
        }
    }

}
