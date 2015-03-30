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

    'Sonstige
    Dim ClickCounterPause As Integer
    Dim Startklicks As Integer
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
        velocityTimer.Interval = 10000 '10 Sekunden
        SpielzeitTimer.Interval = 1000 '1 Sekunde

        'Timer stoppen
        Spiel_starten(False)

        'Spielfeldabmessungen 
        höheSpielfeld = Me.Height - 40
        breiteSpielfeld = Me.Width - 20

        'Punkte für die Standart Position der Objekte
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

        'Spielarten
        SpielBis3ToolStripMenuItem.CheckOnClick = True
        SpielBis5ToolStripMenuItem.CheckOnClick = True
        SpielBis10ToolStripMenuItem.CheckOnClick = True
        FreiesSpielToolStripMenuItem.CheckOnClick = True
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
            velocityTimer.Start()
            ballTimer.Start()
            SpielzeitTimer.Start()
            Spiel_läuft = True

        ElseIf Start = False Then

            'alle Timer stoppen
            playerTimer.Stop()
            computerTimer.Stop()
            velocityTimer.Stop()
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
        ElseIf Not Spiel_läuft Then

            'Prüfen ob das Spiel schon gestartet ist 
            Reset = False

            Minuten = 0
            Sekunden = 0

            'Geschwindigkeit des Balles in X und Y-Richtung zufällig zwischen 5 und 10 festlegen
            vxBall = Math.Round(Rnd() * 5 + 5)
            vyBall = Math.Round(Rnd() * 5 + 5)

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
        Dim result As Integer = MessageBox.Show("Willst du das Spiel wirklich beenden?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Ergebnis des Dialogs vergleichen
        If result = DialogResult.Yes Then 'Ja -> Spiel beenden
            'Programm schließen
            Me.Close()
        ElseIf result = DialogResult.No Then 'Nein -> Spiel nicht beenden
            'Hauptfenster focusieren und Spiel wieder starten
            Me.Focus()
            Spiel_starten(True)
        End If
    End Sub

    Private Sub PauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        'Beim Klick auf Pause

        'Verhindert, dass beim Reset pausiert wird
        If Not Reset Then
            'Spiel beim ersten Klick auf Pause anhalten...
            If ClickCounterPause = 0 Then
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
        'Bei beliebigem Tastendruck

        'Verhindert, dass beim Reset pausiert wird
        If Not Reset Then
            'Wenn die Taste "Esc" war, Spiel pausieren...
            If Keys.Escape And ClickCounterPause = 0 Then
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
        'Beim Klick auf "Wie wird gespielt" Hilfefenster öffnen
        Anleitung.Show()
        Anleitung.Focus()
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreditsToolStripMenuItem.Click
        Credits.Show()
    End Sub

    Private Sub HilfeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HilfeToolStripMenuItem.Click
        'Beim Klick auf Hilfe

        'Verhindert, dass beim Reset pausiert wird
        If Not Reset Then
            'Spiel pausieren
            Spiel_starten(False)
            lblStop.Show()
            ClickCounterPause = 1
        End If

    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EinstellungenToolStripMenuItem.Click
        'Beim Klick auf den Einstellungen-Reiter

        'Verhindert, dass beim Reset pausiert wird
        If Not Reset Then
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
    End Sub

    Private Sub SpielBis3ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpielBis3ToolStripMenuItem.Click
        SpielBis3ToolStripMenuItem.Checked = True
        SpielBis5ToolStripMenuItem.Checked = False
        SpielBis10ToolStripMenuItem.Checked = False
        FreiesSpielToolStripMenuItem.Checked = False

        ResetToolStripMenuItem.PerformClick()
    End Sub

    Private Sub SpielBis5ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpielBis5ToolStripMenuItem.Click
        SpielBis3ToolStripMenuItem.Checked = False
        SpielBis5ToolStripMenuItem.Checked = True
        SpielBis10ToolStripMenuItem.Checked = False
        FreiesSpielToolStripMenuItem.Checked = False

        ResetToolStripMenuItem.PerformClick()
    End Sub

    Private Sub SpielBis10ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpielBis10ToolStripMenuItem.Click
        SpielBis3ToolStripMenuItem.Checked = False
        SpielBis5ToolStripMenuItem.Checked = False
        SpielBis10ToolStripMenuItem.Checked = True
        FreiesSpielToolStripMenuItem.Checked = False

        ResetToolStripMenuItem.PerformClick()
    End Sub

    Private Sub playerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playerTimer.Tick
        'Wird bei jedem Tick des playerTimer ausgeführt (1ms)

        'Verändern der Position des Spielerbumpers mit der Maus
        playerBumper.Top = MousePosition.Y - 250

        'Grenzen bestimmen, an die der Spielerbumper gebracht werden kann
        If playerBumper.Top <= 24 Then 'obere Grenze
            playerBumper.Top = 24
        ElseIf playerBumper.Bottom >= höheSpielfeld Then 'untere Grenze
            playerBumper.Top = höheSpielfeld - playerBumper.Height
        End If
    End Sub

    Private Sub computerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles computerTimer.Tick
        'Wird bei jedem Tick des computerTimer ausgeführt (1ms)

        'Steuerung des Computerbumper
        If gameBall.Top <= computerBumper.Top + (computerBumper.Height / 2) Then

            If Sekunden < 30 Then
                'bevor 30 Sekunden vergangen sind ist der Computerbumper 
                'genauso schnell wie der Ball.
                computerBumper.Top -= vyBall
            Else
                computerBumper.Top -= 20
            End If

        ElseIf gameBall.Top >= computerBumper.Top + (computerBumper.Height / 2) Then

            If Sekunden < 30 Then
                'bevor 30 Sekunden vergangen sind ist der Computerbumper 
                'genauso schnell wie der Ball.
                computerBumper.Top += vyBall
            Else
                computerBumper.Top += 20
            End If

        End If
    End Sub

    Private Sub ballTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ballTimer.Tick
        'Wird bei jedem Tick des ballTimer ausgeführt (1ms)

        'Ball zum Start in die invertierte X- bzw. Y-Richtung bewegen (nach links oben)
        gameBall.Top -= vyBall
        gameBall.Left -= vxBall

        'Prüfen ob der Ball an die 2 Bumper stößt
        If gameBall.Bounds.IntersectsWith(playerBumper.Bounds) Or gameBall.Bounds.IntersectsWith(computerBumper.Bounds) Then
            vxBall = -vxBall 'X-Geschwindigkeit invertiern
        End If

        'Prüfen ob der Ball an die obere bzw untere Spielfeldbegrenzung stößt
        If gameBall.Top <= 24 Or gameBall.Bottom >= höheSpielfeld Then
            vyBall = -vyBall 'Y-Geschwindigkeit invertieren
        End If

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

        'Prüfen ob der Ball an den rechten Spielfeldrand stößt
        If gameBall.Right >= breiteSpielfeld Then
            'Spieler gewinnt
            Spiel_starten(False)
            Spielerpunkte += 1
            StartToolStripMenuItem.Text = "Weiter..."
            MessageBox.Show("Du erhälst einen Punkt!", "Super!", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If

        'Prüfen ob der Ball an den linken Spielfeldrand stößt
        If gameBall.Left <= 0 Then
            'Spieler verliert
            Spiel_starten(False)
            Computerpunkte += 1
            StartToolStripMenuItem.Text = "Weiter..."
            MessageBox.Show("Der Computer erhält einen Punkt!", "Oh man...", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If

        'Spielstand anzeigen
        lblSpielstand.Text = Spielerpunkte & " : " & Computerpunkte

        Spielergebnis_prüfen()

    End Sub

    Private Sub Spielergebnis_prüfen()

        If SpielBis3ToolStripMenuItem.Checked Then
            'Spiel geht bis 3
            If Computerpunkte = 3 Then
                MessageBox.Show("Leider verloren! Versuchs doch gleich nochmal :)", "Oh man...", MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen
            ElseIf Spielerpunkte = 3 Then
                MessageBox.Show("Du hast gewonnen!!!", "Super!", MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen
            End If
        End If

        If SpielBis5ToolStripMenuItem.Checked Then
            'Spiel geht bis 5
            If Computerpunkte = 5 Then
                MessageBox.Show("Leider verloren! Versuchs doch gleich nochmal :)", "Oh man...", MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen
            ElseIf Spielerpunkte = 5 Then
                MessageBox.Show("Du hast gewonnen!!!", "Super!", MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen
            End If
        End If

        If SpielBis10ToolStripMenuItem.Checked Then
            'Spiel geht bis 10
            If Computerpunkte = 10 Then
                MessageBox.Show("Leider verloren! Versuchs doch gleich nochmal :)", "Oh man...", MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen
            ElseIf Spielerpunkte = 10 Then
                MessageBox.Show("Du hast gewonnen!!!", "Super!", MessageBoxButtons.OK, MessageBoxIcon.None)
                ResetToolStripMenuItem.PerformClick() 'Spiel zurücksetzen
            End If
        End If

    End Sub

    Private Sub velocityTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles velocityTimer.Tick
        'hier ist ein Tick 10 Sekunden lang (10000 ms)

        'alle 10 Sekunden wird die X- und Y-Geschwindigkeit um 5 erhöht
        If vxBall < 0 Then
            vxBall -= 5
        Else
            vxBall += 5
        End If

        If vyBall < 0 Then
            vyBall -= 5
        Else
            vyBall += 5
        End If

    End Sub

    Private Sub Spielzeit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpielzeitTimer.Tick
        'Hier ist ein Tick 1s lang (1000 ms)

        'Sekunden zählen hoch
        Sekunden += 1

        'Minutenumsprung
        If Sekunden = 60 Then
            Sekunden = 0
            Minuten = 1
        End If

        'Label Ausgabe richtig formatieren
        'davon ausgegangen, dass niemand mehr als 9 Minuten am Stück spielt
        If Sekunden < 10 Then
            lblSpielzeit.Text = "Spielzeit: " & "0" & Minuten & " : " & "0" & Sekunden
        Else
            lblSpielzeit.Text = "Spielzeit: " & "0" & Minuten & " : " & Sekunden
        End If
    End Sub

End Class
