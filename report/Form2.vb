
Imports System.IO

Imports System.Drawing.Printing
Imports SixLabors.ImageSharp
Imports ZXing



Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim barcodewritte As New BarcodeWriter
        barcodewritte.Format = BarcodeFormat.CODE_128

        PictureBox1.Image = barcodewritte.Write("123456789000")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class