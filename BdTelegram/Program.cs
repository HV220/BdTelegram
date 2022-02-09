using Microsoft.EntityFrameworkCore;

namespace BdTelegram.DbStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintData();     
        }

        private static void PrintData()
        {
            using (var context = new Context())
            {
                context.Database.EnsureDeleted();

                if (context.Database.EnsureCreated())
                {
                    Console.WriteLine("БД успешно создана");
                }
                else
                {
                    Console.WriteLine("БД уже существует");
                }     
                
            
            }
        }
    
    }

}
