<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultarCliente
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
        Me.btnConsultarCte = New System.Windows.Forms.Button()
        Me.LabID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.LabCte = New System.Windows.Forms.Label()
        Me.LabTel = New System.Windows.Forms.Label()
        Me.LabCorr = New System.Windows.Forms.Label()
        Me.txtCte = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtCorr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnConsultarCte
        '
        Me.btnConsultarCte.Location = New System.Drawing.Point(92, 191)
        Me.btnConsultarCte.Name = "btnConsultarCte"
        Me.btnConsultarCte.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultarCte.TabIndex = 0
        Me.btnConsultarCte.Text = "Buscar"
        Me.btnConsultarCte.UseVisualStyleBackColor = True
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(26, 12)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(18, 15)
        Me.LabID.TabIndex = 1
        Me.LabID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(82, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 23)
        Me.txtID.TabIndex = 2
        '
        'LabCte
        '
        Me.LabCte.AutoSize = True
        Me.LabCte.Location = New System.Drawing.Point(26, 53)
        Me.LabCte.Name = "LabCte"
        Me.LabCte.Size = New System.Drawing.Size(44, 15)
        Me.LabCte.TabIndex = 3
        Me.LabCte.Text = "Cliente"
        '
        'LabTel
        '
        Me.LabTel.AutoSize = True
        Me.LabTel.Location = New System.Drawing.Point(26, 88)
        Me.LabTel.Name = "LabTel"
        Me.LabTel.Size = New System.Drawing.Size(52, 15)
        Me.LabTel.TabIndex = 4
        Me.LabTel.Text = "Telefono"
        '
        'LabCorr
        '
        Me.LabCorr.AutoSize = True
        Me.LabCorr.Location = New System.Drawing.Point(26, 130)
        Me.LabCorr.Name = "LabCorr"
        Me.LabCorr.Size = New System.Drawing.Size(43, 15)
        Me.LabCorr.TabIndex = 5
        Me.LabCorr.Text = "Correo"
        '
        'txtCte
        '
        Me.txtCte.Location = New System.Drawing.Point(82, 53)
        Me.txtCte.Name = "txtCte"
        Me.txtCte.Size = New System.Drawing.Size(100, 23)
        Me.txtCte.TabIndex = 6
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(82, 88)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 23)
        Me.txtTel.TabIndex = 7
        '
        'txtCorr
        '
        Me.txtCorr.Location = New System.Drawing.Point(82, 130)
        Me.txtCorr.Name = "txtCorr"
        Me.txtCorr.Size = New System.Drawing.Size(100, 23)
        Me.txtCorr.TabIndex = 8
        '
        'FrmConsultarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 327)
        Me.Controls.Add(Me.txtCorr)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtCte)
        Me.Controls.Add(Me.LabCorr)
        Me.Controls.Add(Me.LabTel)
        Me.Controls.Add(Me.LabCte)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabID)
        Me.Controls.Add(Me.btnConsultarCte)
        Me.Name = "FrmConsultarCliente"
        Me.Text = "FrmConsultarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConsultarCte As Button
    Friend WithEvents LabID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents LabCte As Label
    Friend WithEvents LabTel As Label
    Friend WithEvents LabCorr As Label
    Friend WithEvents txtCte As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtCorr As TextBox
End Class
