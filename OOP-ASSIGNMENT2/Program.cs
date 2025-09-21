namespace OOP_ASSIGNMENT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cinema
            Cinema cinema = new Cinema("Trollhättans Biograf", true); //Name and if its open or not. true==open.
            cinema.DisplayInfo();

            Customer customer = new Customer(1, "Jacob", "jacob@mail.com");
            customer.AddPoints(5);

            Employee employee = new Employee(2, "Adam", "adam@mail.com", "Owner");
            employee.AssignTask("Count money in register");
            Console.WriteLine(employee.getName());
            Console.WriteLine(customer.getName());
        }
    }
}
