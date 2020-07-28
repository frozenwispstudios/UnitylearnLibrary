using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//create parent class for shapes
abstract class Shape
{
    protected string name;
    protected string author;
    protected float averageRating;
    protected int score;

    public abstract double GetPerimeter();
}

//create a child class to shapes that is a Rectangle
class Rectangle : Shape
{
    private double length;
    private double width;

    //contructor the main class function
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    
    //overrides variables from the standard stuff given
    public override double GetPerimeter()
    {
        return (width + length) * 2;
    }
}

//create a second child class inheriting shapes that is a Triangle
class Triangle : Shape
{
    private double sideA,sideB,sideC;

    //contructor the main class function
    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    //overrides variables from the standard stuff given
    public override double GetPerimeter()
    {
        return sideA + sideB + sideC;
    }
}


public class abstractClassLearn : MonoBehaviour
{
    private void OnDisable()
    {
        Rectangle rectangle = new Rectangle(10, 7);
        Triangle triangle = new Triangle(1, 2, 3);

        //both instacnes of the same class type so both objects can be added to this list
        Shape[] shapes = new Shape[] { rectangle, triangle };

        foreach(Shape shape in shapes)
        {
            print(shape.GetPerimeter());
        }
    }
}
