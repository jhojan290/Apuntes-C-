
using ConsoleApp2;
class Program
{
    public static void Main(string[] args)
    {
       GradeBook book = new GradeBook();
        book.AddGrade(91);
        book.AddGrade(81.5f);

        foreach (var numero in book.grades)
        {
            Console.WriteLine(numero);
        }
    }

}
