using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model
{
    public class Medien
    {
        public int Id { get; private set; }
        public string Name { get; set; } = string.Empty;

        public string OriginalLanguage { get; set; } = string.Empty;

        public bool Watched { get; set; }

        public bool Read { get; set; }

        public User UserNavigation { get; private set; } = default!;
        public int UserNavigationId { get; set; }
     
        public Review ReviewNavigation { get; private set; } = default!;
        public int ReviewNavigationId { get; set; }

        private List<Genre> _genreList { get; set; } = new();

        public IReadOnlyList<Genre> GenreList => _genreList;
        public Medien()
        { }

        public Medien(int id, string name, string originalLanguage, bool watched, bool read)
        {
            Id = id;
            Name = name;
            OriginalLanguage = originalLanguage;
            Watched = watched; //ich will das änderen. Ist das okay es im ctor zu lassen
            Read = read;//das auch
        }
    }
}
