﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchAndRead.Domain.Model
{
    public class Serie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int sesons { get; set; }

        public string OriginalLanguage { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public User UserNavigation { get; set; } = default;
    }
}
