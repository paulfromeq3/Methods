using System;

class EntryPoint
{
    static void Main()
    {
        // Creating a method that has optional values.
        // It's not actually optional, it just looks that way when you use it.
        // It's really using default values.
        // This is an approach to using methods that ensures it works properly
        // even if the user decides not to use a value for some of the arguments.

        // Create a method that multiplies three numbers.

        Console.WriteLine(Multi(9, 7, 5));


    }

    static int Multi(int firstNumber, int secondNumber, int thirdNumber)
    {
        return firstNumber * secondNumber * thirdNumber;
    }
}
