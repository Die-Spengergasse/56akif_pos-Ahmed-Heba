﻿namespace ExCollection.App
{
    class Klasse
    {
        // TODO: Erstelle ein Property Schuelers, welches alle Schüler der Klasse in einer
        //       Liste speichert.
        public List<Schueler> Schuelers { get; set; } = new();
        public string Name { get; set; } = string.Empty;
        public string KV { get; set; } = string.Empty;
        /// <summary>
        /// Fügt den Schüler zur Liste hinzu und setzt das Property KlasseNavigation
        /// des Schülers korrekt auf die aktuelle Instanz.
        /// </summary>
        /// <param name="s"></param>
        public void AddSchueler(Schueler s)
        {
            Schuelers.Add(s);
            s.KlasseNavigation = this;
        }
    }
}