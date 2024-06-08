namespace ChallenegeApp
{
    public class SuperVisior : IEmployee
    {
        public string Name => "Adam";

        public string Surname => throw new NotImplementedException();

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            switch(grade)
            {
                case "6":
                    this.AddGrade(95);
                    break;
                case "6+":
                    this.AddGrade(100);
                    break;
                case "6-":
                    this.AddGrade(90);
                    break;
                case "5":
                    this.AddGrade(85);
                    break;
                case "5+":
                    this.AddGrade(90);
                    break;
                case "5-":
                    this.AddGrade(80);
                    break;
                case "4":
                    this.AddGrade(75);
                    break;
                case "4+":
                    this.AddGrade(80);
                    break;
                case "4-":
                    this.AddGrade(70);
                    break;
                case "3":
                    this.AddGrade(65);
                    break;
                case "3+":
                    this.AddGrade(70);
                    break;
                case "3-":
                    this.AddGrade(60);
                    break;
                case "2":
                    this.AddGrade(55);
                    break;
                case "2+":
                    this.AddGrade(60);
                    break;
                case "2-":
                    this.AddGrade(50);
                    break;
                case "1":
                    this.AddGrade(45);
                    break;
                case "1+":
                    this.AddGrade(50);
                    break;
                case "1-":
                    this.AddGrade(40);
                    break;
            }
        }

        public Statistics GetStatistics()
        {
            return new Statistics();
        }
    }
}
