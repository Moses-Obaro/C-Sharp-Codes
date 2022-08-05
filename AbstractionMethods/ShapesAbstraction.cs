using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_WORKS
{
    /*
     * The shape abstract class cannot be used to create shapes
     * But it can be used to define rules to define rules for various shape types
     * All shape types are made to inherit the ShapeRules Class.
     * This means that you can't just create a 
     */
    abstract class ShapeRules
    {
        public abstract double PerimeterOfShape();
        public abstract double AreaOfShape();
        public abstract double[] GetDimensions();

        public void Welcome()
        {
            Console.WriteLine("Welcome to SHAPES. ");
            Console.Write("A sahape is a closed figure");
        }
    }

    class Rectangle : ShapeRules
    {
        public override double[] GetDimensions()
        {
            string[] dimensions = {"breadth","length"};
            double length, breadth;
            double[] Dimensions = new double[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("enter the {0} of the rectangle: ", dimensions[i]);
                Dimensions[i] = Convert.ToInt32(Console.ReadLine());
            }

            length = Dimensions[0];
            breadth = Dimensions[1];                       
            return Dimensions;
        }

        public override double AreaOfShape()
        {
            double area,length, breadth;
            double [] dimensions = GetDimensions();
            breadth = dimensions[0];
            length = dimensions[1]; 
            area = breadth * length;
            return area;
        }

        public override double PerimeterOfShape()
        {
            double perimeter, length, breadth;
            double[] dimensions = GetDimensions();
            breadth = dimensions[0];
            length = dimensions[1];
            
            perimeter = 2 * (length + breadth);
            return perimeter;
        }

        private void DisplayMessage()
        {
            Console.WriteLine("Hello there, I am a rectangle. " +
                "\nI have a breadth and a length. " +
                "\nYou can do some mathematics with me." +
                "\nYou can calculate my Area or my Perimeter" +
                "\nEnter A to calculate my Area and P for my Perimeter." +
                "\nIf none of this is entered, I will calculate show you today's date.");
            Console.WriteLine();
        }

        private void DisplayResultArea()
        {
            Console.WriteLine("The area of this rectangle is: {0}",AreaOfShape());
        }
        private void DisplayResultPerimeter()
        {
            Console.WriteLine("The perimeter of this rectangle is: {0}", PerimeterOfShape());
        }
        public void StartRectangle()
        {
            DisplayMessage();
            Console.Write("What would you like to calculate: ");
            string rectangleOperation = Console.ReadLine().ToLower();
            if (rectangleOperation == "a")
            {
                DisplayResultArea();
            } 
            else if (rectangleOperation == "p")
            {
                DisplayResultPerimeter();
            }
            else
            {
                Console.WriteLine("Today's date and Currrent time is: {0}", DateTime.Now);
            }
        }
    }
    class Circle : ShapeRules
    {

        public override double AreaOfShape()
        {
            double area, diameter;
            double[] dimensions = GetDimensions();
            diameter = dimensions[0];
            area = (diameter / 2) * Math.Pow(3.142, 2);
            return area;
        }

        public override double[] GetDimensions()
        {
            Console.Write("Enter diameter of the circle: ");
            double[] diameter = new double[1];
            diameter[0] = Convert.ToDouble(Console.ReadLine());
            return diameter;
        }

        public override double PerimeterOfShape()
        {
            double perimeter, diameter;
            double[] dimensions = GetDimensions();
            diameter = dimensions[0];
            perimeter = (diameter /2) * 3.142;
            return perimeter;
        }
        private void DisplayMessage()
        {
            Console.WriteLine("Hello there, I am a circle. " +
                "\nI have a diameter (This is twice a radius). " +
                "\nYou can do some mathematics with me." +
                "\nYou can calculate my Area or my Perimeter (I personally call it Circumference)" +
                "\nEnter A to calculate my Area and P for my Perimeter." +
                "\nIf none of this is entered, I will calculate show you today's date.");
            Console.WriteLine();
        }

        private void DisplayResultArea()
        {
            Console.WriteLine("The area of this circle is: {0}", AreaOfShape());
        }
        private void DisplayResultPerimeter()
        {
            Console.WriteLine("The perimeter of this circle is: {0}", PerimeterOfShape());
        }
        public void StartCircle()
        {
            DisplayMessage();
            Console.Write("What would you like to calculate: ");
            string Operation = Console.ReadLine().ToLower();
            if (Operation == "a")
            {
                DisplayResultArea();
            }
            else if (Operation == "p")
            {
                DisplayResultPerimeter();
            }
            else
            {
                Console.WriteLine("Today's date and Currrent time is: {0}", DateTime.Now);
            }
        }
    }

    class UserShapes
    {
        private void DetermineShapeType()
        {
            Console.WriteLine();
            string shapeType;
            Console.Write("Enter the shape you want to work with (C for circle, R for rectangle): ");
            shapeType = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (shapeType == "r") 
            {
                Rectangle rectangle = new Rectangle();
                rectangle.StartRectangle();
            } 
            else if (shapeType == "c")
            {
                Circle circle = new Circle();
                circle.StartCircle();
            }
            else
            {
                Console.WriteLine("We don't recognize that shape type; exiting application");
                Console.WriteLine("The time is {0}",DateTime.Now);
            }
        }
        public void StartShapes()
        {
            Console.Write("Welcome to shapes!!! " +
                "\nThis is just to test abstraction using the abstract keyword");
            Console.WriteLine();
            DetermineShapeType();
        }
    }
}

