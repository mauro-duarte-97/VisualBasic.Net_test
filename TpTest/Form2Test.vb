Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form2Test

    Dim ConString As String = ConfigurationManager.ConnectionStrings(0).ToString()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim row As Integer
        'Dim str As String
        con = New SqlConnection(ConString)
        con.Open()
        cmd = New SqlCommand("INSERT INTO dbo.clientes (Cliente, Telefono, Correo) VALUES ('" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "')", con)
        row = cmd.ExecuteNonQuery()
        If row > 0 Then
            MessageBox.Show("the row inserted" & row)
        End If
        con.Close()
    End Sub




End Class
