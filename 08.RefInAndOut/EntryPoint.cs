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

        ////////////////////////
        // Another example of ref: coordinates
        double x = 10;
        CorrectTheCoordinates(ref x, out double y);
        Console.WriteLine($"{x}, {y}");

        // The "out" keyword.
        // Similar to ref, but must always be assigned INSIDE the method.
        // So create the empty variable in the Main method.
        // Then give it a value inside the other method.
        // After that, you are free to use them from outside the method.
        // Shortcut:  you can create the variable when you call the method.

        Rectangle(5, 10, out double area, out double perimeter);
        Console.WriteLine($"The area is: {area}.\nThe perimeter is {perimeter}.");




    }

    static void IncreaseByOne(ref int number)
    {
        number++;
        // Alternate
        // Change "void" to "int" in the declaration.
        // Then add:
        // return number;
    }

    static void CorrectTheCoordinates(ref double x, out double y)
    {
        // say that x needs to be corrected by 10%
        x *= 1.1;
        y = 10;
    }

    // Challenge
    // Create a method that takes 2 arguments, height and width.
    // Calculate the area and perimeter of a rectangle.
    // Return the values and output them from the console outside the method.
    static void Rectangle(double height, double width, out double area, out double perimeter)
    {
        height = 12;
        width = 32;
        area = height * width;
        perimeter = height * 2 + width * 2;

    }
}
