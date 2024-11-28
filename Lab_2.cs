using System;
using System.Text;
class Quadrangle
{
    private (double x, double y) _a;
    private (double x, double y) _b;
    private (double x, double y) _c;
    private (double x, double y) _d;
    public Quadrangle((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d)
    {
        _a = a;
        _b = b;
        _c = c;
        _d = d;
    }
    private double Distance((double x, double y) p1, (double x, double y) p2)
    {
        return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
    }
    public double Perumeter()
    {
        double AB = Distance(_a, _b);
        double BC = Distance(_b, _c);
        double CD = Distance(_c, _d);
        double DA = Distance(_d, _a);
        Console.WriteLine($"AB = {AB}");
        Console.WriteLine($"BC = {BC}");
        Console.WriteLine($"CD = {CD}");
        Console.WriteLine($"DA = {DA}");
        return AB + BC + CD + DA;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        (double, double) ReadPoint(string pointName)
        {
            Console.WriteLine($"Введіть координати точки {pointName}:");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            return (x, y);
        }
        var a = ReadPoint("A");
        var b = ReadPoint("B");
        var c = ReadPoint("C");
        var d = ReadPoint("D");
        Quadrangle quadrilateral = new Quadrangle(a, b, c, d);
        Console.WriteLine("Периметр чотирикутника: " + quadrilateral.Perumeter());
    }
}