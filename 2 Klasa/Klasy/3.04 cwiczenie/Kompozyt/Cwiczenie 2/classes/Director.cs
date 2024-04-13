namespace Cwiczenie_2.classes;

public class Director : Person
{
    private List<Person> Directors = new();

    public void AddDirector(Person person)
    {
        Directors.Add(person);
    }

}