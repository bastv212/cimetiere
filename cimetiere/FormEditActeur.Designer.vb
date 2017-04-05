<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditActeur
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditActeur))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbPrenom = New cimetiere.TextBoxNullable()
        Me.TbNom = New cimetiere.TextBoxNullable()
        Me.TbCp = New cimetiere.TextBoxIntNullable()
        Me.TbVille = New cimetiere.TextBoxNullable()
        Me.TbPays = New cimetiere.TextBoxNullable()
        Me.TbTel = New cimetiere.TextBoxNullable()
        Me.MtbDateNaiss = New cimetiere.MaskedTextBoxDate()
        Me.TbNumRegistre = New cimetiere.TextBoxIntNullable()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.TbAdresse = New cimetiere.TextBoxNullable()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prénom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Code postal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ville"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(314, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pays"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Téléphone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Date de naissance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(293, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "N° registre national"
        '
        'TbPrenom
        '
        Me.TbPrenom.CueBanner = Nothing
        Me.TbPrenom.Location = New System.Drawing.Point(101, 22)
        Me.TbPrenom.Name = "TbPrenom"
        Me.TbPrenom.Size = New System.Drawing.Size(100, 22)
        Me.TbPrenom.TabIndex = 9
        Me.TbPrenom.Value = Nothing
        '
        'TbNom
        '
        Me.TbNom.CueBanner = Nothing
        Me.TbNom.Location = New System.Drawing.Point(349, 24)
        Me.TbNom.Name = "TbNom"
        Me.TbNom.Size = New System.Drawing.Size(100, 22)
        Me.TbNom.TabIndex = 10
        Me.TbNom.Value = Nothing
        '
        'TbCp
        '
        Me.TbCp.CueBanner = Nothing
        Me.TbCp.Location = New System.Drawing.Point(386, 65)
        Me.TbCp.Name = "TbCp"
        Me.TbCp.Size = New System.Drawing.Size(100, 22)
        Me.TbCp.TabIndex = 12
        Me.TbCp.Value = Nothing
        '
        'TbVille
        '
        Me.TbVille.CueBanner = Nothing
        Me.TbVille.Location = New System.Drawing.Point(386, 107)
        Me.TbVille.Name = "TbVille"
        Me.TbVille.Size = New System.Drawing.Size(100, 22)
        Me.TbVille.TabIndex = 13
        Me.TbVille.Value = Nothing
        '
        'TbPays
        '
        Me.TbPays.CueBanner = Nothing
        Me.TbPays.Location = New System.Drawing.Point(404, 153)
        Me.TbPays.Name = "TbPays"
        Me.TbPays.Size = New System.Drawing.Size(100, 22)
        Me.TbPays.TabIndex = 14
        Me.TbPays.Value = Nothing
        '
        'TbTel
        '
        Me.TbTel.CueBanner = Nothing
        Me.TbTel.Location = New System.Drawing.Point(113, 124)
        Me.TbTel.Name = "TbTel"
        Me.TbTel.Size = New System.Drawing.Size(100, 22)
        Me.TbTel.TabIndex = 15
        Me.TbTel.Value = Nothing
        '
        'MtbDateNaiss
        '
        Me.MtbDateNaiss.DateValue = Nothing
        Me.MtbDateNaiss.IntArrayValue = CType(resources.GetObject("MtbDateNaiss.IntArrayValue"), System.Collections.Generic.List(Of System.Nullable(Of Integer)))
        Me.MtbDateNaiss.Location = New System.Drawing.Point(173, 158)
        Me.MtbDateNaiss.Mask = "00/00/0000"
        Me.MtbDateNaiss.Name = "MtbDateNaiss"
        Me.MtbDateNaiss.Size = New System.Drawing.Size(100, 22)
        Me.MtbDateNaiss.TabIndex = 16
        Me.MtbDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbNumRegistre
        '
        Me.TbNumRegistre.CueBanner = Nothing
        Me.TbNumRegistre.Location = New System.Drawing.Point(429, 201)
        Me.TbNumRegistre.Name = "TbNumRegistre"
        Me.TbNumRegistre.Size = New System.Drawing.Size(100, 22)
        Me.TbNumRegistre.TabIndex = 17
        Me.TbNumRegistre.Value = Nothing
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtEnregistrer.Location = New System.Drawing.Point(489, 253)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(97, 38)
        Me.BtEnregistrer.TabIndex = 18
        Me.BtEnregistrer.Text = "Enregistrer"
        Me.BtEnregistrer.UseVisualStyleBackColor = True
        '
        'BtAnnuler
        '
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.Location = New System.Drawing.Point(317, 253)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(97, 38)
        Me.BtAnnuler.TabIndex = 19
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'TbAdresse
        '
        Me.TbAdresse.CueBanner = Nothing
        Me.TbAdresse.Location = New System.Drawing.Point(101, 63)
        Me.TbAdresse.Name = "TbAdresse"
        Me.TbAdresse.Size = New System.Drawing.Size(100, 22)
        Me.TbAdresse.TabIndex = 21
        Me.TbAdresse.Value = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Adresse"
        '
        'FormEditActeur
        '
        Me.AcceptButton = Me.BtEnregistrer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(683, 303)
        Me.Controls.Add(Me.TbAdresse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.TbNumRegistre)
        Me.Controls.Add(Me.MtbDateNaiss)
        Me.Controls.Add(Me.TbTel)
        Me.Controls.Add(Me.TbPays)
        Me.Controls.Add(Me.TbVille)
        Me.Controls.Add(Me.TbCp)
        Me.Controls.Add(Me.TbNom)
        Me.Controls.Add(Me.TbPrenom)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditActeur"
        Me.Text = "FormModifActeur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbPrenom As TextBoxNullable
    Friend WithEvents TbNom As TextBoxNullable
    Friend WithEvents TbCp As TextBoxIntNullable
    Friend WithEvents TbVille As TextBoxNullable
    Friend WithEvents TbPays As TextBoxNullable
    Friend WithEvents TbTel As TextBoxNullable
    Friend WithEvents MtbDateNaiss As MaskedTextBoxDate
    Friend WithEvents TbNumRegistre As TextBoxIntNullable
    Friend WithEvents BtEnregistrer As Button
    Friend WithEvents BtAnnuler As Button
    Friend WithEvents TbAdresse As TextBoxNullable
    Friend WithEvents Label3 As Label
End Class
