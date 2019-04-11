namespace Employees.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public int BirthYear { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + ", " + Position;
        }
    }
}