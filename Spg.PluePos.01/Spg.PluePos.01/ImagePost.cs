using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01
{
    public class ImagePost : Post
    {
        public string? Url { get; set; }

        public override string Html
        {
            get 
            { 
                if (Url == null) 
                { 
                    throw new ArgumentNullException("Url war Null!");
                }
                else
                {
                    return $"<h1>{Titel}</h1><img src={Url}/>";
                }
            }
        }

        public ImagePost(string titel, DateTime created) : base(titel, created)
        {

        }

        public ImagePost(string titel) : base(titel) 
        {   
        }
    }
}
