<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavingsAccountForm
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
        ResultsListBox = New ListBox()
        CalculateButton = New Button()
        SuspendLayout()
        ' 
        ' ResultsListBox
        ' 
        ResultsListBox.FormattingEnabled = True
        ResultsListBox.ItemHeight = 15
        ResultsListBox.Location = New Point(277, 62)
        ResultsListBox.Name = "ResultsListBox"
        ResultsListBox.Size = New Size(337, 244)
        ResultsListBox.TabIndex = 0
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(403, 317)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(75, 23)
        CalculateButton.TabIndex = 1
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' SavingsAccountForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CalculateButton)
        Controls.Add(ResultsListBox)
        Name = "SavingsAccountForm"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ResultsListBox As ListBox
    Friend WithEvents CalculateButton As Button
End Class
