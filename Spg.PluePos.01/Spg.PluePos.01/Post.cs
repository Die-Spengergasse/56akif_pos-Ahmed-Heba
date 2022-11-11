using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01
{
    public abstract class Post
    {
        private int _rating;
        public string Titel { get; } = string.Empty;
        public DateTime Created { get; }

        public int Rating
        {
            get { return _rating; }
            set 
            { 
                if (_rating>=1 && _rating<=5) 
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Range muss zwischen 1 und 5 liegen!");
                }
            }
        }

        public abstract string Html { get; }

        public Post(string titel, DateTime created)
        {
            if (titel == null)
            {
                throw new ArgumentNullException("Titel war NULL!");
            }
            else
            {
                Titel = titel;
            }
            
            Created = created;
        }

        public Post(string titel)
        {
            Titel =titel;
            Created= DateTime.Now;
        }

        public override string ToString()
        {
            string objectToString = base.ToString();
            return $"base.ToString() von Post {Html} ist {objectToString}";
        }

    }

   
}
