Imports ZXing

Public Class Reader
    Public Class GlobalVariables
        Public Shared Options As Common.DecodingOptions
        Public Shared TryInverted As Boolean = True
        Public Shared AutoRotate As Boolean = True
    End Class
    Public _pic As Bitmap
    Public _gfx As Graphics
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Breader As New BarcodeReader()
        Breader.AutoRotate = GlobalVariables.AutoRotate
        Breader.TryInverted = GlobalVariables.TryInverted
        Breader.Options = GlobalVariables.Options
        PictureBox2.Image = _pic
        Dim result As Result = Breader.Decode(_pic)
        Try
            If Not IsNothing(result) Then
                TextBox1.Text = result.ToString().Trim()
                TextBox2.Text = result.BarcodeFormat.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _gfx.CopyFromScreen(New Point(Me.Location.X + Me.PictureBox1.Location.X + 8, Me.Location.Y + Me.PictureBox1.Location.Y + 31), New Point(0, 0), _pic.Size)
    End Sub

    Private Sub Reader_Resize(sender As Object, e As EventArgs) Handles Me.Resize
         _pic = New Bitmap(PictureBox1.Width, PictureBox1.Height)
         _gfx = Graphics.FromImage(_pic)
     End Sub

    Private Sub Reader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalVariables.Options = New Common.DecodingOptions()
        GlobalVariables.Options.TryHarder = True

        For Each btval In [Enum].GetValues(GetType(ZXing.BarcodeFormat))
            Dim valBarcode = CType(btval, ZXing.BarcodeFormat)
            If valBarcode = ZXing.BarcodeFormat.PLESSEY Then
                Continue For
            End If
            Dim selectedByDefault As Boolean = valBarcode <> ZXing.BarcodeFormat.MSI AndAlso valBarcode <> ZXing.BarcodeFormat.IMB
            If GlobalVariables.Options.PossibleFormats IsNot Nothing Then
                selectedByDefault = GlobalVariables.Options.PossibleFormats.Contains(valBarcode)
            End If
            Options_Reader.CheckedListBox1.Items.Add(btval.ToString(),selectedByDefault)
        Next 
        GlobalVariables.Options.PossibleFormats = new List(Of ZXing.BarcodeFormat)
        For Each item In Options_Reader.CheckedListBox1.CheckedItems
            GlobalVariables.Options.PossibleFormats.Add(CType([Enum].Parse(GetType(ZXing.BarcodeFormat), item.ToString), ZXing.BarcodeFormat))
        Next
        Creator.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Options_Reader.Show()
    End Sub
End Class