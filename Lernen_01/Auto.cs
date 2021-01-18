using System;
using System.Collections.Generic;
using System.Text;

// gleicher Namensraum wie die Klasse "Program", deswegen muss in "Program" diese Klasse nicht mit einem using eingebunden werden
namespace Lernen_01
{
    // diese Klasse heißt "Auto", erbt die Eigenschaften und die Methoden der Klasse Fahrzeug
    public class Auto : Fahrzeug
    {
        // Ideen für mögliche Attribute und Methoden:
        // Farbe, Länge, Breite, Geschwindigkeit, Gewicht, Name
        // lakieren(), fahren(), formen() Länge Breite Ändern

        // hier wurden die in der Klasse gültigen Variablen definiert, aber nicht initialisiert
        // Typ Double bedeutet, dass die Variable eine Gleitkommazahl ist, wie 1.234
        Double Laenge;
        Double Breite;
        Double Geschwindigkeit;
        Double Gewicht;
        //Typ String bedeutet, dass die Variable eine Zeichenkette ist, wie "Hallo"
        // public bedeutet, dass auf die Variable von außerhalb der Klasse zugegriffen werden kann, während auf die anderen Variablen nicht zugegriffen werden kann
        //public String Name;
        // Typ Farbe bedeutet, dass die Variable Werte aus dem enum "Farbe" annehmen kann. Auf diese Variable kann auch von außerhalb zugegriffen werden
        public Farbe Autofarbe;

        // dies ist eine Methode. public bedeutet, dass auf die Methode von außerhalb der Klasse zugegriffen werden kann. void ist der Rückgabetyp der Methode, void bedeutet, dass keine Werte zurückgegeben werden können. lackieren ist der Variablenname. In den Klammern stehen die Werte, die beim Aufruf der Methode übergeben werden. In diesem Fall Werte vom Typ Farbe, werden in der Methode farbe genannt.
        public void lackieren(Farbe farbe)
        {
            // Attribut "Autofarbe" dieser Klasse wird mit der übergebenen Variable farbe überschrieben
            Autofarbe = farbe;
        }

        // Im folgenden kommen zwei Konstruktoren. Ein Konstruktor ist eine Methode, die bei der Initialisierung einer neuen Variablen vom Typ dieser Klasse aufgerufen wird. Also bei "Auto meinAuto = new Auto()" wird bei "new Auto()" der erste Konstruktor aufgerufen.
        // ein Konstruktor hat keinen Rückgabewert und ist immer public (oder protected)
        public Auto()
        {
            // die lokalen Attribute bekommen beim Initialisieren Startwerte zugewiesen bekommen
            Laenge = 4;
            Breite = 2.5;
            Geschwindigkeit = 0;
            Gewicht = 1.3;
            Name = "leer";
            Autofarbe = Farbe.Gelb;
        }

        // Konstruktor, wo alle Werte außer der Name des Autos gleich bleiben
        public Auto(String name)
        {
            Laenge = 4;
            Breite = 2.5;
            Geschwindigkeit = 0;
            Gewicht = 1.3;
            Name = name;
            Autofarbe = Farbe.Gelb;
        }

        // ein Konstruktor kann auch Werte übergeben bekommen. In diesem Fall Initialisierungswerte um von außerhalb der Klasse Startwerte festzulegen
        public Auto(Double laenge, Double breite, Double gewicht, Double geschwindigkeit, Farbe farbe, String name)
        {
            // jedes lokale Attribut bekommt einen übergebenen Wert zugewiesen
            Laenge = laenge;
            Breite = breite;
            Geschwindigkeit = geschwindigkeit;
            Gewicht = gewicht;
            Name = name;
            Autofarbe = farbe;
        }

    }
}
