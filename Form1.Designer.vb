<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        btnStart = New Button()
        btnLap = New Button()
        btnStop = New Button()
        btnReset = New Button()
        lblTimer = New Label()
        Laps = New ListBox()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.ButtonFace
        btnStart.Font = New Font("Gabriola", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStart.ForeColor = SystemColors.ActiveCaptionText
        btnStart.Location = New Point(50, 226)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(119, 36)
        btnStart.TabIndex = 1
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnLap
        ' 
        btnLap.Font = New Font("Gabriola", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLap.Location = New Point(226, 226)
        btnLap.Name = "btnLap"
        btnLap.Size = New Size(119, 36)
        btnLap.TabIndex = 2
        btnLap.Text = "Lap"
        btnLap.UseVisualStyleBackColor = True
        ' 
        ' btnStop
        ' 
        btnStop.Font = New Font("Gabriola", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStop.Location = New Point(414, 226)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(119, 36)
        btnStop.TabIndex = 3
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Gabriola", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(611, 226)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(119, 36)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = SystemColors.ActiveCaptionText
        lblTimer.Font = New Font("Sylfaen", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimer.ForeColor = SystemColors.ButtonHighlight
        lblTimer.Location = New Point(190, 33)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(431, 151)
        lblTimer.TabIndex = 5
        lblTimer.Text = "0:0:0:0" & vbCrLf & vbCrLf
        lblTimer.UseCompatibleTextRendering = True
        ' 
        ' Laps
        ' 
        Laps.BackColor = SystemColors.Info
        Laps.FormattingEnabled = True
        Laps.ItemHeight = 15
        Laps.Location = New Point(190, 309)
        Laps.Name = "Laps"
        Laps.Size = New Size(374, 94)
        Laps.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(795, 450)
        Controls.Add(Laps)
        Controls.Add(lblTimer)
        Controls.Add(btnReset)
        Controls.Add(btnStop)
        Controls.Add(btnLap)
        Controls.Add(btnStart)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents btnLap As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents Laps As ListBox

End Class
