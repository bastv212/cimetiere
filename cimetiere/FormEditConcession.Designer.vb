<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditConcession
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditConcession))
        Me.MaskedTextBoxDate1 = New cimetiere.MaskedTextBoxDate()
        Me.MaskedTextBoxDate2 = New cimetiere.MaskedTextBoxDate()
        Me.SuspendLayout()
        '
        'MaskedTextBoxDate1
        '
        Me.MaskedTextBoxDate1.DateValue = Nothing
        Me.MaskedTextBoxDate1.IntArrayValue = CType(resources.GetObject("MaskedTextBoxDate1.IntArrayValue"), System.Collections.Generic.List(Of System.Nullable(Of Integer)))
        Me.MaskedTextBoxDate1.Location = New System.Drawing.Point(141, 96)
        Me.MaskedTextBoxDate1.Mask = "00/00/0000"
        Me.MaskedTextBoxDate1.Name = "MaskedTextBoxDate1"
        Me.MaskedTextBoxDate1.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBoxDate1.TabIndex = 0
        Me.MaskedTextBoxDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaskedTextBoxDate2
        '
        Me.MaskedTextBoxDate2.DateValue = Nothing
        Me.MaskedTextBoxDate2.IntArrayValue = CType(resources.GetObject("MaskedTextBoxDate2.IntArrayValue"), System.Collections.Generic.List(Of System.Nullable(Of Integer)))
        Me.MaskedTextBoxDate2.Location = New System.Drawing.Point(160, 146)
        Me.MaskedTextBoxDate2.Mask = "00/00/0000"
        Me.MaskedTextBoxDate2.Name = "MaskedTextBoxDate2"
        Me.MaskedTextBoxDate2.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBoxDate2.TabIndex = 1
        Me.MaskedTextBoxDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormEditConcession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 376)
        Me.Controls.Add(Me.MaskedTextBoxDate2)
        Me.Controls.Add(Me.MaskedTextBoxDate1)
        Me.Name = "FormEditConcession"
        Me.Text = "FormEditConcession"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaskedTextBoxDate1 As MaskedTextBoxDate
    Friend WithEvents MaskedTextBoxDate2 As MaskedTextBoxDate
End Class
