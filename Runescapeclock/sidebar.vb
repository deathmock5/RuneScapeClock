Public Class sidebar
    Dim tingy As draginfo
    Private Sub init() Handles Me.Load
        Me.Width = 40
        Me.Location = New System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width,
                                               (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
    End Sub
    Private Sub Panel1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        tingy = New draginfo(Form.MousePosition, Me.Location)
    End Sub

    Private Sub Panel1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If tingy IsNot Nothing Then
            Dim info As draginfo = CType(tingy, draginfo)
            Dim newLoc As Point = info.NewLocation(Form.MousePosition)
            newLoc.X = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            Dim poploc As Point = New Point(newLoc.X, newLoc.Y)
            Form1.messager.Location = New Point(newLoc.X - Form1.messager.Width, newLoc.Y)
            Me.Location = newLoc
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        tingy = Nothing
    End Sub

End Class