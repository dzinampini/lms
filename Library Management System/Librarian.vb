Imports System.Data.SqlClient

Public Class Librarian
    Dim addNewCategory As String

    Dim myconnection As SqlConnection
    Dim insertCategory As SqlCommand

    Private Sub btnAddCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCategory.Click

        If txtAddCategory.Text = "" Then
            MsgBox("Category cannot be null")
        End If

        myconnection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\xampp\htdocs\dzinaishempini.com\Library Management System\Library Management System\library_db.mdf")

        myconnection.Open()
        insertCategory = New SqlCommand("INSERT INTO categories (id, category) VALUES ('1', '" + txtAddCategory.Text + "')", myconnection)

        insertCategory.ExecuteNonQuery()
        myconnection.Close()
        myconnection.Dispose()

        MsgBox("Category succesfully added")
        
    End Sub
End Class