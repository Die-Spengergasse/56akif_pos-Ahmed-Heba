using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        private List<Medien> _media = new();

        public IReadOnlyList<Medien> MedienList => _media;
        //hier ist n zu n Bezeichung mit der Tabelle Medien!

        public Genre() { }

        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
