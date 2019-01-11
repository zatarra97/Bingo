<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opzioni
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
        Me.cmbWebColor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxExtractColor = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbWebColor
        '
        Me.cmbWebColor.FormattingEnabled = True
        Me.cmbWebColor.Location = New System.Drawing.Point(15, 60)
        Me.cmbWebColor.Name = "cmbWebColor"
        Me.cmbWebColor.Size = New System.Drawing.Size(264, 24)
        Me.cmbWebColor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scegli un colore per i numeri estratti:"
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.Location = New System.Drawing.Point(208, 203)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(82, 28)
        Me.ButtonConfirm.TabIndex = 2
        Me.ButtonConfirm.Text = "Conferma"
        Me.ButtonConfirm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Colore per il numero appena estratto:"
        '
        'ComboBoxExtractColor
        '
        Me.ComboBoxExtractColor.FormattingEnabled = True
        Me.ComboBoxExtractColor.Location = New System.Drawing.Point(15, 124)
        Me.ComboBoxExtractColor.Name = "ComboBoxExtractColor"
        Me.ComboBoxExtractColor.Size = New System.Drawing.Size(264, 24)
        Me.ComboBoxExtractColor.TabIndex = 3
        '
        'Opzioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 245)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxExtractColor)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbWebColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Opzioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opzioni"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbWebColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonConfirm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxExtractColor As System.Windows.Forms.ComboBox
End Class
