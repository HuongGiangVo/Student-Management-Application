Imports MySql.Data.MySqlClient
Imports System.IO
Public Class LoginForm
    Dim dbCon As MySqlConnection
    Dim strConn As String
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub connectbtn_Click(sender As Object, e As EventArgs) Handles connectbtn.Click
        Try
            strConn = "Server=" + servertxt.Text + ";Uid=" + usertxt.Text + ";Pwd=" + pwstxt.Text + ";Database=" + dbtxt.Text
            dbCon = New MySqlConnection(strConn)
            'OPEN THE connect
            dbCon.Open()
            StudentForm.Show()
            dbCon.Close()
        Catch ex As Exception
            MsgBox("Failure to communicate!" & vbCrLf & vbCrLf & ex.Message)
        End Try

    End Sub
End Class
