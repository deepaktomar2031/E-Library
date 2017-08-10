

Imports System.Data
Imports System.Data.SqlClient

Public Class LibrarianResetPassword

    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim rs As SqlDataReader
    Dim n As Integer


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox2.Text = TextBox3.Text Then
                cmd.CommandText = "update StudentId set password= '" & TextBox3.Text & "' where uid='" & userID.ToString & "'"
                cmd.Connection = con
                con.Open()
                n = cmd.ExecuteNonQuery
                If n > 0 Then
                    MsgBox("password updated successfully")
                Else
                    MsgBox("password updation failed")
                End If
            Else
                MsgBox("Password and confirm password are not same or empty", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()


        End Try

    End Sub

    Private Sub StuResetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = userID.ToString
    End Sub


End Class