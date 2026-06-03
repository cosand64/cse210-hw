class Person
{
    private string _lastName;

    private string _firstName;

    private int _age;

    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    public string GetPersonInformation()
    {
        return $"{_firstName}, {_lastName}, age:{_age} weight:{_weight}";
    }

    public void ChangeWeight(int update)
    {
        _weight += update;
    }
}