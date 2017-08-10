Imports System.Data
Imports System.Data.SqlClient
Public Module Session
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=eLibrary;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim rs As SqlDataReader

    Public userID As String
    Public librarianID As String

End Module
