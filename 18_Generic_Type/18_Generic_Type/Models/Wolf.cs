using _18_Generic_Type.Enums;

namespace _18_Generic_Type.Models
{
    internal class Wolf<T> : Animal where T : Animal
    {
        public bool IsPrideLeader { get; set; }
        public int AttackDamage { get; set; }
        public Wolf(int avgLifeTime, Gender _gender, string breed, int hP, bool isPrideLeader, int attackDamage) : base(avgLifeTime, _gender, breed, hP)
        {
            IsPrideLeader = isPrideLeader;
            AttackDamage = attackDamage;
        }

        

        public void Hunt(T animal)
        {
            if(this != animal) 
            { 
                animal.HP = animal.HP - AttackDamage;
                Console.WriteLine(animal.HP);
                return;
            }
            throw new WrongEnterParamException("Heyvan ozune saldira bilmez");
        }
    }
}
