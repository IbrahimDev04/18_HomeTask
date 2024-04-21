namespace _18_Generic_Type.Models
{
    internal abstract class Food
    {
        public double Calorie { get; set; }

        protected Food(double calorie)
        {
            Calorie = calorie;
        }
    }
}
