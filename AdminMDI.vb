Public Class AdminMDI

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        

    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click

    End Sub

    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        AdminStudentView.Show()

    End Sub

    Private Sub BooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksToolStripMenuItem.Click
        AdminBooks.Show()
    End Sub

    Private Sub LibrarianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibrarianToolStripMenuItem.Click
        AdminLibrarian.Show()

    End Sub

    Private Sub IssueBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueBookToolStripMenuItem.Click
        AdminIssueBook.Show()
    End Sub

    Private Sub AddBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBookToolStripMenuItem.Click
        AdminAddBook.Show()

    End Sub

    Private Sub AddLibrarianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddLibrarianToolStripMenuItem.Click
        AdminAddLibrarian.Show()
    End Sub

    Private Sub RemoveLibrarianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveLibrarianToolStripMenuItem.Click
        AdminRemoveLibrarian.Show()
    End Sub

    Private Sub AdminMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Close()
    End Sub
End Class