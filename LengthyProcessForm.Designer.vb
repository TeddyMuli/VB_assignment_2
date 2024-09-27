<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LengthyProcessForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ProgressBar1 = New ProgressBar()
        ProgressLabel = New Label()
        Timer1 = New Timer(components)
        StartButton = New Button()
        StopButton = New Button()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(8, 67)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(100, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' ProgressLabel
        ' 
        ProgressLabel.AutoSize = True
        ProgressLabel.Location = New Point(12, 49)
        ProgressLabel.Name = "ProgressLabel"
        ProgressLabel.Size = New Size(23, 15)
        ProgressLabel.TabIndex = 1
        ProgressLabel.Text = "0%"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' StartButton
        ' 
        StartButton.Location = New Point(53, 241)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(75, 23)
        StartButton.TabIndex = 2
        StartButton.Text = "Start"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' StopButton
        ' 
        StopButton.Location = New Point(244, 241)
        StopButton.Name = "StopButton"
        StopButton.Size = New Size(75, 23)
        StopButton.TabIndex = 3
        StopButton.Text = "Stop"
        StopButton.UseVisualStyleBackColor = True
        ' 
        ' LengthyProcessForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StopButton)
        Controls.Add(StartButton)
        Controls.Add(ProgressLabel)
        Controls.Add(ProgressBar1)
        Name = "LengthyProcessForm"
        Text = "LengthyProcessForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
End Class
