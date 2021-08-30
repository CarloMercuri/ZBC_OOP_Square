using System;

namespace ZBC_OOP_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave A

            Console.WriteLine("----------------- OPGAVE A ------------------");

            Square sq1 = new Square(5);
            Console.WriteLine($"Square 1 - Side Lenght: {sq1.SideLenght} Area: {sq1.GetArea()}, Perimeter: {sq1.GetPerimeter()}");

            Square sq2 = new Square(2);
            Console.WriteLine($"Square 2 - Side Lenght: {sq2.SideLenght} Area: {sq2.GetArea()}, Perimeter: {sq2.GetPerimeter()}");

            Square sq3 = new Square(19);
            Console.WriteLine($"Square 3 - Side Lenght: {sq3.SideLenght} Area: {sq3.GetArea()}, Perimeter: {sq3.GetPerimeter()}");

            Square sq4 = new Square(28);
            Console.WriteLine($"Square 4 - Side Lenght: {sq4.SideLenght} Area: {sq4.GetArea()}, Perimeter: {sq4.GetPerimeter()}");

            // Opgave B

            // Changing side lenghts of each square
            sq1.SideLenght = 15;
            sq2.SideLenght = 5;
            sq3.SideLenght = 33;
            sq4.SideLenght = 55;

            Console.WriteLine("");
            Console.WriteLine("----------------  OPGAVE B ----------------");
            Console.WriteLine("");
            Console.WriteLine("Changed the side lenght values for the squares!");
            Console.WriteLine("");
            Console.WriteLine("New values:");
            Console.WriteLine("");

            Console.WriteLine($"Square 1 - Side Lenght: {sq1.SideLenght} Area: {sq1.GetArea()}, Perimeter: {sq1.GetPerimeter()}");


            Console.WriteLine($"Square 2 - Side Lenght: {sq2.SideLenght} Area: {sq2.GetArea()}, Perimeter: {sq2.GetPerimeter()}");

            Console.WriteLine($"Square 3 - Side Lenght: {sq3.SideLenght} Area: {sq3.GetArea()}, Perimeter: {sq3.GetPerimeter()}");

            Console.WriteLine($"Square 4 - Side Lenght: {sq4.SideLenght} Area: {sq4.GetArea()}, Perimeter: {sq4.GetPerimeter()}");


            Console.ReadKey();
        }
    }
}
