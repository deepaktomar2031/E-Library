Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim n, d, a As Integer




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmd.CommandText = " select max(student_id) from StudentInfo ;  "
            cmd.Connection = con
            con.Open()

            d = Convert.ToInt32(cmd.ExecuteScalar())
            n = d
            a = n + 1
            Label1.Text = a


        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            cmd.CommandText = "insert into StudentInfo(student_id, firstname,lastname,gender,address,year,email,course,department) values('" & Label1.Text & "','" & TextBox1.Text & "','" & TextBox6.Text & "', '" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox2.Text & "')  "
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