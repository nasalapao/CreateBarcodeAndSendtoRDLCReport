Imports System.Drawing.Imaging
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports ZXing

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim parami As New ReportParameter()
        parami.Name = "Name"
        parami.Values.Add("มาลี")

        Dim parami2 As New ReportParameter()
        parami2.Name = "Las"
        parami2.Values.Add("มารวย")


        Dim barcodewritte As New BarcodeWriter
        barcodewritte.Format = BarcodeFormat.CODE_128

        Dim img = barcodewritte.Write("123456")

        Dim parami3 As New ReportParameter()
        parami3.Name = "Picpath"
        parami3.Values.Add(ConvertBitmapToBase64String(img))


        With ReportViewer1
            .LocalReport.SetParameters(New ReportParameter() {parami, parami2, parami3})
        End With


        'Refresh the report
        ReportViewer1.RefreshReport()

    End Sub

    Private Function ConvertBitmapToBase64String(image As Bitmap) As String
        Dim encodeType As ImageFormat = ImageFormat.Png
        Using ms As New MemoryStream()
            image.Save(ms, encodeType)
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

End Class
