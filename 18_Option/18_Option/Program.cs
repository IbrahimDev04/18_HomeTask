using _18_Option.Models;

namespace _18_Option
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            bool IsPlag = Convert.ToBoolean(Console.ReadLine());
            bool IsWantPlag = Convert.ToBoolean(Console.ReadLine());
            Student student = new Student(Name, IsPlag, IsWantPlag);

            if(!student.IsPlagiated || !student.IsHelpedToPlagiate)
            {
                Lion.Parcalamaq(student);
            }
            
        }
    }
}
