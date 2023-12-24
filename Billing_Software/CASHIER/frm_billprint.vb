Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frm_billprint
    Private Sub frm_billprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Me.ReportViewer1.RefreshReport()
        load_billprint()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub load_billprint()
        Try
            Dim rptds As ReportDataSource
            Me.ReportViewer1.RefreshReport()

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            'ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\Report\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            da.SelectCommand = New MySqlCommand("SELECT * FROM  `tbi_pos` where billno='" & frm_mainCashier.txt_billno.Text & "'", conn)
            da.Fill(ds.Tables("DataTable1"))


            rptds = New ReportDataSource("DataSet1", ds.Tables("DataTable1"))
            ReportViewer1.LocalReport.DataSources.Add(rptds)

            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


End Class