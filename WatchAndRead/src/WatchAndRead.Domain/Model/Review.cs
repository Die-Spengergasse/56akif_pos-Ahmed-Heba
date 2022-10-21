using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model
{
    public class Review
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Starts { get; set; }

        public string Text { get; set; } = string.Empty;

        public Serie SerieNavi { get; set; } = default;

        public Book BookNavigation { get; set; } = default;

        public Film FilmNavigation { get; set; } = default;
    }
}
