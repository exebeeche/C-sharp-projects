using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace TeaPot {

    public enum Model {
        Vitek = 1,
        Bosch,
        Redmond,
        Xiaomi,
        Polaris
    }

    public class Teapot {
        public Teapot(int temp) {
            ChooseModel();
            this.currentTemp = temp;
            switch (this.Model) {
                case Model.Vitek:
                    Console.WriteLine($"The Vitek teapot has {maxVolume = 1.8f} liters");
                    break;
                case Model.Bosch:
                    Console.WriteLine($"The Bosch teapot has {maxVolume = 1.7f} liters");
                    break;
                case Model.Redmond:
                    Console.WriteLine($"The Redmond teapot has {maxVolume = 1.9f} liters");
                    break;
                case Model.Xiaomi:
                    Console.WriteLine($"The Xiaomi teapot has {maxVolume = 1.5f} liters");
                    break;
                case Model.Polaris:
                    Console.WriteLine($"The Polaris teapot has {maxVolume = 2.0f} liters");
                    break;
                default:
                    Console.WriteLine("You have chosen unknown teapot");
                    break;
            }
        }

        public void ChooseModel() {
            Console.WriteLine($"Choose the teapot model, enter a number in a range 1 - 5: {Environment.NewLine}" +
                $"1 - Vitek; {Environment.NewLine}" +
                $"2 - Bosch; {Environment.NewLine}" +
                $"3 - Redmond; {Environment.NewLine}" +
                $"4 - Xiaomi; {Environment.NewLine}" +
                $"5 - Polaris; {Environment.NewLine}");
            //int model = int.Parse(Console.ReadLine());
            /*if(model == 1) {
                this.Model = Model.Vitek;
            } else if (model == 2) {
                this.Model = Model.Bosch;
            } else if(model == 3) {
                this.Model = Model.Redmond;
            } else if(model == 4) {
                this.Model = Model.Xiaomi;
            } else if(model == 5) {
                this.Model = Model.Polaris;
            }*/
            this.Model = (Model)int.Parse(Console.ReadLine());
        }
        float maxVolume, currentVolume;
        int maxTemp = 100;
        int currentTemp;
        Model Model;

        public void ChangeVolume() {
            float volume = 0;
            while (volume < maxVolume) {
                volume += 0.1f;
            }
            currentVolume = volume;
        }

        public void ChangeTemp() {
            int temp = 0;
            while (temp < maxTemp) {
                temp++;
            }
            currentTemp = temp;
        }

        public void PrintInfo(Model model) {
            Console.WriteLine($"The teapot {Model} has the {maxVolume} liters. Current volume is {currentVolume} liters, current temperature is {currentTemp} degrees.");
        }

    }

    internal class Program {
        static void Main(string[] args) {
            Teapot teapot = new Teapot(20);
            teapot.PrintInfo(Model.Vitek);
            Console.WriteLine("Press Enter to pure water");
                ConsoleKey consoleKey = Console.ReadKey().Key;
                if(consoleKey == ConsoleKey.Enter) {
                    teapot.ChangeVolume();
                }
            teapot.PrintInfo(Model.Vitek);
            Console.WriteLine("Press Enter to heat water");
                consoleKey = Console.ReadKey().Key;
                if (consoleKey == ConsoleKey.Enter) {
                    teapot.ChangeTemp();
                }
            teapot.PrintInfo(Model.Vitek);
            Console.ReadLine();
        }
    }
}
