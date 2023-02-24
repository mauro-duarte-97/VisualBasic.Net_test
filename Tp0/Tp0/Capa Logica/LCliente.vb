Imports System.Data.SqlClient

Public Class LCliente

    Public Function insertarCliente(cte As String, correo As String, tel As String)

        Dim dc As New DCliente(cte, correo, tel)

        If dc.insertarCliente(dc) = True Then

            Return True

        Else

            Return False
        End If

    End Function

    Public Function consultarCliente(ID As String, cte As String, tel As String, corr As String) As DataTable
        Try
            Dim dc As New DCliente(cte, tel, corr)
            Dim dt As DataTable = dc.consultarCliente(ID, cte, tel, corr)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
