
class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("bob", "stuart", 18, 198);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPoliceMan = new Police("Gun", "Robert", "bob", 50, 170);
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("phd", "Rob", "tom", 80, 300);
        Console.WriteLine(myDoctor.GetDoctorInformation());

        myDoctor.ChangeWeight(50);
        myPoliceMan.ChangeWeight(-100);

        Console.WriteLine(myDoctor.GetDoctorInformation());
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());
    }
}
