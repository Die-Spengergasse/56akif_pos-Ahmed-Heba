using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Properties_Aufgabe
{
    public class Rechteck
    {
        private int _laenge;
        private int _breite;
        //private string _rechteck;

        public int Laenge 
        {
            get
            {
                return _laenge;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ungültige Länge");
                }
                _laenge = value;
            }
        }

        public int Breite 
        {
            get
            {
                return _breite;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ungültige Breite");
                }
                _breite = value;
            }
           
        }

        public int Flaeche 
        {
            get
            {
                return _laenge * _breite;
            }
            
        }
    }
}
