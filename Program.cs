using System;

namespace _.Net_Lesson_1_basics
{
    internal class Program
    {
        public class Rectangle
        {
            private double lenght;
            private double width;

            public void AcceptDetails()
            {
                lenght = 4.5;
                width = 3.5;
            }

            private double GetArea()
            {
                return lenght * width;
            }

            public void Display()
            {
                double area = GetArea();
                Console.WriteLine($"Ilgis {lenght}");
                Console.WriteLine($"Plotis {width}");
                Console.WriteLine($"Plotas yra {area}");
            }
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.AcceptDetails();
            rect.Display();
            
            
        }
    }
}
