using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- .NET Division & Conversion Tool ---");

        Console.Write("Enter the dividend (number to be divided): ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the divisor (number to divide by): ");
        string input2 = Console.ReadLine();

        ProcessDivision(input1, input2);
        
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }

    static void ProcessDivision(string str1, string str2)
    {
        try
        {
            // Conversion Step
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);

            // Division Step
            int result = num1 / num2;

            Console.WriteLine($"\nSuccess! Result: {num1} / {num2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One of the inputs is not a valid integer. Please enter digits only.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number entered is too large or too small for a 32-bit integer.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not mathematically defined.");
        }
        catch (Exception ex)
        {
            // Catch-all for unexpected issues (like a NullReference)
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}