using _18_Generic_Type.Enums;

namespace _18_Generic_Type.Models
{
    internal class Elephant : Animal
    {
        public double Weight { get; set; }
        public bool IsTrained { get; set; }
        public Elephant(int avgLifeTime, Gender _gender, string breed, int hP, double weight, bool ısTrained) : base(avgLifeTime, _gender, breed, hP)
        {
            Weight = weight;
            IsTrained = ısTrained;
        }
    }
}
