Public Class Form1
    Dim numeri(89) As Button
    Dim margineSup As Integer       'spazio dal margine superiore
    Dim counter As Integer          'Calcola quando andare a capo per ogni multiplo di 10 e quando aggiungere uno spazio dopo ogni multiplo di 5
    Dim numeriImmessi As Integer = 0
    Dim numeriCancellati As Integer = 0
    Dim F As New Font("Arial", 18, FontStyle.Bold)

    Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Se non è stato cliccato almeno un numero il comando per annullare l'ultimo estratto non è cliccabile
        AnnullaUltimoNumeroToolStripMenuItem.Enabled = False



        margineSup = 264        'Imposto una margineSup dal margine superiore iniziale
        counter = 1             'Inizializzo il contatore per i pulsanti

        For i = 0 To numeri.Length - 1
            numeri(i) = New Button
            numeri(i).Width = 51
            numeri(i).BackColor = Color.LightGray
            numeri(i).Height = 43
            numeri(i).Top = margineSup
            numeri(i).Left = 60 * (counter + 6)
            numeri(i).Font = F

            'gestore eventi per ciascun numero del tombolone
            AddHandler numeri(i).Click, AddressOf tastoPremuto
            numeri(i).Tag = i


            ' aggiungere uno spazio in più dopo i multipli di 5 
            If counter > 5 Then
                numeri(i).Left = 60 * (counter + 7)
            End If

            'Quando si raggiunge un multiplo di 10 si va a capo
            If counter Mod 10 = 0 Then
                If i = 29 Or i = 59 Then
                    margineSup += 80
                    counter = 0
                Else
                    margineSup += 50
                    counter = 0
                End If

            End If

            'Aggiorna i contatori e crea il pulsante
            numeri(i).Text = i + 1
            counter += 1
            Me.Controls.Add(numeri(i))
            numeri(i).BringToFront()

        Next
    End Sub

    Sub tastoPremuto(ByVal sender As Button, ByVal e As EventArgs)

        AnnullaUltimoNumeroToolStripMenuItem.Enabled = True
        VisualizzaStoricoToolStripMenuItem.Enabled = True
        Dim id As Integer = Integer.Parse(sender.Tag)
        'cambia colore il pulsante premuto
        numeri(id).BackColor = Color.CornflowerBlue
        Labelextractnumber.Text = numeri(id).Text
        ExtractNumber.Show()

        numeriImmessi += 1
        Labelimmessi.Text = numeriImmessi 'DA CANCELLARE
        'Aggiungi numero allo storico
        History.TextBoxHistory.Text = History.TextBoxHistory.Text & id + 1 & " - "

        'Scrivi il numero del pulsante sul form adatto
        If id + 1 > 9 Then
            ExtractNumber.LabelDoubleNumber.Visible = True
            ExtractNumber.LabelDoubleNumber.Text = id + 1
        Else
            ExtractNumber.LabelSingleNUmber.Visible = True
            ExtractNumber.LabelSingleNUmber.Text = id + 1
        End If

        TextBoxStoricoHomeScreen.Text = History.TextBoxHistory.Text 'DA CANCELLARE


    End Sub

    
    
    'Uscita dal programma
    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Attenzione, stai per chiudere il programma. Sei sicuro?", "Chiusura Tombola", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    'Nuova partita 
    Private Sub NuovaPartitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuovaPartitaToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Attenzione, terminerai la partita in corso per avviarne una nuova, continuare?", "Nuovo Gioco", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

            'Ogni pulsante torna al colore originale
        ElseIf result = DialogResult.Yes Then
            For i = 0 To numeri.Length - 1
                numeri(i).BackColor = Color.LightGray
            Next

            'TODO azzerrare le varie textbox future
            Labelextractnumber.Text = ""
            History.TextBoxHistory.Text = ""
            TextBoxStoricoHomeScreen.Text = History.TextBoxHistory.Text
            TextBox1.Text = ""
            numeriImmessi = 0
            Labelimmessi.Text = numeriImmessi   'DA CANCELLARE
            numeriCancellati = 0
            Labelcancel.Text = numeriCancellati   'DA CANCELLARE

        End If
    End Sub

    'Annullamento ultimo inserimento
    Private Sub AnnullaUltimoNumeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnullaUltimoNumeroToolStripMenuItem.Click
        Dim newString As String
        Dim testo As String
        Dim stringaNumeroAndMiddleScore As String
        Dim posizione As Integer = 0
        Dim numeroPreciso As Integer = 0
        Dim finish As Integer = 0


        Dim result As Integer = MessageBox.Show("Attenzione, annullare ultimo numero inserito?", "Annullare ultimo numero", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            testo = History.TextBoxHistory.Text

            'Algoritmo di controllo numeri già estratti
            While testo <> ""
                posizione = testo.IndexOf(" - ")
                stringaNumeroAndMiddleScore = testo.Substring(0, posizione)

                TextBox1.Text = stringaNumeroAndMiddleScore
                numeroPreciso = TextBox1.Text
                If TextBox1.Text > 9 Then
                    testo = Replace(testo, TextBox1.Text & " - ", "")
                Else
                    testo = testo.Substring(posizione, testo.Length - 1)
                    testo = testo.Substring(posizione, testo.Length - 1)
                    testo = testo.Substring(posizione, testo.Length - 1)
                    testo = testo.Substring(posizione, testo.Length - 1)
                End If


                'Aggiorno l'ultimo numero estratto per la funzione "Annulla ultimo numero estratto
                Labelextractnumber.Text = numeroPreciso
                TextBox2.Text = testo 'DA CANCELLARE
                posizione = 0
            End While

            numeriCancellati += 1
            Labelcancel.Text = numeriCancellati    'DA CANCELLARE
            numeri(Labelextractnumber.Text - 1).BackColor = Color.LightGray
        End If



        'cancello il numero anche dallo storico 
        'Se è l'ultimo numero nello storico svuoto la pagina
        If numeriImmessi = numeriCancellati Then
            AnnullaUltimoNumeroToolStripMenuItem.Enabled = False
            History.TextBoxHistory.Text = ""
            TextBoxStoricoHomeScreen.Text = History.TextBoxHistory.Text 'DA CANCELLARE
            'Altrimenti rimuovo solamente l'ultimo numero
        Else
            newString = History.TextBoxHistory.Text
            newString = Replace(History.TextBoxHistory.Text, " - " & Labelextractnumber.Text & " ", " ")
            History.TextBoxHistory.Text = newString
            TextBoxStoricoHomeScreen.Text = History.TextBoxHistory.Text 'DA CANCELLARE
        End If

        


    End Sub

    
    Private Sub VisualizzaStoricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizzaStoricoToolStripMenuItem.Click
        History.Show()
    End Sub

   

    Private Sub SalvaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvaToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, History.TextBoxHistory.Text)
        End If

        
    End Sub
    'Caricamento della partita
    Private Sub CaricaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaricaToolStripMenuItem.Click

        Dim result As Integer = MessageBox.Show("Attenzione, terminerai la partita in corso per caricarne un'altra, continuare?", "Carica Gioco", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

            'Ogni pulsante torna al colore originale
        ElseIf result = DialogResult.Yes Then
            For i = 0 To numeri.Length - 1
                numeri(i).BackColor = Color.LightGray
            Next

            'TODO azzerrare le varie textbox future
            Labelextractnumber.Text = ""
            History.TextBoxHistory.Text = ""
            TextBox1.Text = ""
            numeriImmessi = 0
            Labelimmessi.Text = numeriImmessi   'DA CANCELLARE
            numeriCancellati = 0
            Labelcancel.Text = numeriCancellati   'DA CANCELLARE

            'Scegliere da dove caricare
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim testo As String
                Dim stringaNumeroAndMiddleScore As String
                Dim posizione As Integer = 0
                Dim numeroPreciso As Integer = 0
                Dim finish As Integer = 0


                'Carico il contenuto del file nella stringa
                testo = System.IO.File.ReadAllText(OpenFileDialog1.FileName)

                'Se il documento non è vuoto
                If testo <> "" Then
                    'Attivo funzione Annulla ultimo numero
                    AnnullaUltimoNumeroToolStripMenuItem.Enabled = True
                End If


                'Attiva e aggiorna lo storico
                VisualizzaStoricoToolStripMenuItem.Enabled = True
                History.TextBoxHistory.Text = testo
                TextBoxStoricoHomeScreen.Text = testo           'DA CANCELLARE

                'Algoritmo di controllo numeri già estratti
                While testo <> ""
                    posizione = testo.IndexOf(" - ")
                    stringaNumeroAndMiddleScore = testo.Substring(0, posizione)
                    LabelLastOne.Text = posizione
                    TextBox1.Text = stringaNumeroAndMiddleScore 
                    numeroPreciso = TextBox1.Text
                    If TextBox1.Text.Length = 2 Then
                        testo = Replace(testo, TextBox1.Text & " - ", "")
                    Else
                        testo = testo.Substring(posizione, testo.Length - 1)
                        testo = testo.Substring(posizione, testo.Length - 1)
                        testo = testo.Substring(posizione, testo.Length - 1)
                        testo = testo.Substring(posizione, testo.Length - 1)
                    End If
                    numeriImmessi += 1
                    Labelimmessi.Text = numeriImmessi     'DA CANCELLARE
                    numeri(numeroPreciso - 1).BackColor = Color.CornflowerBlue  'coloro il tasto -1 perchè si tratta dell'array

                    'Aggiorno l'ultimo numero estratto per la funzione "Annulla ultimo numero estratto
                    Labelextractnumber.Text = numeroPreciso - 1
                    TextBox2.Text = testo 'DA CANCELLARE
                    posizione = 0
                End While


            End If
        End If
    End Sub

    
End Class
