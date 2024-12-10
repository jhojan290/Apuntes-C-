
namespace ConsoleApp2
{
    class GradeBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public List<float> grades = new List<float>();
    }
}
