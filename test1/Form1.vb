Public Class Form1

    Dim n As Integer = 0

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.M Then
            PictureBox1.Height = PictureBox1.Height + 34



        End If
    End Sub


End Class
