<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SpielToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreiesSpielToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielBis3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielBis5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielBis10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighscoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnleitungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.computerBumper = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.gameBall = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.playerBumper = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.playerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.computerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ballTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SpielzeitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblSpielzeit = New System.Windows.Forms.Label()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.lblSpielstand = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpielToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.HighscoresToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1004, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SpielToolStripMenuItem
        '
        Me.SpielToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ToolStripMenuItem1, Me.SchließenToolStripMenuItem})
        Me.SpielToolStripMenuItem.Name = "SpielToolStripMenuItem"
        Me.SpielToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.SpielToolStripMenuItem.Text = "Spiel"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.PauseToolStripMenuItem.Text = "Pause (Esc)"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(131, 6)
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SchließenToolStripMenuItem.Text = "Schließen..."
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpielartToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'SpielartToolStripMenuItem
        '
        Me.SpielartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FreiesSpielToolStripMenuItem, Me.SpielBis3ToolStripMenuItem, Me.SpielBis5ToolStripMenuItem, Me.SpielBis10ToolStripMenuItem})
        Me.SpielartToolStripMenuItem.Name = "SpielartToolStripMenuItem"
        Me.SpielartToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SpielartToolStripMenuItem.Text = "Spielart"
        '
        'FreiesSpielToolStripMenuItem
        '
        Me.FreiesSpielToolStripMenuItem.Checked = True
        Me.FreiesSpielToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FreiesSpielToolStripMenuItem.Name = "FreiesSpielToolStripMenuItem"
        Me.FreiesSpielToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.FreiesSpielToolStripMenuItem.Text = "freies Spiel"
        '
        'SpielBis3ToolStripMenuItem
        '
        Me.SpielBis3ToolStripMenuItem.Name = "SpielBis3ToolStripMenuItem"
        Me.SpielBis3ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SpielBis3ToolStripMenuItem.Text = "Spiel bis 3"
        '
        'SpielBis5ToolStripMenuItem
        '
        Me.SpielBis5ToolStripMenuItem.Name = "SpielBis5ToolStripMenuItem"
        Me.SpielBis5ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SpielBis5ToolStripMenuItem.Text = "Spiel bis 5"
        '
        'SpielBis10ToolStripMenuItem
        '
        Me.SpielBis10ToolStripMenuItem.Name = "SpielBis10ToolStripMenuItem"
        Me.SpielBis10ToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SpielBis10ToolStripMenuItem.Text = "Spiel bis 10"
        '
        'HighscoresToolStripMenuItem
        '
        Me.HighscoresToolStripMenuItem.Name = "HighscoresToolStripMenuItem"
        Me.HighscoresToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.HighscoresToolStripMenuItem.Text = "Highscores"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnleitungToolStripMenuItem, Me.CreditsToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'AnleitungToolStripMenuItem
        '
        Me.AnleitungToolStripMenuItem.Name = "AnleitungToolStripMenuItem"
        Me.AnleitungToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AnleitungToolStripMenuItem.Text = "Anleitung"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.computerBumper, Me.gameBall, Me.playerBumper})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1004, 671)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'computerBumper
        '
        Me.computerBumper.CornerRadius = 5
        Me.computerBumper.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.computerBumper.Location = New System.Drawing.Point(969, 273)
        Me.computerBumper.Name = "computerBumper"
        Me.computerBumper.Size = New System.Drawing.Size(15, 125)
        '
        'gameBall
        '
        Me.gameBall.FillColor = System.Drawing.Color.OrangeRed
        Me.gameBall.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.gameBall.Location = New System.Drawing.Point(466, 296)
        Me.gameBall.Name = "gameBall"
        Me.gameBall.Size = New System.Drawing.Size(25, 25)
        '
        'playerBumper
        '
        Me.playerBumper.CornerRadius = 5
        Me.playerBumper.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.playerBumper.Location = New System.Drawing.Point(21, 545)
        Me.playerBumper.Name = "playerBumper"
        Me.playerBumper.Size = New System.Drawing.Size(15, 125)
        '
        'playerTimer
        '
        Me.playerTimer.Interval = 1
        '
        'computerTimer
        '
        Me.computerTimer.Interval = 1
        '
        'ballTimer
        '
        Me.ballTimer.Interval = 1
        '
        'SpielzeitTimer
        '
        Me.SpielzeitTimer.Interval = 1000
        '
        'lblSpielzeit
        '
        Me.lblSpielzeit.AutoSize = True
        Me.lblSpielzeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpielzeit.Location = New System.Drawing.Point(403, 639)
        Me.lblSpielzeit.Name = "lblSpielzeit"
        Me.lblSpielzeit.Size = New System.Drawing.Size(0, 25)
        Me.lblSpielzeit.TabIndex = 2
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStop.Location = New System.Drawing.Point(326, 131)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(316, 46)
        Me.lblStop.TabIndex = 3
        Me.lblStop.Text = "Spiel angehalten"
        Me.lblStop.Visible = False
        '
        'lblSpielstand
        '
        Me.lblSpielstand.AutoSize = True
        Me.lblSpielstand.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpielstand.Location = New System.Drawing.Point(458, 24)
        Me.lblSpielstand.Name = "lblSpielstand"
        Me.lblSpielstand.Size = New System.Drawing.Size(0, 46)
        Me.lblSpielstand.TabIndex = 4
        Me.lblSpielstand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1004, 671)
        Me.Controls.Add(Me.lblSpielstand)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.lblSpielzeit)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pong"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents SpielToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SchließenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents computerBumper As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents gameBall As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents playerBumper As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents playerTimer As System.Windows.Forms.Timer
    Friend WithEvents computerTimer As System.Windows.Forms.Timer
    Friend WithEvents ballTimer As System.Windows.Forms.Timer
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpielzeitTimer As System.Windows.Forms.Timer
    Friend WithEvents lblSpielzeit As System.Windows.Forms.Label
    Friend WithEvents lblStop As System.Windows.Forms.Label
    Friend WithEvents AnleitungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSpielstand As System.Windows.Forms.Label
    Friend WithEvents EinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpielartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreiesSpielToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpielBis3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpielBis5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpielBis10ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighscoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
