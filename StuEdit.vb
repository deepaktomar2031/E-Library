Imports System.Data
Imports System.Data.SqlClient

Public Class StuEdit
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader


    Private Sub StuEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '  cmd.CommandText = " select ( first_name ,last_name ,gender ,address ,year ,email ,course ,department ) from student  where student_id='" & userID.ToString & "'"
            cmd.CommandText = " select * from StudentInfo  where student_id='" & userID.ToString & "'"
            cmd.Connection = con
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Label1.Text = dr(0)
                TextBox1.Text = dr(1)
                TextBox6.Text = dr(2)
                ComboBox1.Text = dr(3)
                TextBox4.Text = dr(6)
                TextBox3.Text = dr(8)
                TextBox2.Text = dr(7)
                ComboBox2.Text = dr(4)
                ComboBox3.Text = dr(5)



            End If


        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim n As Integer
            cmd.CommandText = "update StudentInfo set  firstname='" & TextBox1.Text & "',lastname='" & TextBox6.Text & "' ,gender='" & ComboBox1.Text & "',address='" & TextBox4.Text & "',year='" & TextBox3.Text & "',email='" & TextBox2.Text & "',course='" & ComboBox3.Text & "',department='" & ComboBox2.Text & "' where student_id='" & userID.ToString & "'"


            cmd.Connection = con
            con.Open()
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                MsgBox("data modified successfully")
            Else
                MsgBox("data modification failed")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        StudentInfoMDI.Show()
        Me.Hide()

    End Sub
End Class