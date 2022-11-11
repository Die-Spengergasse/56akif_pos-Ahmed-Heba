using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01
{
    public class SmartPhoneApp : List<Post> 
    {
        
        public string SmartPhoneId { get; set; } = string.Empty;

        public SmartPhoneApp(string smartPhoneId)
        {
            SmartPhoneId = smartPhoneId;
        }

        public new void Add(Post posts)
        {
            if (posts!= null)
            {
                Add(posts);
            }
            else
            {
                throw new ArgumentNullException("Post darf nicht NULL sein!");
            }
            if (!base.Contains(posts))
            {
                base.Add(posts);
            }  

        }

        public string ProcessPosts()
        {
            string i = string.Empty;

            foreach (Post item in this)
            {
                i += item.Html;
            }

            return i;
        }

        public int CalcRating()
        {
            int i = 0;

            foreach (Post item in this)
            {
                i += item.Rating;
            }

            return i;
        }

     

    }

          
}
