using ConsoleApp.Models;

namespace ConsoleApp.ViewModels;

public class PersonViewModel
{
    private Person person;

    public PersonViewModel(Person person)
    {
        this.person = person;
    }

    public string Name
    {
        get
        {
            return $"{person.FName} {person.LName}";
        }
    }

    public bool Married
    {
        get
        {
            return person.Married;
        }
    }

    public override string ToString()
    {
        string marriage = Married ? "married" : "not married";
        return $"I am {Name} and i am {marriage}";
    }
}
