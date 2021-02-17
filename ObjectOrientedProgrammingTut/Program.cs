using System;
// objects are the base class in .NET


namespace ObjectOrientedProgrammingTut {
	class Program {
		static void Main(string[] args) {


			var quad1 = new Quad(3,7,4,5);
			Console.WriteLine($"quad1 perimeter is {quad1.GetPerimeter()},\n    and area is unknown,\n    print is {quad1.Print()}.\n");

			var rect1 = new Rect(3,7);
			Console.WriteLine($"rect1 perimeter is {rect1.GetPerimeter()},\n    and area is {rect1.GetArea()},\n    print is {rect1.Print()}.\n");

			var sqr1 = new Sqr(5);
			Console.WriteLine($"sqr1 perimeter is {sqr1.GetPerimeter()},\n    and area is {sqr1.GetArea()},\n    print is {sqr1.Print()}.\n");

			var poly = new Quad[] { sqr1, rect1, quad1 };

			foreach (var quad in poly) {
				Console.WriteLine($"Type of {quad.Print()}.\n" );
			}

		}
	}
}
