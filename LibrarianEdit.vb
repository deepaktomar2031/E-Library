Imports System.Data
Imports System.Data.SqlClient
Public Class LibrarianEdit
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim n As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LibrarianMDI.Show()
    End Sub

    Private Sub LibrarianEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = librarianID.ToString
        Try
            cmd.CommandText = " select * from LibrarianInfo  where librarian_id='" & librarianID.ToString & "'"
            cmd.Connection = con
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read() Then
                TextBox1.Text = dr(1)
                TextBox2.Text = dr(2)
                ComboBox1.Text = dr(3)
                TextBox4.Text = dr(4)
                TextBox5.Text = dr(5)
                TextBox6.Text = dr(6)




            End If


        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cmd.CommandText = "insert into LibrarianInfo (librarian_id , firstname , lastname , gender , address , year , email) values('" & librarianID.ToString & "','" & TextBox1.Text & "','" & TextBox2.Text & "', '" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')  "
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
End Class