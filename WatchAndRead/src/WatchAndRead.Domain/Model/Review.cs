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

        public Medien MedienNavigation { get; private set; } = default!;
        public int MedienNavigationID { get; set; }
        //braucht Navigation kein private Set?

        public Review(int id, int stars, string text)
        {
            Id = id;
            Stars = stars;
            Text = text;
        }
    }
}
