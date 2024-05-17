using System;
using System.Collections.Generic;
using System.Linq;

// Define the Person class
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Person objects
        var personsList = new List<Person>
        {
            new Person { Id = 1, Name = "John", Age = 30, City = "New York" },
            new Person { Id = 2, Name = "Alice", Age = 25, City = "Los Angeles" },
            new Person { Id = 3, Name = "Bob", Age = 35, City = "Chicago" }
        };

        // Create operation
        var newPerson = new Person { Id = 4, Name = "Emma", Age = 28, City = "San Francisco" };
        personsList.Add(newPerson);
        Console.WriteLine("Person created successfully.");

        // Read operation
        Console.WriteLine("List of persons:");
        foreach (var person in personsList)
        {
            Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Age: {person.Age}, City: {person.City}");
        }

        // Update operation
        var personToUpdate = personsList.FirstOrDefault(p => p.Name == "John");
        if (personToUpdate != null)
        {
            personToUpdate.Age = 35;
            Console.WriteLine("Person updated successfully.");
        }

        // Read operation after update
        Console.WriteLine("List of persons after update:");
        foreach (var person in personsList)
        {
            Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Age: {person.Age}, City: {person.City}");
        }

        // Delete operation
        var personToDelete = personsList.FirstOrDefault(p => p.Name == "John");
        if (personToDelete != null)
        {
            personsList.Remove(personToDelete);
            Console.WriteLine("Person deleted successfully.");
        }

        // Read operation after delete
        Console.WriteLine("List of persons after delete:");
        foreach (var person in personsList)
        {
            Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Age: {person.Age}, City: {person.City}");
        }
    }
}
