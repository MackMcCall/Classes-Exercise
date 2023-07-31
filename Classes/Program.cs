namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car()
            {
                Make = "Nissan",
                Model = "Altima",
                Year = 2014,
            };
            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");
        }
    }
}
