Public Class AdminBooks

    Private Sub AdminBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibraryDataSet2.BooksInfo' table. You can move, or remove it, as needed.
        Me.BooksInfoTableAdapter.Fill(Me.ELibraryDataSet2.BooksInfo)

    End Sub
End Class