Public Class Timeconv

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim time As Integer
        time = Day.Text * 86400
        time += Hour.Text * 3600
        time += min.Text * 60
        time += Secnd.Text
        Label1.Text = time
    End Sub
End Class