using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_FinalLibraryCatalog
{
    public class bNode
    {
        public Book BookData { get; set; }
        public bNode Left { get; set; }

        public bNode Right { get; set; }

        public bNode(Book book)
        {
            BookData = book;
        }
    }
}
