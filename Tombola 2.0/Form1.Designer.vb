<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuovaPartitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaricaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StampaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnteprimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StampaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrumentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnullaUltimoNumeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizzaStoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostaPremiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformazioniSuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Labelextractnumber = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxStoricoHomeScreen = New System.Windows.Forms.TextBox()
        Me.Labelimmessi = New System.Windows.Forms.Label()
        Me.Labelcancel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelLastOne = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StrumentiToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1371, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuovaPartitaToolStripMenuItem, Me.SalvaToolStripMenuItem, Me.CaricaToolStripMenuItem, Me.StampaToolStripMenuItem, Me.EsciToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NuovaPartitaToolStripMenuItem
        '
        Me.NuovaPartitaToolStripMenuItem.Name = "NuovaPartitaToolStripMenuItem"
        Me.NuovaPartitaToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.NuovaPartitaToolStripMenuItem.Text = "Nuova Partita"
        '
        'SalvaToolStripMenuItem
        '
        Me.SalvaToolStripMenuItem.Name = "SalvaToolStripMenuItem"
        Me.SalvaToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.SalvaToolStripMenuItem.Text = "Salva Partita"
        '
        'CaricaToolStripMenuItem
        '
        Me.CaricaToolStripMenuItem.Name = "CaricaToolStripMenuItem"
        Me.CaricaToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.CaricaToolStripMenuItem.Text = "Carica Partita"
        '
        'StampaToolStripMenuItem
        '
        Me.StampaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnteprimaToolStripMenuItem, Me.StampaToolStripMenuItem1})
        Me.StampaToolStripMenuItem.Name = "StampaToolStripMenuItem"
        Me.StampaToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.StampaToolStripMenuItem.Text = "Stampante"
        '
        'AnteprimaToolStripMenuItem
        '
        Me.AnteprimaToolStripMenuItem.Name = "AnteprimaToolStripMenuItem"
        Me.AnteprimaToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AnteprimaToolStripMenuItem.Text = "Anteprima"
        '
        'StampaToolStripMenuItem1
        '
        Me.StampaToolStripMenuItem1.Name = "StampaToolStripMenuItem1"
        Me.StampaToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.StampaToolStripMenuItem1.Text = "Stampa"
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.EsciToolStripMenuItem.Text = "Esci"
        '
        'StrumentiToolStripMenuItem
        '
        Me.StrumentiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnnullaUltimoNumeroToolStripMenuItem, Me.VisualizzaStoricoToolStripMenuItem, Me.ImpostaPremiToolStripMenuItem})
        Me.StrumentiToolStripMenuItem.Name = "StrumentiToolStripMenuItem"
        Me.StrumentiToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.StrumentiToolStripMenuItem.Text = "Strumenti"
        '
        'AnnullaUltimoNumeroToolStripMenuItem
        '
        Me.AnnullaUltimoNumeroToolStripMenuItem.Enabled = False
        Me.AnnullaUltimoNumeroToolStripMenuItem.Name = "AnnullaUltimoNumeroToolStripMenuItem"
        Me.AnnullaUltimoNumeroToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.AnnullaUltimoNumeroToolStripMenuItem.Text = "Annulla ultimo numero"
        '
        'VisualizzaStoricoToolStripMenuItem
        '
        Me.VisualizzaStoricoToolStripMenuItem.Enabled = False
        Me.VisualizzaStoricoToolStripMenuItem.Name = "VisualizzaStoricoToolStripMenuItem"
        Me.VisualizzaStoricoToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.VisualizzaStoricoToolStripMenuItem.Text = "Visualizza Storico"
        '
        'ImpostaPremiToolStripMenuItem
        '
        Me.ImpostaPremiToolStripMenuItem.Name = "ImpostaPremiToolStripMenuItem"
        Me.ImpostaPremiToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.ImpostaPremiToolStripMenuItem.Text = "Imposta Premi"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformazioniSuToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 24)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'InformazioniSuToolStripMenuItem
        '
        Me.InformazioniSuToolStripMenuItem.Name = "InformazioniSuToolStripMenuItem"
        Me.InformazioniSuToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.InformazioniSuToolStripMenuItem.Text = "Informazioni su"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-268, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2008, 1300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Labelextractnumber
        '
        Me.Labelextractnumber.AutoSize = True
        Me.Labelextractnumber.Location = New System.Drawing.Point(13, 48)
        Me.Labelextractnumber.Name = "Labelextractnumber"
        Me.Labelextractnumber.Size = New System.Drawing.Size(51, 17)
        Me.Labelextractnumber.TabIndex = 2
        Me.Labelextractnumber.Text = "Label1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Partita Tombola"
        Me.SaveFileDialog1.Filter = "File Tombola|*.tmb"
        Me.SaveFileDialog1.Title = "Salva Partita"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(16, 155)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 252)
        Me.TextBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Contenitore dove prendere numeri da colorare"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Numero da colorare"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Storico attuale"
        '
        'TextBoxStoricoHomeScreen
        '
        Me.TextBoxStoricoHomeScreen.Location = New System.Drawing.Point(16, 448)
        Me.TextBoxStoricoHomeScreen.Multiline = True
        Me.TextBoxStoricoHomeScreen.Name = "TextBoxStoricoHomeScreen"
        Me.TextBoxStoricoHomeScreen.Size = New System.Drawing.Size(272, 252)
        Me.TextBoxStoricoHomeScreen.TabIndex = 7
        '
        'Labelimmessi
        '
        Me.Labelimmessi.AutoSize = True
        Me.Labelimmessi.Location = New System.Drawing.Point(88, 48)
        Me.Labelimmessi.Name = "Labelimmessi"
        Me.Labelimmessi.Size = New System.Drawing.Size(99, 17)
        Me.Labelimmessi.TabIndex = 9
        Me.Labelimmessi.Text = "Storico attuale"
        '
        'Labelcancel
        '
        Me.Labelcancel.AutoSize = True
        Me.Labelcancel.Location = New System.Drawing.Point(193, 48)
        Me.Labelcancel.Name = "Labelcancel"
        Me.Labelcancel.Size = New System.Drawing.Size(99, 17)
        Me.Labelcancel.TabIndex = 10
        Me.Labelcancel.Text = "Storico attuale"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Numeri immessi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(193, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Numeri cancellati"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Ultimo numero"
        '
        'LabelLastOne
        '
        Me.LabelLastOne.AutoSize = True
        Me.LabelLastOne.Location = New System.Drawing.Point(193, 110)
        Me.LabelLastOne.Name = "LabelLastOne"
        Me.LabelLastOne.Size = New System.Drawing.Size(0, 17)
        Me.LabelLastOne.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(16, 729)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(272, 252)
        Me.TextBox3.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 709)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(266, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Verifica se un numero è stato già inserito"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 877)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelLastOne)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Labelcancel)
        Me.Controls.Add(Me.Labelimmessi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxStoricoHomeScreen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Labelextractnumber)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuovaPartitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaricaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StrumentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizzaStoricoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StampaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImpostaPremiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformazioniSuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AnnullaUltimoNumeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Labelextractnumber As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxStoricoHomeScreen As System.Windows.Forms.TextBox
    Friend WithEvents Labelimmessi As System.Windows.Forms.Label
    Friend WithEvents Labelcancel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelLastOne As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents AnteprimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StampaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
