Imports System.Data.SqlClient

'Create a Connection object.
myConn = New SqlConnection("Initial Catalog=Northwind;"  
 & "Data Source=localhost;Integrated Security=SSPI;")

'Create a Command object.
myCmd = myConn.CreateCommand
myCmd.CommandText = "SELECT FirstName, LastName FROM Employees"

'Open the connection.
myConn.Open()
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        Do While myReader.Read()
            results = results & myReader.GetString(0) & vbTab &
            myReader.GetString(1) & vbLf
        Loop
        'Display results.
        MsgBox(results)

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()

    End Sub
End Class
