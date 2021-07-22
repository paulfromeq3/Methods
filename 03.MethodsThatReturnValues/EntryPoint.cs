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
        int[] sortedArray = Sort(3, 1, 2);
        Console.WriteLine($"{sortedArray[0]}, {sortedArray[1]}, {sortedArray[2]}");

        
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
        return result;  // It's an integer array Method so it can only return integer values
    }


    static int[] Sort(int a, int b, int c)
    {
        int[] sorted = new int[3];

        if ((a < b) && (a < c))
        {
            sorted[0] = a;
            if (b < c)
            {
                sorted[1] = b;
                sorted[2] = c;
            }
            else
            {
                sorted[1] = c;
                sorted[2] = b;
            }
        }
        else if ((b < a) && (b < c))
        {
            sorted[0] = b;
            if (a < c)
            {
                sorted[1] = a;
                sorted[2] = c;
            }
            else
            {
                sorted[1] = c;
                sorted[2] = a;
            }
        }
        else if ((c < a) && (c < b))
        {
            sorted[0] = c;
            if (a < b)
            {
                sorted[1] = a;
                sorted[2] = b;
            }
            else
            {
                sorted[1] = b;
                sorted[2] = a;
            }
        }
        return sorted;
    }
}