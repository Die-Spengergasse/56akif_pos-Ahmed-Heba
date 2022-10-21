using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model

    //public enum Genders {Male, Female, Other }
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LasttName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        //public string Email { get; set; } = string.Empty;

        //public Genders gender { get; set; }

        //public string Rolle { get; set; }
    }
}

