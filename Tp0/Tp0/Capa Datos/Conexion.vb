Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Conexion

    Protected con As New SqlConnection("Server=localhost,1433;Uid=sa;Pwd=!felgrand97;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;")

    Public Function conectar() As Boolean

        Try
            con.Open()

            Return True
        Catch ex As Exception

            MsgBox(ex.Message)

            Return False

        End Try
    End Function

    Public Sub desconectar()

        Try

            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
