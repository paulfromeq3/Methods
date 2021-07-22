using System;


class EntryPoint
{
    static void Main()
    {
        // Overloading Methods
        // Overloading means you can have multiple methods with the same name
        // Each can have a different signature
        // Each something a little different

        PrintNames("Paul", "Walker");
        PrintNames("Paul", "Brandt", "Walker");
        PrintNames("Paul", "Walker", ConsoleColor.Red);

        Console.WriteLine(Sum(1, 1));
        Console.WriteLine(Sum(234, 345, 456, 567));

        // Look at the different overloads with other methods
        // Type the name, open parenthesis, and press enter
        // The page through the overloads using the up/down arrow keys
        //Console.ReadKey();
        //Console.ReadKey(true);  // this specifically DOES NOT display the key pressed
        //Console.ReadKey(false); // this specifically DOES display the key pressed


        // Challenge #1
        // Create 3 methods with the name "Area"
        // Calculate the area of a square, a rectangle, and a triangle
        // area of a square = length squared
        // area of a rectangle = length times width
        // area of a triangle =
        // (s = 1/2 times sum of the three sides (or divided by 2))
        // then get the square root of (s * (s - a)(s - b)(s - c))
        // Make the variables doubles because lengths are not always an even integer.

        Console.WriteLine($"The area of a square with sides of 5 inches is {Area(5)}");
        Console.WriteLine($"The area of a rectangle with sides 5 inches by 7 inches is {Area(5, 7)}");
        Console.WriteLine($"The area of a triangle with sides 5 inches, 7 inches, and 9 inches is {Area(5, 7, 9)}");



    }

    // Challenge Methods
    // First is area of a square
    static double Area(double sideOne)
    {
        return sideOne * sideOne;
    }

    // Second is area of a rectangle
    static double Area(double sideOne, double sideTwo)
    {
        return sideOne * sideTwo;
    }

    // Third is area of a triangle
    static double Area(double sideOne, double sideTwo, double sideThree)
    {
        // find s
        //double s = (sideOne + sideTwo + sideThree) / 2;
        // Since we already have a Method to add three numbers, let's use it
        double s = Sum(sideOne, sideTwo, sideThree) / 2;
        double area = Math.Sqrt((s * (s - sideOne) * (s - sideTwo) * (s - sideThree)));

        return area;  // You can use the formula here, but this looks cleaner

    }


    // -------------------------------------

    // PrintNames Method has 3 overloads
    static void PrintNames(string firstName, string lastName)  // The arguments are called the signature
    {
        // Output them to the console
        Console.WriteLine($"My name is {firstName} {lastName}");
    }

    static void PrintNames(string firstName, string middleName, string lastName)
    {
        Console.WriteLine($"My name is {firstName} {middleName} {lastName}");

    }

    static void PrintNames(string firstName, string lastName, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"My name is {firstName} {lastName}.");
        Console.ResetColor();
    }

    // Sum Method also has 3 overloads
    static int Sum(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    static double Sum(double firstNumber, double secondNumber, double thirdNumber)
    {
        return firstNumber + secondNumber + thirdNumber;
    }

    static double Sum(double firstNumber, double secondNumber, double thirdNumber, double fourthNumber)
    {
        return firstNumber + secondNumber + thirdNumber + fourthNumber;
    }
}