Imports Microsoft.VisualBasic.PowerPacks
Public Class MainForm

    'Objekte
    Dim player As New RectangleShape
    Dim computer As New RectangleShape
    Dim Ball As New OvalShape
    Dim canvas As New ShapeContainer

    'Ballgeschwindigkeiten
    Dim vxBall As Integer
    Dim vyBall As Integer

    'Spielfeldgrenzen
    Dim höheSpielfeld As Integer
    Dim breiteSpielfeld As Integer

    'Standartpositionen 
    Dim standartBallLocation As Point
    Dim standartPlayerLocation As Point
    Dim standartComputerLocation As Point

    'Zeitvariablen
    Dim Sekunden As Integer
    Dim Minuten As Integer

    'Spielstandsvariablen
    Dim Computerpunkte As Integer
    Dim Spielerpunkte As Integer

    'Klickvariablen
    Dim ClickCounterPause As Integer
    Dim Startklicks As Integer

    'Hilfsvariablen
    Dim Spiel_läuft As Boolean
    Dim Reset As Boolean

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Hintergrund festlegen
        canvas.Parent = Me
        computer.Parent = canvas
        Ball.Parent = canvas
        player.Parent = canvas

        'Timerintervalle festlegen
        playerTimer.Interval = 1 '1 Millisekunde
        ballTimer.Interval = 1 '1 Millisekunde
        computerTimer.Interval = 1 '1 Millisekunde
        SpielzeitTimer.Interval = 1000 '1 Sekunde

        'Alle Timer stoppen
        Spiel_starten(False)

        'Spielfeldabmessungen festlegen
        höheSpielfeld = Me.Height - MenuStrip.Height
        breiteSpielfeld = Me.Width - 20 '-20 wegen den Rändern der Form

        'Punkte für die Standart Position der Objekte festlegen
        standartBallLocation = New Point(breiteSpielfeld / 2, höheSpielfeld / 2)
        standartPlayerLocation = New Point(20, höheSpielfeld / 2 - playerBumper.Height / 2)
        standartComputerLocation = New Point(breiteSpielfeld - 25, höheSpielfeld / 2 - computerBumper.Height / 2)

        'Objekte auf Standartposition setzen
        setStandartPosition()

        'Spielzeitanzeige
        lblSpielzeit.Text = "Spielzeit: 00 : 00"
        Minuten = 0
        Sekunden = 0

        'Punktestand
        lblSpielstand.Text = "0 : 0"
        Spielerpunkte = 0
        Computerpunkte = 0

        'Bumper und Ball sind für User uninteragierbar
        playerBumper.Enabled = False
        computerBumper.Enabled = False
        gameBall.Enabled = False

        'Spielarten konfigurieren
        SpielBis3ToolStripMenuItem.CheckOnClick = True
        SpielBis5ToolStripMenuItem.CheckOnClick = True
        SpielBis10ToolStripMenuItem.CheckOnClick = True
        FreiesSpielToolStripMenuItem.CheckOnClick = True

        'Spielarten auf Freies Spiel voreinstellen
        SpielBis3ToolStripMenuItem.Checked = False
        SpielBis10ToolStripMenuItem.Checked = False
        SpielBis5ToolStripMenuItem.Checked = False
        FreiesSpielToolStripMenuItem.Checked = True

    End Sub

    Private Sub setStandartPosition()

        'Alle Objekte auf Standartposition setzen
        gameBall.Location = standartBallLocation
        playerBumper.Location = standartPlayerLocation
        computerBumper.Location = standartComputerLocation

    End Sub

    Private Sub Spiel_starten(ByVal Start As Boolean)

        If Start Then

            'alle Timer Starten
            playerTimer.Start()
            computerTimer.Start()
            ballTimer.Start()
            SpielzeitTimer.Start()

            Spiel_läuft = True

        ElseIf Start = False Then

            'alle Timer stoppen
            playerTimer.Stop()
            computerTimer.Stop()
            ballTimer.Stop()
            SpielzeitTimer.Stop()

            Spiel_läuft = False

        End If
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        'Beim Klick auf Start

        Startklicks += 1

        'Spiel weiterlaufen lassen falls es pausiert ist
        If ClickCounterPause = 1 Then
            lblStop.Hide()
            Spiel_starten(True)
            ClickCounterPause = 0
        Else

            Reset = False

            'Zeitanzeige zurücksetzen
            lblSpielzeit.Text = "Spielzeit: 00 : 00"
            Minuten = 0
            Sekunden = 0

            'Geschwindigkeit des Balles in X- und Y-Richtung
            'zufällig zwischen 5 und 10 festlegen
            Dim Zufallsgeschindigkeit As New System.Random
            vxBall = Zufallsgeschindigkeit.Next(5, 10)
            vyBall = Zufallsgeschindigkeit.Next(5, 10)

            'Objekte auf Standartposition setzen
            setStandartPosition()

            'Timer starten
            Spiel_starten(True)
        End If

    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        'Beim Klick auf Reset

        Reset = True

        'Objekte auf Standartposition setzen
        setStandartPosition()

        'Timer stoppen
        Spiel_starten(False)

        'Spielstand zurücksetzen 
        Computerpunkte = 0
        Spielerpunkte = 0
        lblSpielstand.Text = "0 : 0"

        'Spielzeit zurücksetzen
        lblSpielzeit.Text = "Spielzeit: 00 : 00"

        'Text des Start Buttons zurücksetzen
        StartToolStripMenuItem.Text = "Start"

        'Mögliches Pausieren des Spiels rückgängig machen
        ClickCounterPause = 0
        lblStop.Hide()

        'Ballgeschwindigkeit zurücksetzen
        vxBall = 0
        vyBall = 0

    End Sub

    Private Sub SchließenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchließenToolStripMenuItem.Click
        'Beim Klick auf Schließen

        Spiel_starten(False)

        'Messagebox zeigen und Dialogergebnis in Variable einlesen
        Dim result As Integer = MessageBox.Show("Willst du das Spiel wirklich beenden?", "Warnung", _
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Ergebnis des Dialogs vergleichen
        If result = DialogResult.Yes Then 'Ja -> Spiel beenden
            'Programm schließen
            Me.Close()
        ElseIf result = DialogResult.No Then 'Nein -> Spiel nicht beenden
            'Hauptfenster focusieren
            Me.Focus()
        End If
    End Sub

    Private Sub PauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        'Beim Klick auf Pause

        If Not Reset Then 'Verhindern, dass beim Reset pausiert wird

            'Spiel beim ersten Klick auf Pause anhalten...
            If ClickCounterPause = 0 And Spiel_läuft Then
                Spiel_starten(False)
                lblStop.Show()
                ClickCounterPause = 1
                '... und beim zweiten wieder starten
            ElseIf ClickCounterPause = 1 Then
                lblStop.Hide()
                Spiel_starten(True)
                ClickCounterPause = 0
            End If

        End If

    End Sub

    Private Sub MainForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'Bei beliebigem Tastendruck in der MainForm

        If Not Reset Then 'Verhindern, dass beim Reset pausiert wird

            'Wenn die Taste "Esc" war, Spiel pausieren...
            If Keys.Escape And ClickCounterPause = 0 And Spiel_läuft Then
                Spiel_starten(False)
                lblStop.Show()
                ClickCounterPause = 1
                '... und beim zweiten Klick Spiel wieder starten
            ElseIf Keys.Escape And ClickCounterPause = 1 Then
                Spiel_starten(True)
                lblStop.Hide()
                ClickCounterPause = 0
            End If

        End If
    End Sub

    Private Sub AnleitungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnleitungToolStripMenuItem.Click
        Anleitung.Show() 'Anleitungsfenster anzeigen
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreditsToolStripMenuItem.Click
        Credits.Show() 'Creditsfenster anzeigen
    End Sub

    Private Sub HighscoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HighscoresToolStripMenuItem.Click
        'Beim Klick auf Highscores

        If Not Reset And Spiel_läuft Then 'Verhindern, dass beim Reset pausiert wird
            'Spiel pausieren
            Spiel_starten(False)
            lblStop.Show()
            ClickCounterPause = 1
        End If

        Highcores.Show() 'Highscores Fenster anzeigen
    End Sub

    Private Sub HilfeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HilfeToolStripMenuItem.Click
        'Beim Klick auf Hilfe

        If Not Reset And Spiel_läuft Then 'Verhindern, dass beim Reset pausiert wird
            'Spiel pausieren
            Spiel_starten(False)
            lblStop.Show()
            ClickCounterPause = 1
        End If

    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EinstellungenToolStripMenuItem.Click
        'Beim Klick auf den Einstellungen-Reiter

        'Verhindern, dass beim Reset pausiert wird
        If Not Reset And Spiel_läuft Then
            'Spiel pausieren
            Spiel_starten(False)
            lblStop.Show()
            ClickCounterPause = 1
        End If
    End Sub

    Private Sub FreiesSpielToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FreiesSpielToolStripMenuItem.Click
        SpielBis3ToolStripMenuItem.Checked = False
        SpielBis5ToolStripMenuItem.Checked = False
        SpielBis10ToolStripMenuItem.Checked = False
        FreiesSpielToolStripMenuItem.Checked = True

        ResetToolStripMenuItem.PerformClick() 'Spiel reseten
    End Sub

    Private Sub SpielBis3ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpielBis3ToolStripMenuItem.Click
        SpielBis3ToolStripMenuItem.Checked = True
        SpielBis5ToolStripMenuItem.Checked = False
        SpielBis10ToolStripMenuItem.Checked = False
        FreiesSpielToolStripMenuItem.Checked = False

        ResetToolStripMenuItem.PerformClick() 'Spiel reseten
    End Sub

    Private Sub SpielBis5ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpielBis5ToolStripMenuItem.Click
        SpielBis3ToolStripMenuItem.Checked = False
        SpielBis5ToolStripMenuItem.Checked = True
        SpielBis10ToolStripMenuItem.Checked = False
        FreiesSpielToolStripMenuItem.Checked = False

        ResetToolStripMenuItem.PerformClick() 'Spiel reseten
    End Sub

    Private Sub SpielBis10ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpielBis10ToolStripMenuItem.Click
        SpielBis3ToolStripMenuItem.Checked = False
        SpielBis5ToolStripMenuItem.Checked = False
        SpielBis10ToolStripMenuItem.Checked = True
        FreiesSpielToolStripMenuItem.Checked = False

        ResetToolStripMenuItem.PerformClick() 'Spiel reseten
    End Sub

    Private Sub playerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playerTimer.Tick
        'Wird bei jedem Tick des playerTimer ausgeführt (1ms)

        'Verändern der Position des Spielerbumpers mit der Maus
        playerBumper.Top = MousePosition.Y - 120

        'Grenzen bestimmen, an die der Spielerbumper gebracht werden kann
        If playerBumper.Top <= MenuStrip.Height Then 'obere Grenze
            playerBumper.Top = MenuStrip.Height 'Playerbumper kann nicht weiter als 24px nach oben
        ElseIf playerBumper.Bottom >= höheSpielfeld Then 'untere Grenze
            playerBumper.Top = höheSpielfeld - playerBumper.Height
            '-> Playerbumper kann nicht weiter nach unten, als das Spielfeld groß ist
        End If
    End Sub

    Private Sub computerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles computerTimer.Tick
        'Wird bei jedem Tick des computerTimer ausgeführt (1ms)

        'Steuerung des Computerbumper
        If gameBall.Top <= computerBumper.Top + (computerBumper.Height / 2) Then
            'Wenn der Spielball über dem ComputerBumper ist, dann...
            If Sekunden < 30 Then
                '... soll, bevor 30 Sekunden vergangen sind, sich der Bumper mit der 
                'gleichen Geschwindigkeit wie der Ball nach oben bewegen
                computerBumper.Top -= vyBall
            Else
                'nach 30 Sekunden nimmt die Y-Geschwindigkeit des ComputerBumpers ab
                computerBumper.Top -= 20
            End If

        ElseIf gameBall.Top >= computerBumper.Top + (computerBumper.Height / 2) Then
            'Wenn der Spielball unter der ComputerBumper-Mitte ist, dann...
            If Sekunden < 30 Then
                '... soll, bevor 30 Sekunden vergangen sind, sich der Bumper mit der 
                'gleichen Geschwindiketi wie der Ball nach unten bewgen
                computerBumper.Top += vyBall
            Else
                'nach 30 Sekunden nimmt die Y-Geschwindikeit des ComputerBumpers ab
                computerBumper.Top += 20
            End If

        End If
    End Sub

    Private Sub ballTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ballTimer.Tick
        'Wird bei jedem Tick des ballTimer ausgeführt (1ms)

        'X- und Y-Koordinate des Balls die Geschwindigkeit in X- und Y- Richtung abziehen
        '(d.h. Bewegung nach links oben)
        gameBall.Top -= vyBall
        gameBall.Left -= vxBall



        'BALLSTEUERUNG UND REFLEXION AN GRENZEN


        'Wenn der Ball an einen der 2 Bumper stößt...
        If gameBall.Bounds.IntersectsWith(playerBumper.Bounds) _
            Or gameBall.Bounds.IntersectsWith(computerBumper.Bounds) Then
            vxBall = -vxBall '...X-Geschwindigkeit des Balls invertiern
        End If

        'Wenn der Ball an die obere bzw. untere Spielfeldbegrenzung stößt...
        If gameBall.Top <= MenuStrip.Height Or gameBall.Bottom >= höheSpielfeld Then
            vyBall = -vyBall '...Y-Geschwindigkeit des Balls invertieren
        End If

        'Wenn der Ball an den rechten Spielfeldrand stößt:
        If gameBall.Right >= breiteSpielfeld Then
            '-> der Spieler gewinnt

            Spiel_starten(False) 'Timer stoppen

            'Bisherige beste Spielzeit mit der jetzigen Spielzeit vergleichen
            If My.Settings.BesteSpielzeit < Minuten * 60 + Sekunden Then
                'Wenn jetzige Zeit größer ist als die gespeicherte, wird sie überschrieben
                My.Settings.BesteSpielzeit = ((Minuten * 60) + Sekunden)
                My.Settings.Save() 'Änderungen speichern
            End If

            'Jetzige Spielzeit zur Gesamtspielzeit hinzuzählen
            My.Settings.Gesamtspielzeit += ((Minuten * 60) + Sekunden)
            My.Settings.Save() 'Änderungen speichern

            Spielerpunkte += 1 'Spieler erhält einen Punkt
            StartToolStripMenuItem.Text = "Weiter..." 'Text des Start-Buttons ändern
            MessageBox.Show("Du erhälst einen Punkt! Du kannst es mit ""Weiter"" nochmal versuchen", _
                            "Super!", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If




        'SIEGBEDINGUNGEN (BALL STÖßT AN RECHTE/LINKE SPIELFELDGRENZE)


        'Wenn der Ball an den linken Spielfeldrand stößt:
        If gameBall.Left <= 0 Then
            '-> der Spieler verliert

            Spiel_starten(False) 'Timer stoppen

            'Bisherige beste Spielzeit mit der jetzigen Spielzeit vergleichen
            If My.Settings.BesteSpielzeit < Minuten * 60 + Sekunden Then
                'Wenn jetzige Zeit größer ist als die gespeicherte, wird sie überschrieben
                My.Settings.BesteSpielzeit = ((Minuten * 60) + Sekunden)
                My.Settings.Save() 'Änderungen speichern
            End If

            'Jetzige Spielzeit zu Gesamtspielzeit hinzuzählen
            My.Settings.Gesamtspielzeit += ((Minuten * 60) + Sekunden)
            My.Settings.Save() 'Änderungen speichern

            Computerpunkte += 1 '-> Computer erhält einen Punkt
            StartToolStripMenuItem.Text = "Weiter..." 'Text des Start-Buttons ändern
            MessageBox.Show("Der Computer erhält einen Punkt! Du kannst es mit ""Weiter"" nochmal versuchen", _
                            "Oh man...", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If

        'Spielstand anzeigen
        lblSpielstand.Text = Spielerpunkte & " : " & Computerpunkte

        Spielergebnis_prüfen()



        'VERHALTEN VON LABELS BEI KONTAKT MIT BALL

        'Spielstand Label verstecken, wenn der Ball es berührt
        If gameBall.Bounds.IntersectsWith(lblSpielstand.Bounds) Then
            lblSpielstand.Visible = False
        Else
            lblSpielstand.Visible = True
        End If

        'Spielzeit Label verstecken, wenn der Ball es berührt
        If gameBall.Bounds.IntersectsWith(lblSpielzeit.Bounds) Then
            lblSpielzeit.Visible = False
        Else
            lblSpielzeit.Visible = True
        End If

    End Sub

    Private Sub Spielergebnis_prüfen()


        'SPIELERGEBNISPRÜFUNG BEIM SPIEL BIS 3

        If SpielBis3ToolStripMenuItem.Checked Then
            'Spiel geht bis 3
            If Computerpunkte = 3 Then

                'Wert für "Spiele bis 3 verloren" um 1 erhöhen
                My.Settings.SpieleBis3Verloren += 1
                My.Settings.Save() 'speichern

                MessageBox.Show("Leider verloren! Versuchs doch gleich nochmal :)", _
                                "Oh man...", MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen

            ElseIf Spielerpunkte = 3 Then

                'Wert für "Spiele bis 3 gewonnen! um 1 erhöhen 
                My.Settings.SpieleBis3Gewonnen += 1
                My.Settings.Save() 'speichern

                MessageBox.Show("Du hast gewonnen!!!", "Super!", _
                                MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen
            End If

        End If


        'SPIELERGEBNISPRÜFUNG BEIM SPIEL BIS 5

        If SpielBis5ToolStripMenuItem.Checked Then
            'Spiel geht bis 5
            If Computerpunkte = 5 Then

                'Wert für Spiele bis 5 verloren um 1 erhöhen
                My.Settings.SpieleBis3Verloren += 1
                My.Settings.Save() 'speichern

                MessageBox.Show("Leider verloren! Versuchs doch gleich nochmal :)", _
                                "Oh man...", MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen

            ElseIf Spielerpunkte = 5 Then

                'Wert für Spiele bis 5 gewonnen um 1 erhöhen
                My.Settings.SpieleBis5Gewonnen += 1
                My.Settings.Save() 'speichern

                MessageBox.Show("Du hast gewonnen!!!", "Super!", _
                                MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen
            End If
        End If


        'SPIELERGEBNISPRÜFUNG BEIM SPIEL BIS 10

        If SpielBis10ToolStripMenuItem.Checked Then
            'Spiel geht bis 10
            If Computerpunkte = 10 Then

                'Wert für Spiele bis 10 verloren um 1 erhöhen
                My.Settings.SpieleBis3Verloren += 1
                My.Settings.Save() 'speichern

                MessageBox.Show("Leider verloren! Versuchs doch gleich nochmal :)", _
                                "Oh man...", MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen

            ElseIf Spielerpunkte = 10 Then

                'Wert für Spiele bis 10 gewonnen um 1 erhöhen
                My.Settings.SpieleBis10Gewonnen += 1
                My.Settings.Save() 'speichern

                MessageBox.Show("Du hast gewonnen!!!", "Super!", _
                                MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen
            End If
        End If

    End Sub

    Private Sub Spielzeit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpielzeitTimer.Tick
        'Hier ist ein Tick 1s lang (1000 ms)

        Sekunden += 1

        'Minutenumsprung
        If Sekunden = 60 Then
            Sekunden = 0
            Minuten += 1
        End If

        'Label Ausgabe für die Spielzeit formatieren
        'Angenommen "Minuten" bleibt immer einstellig, da keine Runde
        'über 9 Minuten dauern kann.
        If Sekunden < 10 Then
            lblSpielzeit.Text = "Spielzeit: " & "0" & Minuten & " : " & "0" & Sekunden
        Else
            lblSpielzeit.Text = "Spielzeit: " & "0" & Minuten & " : " & Sekunden
        End If


        'GESCHWINDIGKEITSREGELUNG DES BALLS

        For i As Integer = 0 To 50 Step 10
            If Sekunden = i Then
                'Wenn 0,10,20,30,40,50 Sekunden vorbeigegangen sind, wird jeweils
                'die X- und Y-Geschwindigkeit des Balls um den Betrag 5 erhöht
                'Die 0 ist beim ersten Durchlauf nicht relevant, da Sekunden schon
                'hochgezählt wurde. Sie kommt beim Minutenumsprung zum Einsatz,
                'bei dem Sekunden = 0 ist

                'X-Geschwindigkeit erhöhen
                If vxBall < 0 Then
                    vxBall -= 5
                Else
                    vxBall += 5
                End If

                'Y-Geschwindikeit erhöhen
                If vyBall < 0 Then
                    vyBall -= 5
                Else
                    vyBall += 5
                End If
            End If
        Next

    End Sub

End Class
