using GitProject.Models;

var assistent = new People() { Name = "Mario", LastName = "Rossi" };

var input = "";

while (input?.ToLower() != "quit")
{
    Console.WriteLine($"Welcome! My name is {assistent.Name} {assistent.LastName}. Digit \"Quit\" to close the application.");

    input = Console.ReadLine();
}

Console.WriteLine("Application stop running.");