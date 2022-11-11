using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExCollection.App
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Klasse> klassen = new Dictionary<string, Klasse>();
            klassen.Add("3AHIF", new Klasse() { Name = "3AHIF", KV = "KV1" });
            klassen.Add("3BHIF", new Klasse() { Name = "3BHIF", KV = "KV2" });
            klassen.Add("3CHIF", new Klasse() { Name = "3CHIF", KV = "KV3" });
            klassen["3AHIF"].AddSchueler(new Schueler() { Id = 1001, Vorname = "VN1", Zuname = "ZN1", _maxStudiendauer = 5 });
            klassen["3AHIF"].AddSchueler(new Schueler() { Id = 1002, Vorname = "VN2", Zuname = "ZN2", _maxStudiendauer = 2 });
            klassen["3AHIF"].AddSchueler(new Schueler() { Id = 1003, Vorname = "VN3", Zuname = "ZN3", _maxStudiendauer = 3 });
            klassen["3BHIF"].AddSchueler(new Schueler() { Id = 1011, Vorname = "VN4", Zuname = "ZN4", _maxStudiendauer = 1 });
            klassen["3BHIF"].AddSchueler(new Schueler() { Id = 1012, Vorname = "VN5", Zuname = "ZN5", _maxStudiendauer = 7 });
            klassen["3BHIF"].AddSchueler(new Schueler() { Id = 1013, Vorname = "VN6", Zuname = "ZN6", _maxStudiendauer = 2 });

            Schueler s = klassen["3AHIF"].Schuelers[0];
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
            Console.WriteLine("3AHIF vor ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            s.ChangeKlasse(klassen["3BHIF"]);
            Console.WriteLine("3AHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            Console.WriteLine("3BHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3BHIF"].Schuelers));
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");

        }

        private void KurzesteStudiendauer(Klasse k)
        {
            // 1. erste Dauer merken
            // 2. Prüfung on die nächste Dauer kleiner oder größer ist.
            // 2.1 Wenn größer: nichts zu tun ; zum nächsten Schüler gehen
            // 2.2 Wenn kleiner: überschreiben wir den ersten Wert mit dem neuen Minimum

            int minWert = 7;
            foreach(Schueler item in k.Schuelers)
            {
                if (item.MaxStudiendauer < minWert)
                {
                    minWert = item.MaxStudiendauer;
                }
            }
            //Console.WriteLine($"Minimal Studendauer in dieser {k?.Name ?? "unbekannte Klasse"} ist: {minWert}"
        }
    }
}