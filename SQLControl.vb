Imports System.Data.Common
Imports System.Data.SqlClient
Public Class SQLControl
    Private SQLCon As New SqlConnection With {.ConnectionString = "Server=MANDEEP\SQLEXPRESS;Database=Melodifydb;User=sa;Password=manjirosano12"}
    Public SQLDA As DataAdapter
    Public SQLCmd As SqlCommand
    Public SQLDS As DataSet
    Public Params As New List(Of SqlParameter)
    Public RecordCount As Integer
    Public Exception As String
    Public Sub ExecQuery(Query As String)
        Try
            RecordCount = 0
            Exception = ""
            SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLCon)
            Params.ForEach(Sub(x) SQLCmd.Parameters.Add(x))
            Params.Clear()
            SQLDS = New DataSet
            SQLDA = New SqlDataAdapter(SQLCmd)
            RecordCount = SQLDA.Fill(SQLDS)
            SQLCon.Close()
        Catch ex As Exception
            Exception = ex.Message
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
        End If
    End Sub
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter With {.ParameterName = Name, .Value = Value}
        Params.Add(NewParam)
    End Sub
    Public Function hasConnection() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
End Class


