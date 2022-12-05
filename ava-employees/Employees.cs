namespace ava_employees
{
    internal class Employees
    {
        public string name;
        public string role;
        public double atualSalary;
        public int since;

        public double NewSalary(double increase)
        {
            double result = atualSalary + (atualSalary * increase / 100);
            return result;
        }
    }
}
