Public Class Rewardsvb
    Dim ambo As Integer = 1
    Dim terno As Integer = 1
    Dim quaterna As Integer = 1
    Dim cinquina As Integer = 1
    Dim decina As Integer = 1
    Dim tombola As Integer = 1
    Dim tombolino As Integer = 1
    Dim altro As Integer = 1





    Private Sub Rewardsvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBoxAmbo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAmbo.CheckedChanged
        ambo += 1
        If ambo Mod 2 = 0 Then
            TextBoxAmbo.Enabled = True
        Else
            TextBoxAmbo.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxTerno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTerno.CheckedChanged
        terno += 1
        If terno Mod 2 = 0 Then
            TextBoxTerno.Enabled = True
        Else
            TextBoxTerno.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxQuaterna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxQuaterna.CheckedChanged
        quaterna += 1
        If quaterna Mod 2 = 0 Then
            TextBoxQuaterna.Enabled = True
        Else
            TextBoxQuaterna.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxCinquina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxCinquina.CheckedChanged
        cinquina += 1
        If cinquina Mod 2 = 0 Then
            TextBoxCinquina.Enabled = True
        Else
            TextBoxCinquina.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxDecina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDecina.CheckedChanged
        decina += 1
        If decina Mod 2 = 0 Then
            TextBoxDecina.Enabled = True
        Else
            TextBoxDecina.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxTombola_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTombola.CheckedChanged
        tombola += 1
        If tombola Mod 2 = 0 Then
            TextBoxTombola.Enabled = True
        Else
            TextBoxTombola.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxTombolino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTombolino.CheckedChanged
        tombolino += 1
        If tombolino Mod 2 = 0 Then
            TextBoxTombolino.Enabled = True
        Else
            TextBoxTombolino.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxAltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAltro.CheckedChanged
        altro += 1
        If altro Mod 2 = 0 Then
            TextBoxAltro.Enabled = True
        Else
            TextBoxAltro.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click









        Me.Close()
    End Sub
End Class