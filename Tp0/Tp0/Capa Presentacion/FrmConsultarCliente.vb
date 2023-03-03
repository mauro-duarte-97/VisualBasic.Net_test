Public Class FrmConsultarCliente
    Private Sub btnConsultarCte_Click(sender As Object, e As EventArgs) Handles btnConsultarCte.Click
        Try
            Dim lc As New LCliente

            Dim dt As DataTable = lc.consultarCliente(txtID.Text, txtCte.Text, txtTel.Text, txtCorr.Text)
            MsgBox(txtID)
            MsgBox(dt)
            Dim dr As DataRow = dt.Rows.Item(0)
            MsgBox(dr.Item("Cliente") & " | " & dr.Item("Telefono") & " | " & dr.Item("Correo"), vbOKOnly, "Datos")

        Catch ex As Exception
            MsgBox("El cliente ingresado no existe")
        End Try
    End Sub
End Class