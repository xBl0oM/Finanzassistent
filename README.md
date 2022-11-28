# Finanzassistent




| Nr.   | "Titel"      | Zuständige Person  | Beschreibung |
| ----- |--------------|------------------ | ------------ |
| 1.     | Datei Einlesen |  Ben & Joël                |
|2.|Das Programm sollte die Abgespeicherte Datei einlesen um falls weitere Eingaben dazu kommen, diese mit den schon gegebenen Eingaben zu verrechen | Ben & Joël, Jan|
| 3.     | Zahlen verrechnen|     Gian              | 
|4. |Das Programm sollte die Geldsummen von Einnahme und Ausgabe miteinander verrechnen um später dann die Sparzeit auszurechnen. | Jan|
| 5.| Ausgabe der Zahlen|   Jan       | 
|6. |Es sollte ausgegeben werden wie lang man auf das Sparziel sparen müsste um es zu erreichen und vieleicht auch schauen ob es Sinn ergibts so zu sparen. |Joël|




# Projekt-Dokumentation



Gruppe Waldfüchse
Müller, Haldimann, Frey, Miletti

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  24.10     | 0.0.1   | Erste Planung |
|   31.10    | 0.0.2     |      Finale Planung und erste Umsetzung in Code                                                        |
|  7.11     | 0.0.3   |    Weiterführung des Codes zum Einlesen einer Datei und Bekanntmachen mit den Einlese-Methoden                                             |
| 14.11 | 0.1.3   |  Zusammenführung des Codes und Fehlerbehebung, Erstellen des Kalkulators |
| 21.11 | 0.1.4   |  Fehlerbehebung und weiteres Zusammenführen des Codes, Kalkulator final abgeschlossen |
|28.11| 1.0.0 |  | 


## 1 Informieren

### 1.1 Ihr Projekt

Wir programmieren ein Programm, das Sparziele aus Ein- und Ausnahmen errechnen kann und dann eine logische Sparzeit (effektiv) errechnet.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |   muss             | funktional     |Als Benutzer möchte ich meine Ein- und Ausgaben in einer Datei vermerken. |
| 2  |      muss           |  funktional    |  Als Benutzer möchte ich, dass meine Daten richtig verrechnet und logisch ausgegeben werden.      |
| 3 | kann   |   qualitativ    |     Als Benutzer möchte ich darüber informiert werden, ob der Dateipfad richtig ist oder ob er Fehler enthält. | 
| 4 | muss | qualitativ  | Als benutzer möchte ich, dass das Programm benutzerfreundlich ist und gut aussieht. |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- | 
| 1.1  | Die Dateien für Ein/Ausgaben wurden erstellt und der Dateipfad eingegeben.    | Ein- und Ausgaben        |    Die Ein- und Ausgaben wurden in der externen Datei gespeichert. |
| 2.2 | Die Ein- und Ausgaben und das Sparziel wurden eingegeben | Ein- und Ausgaben, Sparziel | Ein logisches und effizientes Sparziel wurde ausgegeben.  |
| 3.3 | Der Dateipfad wurde eingegeben | Dateipfad | Bestätigung dass der Pfad richtig oder dass er falsch ist.|

### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/111043950/204298448-34582752-9293-4e8c-a07c-d61829918ca7.png)


## 2 Planen

Arbeitspakete

| Nr.| Beschreibung | Geplante Zeit |
|----|--------------|---------------|
| 1. | Datei sollte eingelesen werden können |    5          |
| 2. | Es sollte zwischen Einnahme und Ausgabe unterschieden werden können             |   2           |
| 3. | Der Betrag sollte bei Eingabe/Ausgabe richtig eingespeichert werden             |     4          |
| 4. | Die Beträge aus Eingabe und Ausgabe sollten korrekt miteinander verrechnet werden             |      3         |
| 5. | Der Betrag der Gespart werden möchte sollte korrekt erfasst werden             |  3           |
| 6. | Der Betrag der Eingabe und Ausgabe sollten korrekt mit dem Sparziel verrechnet werden und es sollte eine logische Sparzeit ausgegeben werden   |      4       |
| 7. | Es sollte errechnet werden ob das Ziel überhaupt Sinn ergibt(z.B. falls über 10 Jahre Nachricht dass es zu lange ist)         |     1        |
| 8. |   Der Code sollte ohne Fehler laufen und die Benutzung ist angenehm gestaltet           |     10         |

Total: 




## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  24.10     |   Ben & Joël        |  5             |        6           |
|2.A |   31.10    |    Jan       |     2          |    3               |
|3.A| 07.11| Ben & Joël |4|4-5|
|4.A|14.11| Gian|3|3|
|5.A|14.11|Jan|3|3|
|6.A|21.11| Jan |4|4|
|7.A|21.11|Gian|1|1|
|8.A|28.11|Ben, Joël, Jan, Gian|10|15-18|


# 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.
