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
                case '6':
                    this.AddGrade(95);
            break;
                case '@':
                this.AddGrade(100);
                break;
            case 'f':
                this.AddGrade(90);
                break;
            case '5':
                this.AddGrade(85);
                break;
            case 'a':
                this.AddGrade(90);
                break;
            case 's':
                this.AddGrade(80);
                break;
            case '4':
                this.AddGrade(75);
                break;
            case '=':
                this.AddGrade(80);
                break;
            case '/':
                this.AddGrade(70);
                break;
            case '3':
                this.AddGrade(65);
                break;
            case '?':
                this.AddGrade(70);
                break;
            case '#':
                this.AddGrade(60);
                break;
            case '2':
                this.AddGrade(55);
                break;
            case '+':
                this.AddGrade(60);
                break;
            case '-':
                this.AddGrade(50);
                break;
            case '1':
                this.AddGrade(45);
                break;
            case '[':
                this.AddGrade(50);
                break;
            case ']':
                this.AddGrade(40);
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
                throw new Exception("String was not float");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            foreach (var grade in this.grades)
            {
                //break
                //continue
                //goto

                if (grade == 11)
                {
                    goto here;
                }

                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }

        here:
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var b when b >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var c when c >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var d when d >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }    
}
