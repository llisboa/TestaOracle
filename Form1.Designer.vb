<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTestaOracle
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSTART = New System.Windows.Forms.Button()
        Me.txtRESULT = New System.Windows.Forms.TextBox()
        Me.pnlBTN = New System.Windows.Forms.Panel()
        Me.pnlRESULT = New System.Windows.Forms.Panel()
        Me.pnlBTN.SuspendLayout()
        Me.pnlRESULT.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSTART
        '
        Me.btnSTART.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSTART.Location = New System.Drawing.Point(0, 0)
        Me.btnSTART.Name = "btnSTART"
        Me.btnSTART.Size = New System.Drawing.Size(96, 261)
        Me.btnSTART.TabIndex = 0
        Me.btnSTART.Text = "INICIA TESTE"
        Me.btnSTART.UseVisualStyleBackColor = True
        '
        'txtRESULT
        '
        Me.txtRESULT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRESULT.Location = New System.Drawing.Point(0, 0)
        Me.txtRESULT.Multiline = True
        Me.txtRESULT.Name = "txtRESULT"
        Me.txtRESULT.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRESULT.Size = New System.Drawing.Size(488, 261)
        Me.txtRESULT.TabIndex = 1
        Me.txtRESULT.WordWrap = False
        '
        'pnlBTN
        '
        Me.pnlBTN.Controls.Add(Me.btnSTART)
        Me.pnlBTN.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBTN.Location = New System.Drawing.Point(488, 0)
        Me.pnlBTN.Name = "pnlBTN"
        Me.pnlBTN.Size = New System.Drawing.Size(96, 261)
        Me.pnlBTN.TabIndex = 2
        '
        'pnlRESULT
        '
        Me.pnlRESULT.Controls.Add(Me.txtRESULT)
        Me.pnlRESULT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRESULT.Location = New System.Drawing.Point(0, 0)
        Me.pnlRESULT.Name = "pnlRESULT"
        Me.pnlRESULT.Size = New System.Drawing.Size(488, 261)
        Me.pnlRESULT.TabIndex = 3
        '
        'frmTestaOracle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.pnlRESULT)
        Me.Controls.Add(Me.pnlBTN)
        Me.Name = "frmTestaOracle"
        Me.Text = "TestaOracle"
        Me.pnlBTN.ResumeLayout(False)
        Me.pnlRESULT.ResumeLayout(False)
        Me.pnlRESULT.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSTART As Button
    Friend WithEvents txtRESULT As TextBox
    Friend WithEvents pnlBTN As Panel
    Friend WithEvents pnlRESULT As Panel
End Class
