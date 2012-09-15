<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POPUP
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.button_right = New System.Windows.Forms.Button()
        Me.button_left = New System.Windows.Forms.Button()
        Me.left_amount = New System.Windows.Forms.TextBox()
        Me.Rune_button1 = New Runescapeclock.rune_button()
        Me.messagetext = New Runescapeclock.rune_label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'button_right
        '
        Me.button_right.BackColor = System.Drawing.Color.Transparent
        Me.button_right.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.button_out_right
        Me.button_right.FlatAppearance.BorderSize = 0
        Me.button_right.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.button_right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_right.Location = New System.Drawing.Point(318, 69)
        Me.button_right.Margin = New System.Windows.Forms.Padding(2)
        Me.button_right.Name = "button_right"
        Me.button_right.Size = New System.Drawing.Size(40, 40)
        Me.button_right.TabIndex = 4
        Me.button_right.UseVisualStyleBackColor = False
        '
        'button_left
        '
        Me.button_left.BackColor = System.Drawing.Color.Transparent
        Me.button_left.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.button_out_left
        Me.button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_left.FlatAppearance.BorderSize = 0
        Me.button_left.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.button_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_left.Location = New System.Drawing.Point(26, 69)
        Me.button_left.Margin = New System.Windows.Forms.Padding(2)
        Me.button_left.Name = "button_left"
        Me.button_left.Size = New System.Drawing.Size(40, 40)
        Me.button_left.TabIndex = 5
        Me.button_left.UseVisualStyleBackColor = False
        '
        'left_amount
        '
        Me.left_amount.Location = New System.Drawing.Point(26, 163)
        Me.left_amount.Margin = New System.Windows.Forms.Padding(2)
        Me.left_amount.MaxLength = 3
        Me.left_amount.Name = "left_amount"
        Me.left_amount.ReadOnly = True
        Me.left_amount.Size = New System.Drawing.Size(40, 20)
        Me.left_amount.TabIndex = 6
        Me.left_amount.Text = "0"
        Me.left_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Rune_button1
        '
        Me.Rune_button1.BackColor = System.Drawing.Color.Transparent
        Me.Rune_button1.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.button_out
        Me.Rune_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Rune_button1.FlatAppearance.BorderSize = 0
        Me.Rune_button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Rune_button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Rune_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Rune_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rune_button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Rune_button1.Location = New System.Drawing.Point(140, 120)
        Me.Rune_button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Rune_button1.Name = "Rune_button1"
        Me.Rune_button1.Size = New System.Drawing.Size(98, 23)
        Me.Rune_button1.TabIndex = 7
        Me.Rune_button1.Text = "Done"
        Me.Rune_button1.UseCompatibleTextRendering = True
        Me.Rune_button1.UseVisualStyleBackColor = False
        '
        'messagetext
        '
        Me.messagetext.AutoSize = True
        Me.messagetext.BackColor = System.Drawing.Color.Transparent
        Me.messagetext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.messagetext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.messagetext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.messagetext.Location = New System.Drawing.Point(10, 10)
        Me.messagetext.Name = "messagetext"
        Me.messagetext.Size = New System.Drawing.Size(68, 17)
        Me.messagetext.TabIndex = 8
        Me.messagetext.Text = "Rune_label1"
        Me.messagetext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.messagetext.UseCompatibleTextRendering = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.messagetext)
        Me.Panel1.Location = New System.Drawing.Point(71, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(242, 91)
        Me.Panel1.TabIndex = 9
        '
        'POPUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.BottomBgGrad
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(382, 208)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Rune_button1)
        Me.Controls.Add(Me.left_amount)
        Me.Controls.Add(Me.button_left)
        Me.Controls.Add(Me.button_right)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POPUP"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "POPUP"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents button_right As System.Windows.Forms.Button
    Friend WithEvents button_left As System.Windows.Forms.Button
    Friend WithEvents left_amount As System.Windows.Forms.TextBox
    Friend WithEvents Rune_button1 As Runescapeclock.rune_button
    Friend WithEvents messagetext As Runescapeclock.rune_label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
