using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdTelegram.DbStructure
{
    class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }

        public int Count { get; set; }
        public string Description { get; set; }
        public string LinkDownloading { get; set; }

        public virtual Category Category { get; set; }
    }
}
