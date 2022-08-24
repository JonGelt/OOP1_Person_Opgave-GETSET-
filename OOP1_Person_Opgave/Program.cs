namespace OOP1PersonOpgave;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();


        do
        {
            Console.WriteLine("Enter your name:");
            person.Name = Console.ReadLine();
            Console.WriteLine(person.Name);

        } while (person.doesStringContain == false);

        do
        {
            Console.WriteLine("Enter your date of birth: ");
            person.DoB = Console.ReadLine();            
            Console.WriteLine(person.DoB);
            Console.WriteLine($"Din alder er {person.Age}");

        } while (person.checkTrue == true);

        do
        {
            Console.WriteLine("Enter your email:");
            person.Email = Console.ReadLine();
            Console.WriteLine(person.Email);

        } while (person.doesStringContain == false);

        do
        {
            Console.WriteLine("Enter your password:");
            person.Password = Console.ReadLine();
            Console.WriteLine(person.Password);

        } while (person.doesStringContain == false);


    }

}