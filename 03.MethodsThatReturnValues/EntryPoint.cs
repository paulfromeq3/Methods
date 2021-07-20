using System;


class EntryPoint
{
    static void Main()
    {
        // Methods that do return values

        //Console.WriteLine(Addition(1, 1));
        //// Here the Method is almost treated like a variable
        //Console.WriteLine(Addition(Addition(1,2), Addition(4,5)));


        // Challenge #1
        // Create a Method to sort 3 numbers in ascending order, return the output as an array


        Sort(1, 3, 2);


        
    }

    // The void keyword is replaced with the data type
    // This method adds two numbers
    // It's an integer Method
    // In the parenthesis are the arguments for the Method
    // Use the "return" keyword to return a value from the Method
    static int Addition(int firstNumber, int secondNumber)
    {
        // Variables declared inside the Method are only available to the Method
        int result = firstNumber + secondNumber;
        return result;  // It's an integer Method so it can only return integer values
    }


    static string Sort(int a, int b, int c)
    {
        string sorted = string.Empty;

        if ((a > b) && (b > c))
        {
            sorted = a + " ";
            if (b < c)
            {
                sorted = sorted + b + " " + c;
            }
            else
            {
                sorted = sorted + c + " " + b;
            }
        }
        else if ((b < a) && (b < c))
        {
            sorted = b + " ";
            if (a < c)
            {
                sorted = sorted + a + " " + c;
            }
            else
            {
                sorted = sorted + c + " " + a;
            }
        }
        else if ((c < a) && (c < b))
        {
            sorted = c + " ";
            if (a < b)
            {
                sorted = sorted + a + " " + b;
            }
            else
            {
                sorted = sorted + b + " " + a;
            }
        }
        Console.WriteLine($"The result is { sorted}");
        return sorted;
    }
}