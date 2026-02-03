namespace PRA_B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer je naam in");
            string name = Console.ReadLine();

            Console.WriteLine("Voer je leeftijd in");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Voer je adres in");
            string adress = Console.ReadLine();

            Console.WriteLine($"Je naam is {name}, je bent {age} jaar oud en je woont op {adress}");

            Console.WriteLine("Druk op een toets om af te sluiten");
            Console.ReadKey();


        }
    }
}
