
class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("bob", "stuart", 18, 198);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPoliceMan = new Police("Gun", "Robert", "bob", 50, 170);

        Console.WriteLine(myPoliceMan.GetPoliceManInformation());
    }
}
