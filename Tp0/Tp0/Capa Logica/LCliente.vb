Imports System.Data.OleDb

Public Class LCliente

    Public Function insertarCliente(nom As String, nId As String, tel As String)

        Dim dc As New DCliente(nom, nId, tel)

        If dc.insertarCliente(dc) = True Then

            Return True

        Else

            Return False
        End If

    End Function


End Class
