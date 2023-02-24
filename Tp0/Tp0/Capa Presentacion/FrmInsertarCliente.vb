Public Class FrmInsertarCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInsertarCliente.Click

        Try
            If txtNombres.Text <> "" And txtTel.Text <> "" And txtCorreo.Text <> "" Then
                Dim Lc As New LCliente()

                Lc.insertarCliente(txtNombres.Text, txtTel.Text, txtCorreo.Text)
                limpiarCampo()

            Else
                MsgBox("no se puede insertar el cliente por falta de datos")
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub limpiarCampo()

        txtNombres.Clear()
        txtCorreo.Clear()
        txtTel.Clear()

    End Sub

End Class