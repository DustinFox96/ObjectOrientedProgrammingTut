using System;

namespace ObjectOrientedProgrammingTut {
    class Program {
        static void Main(string[] args) {
            var sqr1 = new Sqr(7);
            Console.WriteLine($" SQR: Perimeter is {sqr1.Perimeter() }");
            Console.WriteLine($" SQR: Area is {sqr1.Area() }");

            var rect1 = new Rect(5, 7);
            // up above now works and it less work becasue of the work we did on the Rect class with the base attached to our methods
            //rect1.Side1 = 3;
            //rect1.Side2 = 4;
            //rect1.Side3 = 5;
            //rect1.Side4 = 6;
            Console.WriteLine($"Perimeter is {rect1.Perimeter() }");
            Console.WriteLine($"Area is {rect1.Area() }");
            //Console.WriteLine($"About is {rect.About});
        }
    }
}
