namespace ChallenegeApp
{
    public class EmployeeInMemory : EmployeeBase // : IEmployee
    {
        private List<float> grades = new List<float>();

        public event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
            
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
