<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anleitung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anleitung))
        Me.tvÜbersicht = New System.Windows.Forms.TreeView()
        Me.tbAnleitung = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tvÜbersicht
        '
        Me.tvÜbersicht.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvÜbersicht.Location = New System.Drawing.Point(6, 12)
        Me.tvÜbersicht.Name = "tvÜbersicht"
        Me.tvÜbersicht.Size = New System.Drawing.Size(144, 215)
        Me.tvÜbersicht.TabIndex = 0
        '
        'tbAnleitung
        '
        Me.tbAnleitung.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbAnleitung.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAnleitung.Location = New System.Drawing.Point(157, 13)
        Me.tbAnleitung.Multiline = True
        Me.tbAnleitung.Name = "tbAnleitung"
        Me.tbAnleitung.ReadOnly = True
        Me.tbAnleitung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAnleitung.Size = New System.Drawing.Size(371, 391)
        Me.tbAnleitung.TabIndex = 1
        '
        'Anleitung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(540, 416)
        Me.Controls.Add(Me.tbAnleitung)
        Me.Controls.Add(Me.tvÜbersicht)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Anleitung"
        Me.Text = "Anleitung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tvÜbersicht As System.Windows.Forms.TreeView
    Friend WithEvents tbAnleitung As System.Windows.Forms.TextBox
End Class
