class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        Angle myAngle = new Angle();
        myAngle.SetRadians(10);
        Console.WriteLine(myAngle.GetRadians());
    }
}
