using System;

namespace VolumeCompare {
    internal class Program {
        static void Main(string[] args) {
            // Input radius and side data
            Console.WriteLine("Enter the radius of a sphere");
            double sphereRadiusValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side of a cube");
            double cubeRadiusValue = double.Parse(Console.ReadLine());

            // Calculate volumes
            double sphereVolumeValue = (4.0 / 3.0) * Math.PI * Math.Pow(sphereRadiusValue, 3);
            double cubeVolumeValue = Math.Pow(cubeRadiusValue, 3);

            // Compare volumes

            if (sphereVolumeValue > cubeVolumeValue) {
                Console.WriteLine("The sphere volume is larger than the cube volume.");
            }
            else if (sphereVolumeValue < cubeVolumeValue) {
                Console.WriteLine("The sphere volume is smaller than the cube volume.");
            }
            else {
                Console.WriteLine("The volumes are equal.");
            }

            // Input mass data

            Console.WriteLine("Enter the mass of the sphere");
            double sphereMassValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the mass of the cube");
            double cubeMassValue = double.Parse(Console.ReadLine());

            // Calculate the density

            double sphereDensityValue = sphereMassValue / sphereVolumeValue;
            double cubeDensityValue = cubeMassValue / cubeVolumeValue;

            // Compare the density

            if(sphereDensityValue > cubeDensityValue) {
                Console.WriteLine("The sphere density is larger than the cube volume.");
            } else if(sphereDensityValue < cubeDensityValue) {
                Console.WriteLine("The sphere density is smaller than the cube volume.");
            } else {
                Console.WriteLine("The volumes are equal.");
            }
            Console.ReadKey();
        }
    }
}
