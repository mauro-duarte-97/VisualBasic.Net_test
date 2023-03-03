Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DClientePrueba
    Inherits Conexion

    Private ID As String
    Private cliente As String
    Private correo As String
    Private telefono As String
    Private cmd As SqlCommand
    Dim null As Nullable
    Public Sub New(cte As String, corr As String, tel As String)

        cliente = cte
        correo = corr
        telefono = tel

    End Sub

    Public Sub New()


    End Sub

    Public Property CCliente As String

        Get
            Return cliente
        End Get
        Set(value As String)
            cliente = value
        End Set
    End Property

    Public Property CorreoCliente As String

        Get
            Return correo

        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Property TelCliente As String

        Get
            Return telefono

        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Function consultarCliente(ID As String, cte As String, tel As String, corr As String) As DataTable
        'SE FILTRARA DE A 1 POR CONVENIENCIA DE CODIGO

        Try
            conectar()

            'cmd.Connection = con
            If ID <> 0 Then
                cmd = New SqlCommand("SELECT * FROM dbo.clientes WHERE ID ='" & ID & "'")
                MsgBox(cmd)

            End If

            If cte <> " " Then
                cmd = New SqlCommand("SELECT * FROM dbo.clientes WHERE Cliente ='" & cte & "'")
                MsgBox(cmd)
            End If

            If tel <> " " Then
                cmd = New SqlCommand("SELECT * FROM dbo.clientes WHERE Telefono ='" & tel & "'")
                MsgBox(cmd)
            End If

            If corr <> " " Then
                cmd = New SqlCommand("SELECT * FROM dbo.clientes WHERE Correo ='" & corr & "'")
                MsgBox(cmd)
            End If

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New SqlDataAdapter(cmd)
                adp.Fill(dt)
                Return dt
            Else
                MsgBox("Salio mal")

                Return Nothing
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing
        Finally

            desconectar()

        End Try

    End Function

    Public Function insertarCliente(dc As DClientePrueba) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO dbo.clientes (Cliente,Telefono,Correo)VALUES('" & dc.cliente & "','" &
                dc.telefono & "', '" & dc.correo & "')"


            cmd = New SqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then
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
