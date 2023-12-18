namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstCar = new Car();
            firstCar.Make = "Kia";
            firstCar.Model = "Forte";
            firstCar.Year = 2020;

            Console.WriteLine($"The first car is a {firstCar.Year} {firstCar.Make} {firstCar.Model}.");

        }
    }
}
