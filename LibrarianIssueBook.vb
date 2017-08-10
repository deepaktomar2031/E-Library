Imports System.Data
Imports System.Data.SqlClient


Public Class LibrarianIssueBook
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim n As Integer

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label2.Visible = False
        Label3.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub AdminIssueBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibraryDataSet3.BooksInfo' table. You can move, or remove it, as needed.
        Me.BooksInfoTableAdapter.Fill(Me.ELibraryDataSet3.BooksInfo)
        Label2.Visible = False
        Label3.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        DataGridView1.Visible = False
        Button3.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label2.Visible = False
        Label3.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        DataGridView1.Visible = False
        Button3.Visible = False
        Button4.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button3.Visible = True
        DataGridView1.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim flg As Boolean = False
        Try
            cmd.CommandText = "update BooksInfo set status='issued',stuid='" & TextBox2.Text & "' where isbn='" & TextBox1.Text & "' "
            cmd.Connection = con
            con.Open()
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                flg = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try
        If flg = True Then
            Try
                cmd.CommandText = "delete  from BookStatus where isbn='" & TextBox1.Text & "' "
                cmd.Connection = con
                con.Open()
                n = cmd.ExecuteNonQuery
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                con.Close()
            End Try
        End If
        Try
            cmd.CommandText = "update BookStatus set date_of_issue='" & Date.Now.ToString & "' where isbn='" & TextBox1.Text & "' "
            cmd.Connection = con
            con.Open()
            n = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try

    End Sub
End Class