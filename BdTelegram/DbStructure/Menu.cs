namespace BdTelegram.DbStructure
{
    public class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool Status { get; set; } = true;

        //список курсов (Category)
        //мои покупки 
        //поддержка
        //отзывы
        //получить сертификат
    }
}
