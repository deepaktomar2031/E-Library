Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\eLibrary.mdf;Integrated Security=True;User Instance=True")
    Public cmd As New SqlCommand
    Public rs As SqlDataReader
    Public n As Integer
End Module