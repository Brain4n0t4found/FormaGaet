using FormaCSharpGaet.Model.Character;

namespace FormaCSharpGaet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Character perso = new Character("KéBite", 5, 4);
            Character deuxiemeCharacter = new Character
            {
                Name = "tarace",
                Health = 50,
                Strength = 2.1M,
            };
        }
    }
}