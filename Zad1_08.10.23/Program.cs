class Parent
{
    protected double Pole1;
    protected double Pole2;

    public Parent(double pole1, double pole2)
    {
        this.Pole1 = pole1;
        this.Pole2 = pole2;
    }
    public void Print()
    {
        Console.WriteLine($"\nВитрата пального: {Pole1} л/100 км, Вiдстань: {Pole2} км");
    }
    public  double Metod()
    {
        return Pole1 / 100 * Pole2;
    }
}

class Child1 : Parent
{
    double Pole3;
    public Child1(double pole1, double pole2, double pole3) : base(pole1, pole2)
    {
        this.Pole3 = pole3;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine($"Вантажопiдйомнiсть: {Pole3} у тонах");
    }

    public double Metod()
    {
        return base.Metod() + Math.Sqrt(Pole3) * Pole2;
    }
}
class Child2 : Parent
{
        double Pole4;
        public Child2(double pole1, double pole2, double pole4) : base(pole1, pole2)
        {
           this.Pole4 = pole4;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"Об'єм двигуна: {Pole4} у лiтрах");
        }
        public  double Metod()
        {
            return base.Metod() + 0.005 * Pole2 * Pole4;
        }
}
class Program
{
    static void Main(string[] args)
    {
        Parent pr = new Parent(12, 250);
        pr.Print();
        Console.WriteLine($"Витрата пального: {pr.Metod()} у лiтрах");
        Child1 ch1 = new Child1(21, 200, 11);
        ch1.Print();
        Console.WriteLine($"Витрата пального у вантажiвки: {ch1.Metod():F2} у лiтрах");
        Child2 ch2 = new Child2(7, 150, 2.4);
        ch2.Print();
        Console.WriteLine($"Витрата пального: {ch2.Metod()} л");
    }
}
