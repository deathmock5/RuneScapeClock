Class rune_button
    Inherits Windows.Forms.Button
    Public Sub New()
        'MyBase.UseCompatibleTextRendering = True
        'FlatAppearance.MouseDownBackColor = Color.Transparent
        'FlatAppearance.BorderSize = 0
        'FlatStyle = Windows.Forms.FlatStyle.Flat
        'FlatAppearance.MouseOverBackColor = Color.Transparent
        'MyBase.BackColor = Color.Transparent
        'MyBase.BackgroundImage = My.Resources.button_out
        'MyBase.Font = CustomFont.GetInstance(14, FontStyle.Bold)
        'MyBase.ForeColor = Color.LightYellow
        'MyBase.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    'events
    Protected Overrides Sub OnFontChanged(e As System.EventArgs)
        MyBase.OnFontChanged(e)
        MyBase.UseCompatibleTextRendering = True
        FlatAppearance.MouseDownBackColor = Color.Transparent
        FlatAppearance.BorderSize = 0
        FlatStyle = Windows.Forms.FlatStyle.Flat
        FlatAppearance.MouseOverBackColor = Color.Transparent
        MyBase.BackColor = Color.Transparent
        MyBase.BackgroundImage = My.Resources.button_out
        MyBase.Font = CustomFont.GetInstance(14, FontStyle.Bold)
        MyBase.ForeColor = Color.LightYellow
        MyBase.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Protected Overrides Sub OnMouseEnter(e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        MyBase.ForeColor = Color.White
        MyBase.BackgroundImage = My.Resources.button_over
    End Sub
    Protected Overrides Sub OnMouseLeave(e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        MyBase.ForeColor = Color.LightYellow
        MyBase.BackgroundImage = My.Resources.button_out
    End Sub
End Class
