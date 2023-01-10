using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model
{ 
    public enum Genders {Male, Female, Other }

    public class User
    {
        public int Id { get; private set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        //public string Email { get; set; } = string.Empty;
        public Genders _gender { get; set; }

        //public string Rolle { get; set; }

        private List<Film>_films { get; set; } = new();

        public IReadOnlyList<Film> Films => _films;

        private List<Book> _books { get; set; } = new();
        public IReadOnlyList<Book> Books => _books;

        private List<Serie> _series { get; set; } = new ();

        public IReadOnlyList<Serie> Series => _series;

        public User(int id, string firstName, string lastName, DateTime birthDate, Genders gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            _gender = gender;
        }
    }
}

