<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Label1 = New Label()
        Label2 = New Label()
        NameTextBox = New TextBox()
        SalesTextBox = New TextBox()
        CalculateButton = New Button()
        ResultsListBox = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 0
        Label1.Text = "Salesperson Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(316, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 1
        Label2.Text = "Daily Sales"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(55, 86)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(209, 23)
        NameTextBox.TabIndex = 2
        ' 
        ' SalesTextBox
        ' 
        SalesTextBox.Location = New Point(316, 86)
        SalesTextBox.Name = "SalesTextBox"
        SalesTextBox.Size = New Size(209, 23)
        SalesTextBox.TabIndex = 3
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(234, 175)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(144, 23)
        CalculateButton.TabIndex = 4
        CalculateButton.Text = "Calculate Salary"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' ResultsListBox
        ' 
        ResultsListBox.FormattingEnabled = True
        ResultsListBox.ItemHeight = 15
        ResultsListBox.Location = New Point(55, 249)
        ResultsListBox.Name = "ResultsListBox"
        ResultsListBox.SelectionMode = SelectionMode.None
        ResultsListBox.Size = New Size(470, 94)
        ResultsListBox.TabIndex = 5
        ' 
        ' Sales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ResultsListBox)
        Controls.Add(CalculateButton)
        Controls.Add(SalesTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Sales"
        Text = "Sales"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ResultsListBox As ListBox
End Class
