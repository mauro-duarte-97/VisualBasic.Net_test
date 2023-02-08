Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Windows.Media.Protection.PlayReady

Public Class DCliente
    Inherits Conexion

    Private Id_Cliente As Integer
    Private nombres As String
    Private numId As String
    Private telefono As String

    Private cmd As SqlCommand

    Public Sub New(nom As String, nId As String, tel As String)

        nombres = nom
        numId = nId
        telefono = tel

    End Sub

    Public Sub New()

    End Sub

    Public Property Id_Cliente As Integer

        Get
            Return IdCliente

        End Get
        Set(value As Integer)
            IdCliente = value
        End Set
    End Property

    Public Property NombresCliente As String

        Get
            Return nombres
        End Get
        Set(value As String)
            nombres = value
        End Set
    End Property

    Public Property NumIdCliente As String

        Get
            Return numId

        End Get
        Set(value As String)
            numId = value
        End Set
    End Property

    Public Property TelefonoCliente As String

        Get
            Return telefono

        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property


    Public Function insertarCliente(dc As DCliente) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO CLIENTES(NOMBRES,NUM_ID,TELEFONO)VALUES('" & dc.NombresCliente & "','" &
                dc.NumIdCliente & "', '" & dc.TelefonoCliente & "')"


            cmd = New SqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then
                MsgBox("El cliente se ha ingresado exitosamente")
                Return True

            Else
                Return False

            End If


        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        Finally

            desconectar()

        End Try
    End Function
End Class
