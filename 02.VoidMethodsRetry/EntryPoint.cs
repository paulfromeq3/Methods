using System;

class EntryPoint
{
    static void Main()
    {
        // The static key word
        // Basically means that there can only be one of them
        // We'll get more into that in object oriented programming
        //
        // The void key word
        // It means the Method doesn't return anything
        // It returns nothing

        // Hover over "WriteLine" below and you can see it says "void Console.WriteLine()"
        // This means that the WriteLine Method doesn't return any values.
        Console.WriteLine();
        ChangeColor("My name is Paul", ConsoleColor.Red);
    }

    static void ChangeColor(string message, ConsoleColor textColor)
    {
        // Variables inside the Method are only accessable to the Method
        // Create arguments for the Method if you want to return values
        // The signature of the Method is inside the parenthesis
        Console.ForegroundColor = textColor;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
