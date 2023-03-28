using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle {
    internal class Program {
        static void Main(string[] args) {

            // Input data
            Console.WriteLine("Enter the X coordinate of a circle");
            double circleX1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinate of a circle");
            double circleY1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius of a circle");
            double circleRadius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X coordinate of a point");
            double pointX2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinate of a point");
            double pointY2 = double.Parse(Console.ReadLine());

            // Calculate the distance between the circle center and the point

            double distancePointCircle = Math.Sqrt(Math.Pow(pointX2 - circleX1, 2) + Math.Pow(pointY2 - circleY1, 2));

            // Check if the distance is less than or equal to the radius of the sphere

            if (distancePointCircle <= circleRadius) {
                Console.WriteLine("The point is in the circle!");
            }
            else { Console.WriteLine("The point is out of the circle");
            }
            Console.ReadLine();
        }
    }
}
