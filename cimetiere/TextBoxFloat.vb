Public Class TextBoxFloat
    Inherits TextBoxCBanner
    Public Overridable Property Value As Integer
        Get
            Dim res As Integer
            Single.TryParse(Me.Text.Replace(",", "."), res)
            Return res
        End Get
        Set(value As Integer)
            Me.Text = value
        End Set
    End Property

    ' empêche d'entrer du texte au clavier
    Public Sub nombreskeydown(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not Char.IsControl(e.KeyChar) Then
            If e.KeyChar = "," Then
                ' retirer l'autre virgule si présente
                ''''' mettre la virgule à la position du curseur
                Dim poscur = Me.SelectionStart
                Dim nouvtext = Me.Text
                nouvtext = nouvtext.Replace(",", "R")       ' R = marqueur temporaire pour les virgules à supprimer (évite de décaler les chiffres en supprimant les virgules avant)
                nouvtext = nouvtext.Insert(poscur, ",")
                nouvtext = nouvtext.Replace("R", "")
                Me.Text = nouvtext
                Me.SelectionStart = poscur
                e.Handled = True

                'e.Handled = True
            ElseIf Not Char.IsNumber(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    ' filtre aussi le copier-coller
    Protected Overrides Sub WndProc(ByRef m As Message)

        If m.Msg <> 770 Then         ' WM_PASTE
            MyBase.WndProc(m)
            Return
        End If

        Dim s As String = ""

        Dim ex_s As String = Clipboard.GetText
        For Each c In ex_s
            If Char.IsNumber(c) Then s += c
        Next
        If s <> "" Then
            ' retire les virgules en trop, ne laisse que la dernière
            s = Replace(s, ",", "",, s.Count(Function(lechar As Char) lechar = ","))
            Clipboard.SetText(s)
            MyBase.WndProc(m)
            Clipboard.SetText(ex_s)
        End If
    End Sub

End Class

