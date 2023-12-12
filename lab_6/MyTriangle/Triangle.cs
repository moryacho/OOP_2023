using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//В этом упражнении требуется создать класс Triangle, разработав
//следующие элементы класса:
//· Поля: стороны треугольника. +
//· Конструктор, позволяющий создать экземпляр класса с заданными
//длинами сторон. +
//· Методы, позволяющие:
//-вывести длины сторон треугольника на экран; +
//-расчитать периметр треугольника; +
//-расчитать площадь треугольника; +
//- реализовать проверку, позволяющую установить, существует ли
//треугольник с данными длинами сторон. +

namespace MyTriangle;

internal class Triangle
{
    private int side1 = 0;
    private int side2 = 0;
    private int side3 = 0;

    public Triangle(int side1, int side2, int side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public Triangle()
    {
    }

    public void Show()
    {
        Console.WriteLine($"side 1: {side1}\n" +
            $"side 2: {side2}\n" +
            $"side 3: {side3}");
    }

    public int GetPerimeter()
    {
        if (IsExist())
        {
            int perimeter = side1 + side2 + side3;
            return perimeter;
        }

        return 0;
    }

    public double GetSquare()
    {
        double halfPerimener = GetPerimeter() / 2;
        double square = Math.Sqrt(halfPerimener * (halfPerimener - side1) *
            (halfPerimener - side2) * (halfPerimener - side3));
        return square;
    }

    public bool IsExist()
    {
        List<int> sides = new List<int>() { side1, side2, side3 };
        if (sides.Sum() - 2 * sides.Max() > 0)
        {
            return true;
        }

        return false;
    }
}
