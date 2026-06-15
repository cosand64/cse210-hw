
class Program
{

    public static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
        if(person is Doctor doctor)
            Console.WriteLine(doctor.GetDoctorInformation());
        else if (person is Police police)
            Console.WriteLine(police.GetPoliceManInformation());
        else
            Console.WriteLine(person.GetPersonInformation());
    }

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

        List<Person> myPeople = new List<Person>();
        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceMan);

        foreach(Person person in myPeople)
        {
            // Console.WriteLine(person.GetPersonInformation());
            DisplayPersonInformation(person);
        }
    }
}
