﻿using Packt.Shared;
using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

// вызов метода экземпляра
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

// вызов статического метода
Person baby2 = Person.Procreate(harry, jill);

// вызов операции
Person baby3 = harry * mary;

//WriteLine($"{harry.Name} has {harry.Children.Count} children.");
//WriteLine($"{mary.Name} has {mary.Children.Count} children.");
//WriteLine($"{jill.Name} has {jill.Children.Count} children.");
//WriteLine(format: "{0}'s first child is named \"{1}\".",
//    arg0: harry.Name, arg1: harry.Children[0].Name);

//WriteLine($"5! is {Person.Factorial(5)}");

//static void Harry_Shout(object? sender, EventArgs e)
//{
//    if (sender is null) return;
//    Person p = (Person)sender;
//    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
//}

//harry.Shout += Harry_Shout;

//harry.Poke();
//harry.Poke();
//harry.Poke();
//harry.Poke();

// не дженерик-коллекция поиска
System.Collections.Hashtable lookupObject = new();

lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

//int key = 2; // поиск значения, содержащего 2 в качестве ключа
//WriteLine(format: "Key {0} has value: {1}", arg0: key, arg1: lookupObject[key]);

// поиск значения, содержащего harry в качестве ключа
//WriteLine(format: "Key {0} has value: {1}", arg0: harry, arg1: lookupObject[harry]);

// дженерик-коллекция поиска
Dictionary<int, string> lookIntString = new();

lookIntString.Add(key: 1, value: "Alpha");
lookIntString.Add(key: 2, value: "Beta");
lookIntString.Add(key: 3, value: "Gamma");
lookIntString.Add(key: 4, value: "Delta");

//key = 3;
//WriteLine(format: "Key {0} has value: {1}", arg0: key, arg1: lookIntString[key]);

Person[] people =
{
    new() {Name = "Simon"},
    new() {Name = "Jenny"},
    new() {Name = "Adam"},
    new() {Name = "Richard"}
};

//WriteLine("Initial list of people: ");
//foreach (Person p in people)
//{
//    WriteLine($" {p.Name}");
//}
//WriteLine("Use Person's IComparable implementation to sort:");
//Array.Sort(people);
//foreach (Person p in people)
//{
//    WriteLine($" {p.Name}");
//}

//WriteLine("Use PersonComparer's IComparer implementation to sort:");
//Array.Sort(people, new PersonComparer());
//foreach (Person p in people)
//{
//    WriteLine($" {p.Name}");
//}

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;

//WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

Employee john = new()
{
    Name = "John Jones",
    DateOfBirth = new(year: 1990, month: 7, day: 28)
};
//john.WriteToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
//WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

//WriteLine(john.ToString());

Employee aliceInEmployee = new() { Name = "Alice", EmployeeCode = "AA123" };

Person aliceInPerson = aliceInEmployee;
//aliceInEmployee.WriteToConsole();
//aliceInPerson.WriteToConsole();
//WriteLine(aliceInEmployee.ToString());
//WriteLine(aliceInPerson.ToString());

//if (aliceInPerson is Employee)
//{
//    WriteLine($"{nameof(aliceInPerson)} IS an Employee");
//    Employee explicitAlice = (Employee)aliceInPerson;
//}

Employee? aliceAsEmployee = aliceInPerson as Employee; // может быть null

//if (aliceAsEmployee != null)
//{
//    WriteLine($"{nameof(aliceInPerson)} AS an Employee");
//    // безопасно выполняем что-либо с aliceAsEmployee
//}

//try
//{
//    john.TimeTravel(when: new(1990, 12, 31));
//    john.TimeTravel(when: new(1950, 12, 25));
//}
//catch (PersonException ex)
//{
//    WriteLine(ex.Message);
//}

string email1 = "pamel@test.com";
string email2 = "ian&test.com";

WriteLine("{0} is a valid e-mail address: {1}", arg0: email1, arg1: email1.IsValidEmail());

WriteLine("{0} ia s valid e-mail address: {1}", arg0: email2, arg1: email2.IsValidEmail());