using ConsoleApp;
class Program
{
    public static void Main(string[] args)
    {
        GradeBook book = new GradeBook();
        book.AddGrade(91);
        book.AddGrade(81.5f);

        /*GradeBook book2 = new GradeBook();*/ /*Cada nuevo objeto de una clase tiene su propia lista y tiene acceso a todo lo que este allí, pero no tendrá nada que ver con otro objeto creado*/
        /*book2.AddGrade(75);*/

        //foreach (var numero in book2.grades)
        //{
        //    Console.WriteLine(numero);
        //}
        GradeBook book2 = book; /*Un nuevo objeto puede apuntar a un objeto ya creado, podrán compartir los mismos valores, se puede decir que esto son dos variables que apuntan al mismo objeto*/
        book2.AddGrade(75);

        foreach (var numero in book.grades)
        {
            Console.WriteLine(numero);
        }

    }

}
