<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sidebar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sidebar))
        Me.completed_num = New System.Windows.Forms.TextBox()
        Me.close = New Runescapeclock.rune_button()
        Me.logoff = New Runescapeclock.rune_button()
        Me.expand = New Runescapeclock.rune_button()
        Me.SuspendLayout()
        '
        'completed_num
        '
        Me.completed_num.Location = New System.Drawing.Point(4, 182)
        Me.completed_num.Margin = New System.Windows.Forms.Padding(2)
        Me.completed_num.Name = "completed_num"
        Me.completed_num.Size = New System.Drawing.Size(25, 20)
        Me.completed_num.TabIndex = 3
        '
        'close
        '
        Me.close.BackColor = System.Drawing.Color.Transparent
        Me.close.BackgroundImage = CType(resources.GetObject("close.BackgroundImage"), System.Drawing.Image)
        Me.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.close.FlatAppearance.BorderSize = 0
        Me.close.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close.Location = New System.Drawing.Point(4, 5)
        Me.close.Name = "close"
        Me.close.Padding = New System.Windows.Forms.Padding(2)
        Me.close.Size = New System.Drawing.Size(25, 25)
        Me.close.TabIndex = 4
        Me.close.UseVisualStyleBackColor = False
        '
        'logoff
        '
        Me.logoff.BackColor = System.Drawing.Color.Transparent
        Me.logoff.BackgroundImage = CType(resources.GetObject("logoff.BackgroundImage"), System.Drawing.Image)
        Me.logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoff.FlatAppearance.BorderSize = 0
        Me.logoff.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.logoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.logoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoff.Location = New System.Drawing.Point(4, 36)
        Me.logoff.Name = "logoff"
        Me.logoff.Padding = New System.Windows.Forms.Padding(2)
        Me.logoff.Size = New System.Drawing.Size(25, 59)
        Me.logoff.TabIndex = 5
        Me.logoff.UseVisualStyleBackColor = False
        '
        'expand
        '
        Me.expand.BackColor = System.Drawing.Color.Transparent
        Me.expand.BackgroundImage = CType(resources.GetObject("expand.BackgroundImage"), System.Drawing.Image)
        Me.expand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.expand.FlatAppearance.BorderSize = 0
        Me.expand.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.expand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.expand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.expand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.expand.Location = New System.Drawing.Point(4, 101)
        Me.expand.Name = "expand"
        Me.expand.Padding = New System.Windows.Forms.Padding(2)
        Me.expand.Size = New System.Drawing.Size(25, 76)
        Me.expand.TabIndex = 6
        Me.expand.UseVisualStyleBackColor = False
        '
        'sidebar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Runescapeclock.My.Resources.Resources.box_right
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(40, 208)
        Me.Controls.Add(Me.expand)
        Me.Controls.Add(Me.logoff)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.completed_num)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sidebar"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sidebar"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents completed_num As System.Windows.Forms.TextBox
    Friend WithEvents close As Runescapeclock.rune_button
    Friend WithEvents logoff As Runescapeclock.rune_button
    Friend WithEvents expand As Runescapeclock.rune_button
End Class
