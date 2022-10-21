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

        public int Stars { get; set; }

        public string Text { get; set; } = string.Empty;

        public Medien Medien { get; set; } = default!;

    }
}
