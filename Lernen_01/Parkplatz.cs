using System;
using System.Collections.Generic;
using System.Text;

namespace Lernen_01
{
    // unsere Klasse "Parkplatz"
    public class Parkplatz
    {

        // Hier sind wieder unsere Attribute festgelegt
        Int32 AnzahlParkplaetze;
        Int32 FreienParkplaetze;
        Double Einzelplatzbreite;
        Double Einzelplatzlaenge;
        // Dies ist eine Liste, welche Werte vom Typ Auto, also unser eigenen Klasse, speichert
        List<Auto> GeparkteAutos;

        //im Folgenden sind die Methoden dieser Klasse festgelegt
        // diese Methode ist durch public von außen zugreifbar, hat den Rückgabewert bool (kann also true oder false annehmen), den Namen "parken" und bekommt einen Wert übergeben, die Variable "auto" vom Typ "Auto"
        public bool parken(Auto auto)
        {
            // dies ist eine IF-Abfrage. Wenn die Bedingung in den Klammern erfüllt ist, wird der if-Zweig ausgeführt, wenn die Bedingung nicht erfüllt ist, wird der else-Zweig ausgeführt
            if (FreienParkplaetze >= 1)
            {
                // wenn freie Parkplätze verfügbar sind, wird das Auto geparkt.
                // die übergebene Variable "auto" wird der Liste "GeparkteAutos" mit der Methode "Add()" hinzugefügt.
                GeparkteAutos.Add(auto);
                // die Anzahl der FreienParkplaetze wird um 1 reduziert
                FreienParkplaetze--;
            }
            else
            {
                // gibt bei der Nichterfüllung der Bedingung false als Rückgabewert zurück
                return false;
            }
            // wenn die Methode bis hierhin durchlaufen konnte, ohne beendet zu werden, wird true zurückgegeben
            return true;
        }

        // diese Methode soll die Namen der geparkten Autos zurückgeben
        // der Rückgabewert ist hier die Liste mit den Autonamen, die Autonamen sind vom Typ String
        public List<String> getAutonamen()
        {
            // wenn wir Autos geparkt haben wird dieser Teil ausgeführt
            if (GeparkteAutos.Count > 0)
            {
                // als erstes wird die Liste definiert und initialisiert
                List<String> namen = new List<String>();

                // jeder Autoname von Autos der Liste GeparkteAutos wird der temporären Liste "namen" hinzugefügt
                foreach (Auto item in GeparkteAutos)
                {
                    namen.Add(item.Name);
                }

                // gibt die Liste der Namen zurück
                return namen;
            }

            // wenn keine Autonamen gefunden wurden wird eine leere Liste zurückgeben
            return new List<String>();
        }

        // dies ist der Konstruktor
        public Parkplatz()
        {
            // Listen Attribute müssen IMMER initialisiert werden, sonst wird eine NullReferenceException geworfen
            GeparkteAutos = new List<Auto>();
            // Initialisiert die Werte
            AnzahlParkplaetze = 2;
            FreienParkplaetze = 2;
        }

    }
}
