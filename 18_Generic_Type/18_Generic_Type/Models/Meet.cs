using _18_Generic_Type.Enums;

namespace _18_Generic_Type.Models
{
    internal class Meet : Food
    {
        public TypeMeet TypeMeet { get; set; }
        public Meet(double calorie, TypeMeet typeMeet) : base(calorie)
        {
            TypeMeet = typeMeet;
        }
    }
}
