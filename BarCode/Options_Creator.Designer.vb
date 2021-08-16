<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options_Creator
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PropertyGrid2 = New System.Windows.Forms.PropertyGrid()
        Me.SuspendLayout
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.AllowDrop = true
        Me.PropertyGrid1.HelpVisible = false
        Me.PropertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark
        Me.PropertyGrid1.Location = New System.Drawing.Point(292, 12)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
        Me.PropertyGrid1.Size = New System.Drawing.Size(260, 223)
        Me.PropertyGrid1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(396, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Dismiss"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Apply"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'PropertyGrid2
        '
        Me.PropertyGrid2.AllowDrop = true
        Me.PropertyGrid2.HelpVisible = false
        Me.PropertyGrid2.LineColor = System.Drawing.SystemColors.ControlDark
        Me.PropertyGrid2.Location = New System.Drawing.Point(12, 39)
        Me.PropertyGrid2.Name = "PropertyGrid2"
        Me.PropertyGrid2.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
        Me.PropertyGrid2.Size = New System.Drawing.Size(260, 223)
        Me.PropertyGrid2.TabIndex = 4
        '
        'Options_Creator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 276)
        Me.ControlBox = false
        Me.Controls.Add(Me.PropertyGrid2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.Name = "Options_Creator"
        Me.Text = "Options Creator"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PropertyGrid2 As PropertyGrid
End Class
