Public Class AdminStudentView

    Private Sub AdminStudentView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibraryDataSet.StudentInfo' table. You can move, or remove it, as needed.
        Me.StudentInfoTableAdapter.Fill(Me.ELibraryDataSet.StudentInfo)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class