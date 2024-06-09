using System.Diagnostics;

namespace ChallenegeApp
{
    public class Employee : IEmployee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }

        public string Surname {  get; set; }

        public event EmployeeInMemory.GradeAddedDelegate GradeAdded;

        public void AddGrade(float grade)
        {
            // 3.99
            // 3
            int valueInInt = (int)grade;
            float f = valueInInt;


            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(double grade)
        {
            double gradeAsDouble = (float)grade;
            this.AddGrade(gradeAsDouble);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(char grade)
        {
            switch(grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
                    break;
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }    
}
