Public Class POPUP
    Dim messages() As String = {"There is no current messages"}
    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.Opaque, False)
        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        UpdateStyles()
        Refresh()
        sidebar.Show()
        InitializeComponent()
    End Sub
    Public Sub addmessage(ByVal message As String)
        ReDim Preserve messages(messages.Length)
        messages(messages.Length - 1) = message
        Me.Show()
    End Sub
    Private Sub removemes(ByVal index As Int16)
        Dim messages_front(index - 1) As String
        Dim messages_back() As String
        If index <> 1 Then
            For i = 0 To index - 1
                messages_front(i) = messages(i)
            Next
        End If

    End Sub
    Private Sub update_ui()
        sidebar.completed_num.Text = messages.Length - 1
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Timer1.Stop()
        Me.Close()
    End Sub
    Private Sub Rune_button1_Click(sender As System.Object, e As System.EventArgs) Handles Rune_button1.Click
        Me.Hide()
    End Sub
End Class