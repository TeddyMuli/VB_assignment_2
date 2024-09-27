Public Class DemoForm
    Public Sub ResizeForm()
        Dim screenHeight As Integer
        Dim halfScreenHeight As Integer
        screenHeight = Screen.PrimaryScreen.Bounds.Height
        halfScreenHeight = screenHeight \ 2

        Dim screenWidth As Integer
        Dim threeQuartersScreenWidth As Integer
        screenWidth = Screen.PrimaryScreen.Bounds.Width
        threeQuartersScreenWidth = (screenWidth * 3) \ 4

        Me.Height = halfScreenHeight
        Me.Width = threeQuartersScreenWidth
    End Sub

End Class
