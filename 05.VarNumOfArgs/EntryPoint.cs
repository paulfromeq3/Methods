using System;


class EntryPoint
{
    static void Main()
    {
        // Methods that can take an unlimited number of arguments
        // They have to be the same type variables
        // First example takes integers
        // Just numbers, no special arguments
        // Must use "params" argument before the type
        // NOTE: you CAN create an array Method without useing the "params" keyword, but you have to use an array as input
        // In the example below, we use the "params" keyword and just give it a bunch of integers.
        // Since there could be any number of values, the type will be an array of integers
        // Last you need the variable to which you're going to assign the values

        //Console.WriteLine(Sum(1, 3, 4, 5, 7, 8, 8, 44, 55, 44, 33, 22, 6, 4, 3, 3, 2, 4, 5));
        // You could also rename this Method something like "Perimeter()" and feed it the sides of the object you want the perimeter for.
        // It could be an any-sided object, it would still work.

        // I usually use interpolation, but...
        // Using Placeholders

        //int firstNumber = 5;
        //int secondNumber = 7;
        //int thirdNumber = 9;

        //Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);

        // Challenge 1
        // Make your own version of the WriteLine Method to use placeholders
        // Basically recreate it in your own way
        // I guess use [] square brackets to separate the numbers


        string firstName = "Paul";

        string lastName = "Walker";

        MyWriteLine("[0] [1] [0] [1] [0] [1]", firstName, lastName);






    }
    // If you wanted to return the text instead of just printing it to the console, change "void" to "string" in the method,
    // and add "return text;" line to the body of the method.

    static void MyWriteLine(string text, params string[] variables)
    {

        string newText = string.Empty;
        int placeholderIndex = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].ToString() == "[")
            {
                // When you index something from a string, it is returned as a character type
                // First we need to convert it to a string, and then to an integer
                // It takes all that to work with the number after the open curley braces as an integer
                // To make it easier to read, it is now split up

                placeholderIndex = int.Parse(text[i + 1].ToString());
                // The placeholderIndex variable calculates the placeholder index

                newText += variables[placeholderIndex];
                i += 2;
            }
            else
            {
            newText += text[i];

            }
        }
        Console.WriteLine(newText);

        // if you take a character of text like text[i], you get a char type
        // convert it to string with the ToString() Method if you want to use it




    }

    //static int Sum(params int[] numbers)
    //{
    //    // Since you don't know how many numbers there are, you need to iterate through them with a for or foreach loop
    //    int sum = 0;
    //    for (int i = 0; i < numbers.Length; i++)
    //    {
    //        sum += numbers[i];
    //    }
    //    return sum;

    //}
}