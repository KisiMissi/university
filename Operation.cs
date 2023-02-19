public class Operation
{
    private int side1 = 0, side2 = 0, side3 = 0;

    public double HeronFormula(int side)
    {
        (side1, side2, side3) = (side, side, side);

        // Находим полупериметр треугольника и площадь по формуле Герона
        double halfPerimetr = (side1 + side2 + side3) / 2;
        double triangleS = Math.Sqrt( halfPerimetr * Math.Pow( halfPerimetr - side, 3 ));

        return triangleS;

    }

    public double HeronFormula(int side1, int side2, int side3) 
    {
        (this.side1, this.side2, this.side3) = (side1, side2, side3);

        if (IsTriangle())
        {
            return 0;
        }

        // Находим полупериметр треугольника и площадь по формуле Герона
        double halfPerimetr = (side1 + side2 + side3) / 2; 
        double triangleS = Math.Sqrt(halfPerimetr* (halfPerimetr - side1) * (halfPerimetr - side2) * (halfPerimetr - side3));

        return triangleS;
    }

    private Boolean IsTriangle()
    {
        // Треугольник существует только тогда, когда сумма двух его сторон больше третьей
        if ((side1 + side2 <= side3) & (side2 + side3 <= side1) & (side3 + side1 <= side2)) 
        {
            return false;
        } 
        else
        {
            return true;
        }
    }

    public int RootExistence(int a, int b, int c, out double x1, out double x2)
    {
        // Нахождение корней уравнення по заднным коффициентам
        //x1 = 0; x2 = 0;

        int D = (b * b) - (4 * a * c);
        if (D > 0)
        {
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            return 1;
        }
        else if (D == 0)
        {

            x1 = x2 = -b / (2 * a);
            return 0;
        }
        else
        {
            x1 = x2 = 0;
            return -1;
        }
    }

}
