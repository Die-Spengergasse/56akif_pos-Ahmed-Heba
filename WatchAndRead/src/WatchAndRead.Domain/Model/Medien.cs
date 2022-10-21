using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model
{
    public class Medien
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string OriginalLanguage { get; set; } = string.Empty;

        public bool Watched { get; set; }

        public bool Read { get; set; }

        public User UserNavigation { get; set; } = default!;

        public Genre Genre { get; set; } = default!;
    }
}
