namespace _18_Generic_Type.Models
{
    internal class Grass : Food
    {
        public string Name { get; set; }

        public Grass(double calorie, string name) : base(calorie)
        {
            Name = name;
        }

        

    }
}
