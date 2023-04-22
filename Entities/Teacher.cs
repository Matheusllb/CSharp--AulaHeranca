
using System.Globalization;

namespace ClassHerence.Entities
{
    public class Teacher : Person
    {
        public string Functional { get; set; }
        public double Salary { get; set; }

        public Teacher(string func, double sal)
        {
            Functional = func;
            Salary = sal;
        }

        public Teacher(string name, string cpf, DateTime birth, string func, double sal) : base()
        {
            Name = name;
            Cpf = cpf;
            Birth = birth;
            Functional = func;
            Salary = sal;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Cpf
                + ", Age: "
                + Age()
                + ", Functional: "
                + Functional
                + ", Salary: $ "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
