using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model
{
    public class Film :Medien
    {   
        public int Minutes { get; set; }

        public Film(int minutes) : base()
        {
            Minutes = minutes;
        }
    }
}
