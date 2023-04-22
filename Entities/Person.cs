
namespace ClassHerence.Entities
{
    public class Person
    {
        protected string Name { get; set; }
        protected string Cpf { get; set; }
        protected DateTime Birth { get; set; }

        public Person() { }

        public Person(string name, string cpf, DateTime birth)
        {
            Name = name;
            Cpf = cpf;
            Birth = birth;
        }

        public int Age()
        {
            DateTime d = DateTime.Now;
            int age = d.Year - Birth.Year;
            return age;
        }

        public override string ToString()
        {
            return Name 
                + ", " 
                + Cpf 
                + ", Age: " 
                + Age();
        }
    }
}
