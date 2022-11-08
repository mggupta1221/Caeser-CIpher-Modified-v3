using CaeserCipherAlgorithm;
using System.Text;

public class Program{
    public static void Main()
    {
        try
        {
            Console.Write("Enter text:");
            string inputString = Console.ReadLine();
            Console.Write("Enter Shifting factor:");
            bool isValidShiftingFactor=int.TryParse(Console.ReadLine(), out int shiftingFactor);

            if (isValidShiftingFactor)
            {
                CaeserCipher ceaserCipher = new CaeserCipher();
                StringBuilder cipheredText = ceaserCipher.DoCeaserCipher(inputString, shiftingFactor);
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
