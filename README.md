# Finanzassistent




| Nr.   | "Titel"      | Zuständige Person  | Beschreibung |
| ----- |--------------|------------------ | ------------ |
| 1.     | Datei Einlesen |  Ben & Joël                | Das Programm sollte die Abgespeicherte Datei einlesen um fals weitere Eingaben dazu kommen, diese mit den schon gegebenen Eingeabe zu verrechen | Ben & Joël, Jan
| 2.     | Zahlen verrechnen|     Gian              | Das Programm sollte die Geldsummen von Einnahme und Ausgabe miteinander verrechnen um später dann die Sparzeit auszurechnen. | Jan
| 3.| Ausgabe der Zahlen|   Jan      Jan           | Es sollte ausgegeben werden wie lang man auf das Sparziel sparen müsste um es zu erreichen und vieleicht auch schauen ob es Sinn ergibts so zu sparen. |



Arbeitspakete

| Nr.| Beschreibung | Geplante Zeit |
|----|--------------|---------------|
| 1. | Datei Sollte eingelesen werden können |    5          |
| 2. | Es sollte zwischen Einnahme und Ausgabe entschieden werden können             |   2           |
| 3. | Der Betrag sollte bei Eingabe/Ausahme richtig eingespeichert werden             |     4          |
| 4. | Die Beträge aus Eingabe und Ausgabe sollten korrekt miteinander verrechnet werden.             |      3         |
| 5. | Der Betrag der Gespahrt werden möchte sollte korrekt erfasst werden             |  3           |
| 6. | Der Betag der Eingabe und Ausgabe sollten korrekt mit dem Sparziel verrechnet werden und es sollte eine korrekte Spaarzeit ausgegeben werden.             |      4       |
| 7. | Es sollte errechnet werden ob das Ziel überhaupt Sinn ergibt(z.B. falls über 10 Jahre Nachricht dass es zu lange ist.)         |     1        |
| 8. |   Der Code sollte ohne Fehler laufen und die Benutzung ist angenehm gestaltet           |     10         |


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
![Screenshot_2022-10-24_141302](https://user-images.githubusercontent.com/111043950/204285685-e0240edc-6d7f-4c94-bc9e-2f3ad64dbba3.png)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

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
