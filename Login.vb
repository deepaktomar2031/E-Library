Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\eLibrary.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim rs As SqlDataReader

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txt1.Clear()
        txt2.Clear()
        AdminRadioButton.Checked = False
        StudentRadioButton.Checked = False
        LibrarianRadioButton3.Checked = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If StudentRadioButton.Checked = True Then
                cmd.CommandText = "select * from StudentID where uid='" + txt1.Text + "' and password='" + txt2.Text + "'"
                userID = txt1.Text
                cmd.Connection = con
                con.Open()
                rs = cmd.ExecuteReader
                If rs.Read Then
                    MsgBox("Valid Username and Password")
                    StudentInfoMDI.Show()
                    Me.Hide()

                Else
                    MsgBox("Invalid entry", MsgBoxStyle.Critical)
                End If

            End If

            If AdminRadioButton.Checked = True Then
                cmd.CommandText = "select * from Admin where admin_id='" + txt1.Text + "' and admin_password='" + txt2.Text + "'"
                cmd.Connection = con
                con.Open()
                rs = cmd.ExecuteReader
                If rs.Read Then
                    MsgBox("Valid Username and Password")
                    AdminMDI.Show()
                    Me.Hide()


                Else
                    MsgBox("Invalid entry", MsgBoxStyle.Critical)
                End If

            End If

            If LibrarianRadioButton3.Checked = True Then
                cmd.CommandText = "select * from LibraianID where librarian='" + txt1.Text + "' and password='" + txt2.Text + "'"
                librarianID = txt1.Text
                cmd.Connection = con
                con.Open()
                rs = cmd.ExecuteReader
                If rs.Read Then
                    MsgBox("Valid Username and Password")
                    LibrarianMDI.Show()
                    Me.Hide()


                Else
                    MsgBox("Invalid entry", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try



    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ForgetPassword.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Show()

        Me.Hide()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class