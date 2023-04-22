using System.Globalization;

namespace ClassHerence.Entities
{
    public class Student : Person
    {
        public string Ra { get; set; }
        public double Payment { get; set; }

        public Student(string ra, double pay) 
        {
            Ra = ra;
            Payment = pay;
        }

        public Student(string name, string cpf, DateTime birth, string ra, double pay) : base()
        {
            Name = name;
            Cpf = cpf;
            Birth = birth;
            Ra = ra;
            Payment = pay;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Cpf
                + ", Age: "
                + Age()
                + ", RA: "
                + Ra
                + ", Monthy Payment: $ "
                + Payment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
