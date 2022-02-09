using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdTelegram.DbStructure
{
    class Category
    {
        int Id { get; set; }
        string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
