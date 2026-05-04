class Program
{
    public static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetArea());

        Circle myCircle2 = new Circle();
        myCircle2._radius = 30;
        Console.WriteLine(myCircle2._radius);
    }
}
