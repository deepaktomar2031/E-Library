Imports System.Data
Imports System.Data.SqlClient

Public Class LibrarianReturnBook
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim n, d, a As Integer
    Dim issuedate, submitdate As Date


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cmd.CommandText = " select * from BookStatus  where isbn='" & TextBox1.Text & "'"
            cmd.Connection = con
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read() Then
                issuedate = dr(2)
                submitdate = dr(3)
            End If
            d = (submitdate - issuedate).TotalDays
            If ((d - 7) > 0) Then
                Label5.Text = (d - 7) * 1
            Else
                Label5.Text = (" 0")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
        Try
            cmd.CommandText = "update BookStatus set date_of_submission='" & Date.Now.ToString & "' where isbn='" & TextBox1.Text & "' "
            cmd.Connection = con
            con.Open()
            n = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try
        Try
            cmd.CommandText = "update BooksInfo set status='not issued',stuid='' where isbn='" & TextBox1.Text & "' "
            cmd.Connection = con
            con.Open()
            n = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try
        Label4.Visible = True
        Label5.Visible = True

    End Sub


    Private Sub LibrarianReturnBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Visible = False
        Label5.Visible = False

    End Sub
End Class