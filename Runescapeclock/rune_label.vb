Class rune_label
    Inherits Windows.Forms.Label
    Public Sub New()
        'MyBase.UseCompatibleTextRendering = True
        'MyBase.Font = CustomFont.GetInstance(13, FontStyle.Bold)
        'MyBase.ForeColor = Color.LightYellow
    End Sub
    Protected Overrides Sub OnFontChanged(e As System.EventArgs)
        MyBase.OnFontChanged(e)
        MyBase.UseCompatibleTextRendering = True
        MyBase.Font = CustomFont.GetInstance(13, FontStyle.Bold)
        MyBase.ForeColor = Color.LightYellow
    End Sub
End Class
