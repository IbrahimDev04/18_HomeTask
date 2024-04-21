namespace _18_Option.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public bool IsPlagiated { get; set; } = false;
        public bool IsHelpedToPlagiate { get; set; } = false;

        public Student(string name, bool isPlagiated, bool ısHelpedToPlagiate)
        {
            Name = name;
            IsPlagiated = isPlagiated;
            IsHelpedToPlagiate = ısHelpedToPlagiate;
        }

    }
}
