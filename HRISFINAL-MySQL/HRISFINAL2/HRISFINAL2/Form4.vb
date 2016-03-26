Imports System.Data.Odbc
Public Class Form4

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer1.Load
        Dim myConnection As New OdbcConnection("DSN=gladiesobmerga")
        myConnection.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim RpDs1 As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim SQL As String = "select * from time_sheet"
        Dim da As New OdbcDataAdapter(SQL, myConnection)

        da.Fill(ds, "time_sheet")
        dt = ds.Tables(0)
        ReportViewer1.Reset()
        ReportViewer1.LocalReport.DataSources.Clear()
        RpDs1.Name = "DataSet1"
        RpDs1.Value = dt
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        ReportViewer1.RefreshReport()
        myConnection.Close()
    End Sub
End Class