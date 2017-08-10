Public Class AdminLibrarian

    Private Sub AdminLibrarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibraryDataSet1.LibrarianInfo' table. You can move, or remove it, as needed.
        Me.LibrarianInfoTableAdapter.Fill(Me.ELibraryDataSet1.LibrarianInfo)

    End Sub
End Class