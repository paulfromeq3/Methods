using System;


class EntryPoint
{
    static void Main()
    {
        // This project is about two more keywords we can use with Methods.
        // They are:
        // ref
        // out
        // These keywords can make your Methods more flexible.
        //
        // The ref keyword makes any argument that you use it on to be passed as a reference type.
        // Even if the argument is a value type, it will be passed as a reference type within that Method.
        // If you modify an integer variable inside the Method, that will be reflected on the outside of the Method, too.
        // Remove the "ref" from both Methods and the number is not changed in the main method.

        int number = 0;
        Console.WriteLine($"{ number}");
        IncreaseByOne(ref number);
        Console.WriteLine($"{number}");

        // Alternate
        // number = IncreaseByOne(number);
        // Why use the "ref" keyword?
        // It's handy when you have multiple arguments.





    }

    static void IncreaseByOne(ref int number)
    {
        number++;
        // Alternate
        // Change "void" to "int" in the declaration.
        // Then add:
        // return number;

    }
}
