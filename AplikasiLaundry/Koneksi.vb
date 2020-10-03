Imports System.Data.Odbc
Module Koneksi
    Public conn As OdbcConnection
    Public sql As String
    Public cmd As OdbcCommand
    Public r As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet

    Public Sub ODBC_KONEK()
        Dim Str
        Str = "Dsn=laundry"
        conn = New OdbcConnection(Str)
        If conn.State = ConnectionState.Closed Then

            conn.Open()
        End If
    End Sub
End Module
   
