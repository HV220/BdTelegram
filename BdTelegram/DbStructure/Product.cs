using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdTelegram.DbStructure
{
    class Product
    {
        int IdProduct { get; set; }
        string Name { get; set; }

        int Count { get; set; }
        string Description { get; set; }
        string LinkDownloading { get; set; }

        public Category Category { get; set; }
    }
}
