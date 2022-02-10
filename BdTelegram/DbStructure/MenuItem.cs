#nullable disable

using System.ComponentModel.DataAnnotations;

namespace BdTelegram
{
    internal class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool Status { get; set; }
    }
}
