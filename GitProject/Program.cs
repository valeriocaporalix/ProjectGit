using GitProject.Models;

var assistant = new People() { Name = "Mario", LastName = "Rossi" };

var input = "";

while (input?.ToLower() != "quit")
{
    Console.WriteLine($"Welcome! My name is {assistant.Name} {assistant.LastName}. Digit \"Quit\" to close the application.");

    input = Console.ReadLine();
}

Console.WriteLine("Application stop running.");