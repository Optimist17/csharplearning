// using wird genutzt um Bibliotheken einzubinden, deren Klassen/Methoden verwendet werden
using System;
using System.Collections.Generic;

// namespace gibt den Namensraum an, in dem sich die Datei befindet. Wenn eine Klasse außerhalb des Namensraums genutzt werden soll, muss sie über using eingebunden werden
namespace Lernen_01
{
    // class gibt an, das Program eine Klasse ist. Dies ist der Einstiegspunkt, wenn die Software gestartet wird
    class Program
    {
        // dies ist die Einstiegsmethode, die beim Programmstart aufgerufen wird.
        static void Main(string[] args)
        {
            // Schreibt in die Konsole "Auto:"
            Console.WriteLine("Auto:");

            // unsere selbst erstellte Klasse "Auto" wird genutzt, um die Variable "erstesAuto" vom Typ "Auto" als neues "Auto" zu initialisieren.
            Auto erstesAuto = new Auto();
            // Attribut "Autofarbe" von der Variable "erstesAuto" wird ausgegeben
            Console.WriteLine(erstesAuto.Autofarbe);
            // die öffentlich verfügbare Methode "lackieren" der Variable "erstesAuto" wird aufgerufen, um die Farbe des Autos zu ändern
            erstesAuto.lackieren(Farbe.Lila);
            // gibt die neue Autofarbe aus
            Console.WriteLine(erstesAuto.Autofarbe);

            // eine neues Variable "zweitesAuto" wird erstellt und sofort über den nichtleeren Konstruktor der Klasse "Auto" mit Werten initialisiert
            Auto zweitesAuto = new Auto(3.5,2.1,0.9,0,Farbe.Gruen,"TollesAuto");

            // eine neue Variable "unserParkplatz" unserer selbst erstellten Klasse "Parkplatz" wird erstellt und initialisiert
            Parkplatz unserParkplatz = new Parkplatz(20);
            // Variable "zweitesAuto" wird der Methode "parken" der Klasse "Auto" der vorher erstellten Variable "unserParkplatz" übergeben. Die Methode gibt eine Meldung zurück, ob parken erfolgreich war
            bool parkenErfolgreich = unserParkplatz.parken(zweitesAuto);
            // gibt die Erfolgsmeldung aus
            Console.WriteLine("Parken erfolgreich: " + parkenErfolgreich);

            // parkt jetzt das erste Auto, überschreibt die Variable "parkenErfolgreich"
            parkenErfolgreich = unserParkplatz.parken(erstesAuto);
            // gibt den neuen Wert von "parkenErfolgreich" aus
            Console.WriteLine("Parken erfolgreich: " + parkenErfolgreich);

            for (int i = 0; i < 10; i++)
            {
                Auto einAuto = new Auto("Neues Auto " + i); // "Neues Auto 1"
                bool erfolg = unserParkplatz.parken(einAuto);

                if (!erfolg) break;
            }

            //int j = 0;
            //while (j<10)
            //{
            //    j++;
            //}

            // ruft die Methode "getAutonamen" unserer Variable "unserParkplatz" auf, welche eine Liste der geparkten Autos zurückgibt und in der Variablen "autonamen" speichert. "List<String> bedeutet, das die Klasse der Variable eine Liste ist, in der Werte vom Typ String gespeichert werden können
            List<String> autonamen = unserParkplatz.getAutonamen();

            // dies ist eine Schleife, die jedes Element in der Liste "autonamen" durchgeht, temporär in der Variable "item" speichert und in der Konsole ausgibt.
            foreach (String item in autonamen)
            {
                // gibt die jeweilige Variable in der Konsole aus
                Console.WriteLine(item);
            }

            Motorrad meinMotorrad = new Motorrad();

            unserParkplatz.parken(meinMotorrad);
        }
    }
}
