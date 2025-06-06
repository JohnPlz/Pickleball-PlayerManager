# Pickleball-PlayerManager

# 🏓 C# Aufgabe: Pickleball-Turnierverwaltung

Erstelle eine kleine Konsolenanwendung in C#, mit der Pickleball-Spieler verwaltet und einfache Matches simuliert werden können.

---

## 📌 Anforderungen

### 1. Spielerklasse (`Player`)
- **Eigenschaften:**
  - `Name` (`string`)
  - `Alter` (`int`)
  - `Rating` (`double`, z. B. 2.0 bis 5.0)
- **Methode:**
  - `PrintInfo()` → Gibt Name, Alter und Rating aus.

### 2. Matchklasse (`Match`)
- **Eigenschaften:**
  - `Player1` (`Player`)
  - `Player2` (`Player`)
  - `Gewinner` (`Player`, kann `null` sein)
- **Methoden:**
  - `PlayMatch()`:
    - Der Spieler mit höherem Rating gewinnt.
    - Bei gleichem Rating gewinnt zufällig einer der beiden.
  - `PrintResult()`:
    - Gibt an, wer gegen wen gespielt hat und wer gewonnen hat.

### 3. Verwaltungsklasse (`TournamentManager`)
- **Eigenschaften:**
  - Eine Liste von Spielern.
- **Methoden:**
  - `AddPlayer(Player p)`
  - `ListPlayers()`
  - `StartRandomMatch()`:
    - Wählt zwei zufällige Spieler aus der Liste und startet ein Match.

### 4. `Main`-Methode (`Program.cs`)
Erstelle ein Menüsystem mit folgenden Optionen:
- Spieler hinzufügen
- Spieler auflisten
- Zufälliges Match starten
- Beenden

---

## ✨ Bonusideen (optional)
- Spieler in einer Datei speichern und beim Programmstart wieder laden.
- Ratings nach dem Match anpassen (z. B. Gewinner +0.1, Verlierer -0.1).
- Historie aller gespielten Matches speichern.

---

## 👨‍🏫 Lernziele
- Objektorientierung (Klassen, Methoden, Eigenschaften)
- Grundlegende Logik & Bedingungen
- Arbeiten mit Listen und Zufallszahlen
- Konsoleneingaben und -ausgaben
- Menüführung mit Schleifen

