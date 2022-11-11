﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Properties_Aufgabe
{
    internal class Lehrer
    {
        private decimal? _bruttoGehalt;

        public string Vorname { get; set; } = String.Empty;
        public string Zuname { get;  set; } = String.Empty;

        public string Kuerzel 
        {
            get
            {
                if (Zuname.Length >= 3)
                {
                    return Zuname?.Substring(0, 3).ToUpper() ?? "--";
                }
                return "--";
            } 
         
        }

        public decimal? Bruttogehalt 
        {
            get
            {
                return _bruttoGehalt;
            }
            set
            {
                if (_bruttoGehalt is not null)
                {
                    _bruttoGehalt = value;

                }
            }
                
        }
        public decimal? Nettogehalt => _bruttoGehalt ?? 0 * 0.8M;
        
    }
}
