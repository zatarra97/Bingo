<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExtractNumber
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelDoubleNumber = New System.Windows.Forms.Label()
        Me.LabelSingleNUmber = New System.Windows.Forms.Label()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelDoubleNumber
        '
        Me.LabelDoubleNumber.AutoSize = True
        Me.LabelDoubleNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDoubleNumber.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelDoubleNumber.Location = New System.Drawing.Point(51, 74)
        Me.LabelDoubleNumber.Name = "LabelDoubleNumber"
        Me.LabelDoubleNumber.Size = New System.Drawing.Size(238, 170)
        Me.LabelDoubleNumber.TabIndex = 0
        Me.LabelDoubleNumber.Text = "45"
        Me.LabelDoubleNumber.Visible = False
        '
        'LabelSingleNUmber
        '
        Me.LabelSingleNUmber.AutoSize = True
        Me.LabelSingleNUmber.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSingleNUmber.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LabelSingleNUmber.Location = New System.Drawing.Point(90, 74)
        Me.LabelSingleNUmber.Name = "LabelSingleNUmber"
        Me.LabelSingleNUmber.Size = New System.Drawing.Size(155, 170)
        Me.LabelSingleNUmber.TabIndex = 1
        Me.LabelSingleNUmber.Text = "1"
        Me.LabelSingleNUmber.Visible = False
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.Location = New System.Drawing.Point(235, 276)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(81, 31)
        Me.ButtonConfirm.TabIndex = 2
        Me.ButtonConfirm.Text = "Conferma"
        Me.ButtonConfirm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "E' stato estratto il numero:"
        '
        'ExtractNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 319)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.LabelSingleNUmber)
        Me.Controls.Add(Me.LabelDoubleNumber)
        Me.Name = "ExtractNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExtractNumber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDoubleNumber As System.Windows.Forms.Label
    Friend WithEvents LabelSingleNUmber As System.Windows.Forms.Label
    Friend WithEvents ButtonConfirm As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
