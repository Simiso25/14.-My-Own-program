Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim surname As String
        Dim age As Integer

        name = (TextBox1.Text)
        surname = (TextBox2.Text)
        age = Val(TextBox3.Text)


        If age < 18 Then
            MessageBox.Show("You do not qualify for voting")

        Else
            MessageBox.Show("You qualify for voting")
        End If

    End Sub
End Class
