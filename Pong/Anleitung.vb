Public Class Anleitung

    'Tree View Nodes
    Dim RootAnleitung As TreeNode
    Dim NodeAllgemein As TreeNode
    Dim NodeEinstellungen As TreeNode
    Dim NodeSpielstart As TreeNode
    Dim NodeHighscores As TreeNode

    'Stringvariablen für den Text in der Textbox
    Dim AnleitungAllgemein As String
    Dim AnleitungEinstellungen As String
    Dim AnleitungSpielstart As String
    Dim AnleitungHighscores As String

    Private Sub Anleitung_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Die Stringvariablen mit dem Hilfetext füllen, der in der Textbox angezeigt werden soll:

        AnleitungAllgemein = _
        "ANLEITUNG ZUM SPIEL PONG:" & vbCrLf & vbCrLf & vbCrLf & _
        "Mit deinem Mauszeiger kannst du die Position des linken Bumpers," & _
        "dein Bumper, verändern." & vbCrLf & vbCrLf & _
        "Du musst versuchen den Ball mit deinem Bumper abzuwehren, indem " & _
        "du ihn in die Flugbahn des Balles bewegst. Dein Computergegner wird " & _
        "das selbe tun." & vbCrLf & vbCrLf & _
        "Wenn du es schaffst den Ball am gegnerischen Bumper vorbeizuschlagen, " & _
        "hast du gewonnen."

        AnleitungSpielstart = _
        "FUNKTIONEN DES START-REITERS:" & vbCrLf & vbCrLf & vbCrLf & _
        "- Mit ""Start"" kannst du ein Spiel starten. Im laufenden Spiel kannst du " & _
        "dann an der gleichen Stelle mit ""Weiter..."" dein Spiel nach Rundenende fortsetzen." & vbCrLf & vbCrLf & _
        "- Mit einem Klick auf ""Pause"" oder durch Drücken der Escape-Taste pausierst du das laufende Spiel." & vbCrLf & vbCrLf & _
        "- Der Klick auf Reset, setzt dein aktuelles Spiel zurück. Du kannst mit ""Start"" wieder beginnen." & vbCrLf & vbCrLf & _
        "- Durch die ""Schließen""-Taste beendest du das Spiel." '& vbCrLf & vbCrLf & vbCrLf & vbCrLf & _

        AnleitungEinstellungen = _
        "FUNKTIONEN DES EINSTELLUNGEN-REITERS:" & vbCrLf & vbCrLf & vbCrLf & _
        "Hier kannst du zwischen den 4 Spielarten wählen." & vbCrLf & vbCrLf & _
        "- Wählst du ""freies Spiel"", gibt es kein Punktelimit. Du kannst so lange spielen wie du möchtest." & vbCrLf & vbCrLf & _
        "- Wählst du ""Spiel bis 3/5/10"" gibt es ein Punktelimit von 3/5/10 Punkten. Wer als erster " & _
        "diese Punktzahl erreicht ist der Sieger."

        AnleitungHighscores = _
            "FUNKTIONEN DES HIGHSCORES-REITERS:" & vbCrLf & vbCrLf & vbCrLf & _
        "Hier kannst du verschiedene Erungenschaften betrachten:" & vbCrLf & vbCrLf & _
        "Du siehst, wie viele Spiele du in den verschiedenen Spielmodi gewonnen bzw. verloren hast." & vbCrLf & _
        "Außerdem kannst du betrachten, wie viel Zeit du insgesamt im Spiel verbracht hast " & _
        "und die längste Zeit, in der du eine Runde gegen den Computer gespielt hast "

        'Tree View Hirarchie erstellen
        RootAnleitung = tvÜbersicht.Nodes.Add("Anleitung")
        NodeAllgemein = RootAnleitung.Nodes.Add("Allgemein")
        NodeEinstellungen = RootAnleitung.Nodes.Add("Einstellungen")
        NodeSpielstart = RootAnleitung.Nodes.Add("Spielstart")
        NodeHighscores = RootAnleitung.Nodes.Add("Highscores")

        'Tree View aufklappen
        tvÜbersicht.ExpandAll()

    End Sub

    Private Sub tvÜbersicht_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvÜbersicht.AfterSelect
        'Je nach ausgewähltem Punkt soll eine Erklärung erscheinen
        If tvÜbersicht.SelectedNode Is NodeAllgemein Then
            tbAnleitung.Text = AnleitungAllgemein
        ElseIf tvÜbersicht.SelectedNode Is NodeEinstellungen Then
            tbAnleitung.Text = AnleitungEinstellungen
        ElseIf tvÜbersicht.SelectedNode Is NodeSpielstart Then
            tbAnleitung.Text = AnleitungSpielstart
        ElseIf tvÜbersicht.SelectedNode Is NodeHighscores Then
            tbAnleitung.Text = AnleitungHighscores
        End If
    End Sub
End Class