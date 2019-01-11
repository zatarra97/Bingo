Imports System.Reflection

Public Class Opzioni
    
    Private Sub Opzioni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Calling subprocedures
        Me.BindWebColors()
        Me.BindExtractColors()
    End Sub
    
    Private Sub BindWebColors()
        'binding combobox with color vaues
        'assign combobox drawmode
        cmbWebColor.DrawMode = DrawMode.OwnerDrawFixed
        cmbWebColor.ItemHeight = 20
        Dim colType As Type = GetType(System.Drawing.Color)
        For Each prop As PropertyInfo In colType.GetProperties()
            If prop.PropertyType Is GetType(System.Drawing.Color) Then
                cmbWebColor.Items.Add(prop.Name)
            End If
        Next
    End Sub

    Private Sub cmbWebColor_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmbWebColor.DrawItem
        'Drawing the itemsinto the combobox.
        'Every time it fires when an item is drawn to the combobox.
        'exit if there is no item
        If e.Index = -1 Then
            Exit Sub
        End If
        'declare a colorbrush
        Dim colBrush As Brush = New SolidBrush(Color.FromName(DirectCast(cmbWebColor.Items(e.Index), String)))
        'Drawing rectangles for the color values
        e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.Bounds.Left + 2, e.Bounds.Top + 2, 30, e.Bounds.Height - 5)
        e.Graphics.FillRectangle(colBrush, e.Bounds.Left + 3, e.Bounds.Top + 3, 29, e.Bounds.Height - 6)
        'Draw the name of the color
        e.Graphics.DrawString(DirectCast(cmbWebColor.Items(e.Index), String), cmbWebColor.Font, Brushes.Black, 35, e.Bounds.Top + 2)
    End Sub

    Private Sub BindExtractColors()
        'binding combobox with color vaues
        'assign combobox drawmode
        ComboBoxExtractColor.DrawMode = DrawMode.OwnerDrawFixed
        ComboBoxExtractColor.ItemHeight = 20
        Dim colType As Type = GetType(System.Drawing.Color)
        For Each prop As PropertyInfo In colType.GetProperties()
            If prop.PropertyType Is GetType(System.Drawing.Color) Then
                ComboBoxExtractColor.Items.Add(prop.Name)
            End If
        Next
    End Sub

    Private Sub ComboBoxExtractColor_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBoxExtractColor.DrawItem
        'Drawing the itemsinto the combobox.
        'Every time it fires when an item is drawn to the combobox.
        'exit if there is no item
        If e.Index = -1 Then
            Exit Sub
        End If
        'declare a colorbrush
        Dim colBrush As Brush = New SolidBrush(Color.FromName(DirectCast(ComboBoxExtractColor.Items(e.Index), String)))
        'Drawing rectangles for the color values
        e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.Bounds.Left + 2, e.Bounds.Top + 2, 30, e.Bounds.Height - 5)
        e.Graphics.FillRectangle(colBrush, e.Bounds.Left + 3, e.Bounds.Top + 3, 29, e.Bounds.Height - 6)
        'Draw the name of the color
        e.Graphics.DrawString(DirectCast(ComboBoxExtractColor.Items(e.Index), String), ComboBoxExtractColor.Font, Brushes.Black, 35, e.Bounds.Top + 2)
    End Sub

    
    
    Private Sub cmbColors_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbWebColor.SelectedIndexChanged
        'Scelto il colore viene automaticamente cambiato da quel punto in poi nel form principale del tombolone
        Dim cmb As ComboBox = CType(sender, ComboBox)
        Form1.coloreScelto = Color.FromName(cmb.Items(cmb.SelectedIndex))

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxExtractColor.SelectedIndexChanged
        'Scelto il colore del testo del numero appena estratto viene cambiato nel form principale
        Dim cmb As ComboBox = CType(sender, ComboBox)
        Form1.coloreExtract = Color.FromName(cmb.Items(cmb.SelectedIndex))
    End Sub
    Private Sub ButtonConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConfirm.Click

        Me.Hide()
    End Sub

   
End Class