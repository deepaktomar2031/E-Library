Imports System.Data
Imports System.Data.SqlClient

Public Class StuDeleteAccount
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim rs As SqlDataReader
    Dim n As Integer


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            cmd.CommandText = "delete  from StudentID where uid='" & userID.ToString & "'  "
            cmd.CommandText = "delete  from StudentInfo where student_id='" & userID.ToString & "'  "
            cmd.Connection = con
            con.Open()
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                MsgBox("data deleted")
            Else
                MsgBox("data deletion failed")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub StuDeleteAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = userID.ToString
    End Sub
End Class