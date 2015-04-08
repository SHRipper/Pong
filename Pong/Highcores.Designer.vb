<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Highcores
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
        Me.lbHighscore = New System.Windows.Forms.ListBox()
        Me.btnLängsteZeit = New System.Windows.Forms.Button()
        Me.btnSpieleGewonnen = New System.Windows.Forms.Button()
        Me.btnGesamtspielzeit = New System.Windows.Forms.Button()
        Me.btnHighscoresZurücksetzen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbHighscore
        '
        Me.lbHighscore.BackColor = System.Drawing.Color.Silver
        Me.lbHighscore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbHighscore.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHighscore.FormattingEnabled = True
        Me.lbHighscore.ItemHeight = 27
        Me.lbHighscore.Location = New System.Drawing.Point(205, 91)
        Me.lbHighscore.Name = "lbHighscore"
        Me.lbHighscore.Size = New System.Drawing.Size(467, 324)
        Me.lbHighscore.TabIndex = 0
        '
        'btnLängsteZeit
        '
        Me.btnLängsteZeit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLängsteZeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLängsteZeit.Location = New System.Drawing.Point(12, 160)
        Me.btnLängsteZeit.Name = "btnLängsteZeit"
        Me.btnLängsteZeit.Size = New System.Drawing.Size(168, 63)
        Me.btnLängsteZeit.TabIndex = 1
        Me.btnLängsteZeit.Text = "Längste Zeit im Spiel"
        Me.btnLängsteZeit.UseVisualStyleBackColor = True
        '
        'btnSpieleGewonnen
        '
        Me.btnSpieleGewonnen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpieleGewonnen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpieleGewonnen.Location = New System.Drawing.Point(12, 91)
        Me.btnSpieleGewonnen.Name = "btnSpieleGewonnen"
        Me.btnSpieleGewonnen.Size = New System.Drawing.Size(168, 63)
        Me.btnSpieleGewonnen.TabIndex = 2
        Me.btnSpieleGewonnen.Text = "Spiele gewonnen"
        Me.btnSpieleGewonnen.UseVisualStyleBackColor = True
        '
        'btnGesamtspielzeit
        '
        Me.btnGesamtspielzeit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGesamtspielzeit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGesamtspielzeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGesamtspielzeit.Location = New System.Drawing.Point(12, 229)
        Me.btnGesamtspielzeit.Name = "btnGesamtspielzeit"
        Me.btnGesamtspielzeit.Size = New System.Drawing.Size(168, 63)
        Me.btnGesamtspielzeit.TabIndex = 3
        Me.btnGesamtspielzeit.Text = "Gesamtspielzeit"
        Me.btnGesamtspielzeit.UseVisualStyleBackColor = True
        '
        'btnHighscoresZurücksetzen
        '
        Me.btnHighscoresZurücksetzen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHighscoresZurücksetzen.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnHighscoresZurücksetzen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHighscoresZurücksetzen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighscoresZurücksetzen.Location = New System.Drawing.Point(12, 346)
        Me.btnHighscoresZurücksetzen.Name = "btnHighscoresZurücksetzen"
        Me.btnHighscoresZurücksetzen.Size = New System.Drawing.Size(168, 63)
        Me.btnHighscoresZurücksetzen.TabIndex = 4
        Me.btnHighscoresZurücksetzen.Text = "Highscores zurücksetzen"
        Me.btnHighscoresZurücksetzen.UseVisualStyleBackColor = False
        '
        'Highcores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pong.My.Resources.Resources.Highscores_Hintergrund
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 516)
        Me.Controls.Add(Me.btnHighscoresZurücksetzen)
        Me.Controls.Add(Me.btnGesamtspielzeit)
        Me.Controls.Add(Me.btnSpieleGewonnen)
        Me.Controls.Add(Me.btnLängsteZeit)
        Me.Controls.Add(Me.lbHighscore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Highcores"
        Me.Text = "Highcores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbHighscore As System.Windows.Forms.ListBox
    Friend WithEvents btnLängsteZeit As System.Windows.Forms.Button
    Friend WithEvents btnSpieleGewonnen As System.Windows.Forms.Button
    Friend WithEvents btnGesamtspielzeit As System.Windows.Forms.Button
    Friend WithEvents btnHighscoresZurücksetzen As System.Windows.Forms.Button
End Class
