Imports System.Data
Imports System.Data.SqlClient

Public Class BookSearch
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Text = " "
        ComboBox2.Text = " "
        ComboBox3.Text = " "

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Visible = True
        Button3.Visible = True

        Dim n As Integer
        Dim flg As Boolean = False
        Try
            cmd.CommandText = "select * from BooksInfo where status='not issued'"
            cmd.Connection = con
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                flg = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
        If flg = False Then
            MsgBox("Book Can not be Issued")
        Else
            Try
                cmd.CommandText = "insert into Bookstatus(isbn,user_id) values('" & TextBox1.Text & "','" & userID.ToString & "')  "
                cmd.Connection = con
                con.Open()
                n = cmd.ExecuteNonQuery
                If n > 0 Then
                    MsgBox("Request Sent")
                Else
                    MsgBox("Request not sent")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                con.Close()
            End Try
        End If

    End Sub

    Private Sub BookSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button4.Visible = True
        TextBox1.Visible = True
    End Sub
End Class