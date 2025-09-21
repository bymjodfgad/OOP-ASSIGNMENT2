namespace OOP_ASSIGNMENT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cinema
            Cinema cinema = new Cinema("Trollhättans Biograf", true); //Name and if its open or not. true==open.
            cinema.DisplayInfo();
        }
    }
}
