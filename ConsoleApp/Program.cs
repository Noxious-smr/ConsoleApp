
using ConsoleApp.Models;
using ConsoleApp.ViewModels;

PersonViewModel person = new PersonViewModel(new Person()
{
    Id = 1,
    FName = "Sam",
    LName = "Someone",
    Age = 33,
    Married = false,
}) ;


Console.WriteLine(person);
Console.ReadKey();