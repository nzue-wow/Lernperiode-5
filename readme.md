# Lernperiode 5

2.5 bis 23.5

## Grob-Planung

Wie können Sie Ihr Projekt aus der Lernperiode 4 um eine Persistenz-Lösung erweitern? Was gibt es zu speichern, was für Tabellen brauchen Sie und wie muss der bestehende Code mit diesen interagieren?

> Ich werde eine Datenbank machen, die die Webseiten mit den dazugehörigen Passwörtern speichert. Für das brauche ich zwei Tabellen. Eine Tabelle ist dann Webseite und die  zweite Tabelle ist dann Passwörter. Die Datenbank soll mit dem Code Interagieren also wenn ich ein neues Passwort hinzufüge dann muss auch eine neue Spalte in den neuen Tabellen erstellt werden mit dem neuen Passwort. Das gleiche soll beim Löschen von Passwörtern Passieren.

## 2.5

- [x] Grobplanung machen
- [x] Datenbank machen

✍️ Heute habe ich... (50-100 Wörter)
Ich habe heute mit der Grobplanung gestartet. Dort habe ich mir die Antworten zu den schon da stehenden Fragen überlegt. Ich habe mir überlegt was genau ich eigendlich speicher möchte. Dann habe ich SQL gestartet und erstmal mit `CREATE DATABASE Lernperiode5` eine Datenbank erstellt. Dann habe ich mit
<pre>USE Lernperiode5;
CREATE TABLE Passwörter(
PasswortID INT IDENTITY(1,1) PRIMARY KEY,
Passwort VARCHAR(50)
);</pre> die erste Tabelle Passwörter erstellt

Für die zweite Tabelle habe ich diesen Befehl geschrieben:
<pre>CREATE TABLE Webseiten (
    WebseitenID INT IDENTITY(1,1) PRIMARY KEY,
    WebseitenName VARCHAR(100),
    PasswortID INT NOT NULL,
    CONSTRAINT FK_PasswortID FOREIGN KEY (PasswortID)
        REFERENCES Passwoerter(PasswortID)
);</pre>
Ich habe  die webseiten Tabelle mit der Passwörter Tabelle verbunden also mit Foreign key. So soll klar sein dasnn welches Passwort zu welcher Webseite gehört.
Später habe ich dann gegooglet wie man die datenbank in den Code zu Programmieren, also das die sachen in der Datenbank gespeichert wird.

☝️ Vergessen Sie nicht, Ihr bestehendes Projekt und die Neuerungen von heute hochzuladen. Beschreiben Sie eindeutig, was heute an Code dazugekommen ist.

## 9.5 Kernfunktionalität

- [x] Die Datenbank mit dem Visualstudio Code verbinden
- [ ] Den Speicherort von den passwörtern von json zu der Datenbank ändern.
- [ ] Testen ob die Tabellen aktualisiert werden wenn ich im Passwortmanager etwas hinzufüge oder lösche.

✍️ Heute habe ich... (50-100 Wörter)
Ich habe  SQLlite installiert, damit ich eine einfachre Variante vom SQL habe für mein Programm. Dann habe ich erstmal im SQLlite eine Datenbank erstellt und dann eine Tabelle hinzugefügt. Ich habe nun nicht mehr zwei Tabellen wie am Anfang weil ich finde mit einer Tabelle geht es einfacher erstmal. Dann habe ich eine Verbindung mit dem Code und der Datenbank gemacht:
<pre>
 string connectionString = "Data Source= \"C:\\Users\\nenaz\\source\\repos\\PasswortManager\\SQL_PasswortmanagerDB.db\"";
 connection = new SqliteConnection(connectionString);
 connection.Open();
</pre> 
Damit die Passwörter in die Datenbak kommen, und in die richtige Spalte habe ich recherchiert und später bei einem Klassenkameraden gefragt der mir etwas passendes gezeigt hat:
<pre>
     using (SqliteConnection connection = new SqliteConnection(connectionString))
 {
  

     SqliteCommand insertCommand = new SqliteCommand("INSERT INTO SavedPasswords (WebseitenName, Passwort) VALUES (@WebseitenName, @Passwort)", connection);

     insertCommand.Parameters.AddWithValue("@WebseitenName", $"{website}");

     insertCommand.Parameters.AddWithValue("@Passwort", $"{passwort}");

 }
</pre> 
Leider funktioniert es nicht ganz, das Programm läuft durch bis `connection = new SqliteConnection(connectionString);` kommt da hät es dann immer an und ich habe noch nicht rausgefunden wieso. 
Es hat mir heute nicht gereicht alle lernpakete zu machen, weil die ganze Zeit an dem Problem gearbeitet habe. Das heisst ich habe den anderen Speicherort nicht entfernt und ich bin mir gar nicht sicher ob ich den überhaupt muss entfernen.
☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 16.5 Kernfunktionalität und Ausbau

- [x] Herausfinden warum `connection = new SqliteConnection(connectionString);` nicht geht.
- [x] Checken ob `SqliteCommand insertCommand = new SqliteCommand("INSERT INTO SavedPasswords (WebseitenName, Passwort) VALUES (@WebseitenName, @Passwort)", connection);` überhaupt der richtige befehl ist um die Daten in die Datenbank zu packen.
- [x] Die Daten(Passwörter, Webseiten) mit der DB verbinden, wird sie aktualisiert wenn ich ein neues Passwort hinzufüge.
- [x] Wenn nötig den Speicherort Json löschen


✍️ Heute habe ich... (50-100 Wörter)
Ich habe lange am fehler geschaut warum `connection = new SqliteConnection(connectionString);` nicht funktioniert. Es hat sich herausgestellt das ich irgendwie eine neuere version von visual studio erstmal installieren musste und dann nochmals die sqllite programme updaten musste. Dieser Code `SqliteCommand insertCommand = new SqliteCommand("INSERT INTO SavedPasswords (WebseitenName, Passwort) VALUES (@WebseitenName, @Passwort)", connection);` funktioniert. SObald ich allles ungedatet habe ging dann alles, aber zuerst hat es mir die Teile wo Json steht las falsch angezeigt also habe ich die gelöscht und nun wird allles auf SQL lite geschpeichert in meiner tabelle.
☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 23.5 Abschluss

- [x] Funktion Programmieren um Passwörter zu suchen. Also eine Sucheingabe
- [ ] Reflexion über Ihre Arbeitsweise
- [ ] Beschreibung des fertigen Projekts mit .gif etc.

✍️ Heute habe ich... (50-100 Wörter)
Ich habe heute die Suchfunktion programmiert. Ich habe ein neues Textfeld und einen Button eingefügt. Wenn man etwas in das Suchfeld eingibt und auf den Button klickt, zeigt das Programm alle gespeicherten Passwörter an die zu diesem Begriff passen. Es hat ein bisschen gedauert, bis alles richtig funktioniert hat. Ich habe auch getestet, ob die Suche mit Groß- und Kleinschreibung funktioniert
☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## Fertiges Projekt

✍️ Beschreiben Sie hier, wie Ihr Projekt am Ende aussieht, und fügen Sie mindestens ein .gif ein.
Mein Projekt ist ein einfacher Passwortmanager. Man kann neue Passwörter zu Webseiten speichern und sie später in einer Liste anzeigen lassen. Es gibt auch eine Suchfunktion, mit der man gezielt nach einer bestimmten Webseite suchen kann. Wenn man will, kann man ein Passwort auch wieder löschen. Alle Daten werden in einer SQLite-Datenbank gespeichert, damit sie beim nächsten Öffnen des Programms noch da sind.
Login für das Programm:
![Screenshot 2025-04-04 094326](https://github.com/user-attachments/assets/5a4ec91f-13c4-4616-86a0-c036b4eb93e2)
![Screenshot 2025-04-04 094345](https://github.com/user-attachments/assets/9ef8d52c-a77d-4dd8-940a-6b5fcea40957)

Mit new Passwords kann man neue Passwörter speichern und mit Saved Passwords kann man die gespeicherten Passwörter anschauen.
![Screenshot 2025-04-04 094354](https://github.com/user-attachments/assets/9a2a5881-5b48-4431-b535-8bf162081bb7)

New Passwords:
![Screenshot 2025-04-04 094415](https://github.com/user-attachments/assets/a1ff1393-6df0-4a22-8cd5-56974bef3a6b)
Neues Password eingeben und speichern:
![Screenshot 2025-04-04 094512](https://github.com/user-attachments/assets/542a4ef0-739e-42e0-9975-e30e3932dc6f)

Saved Passwords:
![Screenshot 2025-04-04 094526](https://github.com/user-attachments/assets/294d9b61-7b70-49c5-a9ce-54f7da2e0b9c)

Passwort löschen:
![Screenshot 2025-04-04 094605](https://github.com/user-attachments/assets/8ab5cf57-c9d0-4b1c-a7d4-f8fb7e1609c9)
![Screenshot 2025-04-04 094619](https://github.com/user-attachments/assets/088e31e6-e4a2-4db1-9c6e-44a90268f8e1)

Passwort suchen:
![Bildschirmaufnahme 2025-05-23 104947](https://github.com/user-attachments/assets/bdc95e1d-336d-4788-830c-91ca5bcf1c94)


## Reflexion

✍️ Was ging gut, was ging weniger gut? Was haben Sie gelernt, und was würden Sie bei der nächsten Lernperiode versuchen besser zu machen? Fassen Sie auch einen übergeordneten Vorsatz für Ihr nächstes Jahr im Lernatelier (100 bis 200 Wörter).
In diesem Projekt habe ich viel über Datenbanken und das Arbeiten mit SQLite gelernt. Am Anfang war es nicht so einfach, weil ich viele Fehler beim Einrichten der Verbindung zur Datenbank hatte. Das Einfügen der Daten in die Tabelle hat nicht gleich geklappt, es gab da immer ein paar Fehler. Ich musste Visual Studio und die SQLite-Pakete richtig installieren und updaten. Das hat etwas Zeit gebraucht. Aber als das alles funktioniert hat, konnte ich mein Programm verbessern. Nächstes Jahr möchte ich mit meinen Projekten geduldig sein und nicht immer gleich ein crashout haben und vorallem möchte ich viele Projekte machen um besser zu werden. Auch ganz wichtig ist das ich die Code Teile die ich aus dem Internet habe das ich die am Schluss auch verstehe.
