using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01
{
    public class TextPost : Post
    {
        public string? Content { get; set; }

        public int Length
        {
            get => Content?.Length ?? 0;
        }

        public TextPost(string titel, DateTime created) : base(titel, created)
        {

        }

        public TextPost(string titel) : base(titel)
        {
        }

        public override string Html
        {
            get
            {
                if (Content == null)
                {
                    throw new ArgumentNullException("Content war Null");
                }
                else
                {
                    return $"<h1>{Titel}</h1><p>{Content}</p>";
                }
            }
        }
    }
}
