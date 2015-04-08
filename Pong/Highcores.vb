Public Class Highcores

    'Zeitvariablen
    Dim Gesamtsekunden As Integer
    Dim Minuten As Integer
    Dim Sekunden As Integer

    Private Sub Highcores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbHighscore.Items.Clear() 'Inhalte der Listbox löschen
    End Sub

    Private Sub btnSpieleGewonnen_Click(sender As System.Object, e As System.EventArgs) Handles btnSpieleGewonnen.Click
        'Beim Klick auf Spiele gewonnen

        lbHighscore.Items.Clear() 'Inhalt der ListBox löschen

        'Ausgabe der vorher, im Programm, gespeicherten Werte für die gewonnenen
        'und verlorenen Spiele der verschiedenen Spielmodi

        lbHighscore.Items.Add("Spiele im Modus ""Spiel bis 3"" gewonnen: " & My.Settings.SpieleBis3Gewonnen)
        lbHighscore.Items.Add("Spiele im Modus ""Spiel bis 3"" verloren: " & My.Settings.SpieleBis3Verloren)
        lbHighscore.Items.Add("")
        lbHighscore.Items.Add("")
        lbHighscore.Items.Add("Spiele im Modus ""Spiel bis 5"" gewonnen: " & My.Settings.SpieleBis5Gewonnen)
        lbHighscore.Items.Add("Spiele im Modus ""Spiel bis 5"" verloren: " & My.Settings.SpieleBis5Verloren)
        lbHighscore.Items.Add("")
        lbHighscore.Items.Add("")
        lbHighscore.Items.Add("Spiele im Modus ""Spiel bis 10"" gewonnen: " & My.Settings.SpieleBis10Gewonnen)
        lbHighscore.Items.Add("Spiele im Modus ""Spiel bis 10"" verloren: " & My.Settings.SpieleBis10Verloren)

    End Sub

    Private Sub btnLängsteZeit_Click(sender As System.Object, e As System.EventArgs) Handles btnLängsteZeit.Click
        'Beim Klick auf Längste Zeit im Spiel

        lbHighscore.Items.Clear() 'Inhalt der ListBox löschen

        'Aus den gespeicherten Sekunden für die längste Spielzeit, Minuten und Sekunden berechnen
        Gesamtsekunden = My.Settings.BesteSpielzeit
        Minuten = Math.Floor(Gesamtsekunden / 60) 'Gibt die größte Ganzzahl der Division zurück,
        'die kleiner oder gleich dem Ergebnis ist.
        Sekunden = Gesamtsekunden - (Minuten * 60)

        'Die berechneten Werte in der List Box ausgeben
        lbHighscore.Items.Add("Deine längste Zeit in einem Spiel war: ")
        lbHighscore.Items.Add(Minuten & " Minuten" & " : " & Sekunden & " Sekunden")

    End Sub

    Private Sub btnGesamtspielzeit_Click(sender As System.Object, e As System.EventArgs) Handles btnGesamtspielzeit.Click
        'Beim Klick auf Gesamtspielzeit

        lbHighscore.Items.Clear() 'Inhalt der ListBox löschen

        'Aus den gespeicherten Sekunden für die Gesamtspielzeit, Minuten und Sekunden berechnen
        Gesamtsekunden = My.Settings.Gesamtspielzeit
        Minuten = Math.Floor(Gesamtsekunden / 60) 'Gibt die größte Ganzzahl der Division zurück,
        'die kleiner oder gleich dem Ergebnis ist.
        Sekunden = Gesamtsekunden - (Minuten * 60)

        'Die berechneten Werte in der List Box ausgeben
        lbHighscore.Items.Add("Deine Gesamtspielzeit beträgt: ")
        lbHighscore.Items.Add(Minuten & " Minuten" & " : " & Sekunden & " Sekunden")

    End Sub

    Private Sub btnHighscoresZurücksetzen_Click(sender As System.Object, e As System.EventArgs) Handles btnHighscoresZurücksetzen.Click
        'Beim Klick auf Highscores zurücksetzen

        'Messagebox anzeigen und das Ergebnis des Dialogs in Variable einlesen
        Dim Result As DialogResult = MessageBox.Show("Willst du die Highscores wirklich zurücksetzen?", _
                                                     "Highscores zurücksetzen", MessageBoxButtons.YesNoCancel, _
                                                      MessageBoxIcon.Warning)

        If Result = Windows.Forms.DialogResult.Yes Then 'Beim Klick auf "Ja" in der Messagebox
            'Alle Einstellungen zurücksetzen
            My.Settings.BesteSpielzeit = 0
            My.Settings.Gesamtspielzeit = 0
            My.Settings.SpieleBis3Gewonnen = 0
            My.Settings.SpieleBis3Verloren = 0
            My.Settings.SpieleBis5Gewonnen = 0
            My.Settings.SpieleBis5Verloren = 0
            My.Settings.SpieleBis10Gewonnen = 0
            My.Settings.SpieleBis10Verloren = 0
            lbHighscore.Items.Clear() 'Inhalt der ListBox löschen
            MessageBox.Show("Highscores zurückgesetzt", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class