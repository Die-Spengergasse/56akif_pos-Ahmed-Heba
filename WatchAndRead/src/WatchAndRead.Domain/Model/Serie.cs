using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model 
{
    public class Serie :Medien
    { 
        public int Sesons { get; set; }

        public Serie(int sesons) : base()
        {
            Sesons = sesons;
        }
    }
}
