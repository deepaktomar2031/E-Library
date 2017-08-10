Imports System.Data
Imports System.Data.SqlClient

Public Class StudentInfoMDI
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader




    Private Sub StudentInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '  cmd.CommandText = " select ( first_name ,last_name ,gender ,address ,year ,email ,course ,department ) from student  where student_id='" & userID.ToString & "'"
            cmd.CommandText = " select * from StudentInfo  where student_id='" & userID.ToString & "'"
            cmd.Connection = con
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Label1.Text = dr(0)
                Label12.Text = dr(1)
                Label13.Text = dr(2)
                Label14.Text = dr(3)
                Label15.Text = dr(6)
                Label16.Text = dr(8)
                Label17.Text = dr(7)
                Label18.Text = dr(4)
                Label19.Text = dr(5)



            End If


        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click
        StuEdit.Show()

    End Sub

    Private Sub ResetPasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPasswordToolStripMenuItem1.Click
        StuResetPassword.Show()

    End Sub

    Private Sub DeleteAccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAccountToolStripMenuItem1.Click
        StuDeleteAccount.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class