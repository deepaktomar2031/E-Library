Imports System.Data
Imports System.Data.SqlClient
Public Class LibrarianMDI
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim n As Integer


    Private Sub LibrarianMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = librarianID.ToString
        Try
            cmd.CommandText = " select * from LibrarianInfo  where librarian_id='" & librarianID.ToString & "'"
            cmd.Connection = con
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Label2.Text = dr(1)
                Label3.Text = dr(2)
                Label4.Text = dr(3)
                Label5.Text = dr(4)
                Label6.Text = dr(5)
                Label7.Text = dr(6)
            End If


        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        LibrarianEdit.Show()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        LibrarianResetPassword.Show()
    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        LibrarianDeleteAccount.Show()
    End Sub

    Private Sub IssueBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueBookToolStripMenuItem.Click
        LibrarianIssueBook.Show()
    End Sub

    Private Sub ReturnBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBookToolStripMenuItem.Click
        LibrarianReturnBook.Show()
    End Sub

    Private Sub AddBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBookToolStripMenuItem.Click
        LibrarianAddBook.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class