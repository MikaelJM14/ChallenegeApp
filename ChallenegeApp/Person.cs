namespace ChallenegeApp
{
    public class Person
    {
        public Person(string name,string surname, string sex)
        {
            this.Name = name;
            this.SurName = surname;
            this.Sex = sex;
        }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Sex { get; set; }
    }
}
