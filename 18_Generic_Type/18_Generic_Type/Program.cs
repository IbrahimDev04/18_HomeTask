using _18_Generic_Type.Models;

namespace _18_Generic_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf<Animal> wolf1 = new Wolf<Animal>(4, Enums.Gender.Male, "Xaski", 1200, true, 420);
            Wolf<Animal> wolf2 = new Wolf<Animal>(3, Enums.Gender.Female, "Xaski", 900, true, 310);
            Elephant elephant = new Elephant(5, Enums.Gender.Male, "Holland", 600, 235, true);
            Meet meet = new Meet(1200, Enums.TypeMeet.Chicken);
            Grass grass = new Grass(133, "cemen");
            ZooCage<Animal, Meet> zooCage = new ZooCage<Animal, Meet>(wolf1,meet);

            wolf1.Hunt(elephant);

            

        }
    }
}
