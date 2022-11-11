using Newtonsoft.Json;

namespace ExCollection.App
{
    class Schueler
    {
        // TODO: Erstelle ein Proeprty KlasseNavigation vom Typ Klasse, welches auf
        //       die Klasse des Schülers zeigt.
        // Füge dann über das Proeprty die Zeile
        // [JsonIgnore]
        // ein, damit der JSON Serializer das Objekt ausgeben kann.

        [JsonIgnore]

        public Klasse KlasseNavigation { get; set; } = new();
        public int Id { get; set; }
        public string Zuname { get; set; } = string.Empty; 
        public string Vorname { get; set; } = string.Empty;

        public int _maxStudiendauer;

        public string FullName
        {
            get 
            { 
                //return "Full Name" + Vorname + " " + Zuname; 
                return $"Full Name: {Vorname } {Zuname }";
            }
        }

        public int MaxStudiendauer
        {
            get { return _maxStudiendauer; }
            set 
            {   if (value >= 1 && value<=7)
                { 
                    _maxStudiendauer = value; 
                }
                else
                {
                    throw new ArgumentException("");
                }
                
            } 
        }

        /// <summary>
        /// Ändert die Klassenzugehörigkeit, indem der Schüler
        /// aus der alten Klasse, die in KlasseNavigation gespeichert ist, entfernt wird.
        /// Danach wird der Schüler in die neue Klasse mit der korrekten Navigation eingefügt.
        /// </summary>
        /// <param name="k"></param>
        public void ChangeKlasse(Klasse k)
        {
            KlasseNavigation.Schuelers.Remove(this);

            k.Schuelers.Add(this);

            KlasseNavigation = k;
        }
    }
}