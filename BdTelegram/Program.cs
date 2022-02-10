using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;

namespace BdTelegram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var menuItem = context.MenuItems.ToList();

                foreach (var item in menuItem)
                {

                    Console.WriteLine($"Name: {item.Name}");

                }
            }
        }
    }
}
