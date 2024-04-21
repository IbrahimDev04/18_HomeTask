using _18_Generic_Type.Enums;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace _18_Generic_Type.Models
{
    internal abstract class Animal
    {
        public int AvgLifeTime { get; set; }
        public Gender gender { get; set; }
        public string Breed { get; set; }
        public int HP { get; set; }

        protected Animal(int avgLifeTime, Gender _gender, string breed, int hP)
        {
            AvgLifeTime = avgLifeTime;
            gender = _gender;
            Breed = breed;
            HP = hP;
        }

        
    }
}
