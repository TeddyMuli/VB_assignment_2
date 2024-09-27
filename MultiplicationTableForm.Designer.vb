<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiplicationTableForm
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
        MultiplicationTableTextBox = New TextBox()
        GenerateTableButton = New Button()
        SuspendLayout()
        ' 
        ' MultiplicationTableTextBox
        ' 
        MultiplicationTableTextBox.AcceptsTab = True
        MultiplicationTableTextBox.Location = New Point(211, 65)
        MultiplicationTableTextBox.Multiline = True
        MultiplicationTableTextBox.Name = "MultiplicationTableTextBox"
        MultiplicationTableTextBox.Size = New Size(395, 173)
        MultiplicationTableTextBox.TabIndex = 0
        ' 
        ' GenerateTableButton
        ' 
        GenerateTableButton.Location = New Point(330, 244)
        GenerateTableButton.Name = "GenerateTableButton"
        GenerateTableButton.Size = New Size(75, 23)
        GenerateTableButton.TabIndex = 1
        GenerateTableButton.Text = "Button1"
        GenerateTableButton.UseVisualStyleBackColor = True
        ' 
        ' MultiplicationTableForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GenerateTableButton)
        Controls.Add(MultiplicationTableTextBox)
        Name = "MultiplicationTableForm"
        Text = "MultiplicationTableForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MultiplicationTableTextBox As TextBox
    Friend WithEvents GenerateTableButton As Button
End Class
