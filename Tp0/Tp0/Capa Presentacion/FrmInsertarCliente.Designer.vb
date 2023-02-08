<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsertarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInsertarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnInsertarCliente
        '
        Me.btnInsertarCliente.Location = New System.Drawing.Point(257, 216)
        Me.btnInsertarCliente.Name = "btnInsertarCliente"
        Me.btnInsertarCliente.Size = New System.Drawing.Size(113, 35)
        Me.btnInsertarCliente.TabIndex = 0
        Me.btnInsertarCliente.Text = "Ingresar Cliente"
        Me.btnInsertarCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datos del cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Numero de identificacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Telefono"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(223, 44)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(175, 23)
        Me.txtNombres.TabIndex = 5
        '
        'txtNumId
        '
        Me.txtNumId.Location = New System.Drawing.Point(223, 100)
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(175, 23)
        Me.txtNumId.TabIndex = 6
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(223, 158)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(175, 23)
        Me.txtTel.TabIndex = 7
        '
        'FrmInsertarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 263)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNumId)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInsertarCliente)
        Me.Name = "FrmInsertarCliente"
        Me.Text = "FrmInsertarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsertarCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtNumId As TextBox
    Friend WithEvents txtTel As TextBox
End Class
