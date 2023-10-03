Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My first VB App"
        Me.BackColor = Color.DeepPink
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.Size = New Size(750, 750)
        Me.Opacity = 0.89        'Makes the box a bit transparent
        Me.CenterToParent()     'Centers the exec box to the centre of the screen
        Me.CenterToScreen()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnLebo_Click(sender As Object, e As EventArgs) Handles btnLebo.Click
        MsgBox("This is Lebo",, "Hello")
    End Sub
End Class
