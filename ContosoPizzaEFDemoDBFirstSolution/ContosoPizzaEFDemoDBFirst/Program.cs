using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaEFDemoPart1Context context = new ContosoPizzaEFDemoPart1Context();

foreach (Customer c in context.Customers)
{
    // nothing will print if there is no data in the database table
    Console.WriteLine($"Name: {c.FirstLast}");
}