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
* Datenbank :  Datenbank für Passwort als Hash und Salting erstellt, damit das in der Datenbank gespeicherte Passworte unlesbar und sicherer sind. Unsere Datenbank ist jetzt online, das heißt alle Konnektivität ist direkt mit Microsoft Azure verbunden.

* Fachkonzept : ein REST server erstellen, aber noch nicht in dem GUI implementiert. Der Code läuft ganz gut und man kann mit Postman testen, um zu debuggen (GET, POST, PUT, DELETE). 
Hashing und Salting Passwort erfolgt durch Hashing Verfahren SHA256. Schon angebunden mit der GUI und man kann sich anmelden und auch registieren (nur Administrator).

* GUI : Für Anmeldung kann man sich mit den Daten aus der Datenbank anmelden. 
Die Hauptseite von Mitarbeiter und Administrator in einem Formular erstellt,
Nach dem Login wird nach Rolle gefiltert, die in der Datenbank gespeichert ist, wenn die Rolle Administrator ist, wird die Hauptseite mit der Option Administrator angezeigt und wenn die Rolle mitarbeiter ist, zeigt es die Hauptseite des Mitarbeiters

Installationshinweise :
* Datenbank : Machen Sie eine neue Connection im App **mysqlworkbench** mit :  
hostname :kompetenzdatenbank.mysql.database.azure.com  
username :kompetenzdb@kompetenzdatenbank  
password :Kompetenz2021   
Für die Lokal Datenbank importieren, gehen Sie unter Folder Datenbank und die 'Dump mit Passwort.sql' in **phpmyadmin** importieren. 

* GUI: Run und für Anmeldung können Sie gerne für :  
Administrator - Benutzername : 'thomasm' als Passwort : 'pass123'  
Mitarbeiter -   Benutzername : 'maxm' oder 'jakobs' als Passwort : 'pass123'

* REST: Machen Sie die Projekt "RestAPI" als "set as start up project", dann run die Programm, kopieren Sie die URL, die im Browser angezeigt wird.
zum Beispiel "https://localhost:44340/weatherforecast", nehmen Sie die "https://localhost:44340/" und fügen Sie in dem **Postman** ein, addieren Sie die URL mit was wollen sie zeigen, zum Beispiel mitarbeiter, es wird als "https://localhost:44340/API/mitarbeiter" sein.
für den Befehl(Get,Post,Put,Delete) im **Postman** bitte JSON (body-> raw-> JSON) verwenden.

## Abgabe Sprint 3 (23.01.2022)
* Datenbank :  Datenbank wird eine neue Collumn für Deaktiviert Mitarbeiter Funktion hinzugefügt. Die Konnektivität mit Azure (online) würde verbessert und auch so eben Bugs würde gefixt.

* Fachkonzept : Die Anmeldung erfolgt jetzt über den Restserver. Wenn der Restserver also nicht online ist, kann sich der Benutzer nicht anmelden. Admin kann das Passwort und Biographie von Mitarbeiteren ändern .
Admin kann die Mitarbeiter aktivieren und deaktiviren (wird durch Atributt innerhalb SQL gemacht und durch ein Funktion in C# ).
wird alle wichtigeste Zeile kommentiert und wird wichtigeste Tabellen mit der Verbindung mit C# Programm überpruft (durch Nunit und Doxygen).
wird Die Verbindung und die Kommunikation zwischen Sql-server und Visual-Studio für letzte mal geprüft . 
Wird immer durch die Rolle innerhalb Mitarbeiter-Tabelle erkannt , ob der Benutzer ein Admin oder Mitarbeiter ist .
Alle Methoden und Klassen mit den Kommentare werden innerhalb Dokummente gespeichert.

* CI/CD : Windows Runner in GitLab ist eingesetzt, Pipeline auch fertig konfiguriert im GitLab und schon . Nunit im C# kann man auch direkt testen und das Ergebnis im Test Explorer sehen.

* GUI : Für Anmeldung kann man sich mit den Daten aus der Datenbank anmelden. 
Der login wird für admin und mitarbeiter unterschiedlich sein, und die hauptseite wird unterschiedliche funktionsbuttons zwischen mitarbeiter und admin haben.
Der Login hat jetzt einen "Aktivierung"-Filter, dh wenn das Konto des Mitarbeiters deaktiviert ist, kann sich der Mitarbeiter nicht in die Anwendung einloggen.
Mitarbeiter und Administrator können ihre Biografie, ihren Benutzernamen und ihr Passwort ändern.
Der Administrator kann das Passwort des Mitarbeiters ändern.
Die Liste der Projekte, Kompetenzen und Mitarbeiter zeigt die Daten aus der Datenbank.
Der Administrator kann die Kompetenz- und Projektdetails ändern.
Der Administrator kann das Konto des Mitarbeiters deaktivieren oder löschen.

Installationshinweise :
* Datenbank : Machen Sie eine neue Connection im App **mysqlworkbench** mit :  
hostname :kompetenzdb.mysql.database.azure.com  
username :neueadmin
password :Kompetenz_2021

Üm die Lokal Datenbank zu überprufen, gehen Sie unter Folder Datenbank und die 'Dump Datenbank.sql' in **phpmyadmin** importieren. 

* GUI: Run und für Anmeldung können Sie gerne für :  
Administrator - Benutzername : 'thomasm' als Passwort : 'pass123'  
Mitarbeiter -   Benutzername : 'maxm' oder 'jakobs' als Passwort : 'pass123'

Bitte erstellen Sie "GUI" und "RestAPI" als Startprojekt.
Rechtsklick auf Solution Explorer -> properties -> Startup Project -> Multiple startup projects wählen -> bei dem Action für GUI bitte wählen Sie "Start" and for RestAPI wählen Sie "Start without debugging" -> OK

* REST: nehmen Sie die "https://localhost:44340/" und fügen Sie in dem **Postman** ein, addieren Sie die URL mit was wollen sie zeigen, zum Beispiel mitarbeiter, es wird als "https://localhost:44340/API/mitarbeiter" sein.
für den Befehl(Get,Post,Put,Delete) im **Postman** bitte JSON (body-> raw-> JSON) verwenden.
