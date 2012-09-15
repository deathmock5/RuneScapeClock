<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timeconv
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Day = New System.Windows.Forms.TextBox()
        Me.Hour = New System.Windows.Forms.TextBox()
        Me.min = New System.Windows.Forms.TextBox()
        Me.Secnd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Day
        '
        Me.Day.Location = New System.Drawing.Point(12, 76)
        Me.Day.MaxLength = 2
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(45, 20)
        Me.Day.TabIndex = 1
        Me.Day.Text = "0"
        '
        'Hour
        '
        Me.Hour.Location = New System.Drawing.Point(63, 76)
        Me.Hour.MaxLength = 2
        Me.Hour.Name = "Hour"
        Me.Hour.Size = New System.Drawing.Size(45, 20)
        Me.Hour.TabIndex = 2
        Me.Hour.Text = "0"
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(114, 76)
        Me.min.MaxLength = 2
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(45, 20)
        Me.min.TabIndex = 3
        Me.min.Text = "0"
        '
        'Secnd
        '
        Me.Secnd.Location = New System.Drawing.Point(165, 76)
        Me.Secnd.MaxLength = 2
        Me.Secnd.Name = "Secnd"
        Me.Secnd.Size = New System.Drawing.Size(45, 20)
        Me.Secnd.TabIndex = 4
        Me.Secnd.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timeconv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 137)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Secnd)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.Hour)
        Me.Controls.Add(Me.Day)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Timeconv"
        Me.Text = "Timeconv"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Day As System.Windows.Forms.TextBox
    Friend WithEvents Hour As System.Windows.Forms.TextBox
    Friend WithEvents min As System.Windows.Forms.TextBox
    Friend WithEvents Secnd As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
