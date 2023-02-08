Public Class FrmInsertarCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInsertarCliente.Click

        Try
            Dim Lc As New LCliente()

            Lc.insertarCliente(txtNombres.Text, txtNumId.Text, txtTel.Text)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNumId.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged

    End Sub
End Class