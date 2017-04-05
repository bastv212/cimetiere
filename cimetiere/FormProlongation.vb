Public Class FormProlongation

    Private Sub FaddDDGCons_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProlongDG.CellContentClick

    End Sub

    Private Sub ProlongBTerminer_Click(sender As Object, e As EventArgs) Handles ProlongBTerminer.Click
        Dim ep As New ExporteurPdf
        ep.CreePdfProlongation()
    End Sub
End Class