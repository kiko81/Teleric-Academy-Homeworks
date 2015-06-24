/*
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

using System;

class PointInCircleOutRect
{
    static void Main()
    {
    Input_X:
        Console.Write("Please enter x value of your point: ");
        double pointX;
        if (!double.TryParse(Console.ReadLine(), out pointX))
        {
            Console.WriteLine("Wrong input number, try again");
            goto Input_X;
        }

    Input_Y:
        Console.Write("Please enter y value of your point: ");
        double pointY;
        if (!double.TryParse(Console.ReadLine(), out pointY))
        {
            Console.WriteLine("Wrong input number, try again");
            goto Input_Y;
        }

        bool inCircle = Math.Sqrt((pointX - 1) * (pointX - 1) + (pointY - 1) * (pointY - 1)) <= 1.5;
        bool inRectangle = pointX >= -1 && pointX <= 5 && pointY >= 1 && pointY <= 3;

        if (inCircle && !inRectangle)
        {
            Console.WriteLine("The chosen point ({0}, {1}) is in the circle K({{1, 1}}, 1.5)and out of the rectangle R(top=1, left=-1, width=6, height=2)", pointX, pointY);
        }
        else
        {
            Console.WriteLine("The chosen point ({0}, {1}) doesnt match the given condition ", pointX, pointY);
        }
    }
}