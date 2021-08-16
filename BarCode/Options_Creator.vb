Imports ZXing

Public Class Options_Creator
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange({GetType(Rendering.BitmapRenderer).Name, GetType(Rendering.AlternateBitmapRenderer).Name})
        ComboBox1.SelectedItem = GetType(Rendering.BitmapRenderer).Name
        PropertyGrid1.SelectedObject = Creator.GlobalVariables.Options
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Creator.GlobalVariables.Options = PropertyGrid1.SelectedObject
        Creator.GlobalVariables.Renderer = PropertyGrid2.SelectedObject
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Creator.GlobalVariables.Renderer = New Rendering.BitmapRenderer()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Creator.GlobalVariables.Renderer = New Rendering.AlternateBitmapRenderer()
        End If
        PropertyGrid2.SelectedObject = Creator.GlobalVariables.Renderer
    End Sub
End Class