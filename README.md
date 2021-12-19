# Softwareentwicklungsprojekt: Kompetenzdatenbank

* Teammitglieder:
	1. Kenneth Austin
	2. Reynaldo Domenico
	3. Zakaria Radman
* Team: 6
* Semester: Wintersemester 2021/2022

Kurzbeschreibung :

Wir erstellen eine Datenbankanwendung, welche es ermöglicht Kompetenzen zu Verwalten. Kompetenzen sind als Kenntnis über Technologien oder wissenschaftliche Disziplinen zu Verstehen.
Die Datenbank wird zeigen, welcher Mitarbeiter welche Kompetenz besitzt. Darüber hinaus sollten Projekte auch mit Kompetenzen verbunden sein. Ziel ist es, auf einfache Weise Ansprechpartner für bestimmte Kompetenzen oder Projekte zu finden.

## Abgabe Sprint 1 (28.11.2021)  
Was wir gemacht haben :
* Datenbank : Für die Datenbank wir haben ein Datenbank mit MySQL (Maria DB) erstellt. Da haben mithilfe von xampp als die Verbindung mit unserem localserver im Rechner für Konfigurieren unsere Datenbank im local. Wir haben die Datenbank Tabellen erstellt, soeben auch die Verbindungen (Entitäten) zwischen die Tabellen  wie wir im Pflichtenheft schon entworfen hatten.

* Fachkonzept : wir haben die Verbindung mit Datenbank (lokal) schon erstellt .
und die CRUD-Methoden implementiert ,fällt noch die Überprufung mit Gui und Datenbank.

* GUI : für die GUI haben wir zuerst bereits die Login-Seite mit ID- und Passworteingabe erstellt, dann eine Hauptseite, die im UI Flat Style basiert, wir haben eine Liste von Mitarbeitern, Projekt, Kompetenz erstellt und verwenden DataGridView, um die Dateien von dem Datenbank anzuzeigen
Kompetenz, Projekt, Mitarbeiter Seite wie im Pflichtenheft gemacht.
fällt noch die Logik für Verbindung zwichen frontend und backend.


Installationshinweise :
* Datenbank : Gehen Sie unter Folder Datenbank und die 'Dump Datei mit paar Beispiel Dateien.sql' in phpmyadmin importieren
* GUI: Gehen Sie unter Folder Programm und Sie können das Programm starten, indem Sie auf KompetenzDatenBank.sln klicken

## Abgabe Sprint 2 (19.12.2021)
* Datenbank :  Datenbank für Passwort als Hash erstellen,
Erstellen die Logik von Hash und Salting, damit das in der Datenbank gespeicherte Passwort in abstrakter Form ist.

* Fachkonzept : ein REST server erstellen, aber noch nicht in dem GUI implementiert, trotzdem läuft der Code, kann man im Postman testen, um zu debuggen (GET, POST, PUT, DELETE)

* GUI : Jetzt kann man sich mit den Daten aus der Datenbank anmelden. 
Die Hauptseite von mitarbeiter und Administrator in einem Formular erstellt,
Nach dem Login wird nach Rolle gefiltert, die in der Datenbank gespeichert ist, wenn die Rolle Administrator ist, wird die Hauptseite mit der Option Administrator angezeigt und wenn die Rolle mitarbeiter ist, zeigt es die Hauptseite des Mitarbeiters
