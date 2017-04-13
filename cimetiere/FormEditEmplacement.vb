Public Class FormEditEmplacement
    Public IdEmplacement As Integer?
    Private LEmplacement As Emplacement

    Public Sub New(Optional IdEmpl As Integer? = Nothing)
        ' This call is required by the designer.
        InitializeComponent()
        IdEmplacement = IdEmpl
    End Sub

    Private Sub FormEditEmplacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' édit ou nouveau ?
        If IdEmplacement IsNot Nothing Then
            Me.Text = "Modifier un emplacement"
            LEmplacement = Bdd.Load(Of Emplacement)(IdEmplacement)
            With LEmplacement
                TbReference.Value = .Reference
                TbNbPlaces.Value = .NbPlaces
                TbCommentaire.Value = .Commentaire
                CbMonumentClasse.Checked = If(.MonumClasse, .MonumClasse, False)
            End With
        Else
            Me.Text = "Nouvelle entrée"
            LEmplacement = New Emplacement
        End If
    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        With LEmplacement
            .Reference = TbReference.Value
            .NbPlaces = TbNbPlaces.Value
            .Commentaire = TbCommentaire.Value
            .MonumClasse = CbMonumentClasse.Checked
        End With
        Bdd.Save(LEmplacement)
        IdEmplacement = LEmplacement.Id
        DialogResult = DialogResult.OK
    End Sub

    ' pas de DialogResult automatique sinon il se déclenche quand on appuie sur entrée pour passer une ligne dans le commentaire
    Private Sub DgvConcessions_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNbPlaces.KeyDown, TbReference.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtEnregistrer_Click(BtEnregistrer, Nothing)
        End If
    End Sub



End Class