Imports ZXing

Public Class Creator
    Public _pic As Bitmap
    Public Class GlobalVariables
        Public Shared Options As Common.EncodingOptions
        Public Shared Renderer
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim bcwriter As New BarcodeWriter()
            bcwriter.Format = ComboBox1.SelectedItem
            bcwriter.Options = GlobalVariables.Options
            If Not IsNothing(GlobalVariables.Renderer) Then
                bcwriter.Renderer = GlobalVariables.Renderer
            End If
            _pic = New Bitmap(bcwriter.Write(TextBox1.Text))
            PictureBox1.Image = _pic 
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Creator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i = 0
        For Each format As Object In MultiFormatWriter.SupportedWriters
            If Not format = ZXing.BarcodeFormat.QR_CODE
                ComboBox1.Items.Add(format)
            End If
        Next
        ComboBox1.Items.Add(ZXing.BarcodeFormat.QR_CODE)
        ComboBox1.SelectedItem = ZXing.BarcodeFormat.QR_CODE
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim save As New SaveFileDialog
        save.OverwritePrompt = True
        save.CreatePrompt = False
        save.DefaultExt = "png"
        save.FileName = "QR"
        save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif"
        If save.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            _pic.Save(save.FileName)
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Options_Creator.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem
            Case BarcodeFormat.QR_CODE
                Dim options = New QrCode.QrCodeEncodingOptions()
                With options
                    .Height = PictureBox1.Height - 2
                    .Width = PictureBox1.Width - 2
                    .Margin = 0
                    .ErrorCorrection = QrCode.Internal.ErrorCorrectionLevel.L
                End With
                GlobalVariables.Options = options
                Exit Select
            Case BarcodeFormat.DATA_MATRIX
                Dim options = New Datamatrix.DatamatrixEncodingOptions()
                With options
                    .Height = PictureBox1.Height - 2
                    .Width = PictureBox1.Width - 2
                    .Margin = 0
                    .symbolShape = Datamatrix.Encoder.SymbolShapeHint.FORCE_SQUARE
                End With
                GlobalVariables.Options = options
                Exit Select
            Case BarcodeFormat.PDF_417
                Dim options = New PDF417.PDF417EncodingOptions()
                With options
                    .Height = PictureBox1.Height - 2
                    .Width = PictureBox1.Width - 2
                    .Margin = 0
                End With
                GlobalVariables.Options = options
                Exit Select
            Case BarcodeFormat.CODE_128
                Dim options = New OneD.Code128EncodingOptions()
                With options
                    .Height = PictureBox1.Height - 2
                    .Width = PictureBox1.Width - 2
                    .Margin = 0
                End With
                GlobalVariables.Options = options
                Exit Select
            Case BarcodeFormat.AZTEC
                Dim options = New Aztec.AztecEncodingOptions()
                With options
                    .Height = PictureBox1.Height - 2
                    .Width = PictureBox1.Width - 2
                    .Margin = 0
                End With
                GlobalVariables.Options = options
                Exit Select
            Case BarcodeFormat.UPC_E
                Dim options = New Common.EncodingOptions()
                With options
                    .Height = PictureBox1.Height - 2
                    .Width = PictureBox1.Width - 2
                    .Margin = 50
                End With
                GlobalVariables.Options = options
                Exit Select
            Case Else
                Dim options = New Common.EncodingOptions()
                With options
                    .Height = PictureBox1.Height - 2
                    .Width = PictureBox1.Width - 2
                    .Margin = 0
                End With
                GlobalVariables.Options = options
                Exit Select
        End Select
    End Sub
    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        PictureBox1.SizeMode = If(CheckBox1.Checked, PictureBoxSizeMode.StretchImage, PictureBoxSizeMode.CenterImage)
    End Sub
End Class