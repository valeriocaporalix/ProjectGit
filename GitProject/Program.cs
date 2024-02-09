using GitProject.Models;

var mario = new People() { Name = "Mario", LastName = "Rossi" };

var input = "";

while (input?.ToLower() != "esci")
{
    Console.WriteLine("Il programma è in esecuzione. Digita 'Esci' per uscire.");

    input = Console.ReadLine();
}

Console.WriteLine("Il programma è stato terminato.");