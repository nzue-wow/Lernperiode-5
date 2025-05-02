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


☝️ Vergessen Sie nicht, Ihr bestehendes Projekt und die Neuerungen von heute hochzuladen. Beschreiben Sie eindeutig, was heute an Code dazugekommen ist.

## 9.5 Kernfunktionalität

- [ ] ... (dieses AP sollte zur Hälfte offline, also ohne Laptop zu bearbeiten sein — beispielsweise ein Datenmodell?)
- [ ] ...
- [ ] ...

✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 16.5 Kernfunktionalität und Ausbau

- [ ] ...
- [ ] ...
- [ ] ...
- [ ] ...

✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 23.5 Abschluss

- [ ] ...
- [ ] ... (falls Ihnen nichts einfällt: Können Sie mit einem PowerShell-Skript von Ihrer Datenbank regelmäßig ein *backup* erstellen?)
- [ ] Reflexion über Ihre Arbeitsweise
- [ ] Beschreibung des fertigen Projekts mit .gif etc.

✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## Fertiges Projekt

✍️ Beschreiben Sie hier, wie Ihr Projekt am Ende aussieht, und fügen Sie mindestens ein .gif ein.

## Reflexion

✍️ Was ging gut, was ging weniger gut? Was haben Sie gelernt, und was würden Sie bei der nächsten Lernperiode versuchen besser zu machen? Fassen Sie auch einen übergeordneten Vorsatz für Ihr nächstes Jahr im Lernatelier (100 bis 200 Wörter).
