
Imports MySql.Data.MySqlClient

Module dbconnection
    Public conn As New MySqlConnection
    Public result As Boolean
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public i As Integer

    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            conn.ConnectionString = "server=localhost;username=root;password=;port=3306;database=db_pos"
            conn.Open()
            result = True
            'MsgBox("Connected!", vbInformation)
        Catch ex As Exception
            result = False
            MsgBox("Server Not Connected: " & ex.Message, vbExclamation)
        End Try
        Return result
    End Function


    Public Function GetbillNo() As String
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            ' Use MAX function to get the latest billno
            cmd = New MySqlCommand("SELECT MAX(billno) AS latestBillNo FROM tbi_pos", conn)

            Dim result As Object = cmd.ExecuteScalar()
            'If dr.HasRows AndAlso dr.Read() Then
            ' If there are records, get the latest billno
            '   GetbillNo = (Convert.ToInt64(dr("latestBillNo")) + 1).ToString()
            'Else
            ' If no records, set the billno to the current year + 1
            '   GetbillNo = Date.Now.ToString("yyyy") & "1"
            'End If
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                GetbillNo = (Convert.ToInt64(result) + 1).ToString()
            Else
                GetbillNo = Date.Now.ToString("yyyy") & "1" ' Set a default value if the result is null
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            ' Handle exceptions appropriately
            GetbillNo = String.Empty
        End Try
    End Function

    Public Class UserSession
        Public Shared CurrentUser As String
        ' Add any other user-related properties or methods you may need
    End Class


End Module
