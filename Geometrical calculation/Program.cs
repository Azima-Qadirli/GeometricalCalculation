using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            MainMenu();
            int mainChoice = GetMainChoice();
            if (mainChoice == 3)
            {
                if (ConfirmationToExit())
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            else if (mainChoice == 1 || mainChoice == 2)
            {
                FigureSelection();
                int figureChoice = GetFigureChoice();
                if (figureChoice == 5)
                {
                    continue;
                }

                if (mainChoice == 1)
                {
                    PerformAreaCalculation(figureChoice);
                }
                else if (mainChoice == 2)
                {
                    PerformPerimeterCalculation(figureChoice);
                }
            }
        }
    }

    static void MainMenu()
    {
        Console.WriteLine("Welcome to the main menu:");
        Console.WriteLine("1. Calculation of area");
        Console.WriteLine("2. Calculation of perimeter");
        Console.WriteLine("3. Exit");
        Console.Write("Select a choice: ");
    }

    static int GetMainChoice()
    {
        int choice;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                Console.Write("Enter your choice again: ");
            }
        }
    }

    static void FigureSelection()
    {
        Console.WriteLine("Figure Selection:");
        Console.WriteLine("1. Square");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Triangle");
        Console.WriteLine("4. Circle");
        Console.WriteLine("5. Main menu");
        Console.Write("Select a choice: ");
    }

    static int GetFigureChoice()
    {
        int choice;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                Console.Write("Enter your choice again: ");
            }
        }
    }

    static void PerformAreaCalculation(int figureChoice)
    {
        double area = 0;
        switch (figureChoice)
        {
            case 1:
                double side = PositiveNumber("Enter the side length of the square: ");
                area = side * side;
                break;
            case 2:
                double length = PositiveNumber("Enter the length of the rectangle: ");
                double width = PositiveNumber("Enter the width of the rectangle: ");
                area = length * width;
                break;
            case 3:
                double baseLength = PositiveNumber("Enter the base length of the triangle: ");
                double height = PositiveNumber("Enter the height of the triangle: ");
                area = 0.5 * baseLength * height;
                break;
            case 4:
                double radius = PositiveNumber("Enter the radius of the circle: ");
                area = Math.PI * radius * radius;
                break;
            default:
                Console.WriteLine("Invalid figure choice.");
                break;
        }
        Console.WriteLine($"The area is: {area}");
    }

    static void PerformPerimeterCalculation(int figureChoice)
    {
        double perimeter = 0;
        switch (figureChoice)
        {
            case 1:
                double side = PositiveNumber("Enter the side length of the square: ");
                perimeter = 4 * side;
                break;
            case 2:
                double length = PositiveNumber("Enter the length of the rectangle: ");
                double width = PositiveNumber("Enter the width of the rectangle: ");
                perimeter = 2 * (length + width);
                break;
            case 3:
                double side1 = PositiveNumber("Enter the first side length of the triangle: ");
                double side2 = PositiveNumber("Enter the second side length of the triangle: ");
                double side3 = PositiveNumber("Enter the third side length of the triangle: ");
                perimeter = side1 + side2 + side3;
                break;
            case 4:
                double radius = PositiveNumber("Enter the radius of the circle: ");
                perimeter = 2 * Math.PI * radius;
                break;
            default:
                Console.WriteLine("Invalid figure choice.");
                break;
        }
        Console.WriteLine($"The perimeter is: {perimeter}");
    }

    static bool ConfirmationToExit()
    {
        Console.Write("Are you sure you want to exit the application? (b/B/x/X): ");
        char choice;
        while (true)
        {
            if (char.TryParse(Console.ReadLine(), out choice) && (choice == 'b' || choice == 'B' || choice == 'x' || choice == 'X'))
            {
                return choice == 'b' || choice == 'B';
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'b', 'B', 'x', or 'X'.");
            }
        }
    }

    static double PositiveNumber(string prompt)
    {
        double number;
        Console.Write(prompt);
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                Console.Write(prompt);
            }
        }
    }
}
