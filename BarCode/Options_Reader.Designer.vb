<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options_Reader
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(344, 261)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Dismiss"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.HelpVisible = false
        Me.PropertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark
        Me.PropertyGrid1.Location = New System.Drawing.Point(12, 12)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
        Me.PropertyGrid1.Size = New System.Drawing.Size(236, 241)
        Me.PropertyGrid1.TabIndex = 13
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = true
        Me.CheckedListBox1.FormattingEnabled = true
        Me.CheckedListBox1.Location = New System.Drawing.Point(264, 24)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(236, 229)
        Me.CheckedListBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(261, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Possible Formats :"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.Checked = true
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(12, 265)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Auto Rotate"
        Me.CheckBox1.UseVisualStyleBackColor = true
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = true
        Me.CheckBox2.Checked = true
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(101, 265)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox2.TabIndex = 17
        Me.CheckBox2.Text = "Try Inverted"
        Me.CheckBox2.UseVisualStyleBackColor = true
        '
        'Options_Reader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 294)
        Me.ControlBox = false
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.Name = "Options_Reader"
        Me.Text = "Options Reader"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
