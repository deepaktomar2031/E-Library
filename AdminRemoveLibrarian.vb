Imports System.Data
Imports System.Data.SqlClient
Public Class AdminRemoveLibrarian
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim n, d, a As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            cmd.CommandText = "delete  from LibrarianInfo where librarian_id=" & TextBox1.Text & "  "
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

    End Sub
End Class