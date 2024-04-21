namespace _18_Generic_Type.Models
{
    internal class ZooCage<T, U> where T : Animal where U : Food
    {
        public T Animal { get; set; }
        public U Food { get; set; }

        public ZooCage(T animal, U food)
        {
            Animal = animal;
            Food = food;
        }
    }
}
