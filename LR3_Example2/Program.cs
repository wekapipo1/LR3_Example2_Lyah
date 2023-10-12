using System;
class Pryam
{
    protected double a; //довжина першої сторони
    protected double b; //довжина другої сторони
    public Pryam()
    {

    }
    public Pryam(double a, double b) //конструктор
    {
        this.a = a; this.b = b;
    }
    public void Print() //виведення на екран
    {
        Console.WriteLine("\na={0} b={1}", a, b);
    }
    public double Sqr() //площа
    {
        return a * b;
    }
    public double Diag() //діагональ
    {
        return Math.Sqrt(a * a + b * b);
    }
}
class Kvadrat : Pryam
{
    public Kvadrat()
    {

    }
    public Kvadrat(double x) //конструктор
    {
        a = x; b = x;
    }
    public double Radius() //радіус вписаного кола
    {
        return a / 2;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Random o = new Random(); //для рандомних значень сторін
        double d = 0, s = 0, r = 0;
        for (int i = 1; i<=5;  i++)
        {
            int x = o.Next(1,4); int y = o.Next(1,4);
            if (x != y)
            {
                //об'єкт батьківського класу
                Pryam pr = new Pryam(x, y);
                pr.Print();
                s = pr.Sqr();
                d = pr.Diag();
                Console.WriteLine("Прямокутник: s={0} d={1:F2}", s, d);
            }
            else
            {
                //об'єкт дочірнього класу
                Kvadrat kv = new Kvadrat(x);
                kv.Print();
                s = kv.Sqr();
                d = kv.Diag();
                r = kv.Radius();
                Console.WriteLine("Квадрат: s={0} d={1:F2} r={2}", s, d, r);
            }
        }
    }
}