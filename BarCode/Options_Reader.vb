Imports ZXing

Public Class Options_Reader
    Private options As Common.DecodingOptions
    Private AutoRotate As Boolean
    Private TryInverted As Boolean
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reader.GlobalVariables.Options = PropertyGrid1.SelectedObject
        Reader.GlobalVariables.AutoRotate = AutoRotate
        Reader.GlobalVariables.TryInverted = TryInverted
        Me.Close()
    End Sub

    Private Sub Options_Reader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        options = Reader.GlobalVariables.Options
        PropertyGrid1.SelectedObject = options
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.GetItemCheckState(CheckedListBox1.SelectedIndex) = False
            options.PossibleFormats.Remove(CType([Enum].Parse(GetType(ZXing.BarcodeFormat), CheckedListBox1.SelectedItem.ToString), ZXing.BarcodeFormat))
        Else
            options.PossibleFormats.Add(CType([Enum].Parse(GetType(ZXing.BarcodeFormat), CheckedListBox1.SelectedItem.ToString), ZXing.BarcodeFormat))
        End If
    End Sub

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        If CheckBox1.Checked =True
            AutoRotate = True
        Else 
            AutoRotate = False
        End If
    End Sub

    Private Sub CheckBox2_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckStateChanged
        If CheckBox2.Checked =True
            TryInverted = True
        Else 
            TryInverted = False
        End If
    End Sub
End Class