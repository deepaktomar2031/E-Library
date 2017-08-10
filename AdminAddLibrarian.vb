Imports System.Data
Imports System.Data.SqlClient
Public Class AdminAddLibrarian
    Dim a As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cmd.CommandText = "insert into LibrarianInfo (librarian_id , firstname , lastname , gender , address , year , email) values('" & Label2.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "', '" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')  "
            cmd.Connection = con
            con.Open()
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                MsgBox("data inserted successfully")
            Else
                MsgBox("data insertion failed")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try



    End Sub

    Private Sub AdminAddLibrarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim d As Integer
        Try
            cmd.CommandText = " select max(librarian_id) from LibrarianInfo ;  "
            cmd.Connection = con
            con.Open()

            d = Convert.ToInt32(cmd.ExecuteScalar())
            n = d
            a = n + 1
            Label2.Text = a


        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()

        End Try
    End Sub
End Class