using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model
{
    public class Book :Medien
    {
        public int PageNumber  { get; set; }

        public Book(int pageNumber) : base()
        {
            PageNumber = pageNumber;
        }
    }
}
