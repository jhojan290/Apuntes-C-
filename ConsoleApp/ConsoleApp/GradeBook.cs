

namespace ConsoleApp
{
    class GradeBook
       
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public List<float> grades;
    }
}

